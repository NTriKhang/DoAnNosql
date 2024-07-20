using DoAnNosql.Models;
using Neo4j.Driver;
using Neo4jClient;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DoAnNosql
{
    public partial class CongDanForm : Form
    {
        private readonly IDriver _driver;
        DataTable dataTable;

        public CongDanForm()
        {
            InitializeComponent();
            _driver = GraphDatabase.Driver("neo4j+s://93425e7d.databases.neo4j.io:7687", AuthTokens.Basic("neo4j", "SzGRM_1m5iL1IsiYPX9qgxrSwpK0vG1AzDOeHIvJS5I"));
            dataTable = new DataTable();
            _ = ReFreshDataGrid();
            DisableField();
        }
        private void DisableField()
        {
            txtName.Enabled = false;
            txtTuoi.Enabled = false;
            txtCCCD.Enabled = false;

            btnLuu.Enabled = false;
            btnHuy.Visible = false;
            btnSaveUpdate.Enabled = false;
        }
        private void EnableField()
        {
            txtName.Enabled = true;
            txtTuoi.Enabled = true;
            txtCCCD.Enabled = true;

            //btnLuu.Enabled = true;
        }
        private bool CheckValid()
        {
            return (txtName.Text != "" && txtTuoi.Text != "" && txtCCCD.Text != "");
        }
        private async Task ReFreshDataGrid()
        {
            dataTable.Columns.Add("ID", typeof(string));
            dataTable.Columns.Add("HoTen", typeof(string));
            dataTable.Columns.Add("Tuoi", typeof(int));
            dataTable.Columns.Add("CCCD", typeof(string));

            await GetAllCongDan(dataTable);

            dataGridView1.DataSource = dataTable;
        }
        private async Task GetAllCongDan(DataTable dataTable)
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
                        foreach (var record in res)
                        {
                            var node = record[0].As<INode>();
                            var congDan = new CongDan
                            {
                                id = node.ElementId,
                                hoTen = node.Properties.ContainsKey("hoTen") ? node["hoTen"].As<string>() : string.Empty,
                                tuoi = node.Properties.ContainsKey("tuoi") ? node["tuoi"].As<int>() : 0,
                                cccd = node.Properties.ContainsKey("cccd") ? node["cccd"].As<string>() : string.Empty
                            };
                            dataTable.Rows.Add(congDan.id, congDan.hoTen, congDan.tuoi, congDan.cccd);
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
        private async Task AddNote(CongDan congDan)
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
                            CREATE (c:CongDan {hoTen: $hoTen, tuoi: $tuoi, cccd: $cccd})
                            RETURN c";


                var parameters = new Dictionary<string, object>()
                            {
                                { nameof(CongDan.hoTen), congDan.hoTen },
                                { nameof(CongDan.tuoi), congDan.tuoi },
                                { nameof(CongDan.cccd), congDan.cccd },
                            };

                var createResult = await session.RunAsync(createQuery, parameters);
                var record = await createResult.SingleAsync();

                var nodeId = record[0]?.As<INode>();
                if (nodeId != null)
                {
                    MessageBox.Show("Them cong dan thanh cong");
                    dataTable.Rows.Add(nodeId.ElementId, congDan.hoTen, congDan.tuoi, congDan.tuoi);
                }
                else
                    MessageBox.Show("Error occur");
            }
        }
        private async Task<bool> IsExist(IAsyncSession session, string nodeName, string nameField, string value)
        {
            var checkCCCDQuery = $"MATCH (c: {nodeName} {{{nameField}: ${nameField}}}) RETURN c";
            var checkCCCDParams = new Dictionary<string, object>() { { nameField, value } };
            var checkResult = await session.RunAsync(checkCCCDQuery, checkCCCDParams);
            var res = await checkResult.FetchAsync();
            return res;
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
                    cccd = txtCCCD.Text
                });
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
                var deleteQuery = $"MATCH (c:CongDan) WHERE elementId(c) = '{txtId.Text}' DELETE c";
                //var parameters = new Dictionary<string, object> { { "elementId", txtCCCD.Text } };

                var rec = await session.RunAsync(deleteQuery);

                MessageBox.Show("Node deleted successfully.");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
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
                        break;
                    }
                }
                using (var session = _driver.AsyncSession())
                {
                    var updateQuery = @"
                        MATCH (c:CongDan)
                        WHERE elementId(c) = $elementId
                        SET c.hoTen = $hoTen, c.tuoi = $tuoi, c.cccd = $cccd
                        RETURN c";

                    var parameters = new Dictionary<string, object>
                    {
                        { "elementId", txtId.Text },
                        { "hoTen", txtName.Text },
                        { "tuoi", txtTuoi.Text },
                        { "cccd", txtCCCD.Text },
                    };

                    await session.RunAsync(updateQuery, parameters);

                    MessageBox.Show("Node updated successfully.");
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
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtName.Text = row.Cells["HoTen"].Value.ToString();
                txtTuoi.Text = row.Cells["Tuoi"].Value.ToString();
                txtCCCD.Text = row.Cells["CCCD"].Value.ToString();
                txtId.Text = row.Cells["Id"].Value.ToString();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnSaveUpdate.Enabled = false;
            dataGridView1.Enabled = true;
            DisableField();
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            _ = UpdateNode();
        }
    }
}
