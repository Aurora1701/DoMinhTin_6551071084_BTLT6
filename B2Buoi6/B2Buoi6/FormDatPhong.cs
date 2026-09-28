using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Globalization;
using System.Text.RegularExpressions;

namespace B2Buoi6
{
    public partial class FormDatPhong : Form
    {
        private const string DATE_FORMAT = "dd/MM/yyyy";
        public FormDatPhong()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.EnablePreventFocusChange;
        }
        private void txtHoTen_Validating(object sender, CancelEventArgs e)
        {
            string hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrEmpty(hoTen))
            {
                BaoLoi(txtHoTen, "Họ tên không được để trống!", e);
            }
            else
            {
                XoaLoi(txtHoTen);
            }
        }

        private void txtCCCD_Validating(object sender, CancelEventArgs e)
        {
            string cccd = txtCCCD.Text.Trim();
            if (!Regex.IsMatch(cccd, @"^\d{12}$"))
            {
                BaoLoi(txtCCCD, "Số CCCD phải gồm đúng 12 chữ số!", e);
            }
            else
            {
                XoaLoi(txtCCCD);
            }
        }

        private void txtNgayNhan_Validating(object sender, CancelEventArgs e)
        {
            string strNgayNhan = txtNgayNhan.Text.Trim();
            if (!DateTime.TryParseExact(strNgayNhan, DATE_FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayNhan))
            {
                BaoLoi(txtNgayNhan, "Ngày nhận không đúng định dạng dd/MM/yyyy!", e);
            }
            else if (ngayNhan.Date < DateTime.Today)
            {
                BaoLoi(txtNgayNhan, "Ngày nhận phòng phải từ ngày hôm nay trở đi!", e);
            }
            else
            {
                XoaLoi(txtNgayNhan);
            }
        }

        private void txtNgayTra_Validating(object sender, CancelEventArgs e)
        {
            string strNgayTra = txtNgayTra.Text.Trim();
            if (!DateTime.TryParseExact(strNgayTra, DATE_FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayTra))
            {
                BaoLoi(txtNgayTra, "Ngày trả không đúng định dạng dd/MM/yyyy!", e);
                return;
            }

            if (DateTime.TryParseExact(txtNgayNhan.Text.Trim(), DATE_FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime ngayNhan))
            {
                if (ngayTra.Date <= ngayNhan.Date)
                {
                    BaoLoi(txtNgayTra, "Ngày trả phòng phải sau ngày nhận phòng!", e);
                }
                else
                {
                    XoaLoi(txtNgayTra);
                }
            }
            else
            {
                BaoLoi(txtNgayTra, "Vui lòng nhập ngày nhận phòng hợp lệ trước!", e);
            }
        }

        private void txtSoNguoiLon_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtSoNguoiLon.Text.Trim(), out int soNguoiLon) || soNguoiLon < 1 || soNguoiLon > 4)
            {
                BaoLoi(txtSoNguoiLon, "Số người lớn phải là số nguyên từ 1 đến 4!", e);
            }
            else
            {
                XoaLoi(txtSoNguoiLon);
            }
        }

        private void txtSoTreEm_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtSoTreEm.Text.Trim(), out int soTreEm) || soTreEm < 0 || soTreEm > 3)
            {
                BaoLoi(txtSoTreEm, "Số trẻ em phải là số nguyên từ 0 đến 3!", e);
            }
            else
            {
                XoaLoi(txtSoTreEm);
            }
        }

        private void BaoLoi(TextBox control, string message, CancelEventArgs e)
        {
            e.Cancel = true;
            errorProvider1.SetError(control, message);
            control.BackColor = Color.MistyRose;
        }

        private void XoaLoi(TextBox control)
        {
            errorProvider1.SetError(control, "");
            control.BackColor = Color.Honeydew;
        }

        private void TextBox_Validated(object sender, EventArgs e)
        {
            if (sender is TextBox tb)
            {
                tb.BackColor = Color.Honeydew;
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

            DateTime ngayNhan = DateTime.ParseExact(txtNgayNhan.Text.Trim(), DATE_FORMAT, CultureInfo.InvariantCulture);
            DateTime ngayTra = DateTime.ParseExact(txtNgayTra.Text.Trim(), DATE_FORMAT, CultureInfo.InvariantCulture);

            int soDem = (ngayTra - ngayNhan).Days;

            string thongTin = $"ĐẶT PHÒNG THÀNH CÔNG!\n\n" +
                              $"- Tên khách hàng: {txtHoTen.Text.Trim()}\n" +
                              $"- CCCD: {txtCCCD.Text.Trim()}\n" +
                              $"- Thời gian: {txtNgayNhan.Text.Trim()} -> {txtNgayTra.Text.Trim()} ({soDem} đêm)\n" +
                              $"- Số lượng khách: {txtSoNguoiLon.Text.Trim()} người lớn, {txtSoTreEm.Text.Trim()} trẻ em";

            MessageBox.Show(thongTin, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}