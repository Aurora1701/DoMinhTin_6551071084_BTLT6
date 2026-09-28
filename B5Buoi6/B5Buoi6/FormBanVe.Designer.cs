namespace B5Buoi6
{
    partial class FormBanVe
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
            txtTenKhach = new MaskedTextBox();
            txtGheDaChon = new MaskedTextBox();
            cboPhim = new ComboBox();
            cboSuatChieu = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnChonGhe = new Button();
            btnDatVe = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // txtTenKhach
            // 
            txtTenKhach.Font = new Font("Segoe UI", 12F);
            txtTenKhach.Location = new Point(52, 58);
            txtTenKhach.Name = "txtTenKhach";
            txtTenKhach.Size = new Size(380, 34);
            txtTenKhach.TabIndex = 0;
            // 
            // txtGheDaChon
            // 
            txtGheDaChon.Font = new Font("Segoe UI", 12F);
            txtGheDaChon.Location = new Point(52, 271);
            txtGheDaChon.Name = "txtGheDaChon";
            txtGheDaChon.Size = new Size(380, 34);
            txtGheDaChon.TabIndex = 1;
            // 
            // cboPhim
            // 
            cboPhim.Font = new Font("Segoe UI", 12F);
            cboPhim.FormattingEnabled = true;
            cboPhim.Items.AddRange(new object[] { "A Minecraft Movie  ", "Doraemon: Nobita và cuộc phiêu lưu mới", "Thám Tử Lừng Danh Conan", "Avengers: Secret Wars", "Kung Fu Panda 4", "Spider-Man: Beyond the Spider-Verse" });
            cboPhim.Location = new Point(52, 126);
            cboPhim.Name = "cboPhim";
            cboPhim.Size = new Size(406, 36);
            cboPhim.TabIndex = 2;
            // 
            // cboSuatChieu
            // 
            cboSuatChieu.Font = new Font("Segoe UI", 12F);
            cboSuatChieu.FormattingEnabled = true;
            cboSuatChieu.Items.AddRange(new object[] { "09:00 AM", "11:30 AM", "01:00 PM    ", "03:30 PM", "06:00 PM ", "08:30 PM  ", "11:00 PM" });
            cboSuatChieu.Location = new Point(52, 199);
            cboSuatChieu.Name = "cboSuatChieu";
            cboSuatChieu.Size = new Size(406, 36);
            cboSuatChieu.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(52, 25);
            label1.Name = "label1";
            label1.Size = new Size(97, 28);
            label1.TabIndex = 4;
            label1.Text = "Tên khách";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.AppWorkspace;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(52, 95);
            label2.Name = "label2";
            label2.Size = new Size(56, 28);
            label2.TabIndex = 5;
            label2.Text = "Phim";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.AppWorkspace;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(52, 168);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 6;
            label3.Text = "Suất chiếu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.AppWorkspace;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(52, 240);
            label4.Name = "label4";
            label4.Size = new Size(122, 28);
            label4.TabIndex = 7;
            label4.Text = "Ghế đã chọn";
            // 
            // btnChonGhe
            // 
            btnChonGhe.Location = new Point(138, 346);
            btnChonGhe.Name = "btnChonGhe";
            btnChonGhe.Size = new Size(120, 42);
            btnChonGhe.TabIndex = 8;
            btnChonGhe.Text = "Chọn ghế";
            btnChonGhe.UseVisualStyleBackColor = true;
            btnChonGhe.Click += btnChonGhe_Click;
            // 
            // btnDatVe
            // 
            btnDatVe.Location = new Point(264, 346);
            btnDatVe.Name = "btnDatVe";
            btnDatVe.Size = new Size(120, 42);
            btnDatVe.TabIndex = 9;
            btnDatVe.Text = "Đặt vé";
            btnDatVe.UseVisualStyleBackColor = true;
            btnDatVe.Click += btnDatVe_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(390, 346);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(120, 42);
            btnHuy.TabIndex = 10;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // FormBanVe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1055, 450);
            Controls.Add(btnHuy);
            Controls.Add(btnDatVe);
            Controls.Add(btnChonGhe);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboSuatChieu);
            Controls.Add(cboPhim);
            Controls.Add(txtGheDaChon);
            Controls.Add(txtTenKhach);
            IsMdiContainer = true;
            Name = "FormBanVe";
            Text = "FormBanVe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtTenKhach;
        private MaskedTextBox txtGheDaChon;
        private ComboBox cboPhim;
        private ComboBox cboSuatChieu;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnChonGhe;
        private Button btnDatVe;
        private Button btnHuy;
    }
}
