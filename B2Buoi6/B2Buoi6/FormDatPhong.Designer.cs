namespace B2Buoi6
{
    partial class FormDatPhong
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
            txtHoTen = new TextBox();
            txtCCCD = new TextBox();
            txtNgayTra = new TextBox();
            txtSoNguoiLon = new TextBox();
            txtNgayNhan = new TextBox();
            txtSoTreEm = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnDatPhong = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(344, 57);
            txtHoTen.Margin = new Padding(4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(411, 34);
            txtHoTen.TabIndex = 0;
            txtHoTen.Validating += txtHoTen_Validating;
            txtHoTen.Validated += TextBox_Validated;
            // 
            // txtCCCD
            // 
            txtCCCD.Location = new Point(344, 132);
            txtCCCD.Margin = new Padding(4);
            txtCCCD.Name = "txtCCCD";
            txtCCCD.Size = new Size(411, 34);
            txtCCCD.TabIndex = 1;
            txtCCCD.Validating += txtCCCD_Validating;
            txtCCCD.Validated += TextBox_Validated;
            // 
            // txtNgayTra
            // 
            txtNgayTra.Location = new Point(344, 284);
            txtNgayTra.Margin = new Padding(4);
            txtNgayTra.Name = "txtNgayTra";
            txtNgayTra.Size = new Size(411, 34);
            txtNgayTra.TabIndex = 2;
            txtNgayTra.Validating += txtNgayTra_Validating;
            txtNgayTra.Validated += TextBox_Validated;
            // 
            // txtSoNguoiLon
            // 
            txtSoNguoiLon.Location = new Point(344, 358);
            txtSoNguoiLon.Margin = new Padding(4);
            txtSoNguoiLon.Name = "txtSoNguoiLon";
            txtSoNguoiLon.Size = new Size(411, 34);
            txtSoNguoiLon.TabIndex = 3;
            txtSoNguoiLon.Validating += txtSoNguoiLon_Validating;
            txtSoNguoiLon.Validated += TextBox_Validated;
            // 
            // txtNgayNhan
            // 
            txtNgayNhan.Location = new Point(344, 210);
            txtNgayNhan.Margin = new Padding(4);
            txtNgayNhan.Name = "txtNgayNhan";
            txtNgayNhan.Size = new Size(411, 34);
            txtNgayNhan.TabIndex = 4;
            txtNgayNhan.Validating += txtNgayNhan_Validating;
            txtNgayNhan.Validated += TextBox_Validated;
            // 
            // txtSoTreEm
            // 
            txtSoTreEm.Location = new Point(344, 431);
            txtSoTreEm.Margin = new Padding(4);
            txtSoTreEm.Name = "txtSoTreEm";
            txtSoTreEm.Size = new Size(411, 34);
            txtSoTreEm.TabIndex = 5;
            txtSoTreEm.Validating += txtSoTreEm_Validating;
            txtSoTreEm.Validated += TextBox_Validated;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(344, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(71, 28);
            label1.TabIndex = 6;
            label1.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(344, 99);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 7;
            label2.Text = "Số CCCD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(344, 174);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(170, 28);
            label3.TabIndex = 8;
            label3.Text = "Ngày nhận phòng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(344, 252);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(151, 28);
            label4.TabIndex = 9;
            label4.Text = "Ngày trả phòng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(344, 326);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(125, 28);
            label5.TabIndex = 10;
            label5.Text = "Số người lớn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(344, 399);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(96, 28);
            label6.TabIndex = 11;
            label6.Text = "Số trẻ em";
            // 
            // btnDatPhong
            // 
            btnDatPhong.BackColor = Color.RoyalBlue;
            btnDatPhong.ForeColor = Color.White;
            btnDatPhong.Location = new Point(344, 477);
            btnDatPhong.Margin = new Padding(4);
            btnDatPhong.Name = "btnDatPhong";
            btnDatPhong.Size = new Size(412, 43);
            btnDatPhong.TabIndex = 12;
            btnDatPhong.Text = "Đặt phòng";
            btnDatPhong.UseVisualStyleBackColor = false;
            btnDatPhong.Click += btnDatPhong_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormDatPhong
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGreen;
            ClientSize = new Size(1100, 630);
            Controls.Add(btnDatPhong);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSoTreEm);
            Controls.Add(txtNgayNhan);
            Controls.Add(txtSoNguoiLon);
            Controls.Add(txtNgayTra);
            Controls.Add(txtCCCD);
            Controls.Add(txtHoTen);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FormDatPhong";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtCCCD;
        private TextBox txtNgayTra;
        private TextBox txtSoNguoiLon;
        private TextBox txtNgayNhan;
        private TextBox txtSoTreEm;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnDatPhong;
        private ErrorProvider errorProvider1;
    }
}
