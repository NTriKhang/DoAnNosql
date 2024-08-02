using DoAnNosql.Models;
using Neo4j.Driver;
using Neo4jClient;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DoAnNosql
{
    public partial class CongDanForm : Form
    {
        private readonly IDriver _driver;
        DataTable dataTable;
        DataTable dataTablePhuong;
        DataTable dataTableQuan;
        DataTable dataTable_Merge;
        public CongDanForm()
        {
            InitializeComponent();
            _driver = GraphDatabase.Driver("neo4j+s://93425e7d.databases.neo4j.io:7687", AuthTokens.Basic("neo4j", "SzGRM_1m5iL1IsiYPX9qgxrSwpK0vG1AzDOeHIvJS5I"));
            dataTable = new DataTable();
            dataTablePhuong = new DataTable();
            dataTableQuan = new DataTable();
            _ = ReFreshDataGrid();
            DisableField();


        }
        public string Trash_Old_Phuong = "";
        public string Trash_Old_Quan = "";
        private void CongDanForm_Load(object sender, EventArgs e)
        {
            dataTablePhuong.Columns.Add("name", typeof(string));
            dataTableQuan.Columns.Add("name", typeof(string));
            LoadDataIntoComboBoxAsync();
            LoadDataIntoComboBoxAsyncQuan();
            
        }

        private void DisableField()
        {
            txtName.Enabled = false;
            txtTuoi.Enabled = false;
            txtCCCD.Enabled = false;
            txt_diachi.Enabled = false;
            Dtp_NgaySinh.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Visible = false;
            cb_Phuong.Enabled = false;
            cb_Quan.Enabled = false;
            btnSaveUpdate.Enabled = false;
        }
        private void EnableField()
        {
            txtName.Enabled = true;
            txtTuoi.Enabled = true;
            txtCCCD.Enabled = true;
            cb_Phuong.Enabled = true;
            cb_Quan.Enabled = true;
            txt_diachi.Enabled = true;
            Dtp_NgaySinh.Enabled = true;
            //btnLuu.Enabled = true;
        }
        private void PopulateComboBox(DataTable dataTable)
        {
            cb_Phuong.Items.Clear(); // clear cái cache trước
                
            foreach (DataRow row in dataTable.Rows)
            {
                // đổ data table cột họ tên vô check null rồi thêm vào cái combo box
                var phuong = row["name"] as string;
                if (!string.IsNullOrEmpty(phuong))
                {
                    cb_Phuong.Items.Add(phuong);
                }
            }
        }

        private void PopulateComboBoxQuan(DataTable dataTable)
        {
            cb_Quan.Items.Clear(); // clear cái cache trước

            foreach (DataRow row in dataTable.Rows)
            {
                // đổ data table cột họ tên vô check null rồi thêm vào cái combo box
                var phuong = row["name"] as string;
                if (!string.IsNullOrEmpty(phuong))
                {
                    cb_Quan.Items.Add(phuong);
                }
            }
        }

        private async void LoadDataIntoComboBoxAsync()
        {
            await GetAllPhuong(dataTablePhuong); //async await
            PopulateComboBox(dataTablePhuong);

        }
        public async void LoadDataIntoComboBoxAsyncQuan()
        {
            await GetAllQuan(dataTableQuan); //async await
            PopulateComboBoxQuan(dataTableQuan);
        }



        private bool CheckValid()
        {
            return (txtName.Text != "" && txtTuoi.Text != "" && txtCCCD.Text != "");
        }
        private async Task ReFreshDataGrid()
        {
            if (dataTable_Merge == null)
            {
                dataTable_Merge = new DataTable();
            }
            dataTable_Merge.Columns.Clear();
            dataTable_Merge.Columns.Add("ID", typeof(string));
            dataTable_Merge.Columns.Add("HoTen", typeof(string));
            dataTable_Merge.Columns.Add("Tuoi", typeof(int));
            dataTable_Merge.Columns.Add("CCCD", typeof(string));
            dataTable_Merge.Columns.Add("DiaChi", typeof(string));
            dataTable_Merge.Columns.Add("NgaySinh", typeof(DateTime));
            // insurance

            dataTable_Merge.Columns.Add("NamePhuong", typeof(string));
            dataTable_Merge.Columns.Add("NameQuan", typeof(string));


            await GetAllCongDan(dataTable_Merge);

            dataGridView1.DataSource = dataTable_Merge;
        }

        private async Task GetAllCongDan(DataTable dataTable)
        {
            
            try
            {
                using (var session = _driver.AsyncSession())
                {
                    var getAllQuery = @"
                            MATCH (c:CongDan)-[:LIVE]->(p:PHUONG)-[:THUOC]->(q:QUAN)
                            RETURN c, p, q";

                    var getResult = await session.RunAsync(getAllQuery);
                    var res = await getResult.ToListAsync();
                    if (res.Count > 0)
                    {
                        foreach (var record in res)
                        {
                            var congDanNode = record["c"].As<INode>();
                            var phuongNode = record["p"].As<INode>();
                            var quanNode = record["q"].As<INode>();

                            var congDan = new CongDan
                            {
                                id = congDanNode.ElementId,
                                hoTen = congDanNode.Properties.ContainsKey("hoTen") ? congDanNode["hoTen"].As<string>() : string.Empty,
                                tuoi = congDanNode.Properties.ContainsKey("tuoi") ? congDanNode["tuoi"].As<int>() : 0,
                                cccd = congDanNode.Properties.ContainsKey("cccd") ? congDanNode["cccd"].As<string>() : string.Empty,
                                diachi = congDanNode.Properties.ContainsKey("diachi") ? congDanNode["diachi"].As<string>() : string.Empty,
                                ngaysinh = congDanNode.Properties.ContainsKey("ngaysinh") ? congDanNode["ngaysinh"].As<DateTime>() : DateTime.MinValue
                            };

                            var phuong = new Phuong
                            {
                                id = phuongNode.Properties.ContainsKey("id") ? phuongNode["id"].As<int>() : 0,
                                name = phuongNode.Properties.ContainsKey("name") ? phuongNode["name"].As<string>() : string.Empty
                            };

                            var quan = new Quan
                            {
                                Id = quanNode.Properties.ContainsKey("id") ? quanNode["id"].As<string>() : string.Empty,
                                name = quanNode.Properties.ContainsKey("name") ? quanNode["name"].As<string>() : string.Empty
                            };

                            dataTable.Rows.Add(congDan.id, congDan.hoTen, congDan.tuoi, congDan.cccd, congDan.diachi, congDan.ngaysinh, phuong.name,quan.name);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No CongDan nodes found!");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle general exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private async Task AddNote(CongDan congDan, Phuong phuong, Quan quan)
        {
            using (var session = _driver.AsyncSession())
            {
                var isExist = await IsExist(session, nameof(CongDan), nameof(CongDan.cccd), congDan.cccd);
                if (isExist)
                {
                    MessageBox.Show("CCCD đã tồn tại");
                    return;
                }

                var createQuery = @"
                            CREATE (c:CongDan {hoTen: $hoTen, tuoi: $tuoi, cccd: $cccd, diachi: $diachi, ngaysinh: $ngaysinh})
                            RETURN c";


                var parameters = new Dictionary<string, object>()
                            {
                                { nameof(CongDan.id), congDan.id },
                                { nameof(CongDan.hoTen), congDan.hoTen },
                                { nameof(CongDan.tuoi), congDan.tuoi },
                                { nameof(CongDan.cccd), congDan.cccd },
                                { nameof(CongDan.diachi), congDan.diachi },
                                { nameof(CongDan.ngaysinh), congDan.ngaysinh }
                            };

                var createResult = await session.RunAsync(createQuery, parameters);
                var record = await createResult.SingleAsync();

                var nodeId = record[0]?.As<INode>();
                
                if (nodeId == null)
                {
                    MessageBox.Show("Dòng 221 lỗi tạo công dân");
                }
                congDan.id = nodeId.ElementId;
                // Tạo relationship 
                var createRelationshipQuery = @"
                                                MATCH (c:CongDan {cccd: $cccd})
                                                MATCH (p:PHUONG {name: $namePhuong})-[:THUOC]->(q:QUAN {name: $nameQuan})
                                                CREATE (c)-[:LIVE]->(p)
                                                RETURN c, p, q";


                var relationshipParameters = new Dictionary<string, object>
                {
                    { "cccd", congDan.cccd },
                    { "namePhuong", phuong.name },
                    { "nameQuan", quan.name },
                };

                try
                {
                    var relationshipResult = await session.RunAsync(createRelationshipQuery, relationshipParameters);
                    var relationshipRecord = await relationshipResult.SingleAsync();

                    UpdateDataTable(congDan, phuong, quan);
                    MessageBox.Show("Thêm Công Dân và relation đến Phường và từ Phường đến Quận thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception dòng 149-159 Error: " + ex.Message);
                }
            }
        }

        private void UpdateDataTable(CongDan congDan, Phuong phuong, Quan quan)
        {
            DataRow row = dataTable_Merge.NewRow();
            row["ID"] = congDan.id;
            row["HoTen"] = congDan.hoTen;
            row["Tuoi"] = congDan.tuoi;
            row["diachi"] = congDan.diachi;
            row["ngaysinh"] = congDan.ngaysinh;
            row["CCCD"] = congDan.cccd;
            // Thêm thông tin Phường
            row["NamePhuong"] = phuong.name;

            // Thêm thông tin Quận
            row["NameQuan"] = quan.name;

            dataTable_Merge.Rows.Add(row);
        }


        private async Task<bool> IsExist(IAsyncSession session, string nodeName, string nameField, string value)
        {
            var checkCCCDQuery = $"MATCH (c: {nodeName} {{{nameField}: ${nameField}}}) RETURN c";
            var checkCCCDParams = new Dictionary<string, object>() { { nameField, value } };
            var checkResult = await session.RunAsync(checkCCCDQuery, checkCCCDParams);
            var res = await checkResult.FetchAsync();
            return res;
        }

        private async Task GetAllPhuong(DataTable dataTable)
        {
            try
            {
                using (var session = _driver.AsyncSession())
                {
                    var getAllQuery = "MATCH (p:PHUONG) RETURN p";

                    var getResult = await session.RunAsync(getAllQuery);
                    var res = await getResult.ToListAsync();

                    if (dataTable == null)
                    {
                        dataTable = new DataTable();
                    }
                    if (res.Count > 0)
                    {
                        dataTable.Clear(); // Clear 
                        dataTable.Columns.Clear(); // Clear columns

                        // Define the structure of DataTable
                        dataTable.Columns.Add("name", typeof(string));
                        cb_Phuong.Items.Clear(); // Clear cache comboBox

                        foreach (var record in res)
                        {
                            var node = record[0].As<INode>();
                            var name = node.Properties.ContainsKey("name") ? node["name"].As<string>() : string.Empty;

                            if (!string.IsNullOrEmpty(name))
                            {
                                // Add data vào DataTable
                                dataTable.Rows.Add(name);

                                // Add CCCD vào ComboBox
                                cb_Phuong.Items.Add(name);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy phường row 177");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle general exceptions
                MessageBox.Show("lỗi dòng exception 185 " + ex.Message);
            }
        }

        private async Task GetAllQuan(DataTable dataTable)
        {
            try
            {
                using (var session = _driver.AsyncSession())
                {
                    var getAllQuery = "MATCH (q:QUAN) RETURN q";

                    var getResult = await session.RunAsync(getAllQuery);
                    var res = await getResult.ToListAsync();
                    if (dataTable == null)
                    {
                        dataTable = new DataTable();
                    }

                    if (res.Count > 0)
                    {
                        dataTable.Clear(); // Clear 
                        dataTable.Columns.Clear(); // Clear columns

                        // Define the structure of DataTable
                        dataTable.Columns.Add("name", typeof(string));
                        cb_Quan.Items.Clear(); // Clear cache comboBox

                        foreach (var record in res)
                        {
                            var node = record[0].As<INode>();
                            var name = node.Properties.ContainsKey("name") ? node["name"].As<string>() : string.Empty;

                            if (!string.IsNullOrEmpty(name))
                            {
                                // Add data vào DataTable
                                dataTable.Rows.Add(name);

                                // Add CCCD vào ComboBox
                                cb_Quan.Items.Add(name);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy Quận row 226");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle general exceptions
                MessageBox.Show("lỗi dòng exception 233" + ex.Message);
            }
        }

        private DataTable GetDataTable()
        {
            // Trả về DataTable chứa thông tin công dân
            return dataTable;
        }



        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValid())
                {
                    MessageBox.Show("Du lieu khong hop le");
                    return;
                }
                _ = AddNote(new CongDan
                {
                    hoTen = txtName.Text,
                    tuoi = int.Parse(txtTuoi.Text),
                    cccd = txtCCCD.Text,
                    diachi = txt_diachi.Text,
                    ngaysinh = Dtp_NgaySinh.Value
                },
                new Phuong
                {
                    name = cb_Phuong.Text
                },
                new Quan
                {
                    name = cb_Quan.Text
                }
                );
                DisableField();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            EnableField();
            btnLuu.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Sure?", "Delete this row", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    dataGridView1.Rows.Remove(selectedRow);

                    try
                    {
                        _ = DeleteNode();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting the node: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
        private async Task DeleteNode()
        {
            
            using (var session = _driver.AsyncSession())
            {
                try
                {
                    // Xoá rel trước r xoá cd
                    var deleteQuery = @"
                    
                    MATCH (c:CongDan)-[r:LIVE]->(p:PHUONG)
                    WHERE c.cccd = $cccd
                    DELETE r
                    WITH c
                    DETACH DELETE c";

                    var parameters = new Dictionary<string, object>
                    {
                        { "cccd", txtCCCD.Text }
                    };

                    var result = await session.RunAsync(deleteQuery, parameters);
                    var records = await result.ToListAsync();

                    MessageBox.Show("Công Dân đã được xóa thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private async Task DeleteREL_CD_PHUONG(string cccd)
        {
            using (var session = _driver.AsyncSession())
            {
                try
                {
                    var deleteLinkQuery = @"
                        MATCH (c:CongDan {cccd: $cccd})-[rel:LIVE]->(p:PHUONG)
                        DELETE rel
                        RETURN c, p";

                    var parameters = new Dictionary<string, object>
                    {
                        { "cccd", cccd }
                    };

                    var result = await session.RunAsync(deleteLinkQuery, parameters);
                    var records = await result.ToListAsync();

                    if (records.Any())
                    {
                        MessageBox.Show("Liên kết giữa Công Dân và Phường đã được xoá thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy liên kết nào để xoá.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private async Task UpdateNode()
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["Id"].Value != null && (string)row.Cells["Id"].Value == txtId.Text)
                    {
                        row.Cells["HoTen"].Value = txtName.Text;
                        row.Cells["Tuoi"].Value = txtTuoi.Text;
                        row.Cells["CCCD"].Value = txtCCCD.Text;
                        row.Cells["diachi"].Value = txt_diachi.Text;
                        row.Cells["ngaysinh"].Value = Dtp_NgaySinh.Value;
                        //row.Cells["ID"].Value = txtId.Text;
                        row.Cells["NamePhuong"].Value = txtCCCD.Text;
                        row.Cells["NameQuan"].Value = txtCCCD.Text;
                        break;
                    }
                }
                using (var session = _driver.AsyncSession())
                {
                    try
                    {
                        // Kiểm tra liên kết THUOC giữa Phuong mới và Quan
                        var checkThucQuery = @"
                            MATCH (newPhuong:PHUONG {name: $newPhuongName})-[:THUOC]->(newQuan:QUAN {name: $newQuanName})
                            RETURN newPhuong, newQuan";

                        var checkThucParameters = new Dictionary<string, object>
                        {
                            { "newPhuongName", cb_Phuong.Text },
                            { "newQuanName", cb_Quan.Text }
                        };

                        var checkThucResult = await session.RunAsync(checkThucQuery, checkThucParameters);
                        var checkThucRecords = await checkThucResult.ToListAsync();

                        if (checkThucRecords.Count == 0)
                        {
                            MessageBox.Show("Phường này không có liên kết với Quận.");
                            return;
                        }
                        else
                        {

                            /*
                            // 1. xoá liên kết cũ trước
                            await DeleteREL_CD_PHUONG(txtCCCD.Text);
                            // 2.update liên kết mới CongDAN và PHUONG liên kết LIVE mới

                            var createLinkQuery = @"
                                MATCH (c:CongDan {cccd: $cccd})
                                MATCH (newPhuong:PHUONG {name: $newPhuongName})
                                MERGE (c)-[:LIVE]->(newPhuong)
                                RETURN c, newPhuong";

                                    var createLinkParameters = new Dictionary<string, object>
                            {
                                { "cccd", txtCCCD.Text },
                                { "newPhuongName", cb_Phuong.Text }
                            };

                            await session.RunAsync(createLinkQuery, createLinkParameters);



                            // 3. sau đó cập nhật công dân
                            // Cập nhật thông tin của CongDan

                            var updateCongDanQuery = @"
                                MATCH (c:CongDan {cccd: $cccd})
                                SET c.hoTen = $hoTen, c.tuoi = $tuoi, c.diachi = $diachi, c.ngaysinh = $ngaysinh
                                RETURN c";

                            var updateCongDanParameters = new Dictionary<string, object>
                            {
                                { "cccd", txtCCCD.Text },
                                { "hoTen", txtName.Text },
                                { "tuoi", int.TryParse(txtTuoi.Text, out int age) ? age : 0 },
                                { "diachi", txt_diachi.Text },
                                { "ngaysinh", Dtp_NgaySinh.Value.ToString("yyyy-MM-dd") }
                            };

                            await session.RunAsync(updateCongDanQuery, updateCongDanParameters);
                            */

                            var updateCongDanQuery = @"
                            MATCH (c:CongDan {cccd: $cccd})
                            SET c.hoTen = $hoTen, c.tuoi = $tuoi, c.diachi = $diachi, c.ngaysinh = $ngaysinh
                            RETURN c";

                            var updateCongDanParameters = new Dictionary<string, object>
                            {
                                { "cccd", txtCCCD.Text },
                                { "hoTen", txtName.Text },
                                { "tuoi", txtTuoi.Text },
                                { "diachi", txt_diachi.Text },
                                { "ngaysinh", Dtp_NgaySinh.Value }
                            };

                            await session.RunAsync(updateCongDanQuery, updateCongDanParameters);

                            // Xoá liên kết LIVE cũ và tạo liên kết LIVE mới
                            var updateRelationsQuery = @"
                                MATCH (c:CongDan {cccd: $cccd})-[oldRel:LIVE]->(oldPhuong:PHUONG)
                                DELETE oldRel
                                WITH c
                                MATCH (newPhuong:PHUONG {name: $newPhuongName})
                                MERGE (c)-[:LIVE]->(newPhuong)
                                WITH c, newPhuong
                                MATCH (newPhuong)-[:THUOC]->(newQuan:QUAN)
                                RETURN c.id,c.hoTen,c.tuoi, c.diachi, c.ngaysinh, newPhuong.name, newQuan.name ";
                            //RETURN c, newPhuong, newQuan, (c)-[:LIVE]->(newPhuong) AS liveRel, (newPhuong)-[:THUOC]->(newQuan) AS thucRel";
                            var updateRelationsParameters = new Dictionary<string, object>
                            {
                                { "cccd", txtCCCD.Text },
                                { "newPhuongName", cb_Phuong.Text }
                            };

                            await session.RunAsync(updateRelationsQuery, updateRelationsParameters);
                            
                            MessageBox.Show("Cập nhật Công Dân và liên kết thành công.");

                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DateTime ngaysinhDateTime;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtName.Text = row.Cells["HoTen"].Value.ToString();
                txtTuoi.Text = row.Cells["Tuoi"].Value.ToString();
                txtCCCD.Text = row.Cells["CCCD"].Value.ToString();
                txtId.Text = row.Cells["Id"].Value.ToString();
                cb_Phuong.Text = row.Cells["NamePhuong"].Value.ToString();
                cb_Quan.Text = row.Cells["NameQuan"].Value.ToString();
                txt_diachi.Text = row.Cells["diachi"].Value.ToString();
                if(DateTime.TryParse(row.Cells["ngaysinh"].Value.ToString(), out ngaysinhDateTime))
                {
                    Dtp_NgaySinh.Value = ngaysinhDateTime;
                }    
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnSaveUpdate.Enabled = false;
            dataGridView1.Enabled = true;
            DisableField();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            Trash_Old_Phuong = cb_Phuong.Text;
            Trash_Old_Quan = cb_Quan.Text;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                EnableField();
                btnLuu.Enabled = false;
                dataGridView1.Enabled = false;
                btnHuy.Visible = true;
                btnSaveUpdate.Enabled = true;
                btnLuu.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            
            _ = UpdateNode();
            
        }

        private void Strip_TTBaoHiem_Click(object sender, EventArgs e)
        {
            InsuranceForm ins = new InsuranceForm();
            ins.ShowDialog();

        }

        private void cb_Phuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPhuong = cb_Phuong.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedPhuong))
            {
                
                //// Tìm tên công dân từ DataTable => CCCD
                //var dataTable = GetDataTable(); // Hàm này trả về DataTable đã được cập nhật

                //foreach (DataRow row in dataTable.Rows)
                //{
                //    var phuong = row["name"].ToString();
                //    if (phuong == selectedPhuong)
                //    {
                        
                //        break;
                //    }
                //}
            }
        }
    }
}
