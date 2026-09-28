namespace B4Buoi6
{
    partial class FormDanhBa
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
            lstLienHe = new ListBox();
            txtTen = new MaskedTextBox();
            txtSDT = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // lstLienHe
            // 
            lstLienHe.FormattingEnabled = true;
            lstLienHe.Location = new Point(5, 4);
            lstLienHe.Name = "lstLienHe";
            lstLienHe.Size = new Size(340, 424);
            lstLienHe.TabIndex = 0;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(351, 43);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(417, 27);
            txtTen.TabIndex = 1;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(351, 109);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(417, 27);
            txtSDT.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(351, 9);
            label1.Name = "label1";
            label1.Size = new Size(41, 28);
            label1.TabIndex = 3;
            label1.Text = "Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(351, 75);
            label2.Name = "label2";
            label2.Size = new Size(128, 28);
            label2.TabIndex = 4;
            label2.Text = "Số điện thoại";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(593, 167);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(175, 29);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += this.btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(593, 213);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(175, 29);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += this.btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(593, 257);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(175, 29);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += this.btnXoa_Click;  
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(593, 382);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(175, 29);
            btnThoat.TabIndex = 8;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += this.btnThoat_Click;
            // 
            // FormDanhBa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnThoat);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSDT);
            Controls.Add(txtTen);
            Controls.Add(lstLienHe);
            Name = "FormDanhBa";
            Text = "FormDanhBa";
            FormClosing += FormDanhBa_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstLienHe;
        private MaskedTextBox txtTen;
        private MaskedTextBox txtSDT;
        private Label label1;
        private Label label2;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
    }
}
