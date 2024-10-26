namespace WinFormsApp4
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            txtMaSinhVientc = new TextBox();
            label1 = new Label();
            txtMaSinhVien = new TextBox();
            txtTen = new TextBox();
            txtDiem = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(874, 194);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(54, 292);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(428, 292);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(792, 292);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "Xoá";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(54, 411);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "Tra cứu";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtMaSinhVientc
            // 
            txtMaSinhVientc.Location = new Point(244, 358);
            txtMaSinhVientc.Name = "txtMaSinhVientc";
            txtMaSinhVientc.Size = new Size(199, 27);
            txtMaSinhVientc.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 361);
            label1.Name = "label1";
            label1.Size = new Size(184, 20);
            label1.TabIndex = 6;
            label1.Text = "Nhập Mã sinh viên tra cứu:";
            // 
            // txtMaSinhVien
            // 
            txtMaSinhVien.Location = new Point(154, 236);
            txtMaSinhVien.Name = "txtMaSinhVien";
            txtMaSinhVien.Size = new Size(132, 27);
            txtMaSinhVien.TabIndex = 7;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(402, 240);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(166, 27);
            txtTen.TabIndex = 8;
            // 
            // txtDiem
            // 
            txtDiem.Location = new Point(754, 236);
            txtDiem.Name = "txtDiem";
            txtDiem.Size = new Size(132, 27);
            txtDiem.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 243);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 11;
            label2.Text = "Mã sinh viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 243);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 12;
            label3.Text = "Tên:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(668, 243);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 14;
            label5.Text = "Điểm:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 491);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtDiem);
            Controls.Add(txtTen);
            Controls.Add(txtMaSinhVien);
            Controls.Add(label1);
            Controls.Add(txtMaSinhVientc);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox txtMaSinhVientc;
        private Label label1;
        private TextBox txtMaSinhVien;
        private TextBox txtTen;
        private TextBox txtDiem;
        private Label label2;
        private Label label3;
        private Label label5;
    }
}
