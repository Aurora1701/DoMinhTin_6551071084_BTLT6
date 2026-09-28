namespace B3Buoi6
{
    partial class FormNhapDiem
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
            components = new System.ComponentModel.Container();
            txtMaHS = new TextBox();
            txtHoTen = new TextBox();
            txtToan = new TextBox();
            txtVan = new TextBox();
            txtAnh = new TextBox();
            btnLuu = new Button();
            btnXoaTrang = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            errorProvider1 = new ErrorProvider(components);
            lstDanhSach = new ListBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtMaHS
            // 
            txtMaHS.Font = new Font("Segoe UI", 12F);
            txtMaHS.Location = new Point(35, 47);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(125, 34);
            txtMaHS.TabIndex = 0;
            // 
            // txtHoTen
            // 
            txtHoTen.Font = new Font("Segoe UI", 12F);
            txtHoTen.Location = new Point(198, 47);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(125, 34);
            txtHoTen.TabIndex = 1;
            // 
            // txtToan
            // 
            txtToan.Font = new Font("Segoe UI", 12F);
            txtToan.Location = new Point(351, 47);
            txtToan.Name = "txtToan";
            txtToan.Size = new Size(125, 34);
            txtToan.TabIndex = 2;
            txtToan.Enter += new System.EventHandler(TextBoxDiem_Enter);
            // 
            // txtVan
            // 
            txtVan.Font = new Font("Segoe UI", 12F);
            txtVan.Location = new Point(503, 47);
            txtVan.Name = "txtVan";
            txtVan.Size = new Size(125, 34);
            txtVan.TabIndex = 3;
            txtVan.Enter += new System.EventHandler(TextBoxDiem_Enter);
            // 
            // txtAnh
            // 
            txtAnh.Font = new Font("Segoe UI", 12F);
            txtAnh.Location = new Point(652, 47);
            txtAnh.Name = "txtAnh";
            txtAnh.Size = new Size(125, 34);
            txtAnh.TabIndex = 4;
            txtAnh.Enter += new System.EventHandler(TextBoxDiem_Enter);
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.LightGreen;
            btnLuu.Font = new Font("Segoe UI", 12F);
            btnLuu.Location = new Point(35, 101);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(123, 48);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += new System.EventHandler(btnLuu_Click);
            // 
            // btnXoaTrang
            // 
            btnXoaTrang.BackColor = Color.Gray;
            btnXoaTrang.Font = new Font("Segoe UI", 12F);
            btnXoaTrang.Location = new Point(182, 101);
            btnXoaTrang.Name = "btnXoaTrang";
            btnXoaTrang.Size = new Size(123, 48);
            btnXoaTrang.TabIndex = 6;
            btnXoaTrang.Text = "Xóa Trắng";
            btnXoaTrang.UseVisualStyleBackColor = false;
            btnXoaTrang.Click += new System.EventHandler(btnXoaTrang_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(35, 18);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 7;
            label1.Text = "Mã HS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(198, 18);
            label2.Name = "label2";
            label2.Size = new Size(71, 28);
            label2.TabIndex = 8;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(351, 18);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 9;
            label3.Text = "Điểm Toán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(503, 18);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 10;
            label4.Text = "Điểm Văn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(652, 18);
            label5.Name = "label5";
            label5.Size = new Size(98, 28);
            label5.TabIndex = 11;
            label5.Text = "Điểm Anh";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lstDanhSach
            // 
            lstDanhSach.FormattingEnabled = true;
            lstDanhSach.Location = new Point(35, 168);
            lstDanhSach.Name = "lstDanhSach";
            lstDanhSach.Size = new Size(715, 264);
            lstDanhSach.TabIndex = 12;
            // 
            // FormNhapDiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstDanhSach);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnXoaTrang);
            Controls.Add(btnLuu);
            Controls.Add(txtAnh);
            Controls.Add(txtVan);
            Controls.Add(txtToan);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaHS);
            Name = "FormNhapDiem";
            Text = "FormNhapDiem";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaHS;
        private TextBox txtHoTen;
        private TextBox txtToan;
        private TextBox txtVan;
        private TextBox txtAnh;
        private Button btnLuu;
        private Button btnXoaTrang;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ErrorProvider errorProvider1;
        private ListBox lstDanhSach;
    }
}
