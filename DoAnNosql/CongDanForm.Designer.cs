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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(833, 505);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 0;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(83, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(168, 27);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 77);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 3;
            label1.Text = "Ho ten";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 80);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 4;
            label2.Text = "Tuoi";
            // 
            // txtTuoi
            // 
            txtTuoi.Location = new Point(361, 80);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(168, 27);
            txtTuoi.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 120);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 12;
            label3.Text = "CCCD";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(83, 120);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(446, 27);
            txtCCCD.TabIndex = 13;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 168);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(904, 303);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(23, 505);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(223, 505);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(123, 505);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(759, 74);
            txtId.Name = "txtId";
            txtId.Size = new Size(168, 27);
            txtId.TabIndex = 18;
            txtId.Visible = false;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(733, 505);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 19;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnSaveUpdate
            // 
            btnSaveUpdate.Location = new Point(323, 505);
            btnSaveUpdate.Name = "btnSaveUpdate";
            btnSaveUpdate.Size = new Size(141, 29);
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
            menuStrip1.Size = new Size(984, 28);
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
            thoátToolStripMenuItem.Size = new Size(224, 26);
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
            // CongDanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 554);
            Controls.Add(btnSaveUpdate);
            Controls.Add(btnHuy);
            Controls.Add(txtId);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dataGridView1);
            Controls.Add(txtCCCD);
            Controls.Add(label3);
            Controls.Add(txtTuoi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(btnLuu);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "CongDanForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
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
    }
}
