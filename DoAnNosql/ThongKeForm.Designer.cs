namespace DoAnNosql
{
    partial class ThongKeForm
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
            label4 = new Label();
            dataGridView1 = new DataGridView();
            lb6 = new Label();
            cb_Phuong = new ComboBox();
            label6 = new Label();
            cb_Quan = new ComboBox();
            label1 = new Label();
            tb_TongDanSo = new TextBox();
            label2 = new Label();
            tb_SoDan = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(531, 72);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(344, 54);
            label4.TabIndex = 24;
            label4.Text = "Thống kê dân số";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(132, 311);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1166, 489);
            dataGridView1.TabIndex = 25;
            // 
            // lb6
            // 
            lb6.AutoSize = true;
            lb6.Location = new Point(484, 223);
            lb6.Margin = new Padding(4, 0, 4, 0);
            lb6.Name = "lb6";
            lb6.Size = new Size(102, 25);
            lb6.TabIndex = 26;
            lb6.Text = "Phường/Xã";
            // 
            // cb_Phuong
            // 
            cb_Phuong.FormattingEnabled = true;
            cb_Phuong.Location = new Point(603, 215);
            cb_Phuong.Margin = new Padding(4);
            cb_Phuong.Name = "cb_Phuong";
            cb_Phuong.Size = new Size(212, 33);
            cb_Phuong.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(132, 223);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(55, 25);
            label6.TabIndex = 28;
            label6.Text = "Quận";
            // 
            // cb_Quan
            // 
            cb_Quan.FormattingEnabled = true;
            cb_Quan.Location = new Point(195, 215);
            cb_Quan.Margin = new Padding(4);
            cb_Quan.Name = "cb_Quan";
            cb_Quan.Size = new Size(209, 33);
            cb_Quan.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(885, 171);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(176, 25);
            label1.TabIndex = 30;
            label1.Text = "Tổng dân số TPHCM";
            // 
            // tb_TongDanSo
            // 
            tb_TongDanSo.Location = new Point(1085, 165);
            tb_TongDanSo.Name = "tb_TongDanSo";
            tb_TongDanSo.Size = new Size(213, 31);
            tb_TongDanSo.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(983, 223);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 25);
            label2.TabIndex = 32;
            label2.Text = "Số dân";
            // 
            // tb_SoDan
            // 
            tb_SoDan.Location = new Point(1085, 220);
            tb_SoDan.Name = "tb_SoDan";
            tb_SoDan.Size = new Size(213, 31);
            tb_SoDan.TabIndex = 33;
            // 
            // ThongKeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1477, 813);
            Controls.Add(tb_SoDan);
            Controls.Add(label2);
            Controls.Add(tb_TongDanSo);
            Controls.Add(label1);
            Controls.Add(cb_Quan);
            Controls.Add(label6);
            Controls.Add(cb_Phuong);
            Controls.Add(lb6);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Name = "ThongKeForm";
            Text = "ThongKeForm";
            Load += ThongKeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private DataGridView dataGridView1;
        private Label lb6;
        private ComboBox cb_Phuong;
        private Label label6;
        private ComboBox cb_Quan;
        private Label label1;
        private TextBox tb_TongDanSo;
        private Label label2;
        private TextBox tb_SoDan;
    }
}