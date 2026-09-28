namespace B4Buoi6
{
    public partial class FormDanhBa : Form
    {
        private int _indexDangSua = -1;
        public FormDanhBa()
        {
            InitializeComponent();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            if (string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ tên và số điện thoại!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string dongThongTin = $"{ten} - {sdt}";

            if (_indexDangSua != -1)
            {
                lstLienHe.Items[_indexDangSua] = dongThongTin;
                _indexDangSua = -1;
                btnThem.Text = "Thêm";

                MessageBox.Show(
                    "Cập nhật thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                lstLienHe.Items.Add(dongThongTin);

                MessageBox.Show(
                    "Thêm thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            XoaTrangTextBox();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để xóa",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string dongDaChon = lstLienHe.SelectedItem.ToString();
            string ten = dongDaChon.Split(new[] { " - " }, StringSplitOptions.None)[0];

            DialogResult ketQua = MessageBox.Show(
                $"Bạn có chắc muốn xóa liên hệ {ten}? Thao tác này không thể hoàn tác!",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (ketQua == DialogResult.Yes)
            {
                int viTriXoa = lstLienHe.SelectedIndex;
                lstLienHe.Items.RemoveAt(viTriXoa);

                if (_indexDangSua == viTriXoa)
                {
                    _indexDangSua = -1;
                    btnThem.Text = "Thêm";
                    XoaTrangTextBox();
                }

                MessageBox.Show(
                    "Xóa liên hệ thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lstLienHe.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Vui lòng chọn một liên hệ để sửa!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            _indexDangSua = lstLienHe.SelectedIndex;
            string dongDaChon = lstLienHe.SelectedItem.ToString();
            string[] phanDoan = dongDaChon.Split(new[] { " - " }, StringSplitOptions.None);

            txtTen.Text = phanDoan[0];
            txtSDT.Text = phanDoan.Length > 1 ? phanDoan[1] : "";
            btnThem.Text = "Cập nhật";
            txtTen.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FormDanhBa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTen.Text) || !string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                DialogResult ketQua = MessageBox.Show(
                    "Bạn có dữ liệu chưa được lưu. Bạn muốn thoát không?",
                    "Cảnh báo",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning
                );

                if (ketQua == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else if (ketQua == DialogResult.No)
                {
                    XoaTrangTextBox();
                }
            }
        }

        private void XoaTrangTextBox()
        {
            txtTen.Clear();
            txtSDT.Clear();
            txtTen.Focus();
        }
    }
}
