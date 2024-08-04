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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CongDanForm));
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
            Strip_SaoLuu = new ToolStripMenuItem();
            Strip_PhucHoi = new ToolStripMenuItem();
            bảoHiểmToolStripMenuItem = new ToolStripMenuItem();
            Strip_TTBaoHiem = new ToolStripMenuItem();
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
            btnLuu.Location = new Point(296, 46);
            btnLuu.Margin = new Padding(3, 2, 3, 2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(82, 26);
            btnLuu.TabIndex = 0;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(5, 82);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(149, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 64);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 3;
            label1.Text = "Họ và Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 117);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 4;
            label2.Text = "Tuổi";
            // 
            // txtTuoi
            // 
            txtTuoi.Location = new Point(198, 134);
            txtTuoi.Margin = new Padding(3, 2, 3, 2);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(148, 23);
            txtTuoi.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 117);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 12;
            label3.Text = "CCCD";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(5, 134);
            txtCCCD.Margin = new Padding(3, 2, 3, 2);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(149, 23);
            txtCCCD.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(490, 89);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(816, 362);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(5, 20);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(82, 22);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(200, 20);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(82, 22);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(101, 20);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(82, 22);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(270, 20);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(148, 23);
            txtId.TabIndex = 18;
            txtId.Visible = false;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(296, 20);
            btnHuy.Margin = new Padding(3, 2, 3, 2);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(82, 22);
            btnHuy.TabIndex = 19;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnSaveUpdate
            // 
            btnSaveUpdate.Location = new Point(172, 46);
            btnSaveUpdate.Margin = new Padding(3, 2, 3, 2);
            btnSaveUpdate.Name = "btnSaveUpdate";
            btnSaveUpdate.Size = new Size(110, 26);
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
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1354, 24);
            menuStrip1.TabIndex = 21;
            menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            trangChủToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thoátToolStripMenuItem, Strip_SaoLuu, Strip_PhucHoi });
            trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            trangChủToolStripMenuItem.Size = new Size(71, 20);
            trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(180, 22);
            thoátToolStripMenuItem.Text = "Thoát";
            // 
            // Strip_SaoLuu
            // 
            Strip_SaoLuu.Name = "Strip_SaoLuu";
            Strip_SaoLuu.Size = new Size(180, 22);
            Strip_SaoLuu.Text = "Sao Lưu";
            Strip_SaoLuu.Click += Strip_SaoLuu_Click;
            // 
            // Strip_PhucHoi
            // 
            Strip_PhucHoi.Name = "Strip_PhucHoi";
            Strip_PhucHoi.Size = new Size(180, 22);
            Strip_PhucHoi.Text = "Phục Hồi";
            Strip_PhucHoi.Click += Strip_PhucHoi_Click;
            // 
            // bảoHiểmToolStripMenuItem
            // 
            bảoHiểmToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { Strip_TTBaoHiem });
            bảoHiểmToolStripMenuItem.Name = "bảoHiểmToolStripMenuItem";
            bảoHiểmToolStripMenuItem.Size = new Size(71, 20);
            bảoHiểmToolStripMenuItem.Text = "Bảo Hiểm";
            // 
            // Strip_TTBaoHiem
            // 
            Strip_TTBaoHiem.Name = "Strip_TTBaoHiem";
            Strip_TTBaoHiem.Size = new Size(182, 22);
            Strip_TTBaoHiem.Text = "Thông Tin Bảo Hiểm";
            Strip_TTBaoHiem.Click += Strip_TTBaoHiem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(49, 20);
            helpToolStripMenuItem.Text = "Help?";
            // 
            // càiĐặtToolStripMenuItem
            // 
            càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            càiĐặtToolStripMenuItem.Size = new Size(57, 20);
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
            groupBox1.Location = new Point(28, 98);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(437, 362);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin công dân";
            // 
            // txt_diachi
            // 
            txt_diachi.Location = new Point(5, 241);
            txt_diachi.Margin = new Padding(3, 2, 3, 2);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(340, 23);
            txt_diachi.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(5, 224);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
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
            groupBox2.Location = new Point(0, 283);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(437, 80);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Các thao tác";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(203, 170);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 24;
            label6.Text = "Quận";
            // 
            // lb6
            // 
            lb6.AutoSize = true;
            lb6.Location = new Point(9, 170);
            lb6.Name = "lb6";
            lb6.Size = new Size(49, 15);
            lb6.TabIndex = 23;
            lb6.Text = "Phường";
            // 
            // cb_Quan
            // 
            cb_Quan.FormattingEnabled = true;
            cb_Quan.Location = new Point(198, 193);
            cb_Quan.Margin = new Padding(3, 2, 3, 2);
            cb_Quan.Name = "cb_Quan";
            cb_Quan.Size = new Size(148, 23);
            cb_Quan.TabIndex = 22;
            // 
            // cb_Phuong
            // 
            cb_Phuong.FormattingEnabled = true;
            cb_Phuong.Location = new Point(5, 193);
            cb_Phuong.Margin = new Padding(3, 2, 3, 2);
            cb_Phuong.Name = "cb_Phuong";
            cb_Phuong.Size = new Size(149, 23);
            cb_Phuong.TabIndex = 21;
            cb_Phuong.SelectedIndexChanged += cb_Phuong_SelectedIndexChanged;
            // 
            // Dtp_NgaySinh
            // 
            Dtp_NgaySinh.Location = new Point(198, 82);
            Dtp_NgaySinh.Margin = new Padding(3, 2, 3, 2);
            Dtp_NgaySinh.Name = "Dtp_NgaySinh";
            Dtp_NgaySinh.Size = new Size(219, 23);
            Dtp_NgaySinh.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 64);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 19;
            label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(336, 34);
            label4.Name = "label4";
            label4.Size = new Size(296, 37);
            label4.TabIndex = 23;
            label4.Text = "QUẢN LÝ CÔNG DÂN";
            // 
            // CongDanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 473);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "CongDanForm";
            Text = "Ứng Dụng Quản Lý Công Dân";
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
        private ToolStripMenuItem Strip_SaoLuu;
        private ToolStripMenuItem Strip_PhucHoi;
    }
}
