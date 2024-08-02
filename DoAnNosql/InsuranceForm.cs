using DoAnNosql.Models;
using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Aspose.Words;
using Aspose.Words.Tables;
using ThuVienWinform.Report.AsposeWordExtension;
using System.Diagnostics;

//using ThuVienWinform.Report.AsposeWordExtension;

namespace DoAnNosql
{
    public partial class InsuranceForm : Form
    {
        private readonly IDriver _driver;
        DataTable dataTable;
        DataTable dataTable_Full;
        DataTable dataTable_Merge;
        
        public InsuranceForm()
        {
            InitializeComponent();
            _driver = GraphDatabase.Driver("neo4j+s://93425e7d.databases.neo4j.io:7687", AuthTokens.Basic("neo4j", "SzGRM_1m5iL1IsiYPX9qgxrSwpK0vG1AzDOeHIvJS5I"));
            dataTable = new DataTable();
            _ = ReFreshDataGrid();
            LoadDataIntoComboBoxAsync();
            btn_XuatFile.Enabled = false;
        }
        private bool CheckValid()
        {
            return (tb_chitratruoc.Text != "" ||
                tb_co_payment_amount.Text != "" ||
                tb_ngaygiahan.Text != "" ||
                tb_premium_amount.Text != "" ||
                cb_donvi.Text != "" ||
                tb_tennhacungcap.Text != "" ||
                tb_sohopdongbaohiem.Text != "" ||
                tb_start_date.Text != "" ||
                tb_end_date.Text != "");

        }
        private void Insurance_Load(object sender, EventArgs e)
        {
            DisableField();
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            // Khởi tạo DataTable
            dataTable.Columns.Add("cccd", typeof(string));
            dataTable.Columns.Add("hoTen", typeof(string));
            // Tải dữ liệu vào ComboBox và DataTable
            LoadDataIntoComboBoxAsync();

            // Gán sự kiện SelectedIndexChanged cho ComboBox
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

        }

