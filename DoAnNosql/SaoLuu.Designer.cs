namespace DoAnNosql
{
    partial class SaoLuu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaoLuu));
            btn_SaoLuu = new Button();
            txt_url = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btn_KhoiPhuc = new Button();
            groupBox5 = new GroupBox();
            groupBox6 = new GroupBox();
            btn_openfileBK = new Button();
            txt_pathjson = new TextBox();
            groupBox3 = new GroupBox();
            btn_TaiXuong = new Button();
            groupBox4 = new GroupBox();
            txt_LocalPath = new TextBox();
            btn_OpenLocalPath = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // btn_SaoLuu
            // 
            btn_SaoLuu.Location = new Point(110, 32);
            btn_SaoLuu.Name = "btn_SaoLuu";
            btn_SaoLuu.Size = new Size(156, 54);
            btn_SaoLuu.TabIndex = 0;
            btn_SaoLuu.Text = "Sao lưu Dữ Liệu Lên AWS";
            btn_SaoLuu.UseVisualStyleBackColor = true;
            btn_SaoLuu.Click += btn_SaoLuu_Click;
            // 
            // txt_url
            // 
            txt_url.Location = new Point(21, 56);
            txt_url.Name = "txt_url";
            txt_url.Size = new Size(607, 23);
            txt_url.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(187, 19);
            label1.Name = "label1";
            label1.Size = new Size(336, 21);
            label1.TabIndex = 2;
            label1.Text = "Link sau khi backup và upload file lên AWS";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txt_url);
            groupBox1.Location = new Point(30, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(660, 103);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Group Link";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_KhoiPhuc);
            groupBox2.Controls.Add(groupBox5);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(btn_SaoLuu);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(787, 513);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thao Tác";
            // 
            // btn_KhoiPhuc
            // 
            btn_KhoiPhuc.Location = new Point(479, 32);
            btn_KhoiPhuc.Name = "btn_KhoiPhuc";
            btn_KhoiPhuc.Size = new Size(169, 54);
            btn_KhoiPhuc.TabIndex = 6;
            btn_KhoiPhuc.Text = "Khôi Phục Dữ Liệu";
            btn_KhoiPhuc.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(groupBox6);
            groupBox5.Location = new Point(30, 382);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(660, 125);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Group Khôi Phục ";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btn_openfileBK);
            groupBox6.Controls.Add(txt_pathjson);
            groupBox6.Location = new Point(21, 22);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(553, 77);
            groupBox6.TabIndex = 1;
            groupBox6.TabStop = false;
            groupBox6.Text = "Đường Dẫn File Json";
            // 
            // btn_openfileBK
            // 
            btn_openfileBK.Location = new Point(428, 16);
            btn_openfileBK.Name = "btn_openfileBK";
            btn_openfileBK.Size = new Size(107, 53);
            btn_openfileBK.TabIndex = 1;
            btn_openfileBK.Text = "Open File JSON";
            btn_openfileBK.UseVisualStyleBackColor = true;
            btn_openfileBK.Click += btn_openfileBK_Click;
            // 
            // txt_pathjson
            // 
            txt_pathjson.Location = new Point(6, 33);
            txt_pathjson.Name = "txt_pathjson";
            txt_pathjson.Size = new Size(416, 23);
            txt_pathjson.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_TaiXuong);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Location = new Point(30, 236);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(660, 129);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Group Dowload";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // btn_TaiXuong
            // 
            btn_TaiXuong.Location = new Point(561, 33);
            btn_TaiXuong.Name = "btn_TaiXuong";
            btn_TaiXuong.Size = new Size(92, 56);
            btn_TaiXuong.TabIndex = 7;
            btn_TaiXuong.Text = "Tải Xuống";
            btn_TaiXuong.UseVisualStyleBackColor = true;
            btn_TaiXuong.Click += btn_TaiXuong_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txt_LocalPath);
            groupBox4.Controls.Add(btn_OpenLocalPath);
            groupBox4.Location = new Point(21, 21);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(535, 75);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Đường Dẫn File Tải Về";
            // 
            // txt_LocalPath
            // 
            txt_LocalPath.Location = new Point(6, 30);
            txt_LocalPath.Name = "txt_LocalPath";
            txt_LocalPath.Size = new Size(416, 23);
            txt_LocalPath.TabIndex = 0;
            // 
            // btn_OpenLocalPath
            // 
            btn_OpenLocalPath.Location = new Point(428, 16);
            btn_OpenLocalPath.Name = "btn_OpenLocalPath";
            btn_OpenLocalPath.Size = new Size(88, 51);
            btn_OpenLocalPath.TabIndex = 5;
            btn_OpenLocalPath.Text = "Open Folder";
            btn_OpenLocalPath.UseVisualStyleBackColor = true;
            btn_OpenLocalPath.Click += btn_OpenLocalPath_Click;
            // 
            // SaoLuu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 537);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SaoLuu";
            Text = "Form Sao Lưu Dữ Liệu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_SaoLuu;
        private TextBox txt_url;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btn_OpenLocalPath;
        private GroupBox groupBox4;
        private TextBox txt_LocalPath;
        private Button btn_TaiXuong;
        private FolderBrowserDialog folderBrowserDialog1;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private TextBox txt_pathjson;
        private Button btn_KhoiPhuc;
        private Button btn_openfileBK;
    }
}