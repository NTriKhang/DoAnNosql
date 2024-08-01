namespace DoAnNosql
{
    partial class CongDanForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLuu = new Button();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtTuoi = new TextBox();
            label3 = new Label();
            txtCCCD = new TextBox();
            dataGridView1 = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            txtId = new TextBox();
            btnHuy = new Button();
            btnSaveUpdate = new Button();
            menuStrip1 = new MenuStrip();
            trangChủToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            bảoHiểmToolStripMenuItem = new ToolStripMenuItem();
            Strip_TTBaoHiem = new ToolStripMenuItem();
            Strip_BHThanhToan = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            càiĐặtToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            txt_diachi = new TextBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            label6 = new Label();
            lb6 = new Label();
            cb_Quan = new ComboBox();
            cb_Phuong = new ComboBox();
            Dtp_NgaySinh = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(338, 61);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 34);
            btnLuu.TabIndex = 0;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(6, 109);
            txtName.Name = "txtName";
            txtName.Size = new Size(170, 27);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 86);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Họ và Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 156);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 4;
            label2.Text = "Tuổi";
            // 
            // txtTuoi
            // 
            txtTuoi.Location = new Point(226, 179);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(168, 27);
            txtTuoi.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 156);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 12;
            label3.Text = "CCCD";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(6, 179);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(170, 27);
            txtCCCD.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(560, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(933, 483);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(6, 26);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(229, 26);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(115, 26);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(308, 26);
            txtId.Name = "txtId";
            txtId.Size = new Size(168, 27);
            txtId.TabIndex = 18;
            txtId.Visible = false;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(338, 26);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 19;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnSaveUpdate
            // 
            btnSaveUpdate.Location = new Point(197, 61);
            btnSaveUpdate.Name = "btnSaveUpdate";
            btnSaveUpdate.Size = new Size(126, 34);
            btnSaveUpdate.TabIndex = 20;
            btnSaveUpdate.Text = "Lưu cập nhật";
            btnSaveUpdate.UseVisualStyleBackColor = true;
            btnSaveUpdate.Click += btnSaveUpdate_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, bảoHiểmToolStripMenuItem, helpToolStripMenuItem, càiĐặtToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1547, 28);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            trangChủToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thoátToolStripMenuItem });
            trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            trangChủToolStripMenuItem.Size = new Size(87, 24);
            trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(130, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // bảoHiểmToolStripMenuItem
            // 
            bảoHiểmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Strip_TTBaoHiem, Strip_BHThanhToan });
            bảoHiểmToolStripMenuItem.Name = "bảoHiểmToolStripMenuItem";
            bảoHiểmToolStripMenuItem.Size = new Size(89, 24);
            bảoHiểmToolStripMenuItem.Text = "Bảo Hiểm";
            // 
            // Strip_TTBaoHiem
            // 
            Strip_TTBaoHiem.Name = "Strip_TTBaoHiem";
            Strip_TTBaoHiem.Size = new Size(228, 26);
            Strip_TTBaoHiem.Text = "Thông Tin Bảo Hiểm";
            Strip_TTBaoHiem.Click += Strip_TTBaoHiem_Click;
            // 
            // Strip_BHThanhToan
            // 
            Strip_BHThanhToan.Name = "Strip_BHThanhToan";
            Strip_BHThanhToan.Size = new Size(228, 26);
            Strip_BHThanhToan.Text = "Thanh Toán";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(62, 24);
            helpToolStripMenuItem.Text = "Help?";
            // 
            // càiĐặtToolStripMenuItem
            // 
            càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            càiĐặtToolStripMenuItem.Size = new Size(72, 24);
            càiĐặtToolStripMenuItem.Text = "Cài Đặt";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_diachi);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(lb6);
            groupBox1.Controls.Add(cb_Quan);
            groupBox1.Controls.Add(cb_Phuong);
            groupBox1.Controls.Add(Dtp_NgaySinh);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(txtTuoi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCCCD);
            groupBox1.Location = new Point(32, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(499, 483);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin công dân";
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(6, 321);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(388, 27);
            txt_diachi.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 298);
            label7.Name = "label7";
            label7.Size = new Size(55, 20);
            label7.TabIndex = 26;
            label7.Text = "Địa chỉ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnSua);
            groupBox2.Controls.Add(btnSaveUpdate);
            groupBox2.Controls.Add(btnHuy);
            groupBox2.Controls.Add(btnLuu);
            groupBox2.Location = new Point(0, 377);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(499, 106);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Các thao tác";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(232, 227);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 24;
            label6.Text = "Quận";
            // 
            // lb6
            // 
            lb6.AutoSize = true;
            lb6.Location = new Point(10, 227);
            lb6.Name = "lb6";
            lb6.Size = new Size(60, 20);
            lb6.TabIndex = 23;
            lb6.Text = "Phường";
            // 
            // cb_Quan
            // 
            cb_Quan.FormattingEnabled = true;
            cb_Quan.Location = new Point(226, 257);
            cb_Quan.Name = "cb_Quan";
            cb_Quan.Size = new Size(168, 28);
            cb_Quan.TabIndex = 22;
            // 
            // cb_Phuong
            // 
            cb_Phuong.FormattingEnabled = true;
            cb_Phuong.Location = new Point(6, 257);
            cb_Phuong.Name = "cb_Phuong";
            cb_Phuong.Size = new Size(170, 28);
            cb_Phuong.TabIndex = 21;
            cb_Phuong.SelectedIndexChanged += cb_Phuong_SelectedIndexChanged;
            // 
            // Dtp_NgaySinh
            // 
            Dtp_NgaySinh.Location = new Point(226, 109);
            Dtp_NgaySinh.Name = "Dtp_NgaySinh";
            Dtp_NgaySinh.Size = new Size(250, 27);
            Dtp_NgaySinh.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(226, 86);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 19;
            label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(384, 46);
            label4.Name = "label4";
            label4.Size = new Size(371, 46);
            label4.TabIndex = 23;
            label4.Text = "QUẢN LÝ CÔNG DÂN";
            // 
            // CongDanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1547, 631);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CongDanForm";
            Text = "Form1";
            Load += CongDanForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLuu;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private TextBox txtTuoi;
        private Label label3;
        private TextBox txtCCCD;
        private DataGridView dataGridView1;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtId;
        private Button btnHuy;
        private Button btnSaveUpdate;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem trangChủToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem bảoHiểmToolStripMenuItem;
        private ToolStripMenuItem Strip_TTBaoHiem;
        private ToolStripMenuItem Strip_BHThanhToan;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem càiĐặtToolStripMenuItem;
        private GroupBox groupBox1;
        private Label label4;
        private DateTimePicker Dtp_NgaySinh;
        private Label label5;
        private GroupBox groupBox2;
        private Label label6;
        private Label lb6;
        private ComboBox cb_Quan;
        private ComboBox cb_Phuong;
        private Label label7;
        private TextBox txt_diachi;
    }
}
