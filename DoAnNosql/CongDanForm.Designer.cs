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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(822, 440);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 0;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(72, 15);
            txtName.Name = "txtName";
            txtName.Size = new Size(168, 27);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 3;
            label1.Text = "Ho ten";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 15);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 4;
            label2.Text = "Tuoi";
            // 
            // txtTuoi
            // 
            txtTuoi.Location = new Point(350, 15);
            txtTuoi.Name = "txtTuoi";
            txtTuoi.Size = new Size(168, 27);
            txtTuoi.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 55);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 12;
            label3.Text = "CCCD";
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(72, 55);
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
            dataGridView1.Location = new Point(12, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(904, 303);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 440);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 15;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(212, 440);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(112, 440);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 17;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(748, 9);
            txtId.Name = "txtId";
            txtId.Size = new Size(168, 27);
            txtId.TabIndex = 18;
            txtId.Visible = false;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(722, 440);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 19;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnSaveUpdate
            // 
            btnSaveUpdate.Location = new Point(312, 440);
            btnSaveUpdate.Name = "btnSaveUpdate";
            btnSaveUpdate.Size = new Size(141, 29);
            btnSaveUpdate.TabIndex = 20;
            btnSaveUpdate.Text = "Lưu cập nhật";
            btnSaveUpdate.UseVisualStyleBackColor = true;
            btnSaveUpdate.Click += btnSaveUpdate_Click;
            // 
            // CongDanForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 481);
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
            Name = "CongDanForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    }
}