        private void DisableField()
        {
            //txtName.Enabled = false;
            //txtTuoi.Enabled = false;
            //txtCCCD.Enabled = false;

            //btnLuu.Enabled = false;
            //btnHuy.Visible = false;
            //btnSaveUpdate.Enabled = false;
            btn_luuchinhsua.Enabled = false;
            tb_sohopdongbaohiem.Enabled = false;
            tb_tennhacungcap.Enabled = false;
            comboBox1.Enabled = false;
            cb_donvi.Enabled = false;
            tb_co_payment_amount.Enabled = false;
            comboBox2.Enabled = false;
            tb_chitratruoc.Enabled = false;
            tb_ngaygiahan.Enabled = false;
            tb_premium_amount.Enabled = false;

            tb_start_date.Enabled = false;
            tb_end_date.Enabled = false;
            tb_premium_amount.Enabled = false;

            tb_co_payment_amount.Enabled = false;
            btn_Luu.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;


        }
        private void EnableField()
        {
            //txtName.Enabled = true;
            //txtTuoi.Enabled = true;
            //txtCCCD.Enabled = true;

            //btnLuu.Enabled = true;

            tb_sohopdongbaohiem.Enabled = true;
            tb_tennhacungcap.Enabled = true;
            comboBox1.Enabled = true;
            cb_donvi.Enabled = true;
            tb_co_payment_amount.Enabled = true;
            comboBox2.Enabled = true;
            tb_chitratruoc.Enabled = true;
            tb_ngaygiahan.Enabled = true;
            tb_premium_amount.Enabled = true;

            tb_start_date.Enabled = true;
            tb_end_date.Enabled = true;
            tb_premium_amount.Enabled = true;

            tb_co_payment_amount.Enabled = true;
            //btn_Luu.Enabled = true;
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void PopulateComboBox(DataTable dataTable)
        {
            comboBox1.Items.Clear(); // clear cái cache trước

            foreach (DataRow row in dataTable.Rows)
            {
                // đổ data table cột họ tên vô check null rồi thêm vào cái combo box
                var hoTen = row["cccd"] as string;
                if (!string.IsNullOrEmpty(hoTen))
                {
                    comboBox1.Items.Add(hoTen);
                }
            }
        }

        private async void LoadDataIntoComboBoxAsync()
        {
            await GetCCCDNameCongDan(dataTable); //async await
            PopulateComboBox(dataTable);
        }

        private string generate10so()
        {
            Random random = new Random();
            string numbers = "";

            for (int i = 0; i < 10; i++)
            {
                numbers += random.Next(0, 10).ToString();
            }

            return numbers;
        }
        private async Task GetCCCDNameCongDan(DataTable dataTable)
        {
            try
            {
                using (var session = _driver.AsyncSession())
                {
                    var getAllQuery = "MATCH (c:CongDan) RETURN c";

                    var getResult = await session.RunAsync(getAllQuery);
                    var res = await getResult.ToListAsync();

                    if (res.Count > 0)
                    {
                        dataTable.Clear(); // Clear 
                        dataTable.Columns.Clear(); // Clear columns

                        // Define the structure of DataTable
                        dataTable.Columns.Add("cccd", typeof(string));
                        dataTable.Columns.Add("hoTen", typeof(string));
                        dataTable.Columns.Add("tuoi", typeof(int));
                        comboBox1.Items.Clear(); // Clear cache comboBox

                        foreach (var record in res)
                        {
                            var node = record[0].As<INode>();
                            var cccd = node.Properties.ContainsKey("cccd") ? node["cccd"].As<string>() : string.Empty;
                            var hoTen = node.Properties.ContainsKey("hoTen") ? node["hoTen"].As<string>() : string.Empty;
                            var tuoi = node.Properties.ContainsKey("tuoi") ? node["tuoi"].As<int>() : 0;
                            if (!string.IsNullOrEmpty(cccd) && !string.IsNullOrEmpty(hoTen))
                            {
                                // Add data vào DataTable
                                dataTable.Rows.Add(cccd, hoTen, tuoi);

                                // Add CCCD vào ComboBox
                                comboBox1.Items.Add(cccd);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("ko tim thay cong dan noob");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle general exceptions
                MessageBox.Show("lỗi dòng exception 139 " + ex.Message);
            }
        }

        private DataTable GetDataTable()
        {
            // Trả về DataTable chứa thông tin công dân
            return dataTable;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCCCD = comboBox1.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedCCCD))
            {
                // Tìm tên công dân từ DataTable => CCCD
                var dataTable = GetDataTable(); // Hàm này trả về DataTable đã được cập nhật

                foreach (DataRow row in dataTable.Rows)
                {
                    var cccd = row["cccd"].ToString();
                    if (cccd == selectedCCCD)
                    {
                        var hoTen = row["hoTen"].ToString();
                        var tuoi = row["tuoi"].ToString();
                        lb_idcd.Text = hoTen;
                        lb_tuoi.Text = tuoi;
                        break;
                    }
                }
            }
        }

        private void UpdateDataTable(CongDan congDan, Insurance insurance, HAS_INSURANCE rel)
        {
            // Thêm vào DataTable
            DataRow row = dataTable_Merge.NewRow();
            row["ID"] = congDan.cccd;
            row["HoTen"] = congDan.hoTen;
            row["Tuoi"] = congDan.tuoi;
            row["CCCD"] = congDan.cccd;

            row["insuranceId"] = insurance.insuranceId;
            row["insuranceType"] = insurance.insuranceType;
            row["policyId"] = insurance.policyId;
            row["provider"] = insurance.provider;
            row["start_date"] = insurance.start_date;
            row["end_date"] = insurance.end_date;
            row["premium_frequency"] = insurance.premium_frequency;
            row["co_payment_amount"] = insurance.co_payment_amount;
            row["deductible_amount"] = insurance.deductible_amount;
            row["renewal_date"] = insurance.renewal_date;
            row["premium_amount"] = insurance.premium_amount;

            row["start_dateOfInsurance"] = rel.start_date;
            row["end_dateOfInsurance"] = rel.end_date;
            row["statusOfInsurance"] = rel.status;

            dataTable_Merge.Rows.Add(row);
            
        }

        private async Task AddInsuranceAndRelationAsync(CongDan congDan, Insurance insurance, HAS_INSURANCE rel)
        {
            using (var session = _driver.AsyncSession())
            {
                // check exitstsst của node CongDan
                var congDanExists = await IsExist(session, nameof(CongDan), nameof(CongDan.cccd), congDan.cccd);
                if (!congDanExists)
                {
                    MessageBox.Show("Dòng 179 Công dân không tồn tại");
                    return;
                }

                // Tạo node Insurance mới
                var createInsuranceQuery = @"
                                CREATE (i:Insurance {
                                    insuranceId: $insuranceId,
                                    insuranceType: $insuranceType,
                                    policyId: $policyId,
                                    provider: $provider,
                                    start_date: $start_date,
                                    end_date: $end_date,
                                    premium_frequency: $premium_frequency,
                                    co_payment_amount: $co_payment_amount,
                                    deductible_amount: $deductible_amount,
                                    renewal_date: $renewal_date,
                                    premium_amount: $premium_amount
                                })
                                RETURN i";

                var insuranceParameters = new Dictionary<string, object>
                {
                    { nameof(Insurance.insuranceId), insurance.insuranceId },
                    { nameof(Insurance.insuranceType), insurance.insuranceType },
                    { nameof(Insurance.policyId), insurance.policyId },
                    { nameof(Insurance.provider), insurance.provider },
                    { nameof(Insurance.start_date), insurance.start_date }, //ghim
                    { nameof(Insurance.end_date), insurance.end_date },//ghim
                    { nameof(Insurance.premium_frequency), insurance.premium_frequency }, // ghim
                    { nameof(Insurance.co_payment_amount), insurance.co_payment_amount },
                    { nameof(Insurance.deductible_amount), insurance.deductible_amount },
                    { nameof(Insurance.renewal_date), insurance.renewal_date },//ghim
                    { nameof(Insurance.premium_amount), insurance.premium_amount }
                };

                var insuranceCreateResult = await session.RunAsync(createInsuranceQuery, insuranceParameters);
                var insuranceRecord = await insuranceCreateResult.SingleAsync(); 
                var insuranceNode = insuranceRecord[0]?.As<INode>();

                if (insuranceNode == null)
                {
                    MessageBox.Show("Dòng 221 lỗi tạo bảo hiểm");
                    return;
                }

                // Tạo relationship HAS_INSURANCE
                var createRelationshipQuery = @"
                                                MATCH (c:CongDan {cccd: $cccd}), (i:Insurance {insuranceId: $insuranceId})
                                                CREATE (c)-[r:HAS_INSURANCE {
                                                    start_date: $start_date,
                                                    end_date: $end_date,
                                                    status: $status
                                                }]->(i)
                                                RETURN c, r, i";


                var relationshipParameters = new Dictionary<string, object>
                {
                    { "cccd", congDan.cccd },
                    { "insuranceId", insurance.insuranceId },
                    { "start_date", rel.start_date },
                    { "end_date", rel.end_date },
                    { "status", rel.status }
                };

                try
                {
                    var relationshipResult = await session.RunAsync(createRelationshipQuery, relationshipParameters);
                    var relationshipRecord = await relationshipResult.SingleAsync();
                    //UpdateDataTable(congDan, insurance, rel);
                    ReFreshDataGrid();
                    MessageBox.Show("Thêm bảo hiểm và thêm relation success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("exception dòng 354 Error: " + ex.Message);
                }
            }
        }
        private async Task<bool> IsExist(IAsyncSession session, string label, string property, string value)
        {

            var query = $"MATCH (n:{label} {{{property}: $value}}) RETURN COUNT(n) > 0 AS exists";
            var parameters = new { value };

            var result = await session.RunAsync(query, parameters);
            var record = await result.SingleAsync();

            return record["exists"].As<bool>();
        }
        public void hiddenPolicyID()
        {
            tb_policy_id.Text = "HD" + generate10so();
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
            // insurance

            dataTable_Merge.Columns.Add("insuranceId", typeof(string));
            dataTable_Merge.Columns.Add("insuranceType", typeof(string));
            dataTable_Merge.Columns.Add("policyId", typeof(string));
            dataTable_Merge.Columns.Add("provider", typeof(string));
            dataTable_Merge.Columns.Add("start_date", typeof(DateTime));
            dataTable_Merge.Columns.Add("end_date", typeof(DateTime));
            dataTable_Merge.Columns.Add("premium_frequency", typeof(string));
            dataTable_Merge.Columns.Add("co_payment_amount", typeof(long));
            dataTable_Merge.Columns.Add("deductible_amount", typeof(long));
            dataTable_Merge.Columns.Add("renewal_date", typeof(DateTime));
            dataTable_Merge.Columns.Add("premium_amount", typeof(long));

            // has insurnce
            dataTable_Merge.Columns.Add("start_dateOfInsurance", typeof(DateTime));
            dataTable_Merge.Columns.Add("end_dateOfInsurance", typeof(DateTime));
            dataTable_Merge.Columns.Add("statusOfInsurance", typeof(string));

            await GetAllCongDanWithInsurance(dataTable_Merge);

            dataGridView1.DataSource = dataTable_Merge;
        }

        private async Task GetAllCongDanWithInsurance(DataTable dataTable)
        {
            try
            {
                using (var session = _driver.AsyncSession())
                {
                    var getAllQuery = @"
                        MATCH (c:CongDan)-[r:HAS_INSURANCE]->(i:Insurance)
                        RETURN c, r, i";

                    var getResult = await session.RunAsync(getAllQuery);
                    var res = await getResult.ToListAsync();

                    if (res.Count > 0)
                    {
                        foreach (var record in res)
                        {
                            var congDanNode = record["c"].As<INode>();
                            var hasInsuranceRel = record["r"].As<IRelationship>();
                            var insuranceNode = record["i"].As<INode>();

                            var congDan = new CongDan
                            {
                                id = congDanNode.ElementId,
                                hoTen = congDanNode.Properties.ContainsKey("hoTen") ? congDanNode["hoTen"].As<string>() : string.Empty,
                                tuoi = congDanNode.Properties.ContainsKey("tuoi") ? congDanNode["tuoi"].As<int>() : 0,
                                cccd = congDanNode.Properties.ContainsKey("cccd") ? congDanNode["cccd"].As<string>() : string.Empty
                            };

                            DateTime startDate, endDate, renewalDate;
                            DateTime.TryParse(insuranceNode.Properties.ContainsKey("start_date") ? insuranceNode["start_date"].As<string>() : string.Empty, out startDate);
                            DateTime.TryParse(insuranceNode.Properties.ContainsKey("end_date") ? insuranceNode["end_date"].As<string>() : string.Empty, out endDate);
                            DateTime.TryParse(insuranceNode.Properties.ContainsKey("renewal_date") ? insuranceNode["renewal_date"].As<string>() : string.Empty, out renewalDate);

                            long coPaymentAmount = 0, deductibleAmount = 0, premiumAmount = 0;
                            long.TryParse(insuranceNode.Properties.ContainsKey("co_payment_amount") ? insuranceNode["co_payment_amount"].As<string>() : "0", out coPaymentAmount);
                            long.TryParse(insuranceNode.Properties.ContainsKey("deductible_amount") ? insuranceNode["deductible_amount"].As<string>() : "0", out deductibleAmount);
                            long.TryParse(insuranceNode.Properties.ContainsKey("premium_amount") ? insuranceNode["premium_amount"].As<string>() : "0", out premiumAmount);

                            var insurance = new Insurance
                            {
                                insuranceId = insuranceNode.Properties.ContainsKey("insuranceId") ? insuranceNode["insuranceId"].As<string>() : string.Empty,
                                insuranceType = insuranceNode.Properties.ContainsKey("insuranceType") ? insuranceNode["insuranceType"].As<string>() : string.Empty,
                                policyId = insuranceNode.Properties.ContainsKey("policyId") ? insuranceNode["policyId"].As<string>() : string.Empty,
                                provider = insuranceNode.Properties.ContainsKey("provider") ? insuranceNode["provider"].As<string>() : string.Empty,
                                start_date = startDate,
                                end_date = endDate,
                                premium_frequency = insuranceNode.Properties.ContainsKey("premium_frequency") ? insuranceNode["premium_frequency"].As<string>() : string.Empty,
                                co_payment_amount = coPaymentAmount,
                                deductible_amount = deductibleAmount,
                                renewal_date = renewalDate,
                                premium_amount = premiumAmount
                            };

                            DateTime hasInsStartDate, hasInsEndDate;
                            DateTime.TryParse(hasInsuranceRel.Properties.ContainsKey("start_date") ? hasInsuranceRel["start_date"].As<string>() : string.Empty, out hasInsStartDate);
                            DateTime.TryParse(hasInsuranceRel.Properties.ContainsKey("end_date") ? hasInsuranceRel["end_date"].As<string>() : string.Empty, out hasInsEndDate);

                            var hasInsurance = new HAS_INSURANCE
                            {
                                start_date = hasInsStartDate,
                                end_date = hasInsEndDate,
                                status = hasInsuranceRel.Properties.ContainsKey("status") ? hasInsuranceRel["status"].As<string>() : string.Empty
                            };

                            dataTable.Rows.Add(congDan.id, congDan.hoTen, congDan.tuoi, congDan.cccd,
                                insurance.insuranceId, insurance.insuranceType, insurance.policyId, insurance.provider,
                                insurance.start_date, insurance.end_date, insurance.premium_frequency, insurance.co_payment_amount,
                                insurance.deductible_amount, insurance.renewal_date, insurance.premium_amount,
                                hasInsurance.start_date, hasInsurance.end_date, hasInsurance.status);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No CongDan nodes with insurance found!");
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle general exceptions
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private async Task DeleteInsuranceAndRelation()
        {
            using (var session = _driver.AsyncSession())
            {
                string policyId = tb_policy_id.Text;
                var deleteQuery = @"
                MATCH (c:CongDan)-[r:HAS_INSURANCE]->(i:Insurance)
                WHERE i.policyId = $policyId
                DELETE r, i";

                var parameters = new Dictionary<string, object>
                {
                    { "policyId", policyId }
                };
                try
                {

                    var result = await session.RunAsync(deleteQuery, parameters);
                    await result.ConsumeAsync(); // Chờ hoàn tất thực thi truy vấn

                    MessageBox.Show("Xoá node bảo hiểm và quan hệ successss");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi try catch 483 " + ex.Message);
                }
            }
        }

        private async Task UpdateInsuranceAndRelation()
        {
            tb_sohopdongbaohiem.Enabled = false;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["cccd"].Value != null && (string)row.Cells["cccd"].Value == comboBox1.Text)
                    {
                        row.Cells["HoTen"].Value = lb_idcd.Text;
                        row.Cells["Tuoi"].Value = lb_tuoi.Text;

                        // Cập nhật các giá trị liên quan đến bảo hiểm
                        row.Cells["insuranceType"].Value = comboBox2.Text;
                        row.Cells["provider"].Value = tb_tennhacungcap.Text;
                        row.Cells["start_date"].Value = DateTime.Parse(tb_start_date.Text);
                        row.Cells["end_date"].Value = DateTime.Parse(tb_end_date.Text);
                        //row.Cells["status"].Value = "Hoạt Động";
                        break;
                    }
                }

                using (var session = _driver.AsyncSession())
                {
                    var updateQuery = @"
                    MATCH (c:CongDan)-[r:HAS_INSURANCE]->(i:Insurance)
                    WHERE c.policyId = $policyId
                    SET i.insuranceType = $insuranceType,
                        i.provider = $provider,
                        i.premium_frequency = $premium_frequency,
                        i.co_payment_amount = $co_payment_amount,
                        i.deductible_amount = $deductible_amount,
                        i.start_date = $start_date,
                        i.end_date = $end_date,
                        i.renewal_date = $renewal_date,
                        i.premium_amount = $premium_amount,
                        r.start_date = $start_date,
                        r.end_date = $end_date
                    RETURN c, r, i";

                    var parameters = new Dictionary<string, object>
                    {
                        { "policyId", tb_policy_id.Text },
                        { "insuranceType", comboBox2.Text },
                        { "provider", tb_tennhacungcap.Text },
                        { "premium_frequency", cb_donvi.Text},
                        { "co_payment_amount", tb_co_payment_amount.Text },
                        { "deductible_amount", tb_chitratruoc },
                        { "start_date", DateTime.Parse(tb_start_date.Text) },
                        { "end_date", DateTime.Parse(tb_end_date.Text) },
                        { "renewal_date",tb_ngaygiahan.Text },
                        { "premium_amount",tb_premium_amount.Text }

                    };
                    await session.RunAsync(updateQuery, parameters);
                    MessageBox.Show("Node updated successfully.");

                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private async void btn_themmoi_Click(object sender, EventArgs e)
        {
            hiddenPolicyID();
            EnableField();
            btn_Luu.Enabled = true;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckValid())
                {
                    MessageBox.Show("Dữ liệu còn trống xem lại!");
                    return;
                }
                _ = AddInsuranceAndRelationAsync(new CongDan
                {
                    hoTen = lb_idcd.Text,
                    tuoi = int.Parse(lb_tuoi.Text),
                    cccd = comboBox1.Text
                }, new Insurance
                {
                    insuranceId = tb_sohopdongbaohiem.Text,
                    insuranceType = comboBox2.Text,
                    policyId = tb_policy_id.Text,
                    provider = tb_tennhacungcap.Text,
                    start_date = DateTime.Parse(tb_start_date.Text),
                    end_date = DateTime.Parse(tb_end_date.Text),
                    premium_frequency = cb_donvi.Text,
                    co_payment_amount = long.Parse(tb_co_payment_amount.Text),
                    deductible_amount = long.Parse(tb_chitratruoc.Text),
                    renewal_date = DateTime.Parse(tb_ngaygiahan.Text),
                    premium_amount = long.Parse(tb_premium_amount.Text)
                }, new HAS_INSURANCE
                {
                    start_date = DateTime.Parse(tb_start_date.Text),
                    end_date = DateTime.Parse(tb_end_date.Text),
                    status = "Hoạt Động"
                }
                );
                DisableField();


            }
            catch (Exception)
            {
                MessageBox.Show("Exception 341");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_XuatFile.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Luu.Enabled = false;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                if (row.Cells["HoTen"].Value.ToString() == "")
                {
                    DisableField();
                }
                lb_idcd.Text = row.Cells["HoTen"].Value.ToString();
                lb_tuoi.Text = row.Cells["Tuoi"].Value.ToString();
                comboBox1.Text = row.Cells["CCCD"].Value.ToString();
                tb_sohopdongbaohiem.Text = row.Cells["insuranceId"].Value.ToString();
                comboBox2.Text = row.Cells["insuranceType"].Value.ToString();
                tb_tennhacungcap.Text = row.Cells["provider"].Value.ToString();
                tb_policy_id.Text = row.Cells["policyId"].Value.ToString();
                cb_donvi.Text = row.Cells["premium_frequency"].Value.ToString();
                tb_co_payment_amount.Text = row.Cells["co_payment_amount"].Value.ToString();

                tb_chitratruoc.Text = row.Cells["deductible_amount"].Value.ToString();
                tb_ngaygiahan.Text = row.Cells["renewal_date"].Value.ToString();
                tb_premium_amount.Text = row.Cells["premium_amount"].Value.ToString();

                tb_start_date.Text = row.Cells["start_date"].Value.ToString();
                tb_end_date.Text = row.Cells["end_date"].Value.ToString();
                tb_premium_amount.Text = row.Cells["premium_amount"].Value.ToString();

                tb_co_payment_amount.Text = row.Cells["co_payment_amount"].Value.ToString();

            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Đảm bảo có ít nhất một dòng được chọn
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xóa dòng", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Lấy giá trị policyId từ dòng được chọn
                    string policyId = selectedRow.Cells["policyId"].Value.ToString();

                    dataGridView1.Rows.Remove(selectedRow);

                    try
                    {
                        _ = DeleteInsuranceAndRelation();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting the node: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                EnableField();
                tb_sohopdongbaohiem.Enabled = false;
                comboBox1.Enabled = false;
                btn_Xoa.Enabled = false;
                btn_themmoi.Enabled = false;
                btn_Luu.Enabled = false;
                dataGridView1.Enabled = false;
                //btnHuy.Visible = true;
                btn_luuchinhsua.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btn_luuchinhsua_Click(object sender, EventArgs e)
        {
            _ = UpdateInsuranceAndRelation();
            dataGridView1.Enabled = true;
            DisableField();
            btn_themmoi.Enabled = true;

        }

        private void btn_XuatFile_Click(object sender, EventArgs e)
        {



            var homNay = DateTime.Now;
            // Bước 1: Nạp file mẫu
            Document baoCao = new Document("Template\\Mau_Bao_Cao.doc");

            // Bước 2: Điền các thông tin cố định
            baoCao.MailMerge.Execute(new[] { "TINH" }, new[] { "TP.HCM" });
            baoCao.MailMerge.Execute(new[] { "Ngay_Thang_Nam_BC" }, new[] { string.Format(" ngày {0} tháng {1} năm {2}", homNay.Day, homNay.Month, homNay.Year) });
            baoCao.MailMerge.Execute(new[] { "HO_TEN" }, new[] { lb_idcd.Text });
            baoCao.MailMerge.Execute(new[] { "Tuoi" }, new[] { lb_tuoi.Text });
            baoCao.MailMerge.Execute(new[] { "CCCD" }, new[] { comboBox1.Text });
            // baoCao.MailMerge.Execute(new[] { "Ngay_Sinh" }, new[] { dateNgaySinh.Value.ToString("dd/MM/yyyy") });
            baoCao.MailMerge.Execute(new[] { "Start" }, new[] { FormatDate(tb_start_date.Text) });
            baoCao.MailMerge.Execute(new[] { "End" }, new[] { FormatDate(tb_end_date.Text) });
            baoCao.MailMerge.Execute(new[] { "So_HD" }, new[] { tb_policy_id.Text });
            baoCao.MailMerge.Execute(new[] { "Que_Quan" }, new[] { "Bến Tre" });

            baoCao.MailMerge.Execute(new[] { "Loai_Bao_Hiem" }, new[] { comboBox2.Text });
            baoCao.MailMerge.Execute(new[] { "NCC" }, new[] { tb_tennhacungcap.Text });
            baoCao.MailMerge.Execute(new[] { "GiaHan" }, new[] { tb_start_date.Text });
            baoCao.MailMerge.Execute(new[] { "TanSuat" }, new[] { cb_donvi.Text });
            baoCao.MailMerge.Execute(new[] { "TienYeuCau" }, new[] { tb_co_payment_amount.Text });
            baoCao.MailMerge.Execute(new[] { "TienTDK" }, new[] { tb_premium_amount.Text });

            string startDateFormatted = FormatDate(tb_start_date.Text);
            string endDateFormatted = FormatDate(tb_end_date.Text);

            Table bangThongTinCongdan = baoCao.GetChild(NodeType.Table, 1, true) as Table; // Lấy bảng thứ 2 trong file mẫu
            if (bangThongTinCongdan != null)
            {
                int hangHienTai = 1;
                // Chèn thêm một dòng mới với 5 cột
                Row newRow = new Row(baoCao);
                for (int i = 0; i < 4; i++)
                {
                    newRow.Cells.Add(new Cell(baoCao));
                    newRow.Cells[i].AppendChild(new Paragraph(baoCao));
                }
                bangThongTinCongdan.Rows.Add(newRow);

                // Điền dữ liệu vào các ô của dòng mới
                bangThongTinCongdan.Rows[hangHienTai].Cells[0].FirstParagraph.AppendChild(new Run(baoCao, tb_policy_id.Text));
                bangThongTinCongdan.Rows[hangHienTai].Cells[1].FirstParagraph.AppendChild(new Run(baoCao, comboBox2.Text));
                bangThongTinCongdan.Rows[hangHienTai].Cells[2].FirstParagraph.AppendChild(new Run(baoCao, tb_tennhacungcap.Text));
                bangThongTinCongdan.Rows[hangHienTai].Cells[3].FirstParagraph.AppendChild(new Run(baoCao, FormatDate(tb_ngaygiahan.Text)));
            }
            dataGridView1.Enabled = true;
            
            // Bước 4: Lưu và mở file
            string filePath = "D:\\HK7\\MongoDB\\DoAn\\DoAnNosql\\bin\\Debug\\net7.0-windows\\temp\\Mau_Bao_Cao.doc";
            baoCao.Save(filePath);

            // Mở tệp tài liệu bằng ứng dụng mặc định
            ProcessStartInfo startInfo = new ProcessStartInfo(filePath)
            {
                UseShellExecute = true
            };
            Process.Start(startInfo);
        }

        private string FormatDate(string dateText)
        {
            if (DateTime.TryParse(dateText, out DateTime dateValue))
            {
                return dateValue.ToString("dd/MM/yyyy");
            }
            else
            {
                // Nếu chuỗi không hợp lệ, trả về giá trị mặc định hoặc thông báo lỗi
                return "Ngày không hợp lệ";
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    _ = UpdateInsuranceAndRelation();
        //    EnableField();
        //}
    }
}
