using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neo4jClient;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
namespace DoAnNosql
{
    public partial class SaoLuu : Form
    {
        private readonly IDriver _driver;

        private readonly IAmazonS3 _s3Client;


        string accessKeyId = Environment.GetEnvironmentVariable("AWS_ACCESS_KEY_ID");

        string secretAccessKey = Environment.GetEnvironmentVariable("AWS_SECRET_ACCESS_KEY");

        string Region = Environment.GetEnvironmentVariable("AWS_REGION"); //ap-southeast-2

        private readonly string _bucketName = "backup-restore-neo4j-s3";

        private readonly string _filePath = "backup.json";

        private readonly string _s3KeyName = "backup.json"; // Tên file trên S3

        public SaoLuu()
        {
            InitializeComponent();
            _driver = GraphDatabase.Driver("neo4j+s://93425e7d.databases.neo4j.io:7687", AuthTokens.Basic("neo4j", "SzGRM_1m5iL1IsiYPX9qgxrSwpK0vG1AzDOeHIvJS5I"));
            var awsCredentials = new BasicAWSCredentials(accessKeyId, secretAccessKey);
            _s3Client = new AmazonS3Client(awsCredentials, Amazon.RegionEndpoint.APSoutheast2);
            txt_LocalPath.Enabled = false;
            txt_url.Enabled = false;
            btn_KhoiPhuc.Enabled = false;
            txt_pathjson.Enabled = false;
            btn_TaiXuong.Enabled = false;
            btn_OpenLocalPath.Enabled = false;
            btn_openfileBK.Enabled = false;
        }


        private async Task ExportDataAsync(String filePath)
        {
            var query = @"CALL apoc.export.json.query('MATCH (n) RETURN n', null, {stream: true})";

            try
            {
                await using (var session = _driver.AsyncSession())
                {
                    var result = await session.RunAsync(query);
                    await using (var writer = new StreamWriter(filePath))
                    {
                        // Đọc data r ghi vô file
                        while (await result.FetchAsync())
                        {
                            //lấy data xong chuyển chuỗi => maps dc
                            var data = result.Current["data"];
                            var chunk = data != null ? data.ToString() : string.Empty;
                            await writer.WriteAsync(chunk);
                        }
                    }
                    MessageBox.Show("Export completed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting data: {ex.Message}");
                throw; // lỗi lên BackupAndUploadAsync 
            }
        }

        private async Task<string> UploadFileAsync()
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    throw new FileNotFoundException("The file to upload does not exist.");
                }

                var fileTransferUtility = new TransferUtility(_s3Client);

                // Tải file lên S3
                await fileTransferUtility.UploadAsync(_filePath, _bucketName, "backup.json");

                // set time cho URL sau 1 tiếng die link 
                var request = new GetPreSignedUrlRequest
                {
                    BucketName = _bucketName,
                    Key = _s3KeyName,
                    Expires = DateTime.UtcNow.AddHours(1) // Thay đổi thời gian hết hạn nếu cần
                };

                string url = _s3Client.GetPreSignedURL(request);
                txt_url.Text = url;
                MessageBox.Show("Đã upload file lên S3 AWS");
                return url;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error uploading to S3: {ex.Message}");
                throw;
            }
        }

        public async Task BackupAndUploadAsync()
        {
            try
            {
                var filePath = "backup.json"; // Đường dẫn tới file JSON

                // Xuất dữ liệu từ Neo4j ra file JSON
                await ExportDataAsync(filePath);

                // Tải file lên S3
                await UploadFileAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private async Task DownloadFileFromUrlAsync()
        {
            using (var httpClient = new HttpClient())
            {
                if (txt_LocalPath.Text == null)
                {
                    MessageBox.Show("Đường dẫn trống không thể tải!");
                    return;
                }

                try
                {

                    var response = await httpClient.GetAsync(txt_url.Text);
                    response.EnsureSuccessStatusCode();

                    await using (var fileStream = new FileStream(txt_LocalPath.Text, FileMode.Create, FileAccess.Write, FileShare.None, 4096, true))
                    {
                        await response.Content.CopyToAsync(fileStream);
                    }
                    MessageBox.Show("File downloaded successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error downloading file: {ex.Message}");
                    throw;
                }
            }
        }

        private async Task RestoreDataAsync()
        {
            var query = $@"CALL apoc.import.json('{txt_LocalPath.Text}', {{batchSize:1000, ignoreMissingNodes:true}})";

            try
            {
                await using (var session = _driver.AsyncSession())
                {
                    var result = await session.RunAsync(query);
                    var summary = await result.ConsumeAsync();
                    MessageBox.Show("Restore completed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error restoring data: {ex.Message}");
                throw;
            }
        }

        private void btn_SaoLuu_Click(object sender, EventArgs e)
        {
            _ = BackupAndUploadAsync();
            txt_url.Enabled = true;
            btn_OpenLocalPath.Enabled = true;
            btn_openfileBK.Enabled = true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_OpenLocalPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = " Chọn đường dẫn nhanh nhanh dùm tôi! ";
            dialog.ShowDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txt_LocalPath.Text = dialog.SelectedPath.ToString();
                btn_TaiXuong.Enabled = true;
            }
        }

        private void btn_TaiXuong_Click(object sender, EventArgs e)
        {
            _ = DownloadFileFromUrlAsync();
            //string filePath = "D:\\HK7\\MongoDB\\DoAn\\DoAnNosql\\bin\\Debug\\net7.0-windows\\temp\\backup.json";
            txt_LocalPath.Text += "\\backup.json";
        }

        private void btn_openfileBK_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialogRes = new FolderBrowserDialog();
            dialogRes.ShowDialog();
            if (dialogRes.ShowDialog() == DialogResult.OK)
            {
                txt_pathjson.Text = dialogRes.SelectedPath.ToString();
                btn_KhoiPhuc.Enabled = true;
            }
        }
    }
}
