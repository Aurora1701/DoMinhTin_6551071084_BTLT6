namespace B5Buoi6
{
    public partial class FormBanVe : Form
    {
        public FormBanVe()
        {
            InitializeComponent();
            txtGheDaChon.ReadOnly = true;
            txtGheDaChon.ReadOnly = true;
        }
        private void btnChonGhe_Click(object sender, EventArgs e)
        {
            using (FormChonGhe dlg = new FormChonGhe(txtGheDaChon.Text.Trim()))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    txtGheDaChon.Text = dlg.GheChon;
                }
            }
        }

        private void btnDatVe_Click(object sender, EventArgs e)
        {
            string tenKhach = txtTenKhach.Text.Trim();
            string phim = cboPhim.SelectedItem?.ToString();
            string suatChieu = cboSuatChieu.SelectedItem?.ToString();
            string ghe = txtGheDaChon.Text.Trim();

            if (string.IsNullOrEmpty(tenKhach) || string.IsNullOrEmpty(phim) ||
                string.IsNullOrEmpty(suatChieu) || string.IsNullOrEmpty(ghe))
            {
                MessageBox.Show(
                    "Vui lòng điền đầy đủ thông tin khách, phim, suất chiếu và chọn ghế!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string thongTin = $"XÁC NHẬN ĐẶT VÉ\n\n" +
                              $"- Tên khách: {tenKhach}\n" +
                              $"- Phim: {phim}\n" +
                              $"- Suất chiếu: {suatChieu}\n" +
                              $"- Ghế: {ghe}\n" +
                              $"- Giá vé: 75.000đ/vé";

            MessageBox.Show(thongTin, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenKhach.Clear();
            cboPhim.SelectedIndex = -1;
            cboSuatChieu.SelectedIndex = -1;
            txtGheDaChon.Clear();
            txtTenKhach.Focus();
        }
    }
}
