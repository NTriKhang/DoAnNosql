﻿namespace DoAnNosql
{
    partial class InsuranceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsuranceForm));
            groupBox1 = new GroupBox();
            btn_XuatFile = new Button();
            cb_donvi = new ComboBox();
            tb_policy_id = new Label();
            tb_premium_amount = new TextBox();
            label11 = new Label();
            tb_end_date = new TextBox();
            label10 = new Label();
            tb_start_date = new TextBox();
            label9 = new Label();
            tb_co_payment_amount = new TextBox();
            label8 = new Label();
            groupBox5 = new GroupBox();
            lb_tuoi = new Label();
            groupBox4 = new GroupBox();
            lb_idcd = new Label();
            groupBox3 = new GroupBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label7 = new Label();
            tb_ngaygiahan = new TextBox();
            label6 = new Label();
            tb_chitratruoc = new TextBox();
            label5 = new Label();
            label4 = new Label();
            tb_tennhacungcap = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tb_sohopdongbaohiem = new TextBox();
            groupBox2 = new GroupBox();
            btn_luuchinhsua = new Button();
            btn_Sua = new Button();
            btn_Xoa = new Button();
            btn_Luu = new Button();
            btn_themmoi = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_XuatFile);
            groupBox1.Controls.Add(cb_donvi);
            groupBox1.Controls.Add(tb_policy_id);
            groupBox1.Controls.Add(tb_premium_amount);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(tb_end_date);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(tb_start_date);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(tb_co_payment_amount);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(groupBox4);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tb_ngaygiahan);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tb_chitratruoc);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tb_tennhacungcap);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tb_sohopdongbaohiem);
            groupBox1.Location = new Point(14, 95);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(754, 685);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Bảo Hiểm";
            // 
            // btn_XuatFile
            // 
            btn_XuatFile.Location = new Point(600, 580);
            btn_XuatFile.Margin = new Padding(4, 5, 4, 5);
            btn_XuatFile.Name = "btn_XuatFile";
            btn_XuatFile.Size = new Size(123, 75);
            btn_XuatFile.TabIndex = 29;
            btn_XuatFile.Text = "Xuất Word";
            btn_XuatFile.UseVisualStyleBackColor = true;
            btn_XuatFile.Click += btn_XuatFile_Click;
            // 
            // cb_donvi
            // 
            cb_donvi.FormattingEnabled = true;
            cb_donvi.Items.AddRange(new object[] { "Theo Tháng", "Theo Quý", "Theo Năm" });
            cb_donvi.Location = new Point(337, 305);
            cb_donvi.Margin = new Padding(4, 3, 4, 3);
            cb_donvi.Name = "cb_donvi";
            cb_donvi.Size = new Size(217, 33);
            cb_donvi.TabIndex = 20;
            // 
            // tb_policy_id
            // 
            tb_policy_id.AutoSize = true;
            tb_policy_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_policy_id.Location = new Point(231, 17);
            tb_policy_id.Margin = new Padding(4, 0, 4, 0);
            tb_policy_id.Name = "tb_policy_id";
            tb_policy_id.Size = new Size(21, 32);
            tb_policy_id.TabIndex = 28;
            tb_policy_id.Text = " ";
            // 
            // tb_premium_amount
            // 
            tb_premium_amount.Location = new Point(337, 600);
            tb_premium_amount.Margin = new Padding(4, 3, 4, 3);
            tb_premium_amount.Name = "tb_premium_amount";
            tb_premium_amount.Size = new Size(210, 31);
            tb_premium_amount.TabIndex = 27;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(333, 565);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(190, 25);
            label11.TabIndex = 26;
            label11.Text = "Số tiền phải trả định kì";
            // 
            // tb_end_date
            // 
            tb_end_date.Location = new Point(337, 488);
            tb_end_date.Margin = new Padding(4, 3, 4, 3);
            tb_end_date.Name = "tb_end_date";
            tb_end_date.Size = new Size(210, 31);
            tb_end_date.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(334, 460);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(122, 25);
            label10.TabIndex = 24;
            label10.Text = "Ngày kết thúc";
            // 
            // tb_start_date
            // 
            tb_start_date.Location = new Point(26, 488);
            tb_start_date.Margin = new Padding(4, 3, 4, 3);
            tb_start_date.Name = "tb_start_date";
            tb_start_date.Size = new Size(210, 31);
            tb_start_date.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 460);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(123, 25);
            label9.TabIndex = 22;
            label9.Text = "Ngày đăng ký";
            // 
            // tb_co_payment_amount
            // 
            tb_co_payment_amount.Location = new Point(26, 395);
            tb_co_payment_amount.Margin = new Padding(4, 3, 4, 3);
            tb_co_payment_amount.Name = "tb_co_payment_amount";
            tb_co_payment_amount.Size = new Size(210, 31);
            tb_co_payment_amount.TabIndex = 21;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 367);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(189, 25);
            label8.TabIndex = 20;
            label8.Text = "Tiền yêu cầu bảo hiểm";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lb_tuoi);
            groupBox5.Location = new Point(563, 57);
            groupBox5.Margin = new Padding(4, 3, 4, 3);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4, 3, 4, 3);
            groupBox5.Size = new Size(111, 93);
            groupBox5.TabIndex = 18;
            groupBox5.TabStop = false;
            groupBox5.Text = "Tuổi";
            // 
            // lb_tuoi
            // 
            lb_tuoi.AutoSize = true;
            lb_tuoi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_tuoi.Location = new Point(20, 37);
            lb_tuoi.Margin = new Padding(4, 0, 4, 0);
            lb_tuoi.Name = "lb_tuoi";
            lb_tuoi.Size = new Size(21, 32);
            lb_tuoi.TabIndex = 0;
            lb_tuoi.Text = " ";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lb_idcd);
            groupBox4.Location = new Point(323, 57);
            groupBox4.Margin = new Padding(4, 5, 4, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 5, 4, 5);
            groupBox4.Size = new Size(233, 93);
            groupBox4.TabIndex = 17;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tên công dân";
            // 
            // lb_idcd
            // 
            lb_idcd.AutoSize = true;
            lb_idcd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_idcd.Location = new Point(13, 32);
            lb_idcd.Margin = new Padding(4, 0, 4, 0);
            lb_idcd.Name = "lb_idcd";
            lb_idcd.Size = new Size(21, 32);
            lb_idcd.TabIndex = 13;
            lb_idcd.Text = " ";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Location = new Point(24, 57);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(217, 93);
            groupBox3.TabIndex = 16;
            groupBox3.TabStop = false;
            groupBox3.Text = "Số CCCD";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(30, 37);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 33);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Y Tế", "Nhân Thọ", "Lao Động" });
            comboBox2.Location = new Point(337, 213);
            comboBox2.Margin = new Padding(4, 5, 4, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(217, 33);
            comboBox2.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 565);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(202, 25);
            label7.TabIndex = 11;
            label7.Text = "Ngày gia hạn hợp đồng";
            // 
            // tb_ngaygiahan
            // 
            tb_ngaygiahan.Location = new Point(26, 593);
            tb_ngaygiahan.Margin = new Padding(4, 3, 4, 3);
            tb_ngaygiahan.Name = "tb_ngaygiahan";
            tb_ngaygiahan.Size = new Size(214, 31);
            tb_ngaygiahan.TabIndex = 10;
            tb_ngaygiahan.TextChanged += textBox5_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(333, 367);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(110, 25);
            label6.TabIndex = 9;
            label6.Text = "Chi trả trước";
            // 
            // tb_chitratruoc
            // 
            tb_chitratruoc.Location = new Point(333, 395);
            tb_chitratruoc.Margin = new Padding(4, 3, 4, 3);
            tb_chitratruoc.Name = "tb_chitratruoc";
            tb_chitratruoc.Size = new Size(221, 31);
            tb_chitratruoc.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(333, 277);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(169, 25);
            label5.TabIndex = 7;
            label5.Text = "Tần suất thanh toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 277);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(149, 25);
            label4.TabIndex = 5;
            label4.Text = "Tên nhà cung cấp";
            // 
            // tb_tennhacungcap
            // 
            tb_tennhacungcap.Location = new Point(26, 307);
            tb_tennhacungcap.Margin = new Padding(4, 3, 4, 3);
            tb_tennhacungcap.Name = "tb_tennhacungcap";
            tb_tennhacungcap.Size = new Size(214, 31);
            tb_tennhacungcap.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(333, 183);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 3;
            label3.Text = "Loại bảo hiểm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 183);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(198, 25);
            label2.TabIndex = 1;
            label2.Text = "Số hợp đồng bảo hiểm";
            // 
            // tb_sohopdongbaohiem
            // 
            tb_sohopdongbaohiem.Location = new Point(26, 213);
            tb_sohopdongbaohiem.Margin = new Padding(4, 3, 4, 3);
            tb_sohopdongbaohiem.Name = "tb_sohopdongbaohiem";
            tb_sohopdongbaohiem.Size = new Size(214, 31);
            tb_sohopdongbaohiem.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_luuchinhsua);
            groupBox2.Controls.Add(btn_Sua);
            groupBox2.Controls.Add(btn_Xoa);
            groupBox2.Controls.Add(btn_Luu);
            groupBox2.Controls.Add(btn_themmoi);
            groupBox2.Location = new Point(14, 787);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(754, 110);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Các thao tác";
            // 
            // btn_luuchinhsua
            // 
            btn_luuchinhsua.Location = new Point(570, 33);
            btn_luuchinhsua.Margin = new Padding(4, 3, 4, 3);
            btn_luuchinhsua.Name = "btn_luuchinhsua";
            btn_luuchinhsua.Size = new Size(153, 60);
            btn_luuchinhsua.TabIndex = 5;
            btn_luuchinhsua.Text = "Lưu Chỉnh Sửa";
            btn_luuchinhsua.UseVisualStyleBackColor = true;
            btn_luuchinhsua.Click += btn_luuchinhsua_Click;
            // 
            // btn_Sua
            // 
            btn_Sua.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Sua.Image = Properties.Resources._2Sua;
            btn_Sua.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Sua.Location = new Point(303, 33);
            btn_Sua.Margin = new Padding(4, 3, 4, 3);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.RightToLeft = RightToLeft.Yes;
            btn_Sua.Size = new Size(123, 60);
            btn_Sua.TabIndex = 4;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Image = Properties.Resources._3Xoa;
            btn_Xoa.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Xoa.Location = new Point(173, 33);
            btn_Xoa.Margin = new Padding(4, 3, 4, 3);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.RightToLeft = RightToLeft.Yes;
            btn_Xoa.Size = new Size(123, 60);
            btn_Xoa.TabIndex = 3;
            btn_Xoa.Text = "Xoá";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // btn_Luu
            // 
            btn_Luu.Location = new Point(433, 33);
            btn_Luu.Margin = new Padding(4, 3, 4, 3);
            btn_Luu.Name = "btn_Luu";
            btn_Luu.Size = new Size(123, 60);
            btn_Luu.TabIndex = 2;
            btn_Luu.Text = "Lưu";
            btn_Luu.UseVisualStyleBackColor = true;
            btn_Luu.Click += btn_Luu_Click;
            // 
            // btn_themmoi
            // 
            btn_themmoi.Image = (Image)resources.GetObject("btn_themmoi.Image");
            btn_themmoi.ImageAlign = ContentAlignment.MiddleLeft;
            btn_themmoi.Location = new Point(24, 33);
            btn_themmoi.Margin = new Padding(4, 3, 4, 3);
            btn_themmoi.Name = "btn_themmoi";
            btn_themmoi.RightToLeft = RightToLeft.Yes;
            btn_themmoi.Size = new Size(141, 60);
            btn_themmoi.TabIndex = 0;
            btn_themmoi.Text = "Thêm";
            btn_themmoi.UseVisualStyleBackColor = true;
            btn_themmoi.Click += btn_themmoi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(476, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(683, 45);
            label1.TabIndex = 3;
            label1.Text = "Thông tin về Bảo Hiểm của Công Dân 2024";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(801, 95);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1151, 768);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // InsuranceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1967, 912);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            //Margin = new Padding(4, 3, 4, 3);
            Name = "InsuranceForm";
            Text = "Form Quản Lý Thông Tin Bảo Hiểm của Công Dân";
            Load += Insurance_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btn_Sua;
        private Button btn_Xoa;
        private Button btn_Luu;
        private Button btn_themmoi;
        private Label label1;
        private Label label2;
        private TextBox tb_sohopdongbaohiem;
        private Label label3;
        private Label label4;
        private TextBox tb_tennhacungcap;
        private Label label5;
        private Label label6;
        private TextBox tb_chitratruoc;
        private Label label7;
        private TextBox tb_ngaygiahan;
        private DataGridView dataGridView1;
        private Label lb_idcd;
        public ComboBox comboBox1;
        private ComboBox comboBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private Label lb_tuoi;
        private ComboBox cb_donvi;
        private Label label8;
        private TextBox tb_co_payment_amount;
        private TextBox tb_start_date;
        private Label label9;
        private TextBox tb_end_date;
        private Label label10;
        private TextBox tb_premium_amount;
        private Label label11;
        private Label tb_policy_id;
        private Button btn_luuchinhsua;
        private Button btn_XuatFile;
    }
}