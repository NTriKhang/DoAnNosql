using DoAnNosql.Models;
using Neo4j.Driver;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNosql
{
    public partial class ThongKeForm : Form
    {
        private readonly IDriver _driver;
        DataTable dataTablePhuong;
        DataTable dataTableQuan;
        DataTable dataTable_Merge;

        public ThongKeForm()
        {
            InitializeComponent();
            _driver = GraphDatabase.Driver("neo4j+s://93425e7d.databases.neo4j.io:7687", AuthTokens.Basic("neo4j", "SzGRM_1m5iL1IsiYPX9qgxrSwpK0vG1AzDOeHIvJS5I"));
            dataTablePhuong = new DataTable();
            dataTableQuan = new DataTable();
            dataTable_Merge = new DataTable();
            DisableField();
        }

        private void DisableField()
        {
            tb_TongDanSo.Enabled = false;
            tb_SoDan.Enabled = false;
        }

        private async void ThongKeForm_Load(object sender, EventArgs e)
        {
            dataTablePhuong.Columns.Add("name", typeof(string));
            dataTableQuan.Columns.Add("name", typeof(string));
            await LoadDataIntoComboBoxAsync(cb_Quan, "QUAN");

            // Add event handler for ComboBox Quan selection change
            cb_Quan.SelectedIndexChanged += cb_Quan_SelectedIndexChanged;
            cb_Phuong.SelectedIndexChanged += cb_Phuong_SelectedIndexChanged;

            // Load total population initially
            await UpdateTotalPopulation();
            await ReFreshDataGrid();
        }

        private async void cb_Quan_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedQuan = cb_Quan.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedQuan))
            {
                await LoadPhuongByQuanAsync(selectedQuan);
                await UpdatePopulationData(selectedQuan, "QUAN");
                await ReFreshDataGrid(selectedQuan, null);
            }
        }

        private async void cb_Phuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPhuong = cb_Phuong.SelectedItem as string;
            var selectedQuan = cb_Quan.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedPhuong))
            {
                await UpdatePopulationData(selectedPhuong, "PHUONG", selectedQuan);
                await ReFreshDataGrid(selectedQuan, selectedPhuong);
            }
        }


        private async Task LoadPhuongByQuanAsync(string quanName)
        {
            dataTablePhuong.Clear();
            using (var session = _driver.AsyncSession())
            {
                var query = @"
                    MATCH (q:QUAN {name: $quanName})<-[:THUOC]-(p:PHUONG)
                    RETURN p";
                var result = await session.RunAsync(query, new { quanName });
                var records = await result.ToListAsync();

                foreach (var record in records)
                {
                    var node = record["p"].As<INode>();
                    var name = node.Properties["name"].As<string>();
                    dataTablePhuong.Rows.Add(name);
                }
            }
            PopulateComboBox(cb_Phuong, dataTablePhuong);
        }

        private async Task LoadDataIntoComboBoxAsync(ComboBox comboBox, string nodeType)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("name", typeof(string));
            await GetAllNodes(dataTable, nodeType);
            PopulateComboBox(comboBox, dataTable);
        }

        private void PopulateComboBox(ComboBox comboBox, DataTable dataTable)
        {
            comboBox.Items.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                var name = row["name"] as string;
                if (!string.IsNullOrEmpty(name))
                {
                    comboBox.Items.Add(name);
                }
            }
        }

        private async Task GetAllNodes(DataTable dataTable, string nodeType)
        {
            try
            {
                using (var session = _driver.AsyncSession())
                {
                    var getAllQuery = $"MATCH (n:{nodeType}) RETURN n";

                    var getResult = await session.RunAsync(getAllQuery);
                    var res = await getResult.ToListAsync();

                    if (res.Count > 0)
                    {
                        dataTable.Clear();

                        foreach (var record in res)
                        {
                            var node = record["n"].As<INode>();
                            var name = node.Properties.ContainsKey("name") ? node["name"].As<string>() : string.Empty;

                            if (!string.IsNullOrEmpty(name))
                            {
                                dataTable.Rows.Add(name);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show($"No {nodeType} nodes found!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private async Task UpdateTotalPopulation()
        {
            using (var session = _driver.AsyncSession())
            {
                var query = @"
                    MATCH (c:CongDan)
                    WHERE c.diachi IS NOT NULL
                    RETURN COUNT(c) AS totalPopulation";

                var result = await session.RunAsync(query);
                var records = await result.ToListAsync();
                if (records.Count > 0)
                {
                    int totalPopulation = records[0]["totalPopulation"].As<int>();
                    tb_TongDanSo.Text = totalPopulation.ToString();
                }
                else
                {
                    tb_TongDanSo.Text = "0";
                }
            }
        }

        private async Task UpdatePopulationData(string name, string nodeType, string quanName = null)
        {
            using (var session = _driver.AsyncSession())
            {
                var query = nodeType == "QUAN"
                    ? @"
                        MATCH (q:QUAN {name: $name})<-[:THUOC]-(p:PHUONG)<-[:LIVE]-(c:CongDan)
                        WHERE c.diachi IS NOT NULL
                        RETURN COUNT(c) AS population"
                    : @"
                        MATCH (q:QUAN {name: $quanName})<-[:THUOC]-(p:PHUONG {name: $name})<-[:LIVE]-(c:CongDan)
                        WHERE c.diachi IS NOT NULL
                        RETURN COUNT(c) AS population";

                var result = await session.RunAsync(query, new { name, quanName });
                var records = await result.ToListAsync();
                if (records.Count > 0)
                {
                    int population = records[0]["population"].As<int>();
                    tb_SoDan.Text = population.ToString();
                }
                else
                {
                    tb_SoDan.Text = "0";
                }
            }
        }

        private async Task ReFreshDataGrid(string quanName = null, string phuongName = null)
        {
            dataTable_Merge.Clear();
            dataTable_Merge.Columns.Clear();
            dataTable_Merge.Columns.Add("ID", typeof(string));
            dataTable_Merge.Columns.Add("HoTen", typeof(string));
            dataTable_Merge.Columns.Add("Tuoi", typeof(int));
            dataTable_Merge.Columns.Add("CCCD", typeof(string));
            dataTable_Merge.Columns.Add("DiaChi", typeof(string));
            dataTable_Merge.Columns.Add("NgaySinh", typeof(DateTime));
            dataTable_Merge.Columns.Add("NamePhuong", typeof(string));
            dataTable_Merge.Columns.Add("NameQuan", typeof(string));

            await GetAllCongDan(dataTable_Merge, quanName, phuongName);

            dataGridView1.DataSource = dataTable_Merge;
        }


        private async Task GetAllCongDan(DataTable dataTable, string quanName = null, string phuongName = null)
        {
            try
            {
                using (var session = _driver.AsyncSession())
                {
                    var query = @"
                MATCH (c:CongDan)-[:LIVE]->(p:PHUONG)-[:THUOC]->(q:QUAN)
                WHERE ($quanName IS NULL OR q.name = $quanName)
                AND ($phuongName IS NULL OR p.name = $phuongName)
                RETURN c, p, q";

                    var result = await session.RunAsync(query, new { quanName, phuongName });
                    var res = await result.ToListAsync();

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

                            dataTable.Rows.Add(congDan.id, congDan.hoTen, congDan.tuoi, congDan.cccd, congDan.diachi, congDan.ngaysinh, phuong.name, quan.name);
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
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

    }
}