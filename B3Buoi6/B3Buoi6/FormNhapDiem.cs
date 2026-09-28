namespace B3Buoi6
{
    public partial class FormNhapDiem : Form
    {
        public FormNhapDiem()
        {
            InitializeComponent();
            DangKyEnterChuyenField();
        }

        private void DangKyEnterChuyenField()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox tb)
                {
                    tb.KeyPress += TextBox_KeyPress;
                }
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                if (sender == txtAnh)
                {
                    btnLuu.PerformClick();
                }
                else
                {
                    SelectNextControl((Control)sender, true, true, true, true);
                }
            }
        }

        private void TextBoxDiem_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox tb)
            {
                tb.SelectAll();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hopLe = true;

            if (string.IsNullOrWhiteSpace(txtMaHS.Text))
            {
                errorProvider1.SetError(txtMaHS, "Mã học sinh không được để trống!");
                hopLe = false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống!");
                hopLe = false;
            }

            if (!KiemTraDiem(txtToan, "Điểm Toán")) hopLe = false;
            if (!KiemTraDiem(txtVan, "Điểm Văn")) hopLe = false;
            if (!KiemTraDiem(txtAnh, "Điểm Anh")) hopLe = false;

            if (!hopLe)
            {
                return;
            }

            string dongThongTin = $"{txtMaHS.Text.Trim()} | {txtHoTen.Text.Trim()} | T:{txtToan.Text.Trim()} V:{txtVan.Text.Trim()} A:{txtAnh.Text.Trim()}";
            lstDanhSach.Items.Add(dongThongTin);

            XoaTrangForm();
            txtMaHS.Focus();
        }

        private bool KiemTraDiem(TextBox txt, string tenMon)
        {
            if (!decimal.TryParse(txt.Text.Trim(), out decimal diem) || diem < 0 || diem > 10)
            {
                errorProvider1.SetError(txt, $"{tenMon} phải là số từ 0.0 đến 10.0!");
                return false;
            }
            return true;
        }

        private void btnXoaTrang_Click(object sender, EventArgs e)
        {
            XoaTrangForm();
            txtMaHS.Focus();
        }

        private void XoaTrangForm()
        {
            txtMaHS.Clear();
            txtHoTen.Clear();
            txtToan.Clear();
            txtVan.Clear();
            txtAnh.Clear();
            errorProvider1.Clear();
        }
    }
}
