using System.Text.RegularExpressions;

namespace B1Buoi6
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            btnHuy.CausesValidation = false;
        }
        private bool KiemTraHopLe()
        {
            bool hopLe = true;
            string hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrEmpty(hoTen))
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được để trống!");
                hopLe = false;
            }
            else if (hoTen.Length < 3)
            {
                errorProvider1.SetError(txtHoTen, "Họ tên phải có tối thiểu 3 ký tự!");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtHoTen, "");
            }

            string sdt = txtSDT.Text.Trim();
            if (!Regex.IsMatch(sdt, @"^0\d{9}$"))
            {
                errorProvider1.SetError(txtSDT, "Số điện thoại phải gồm đúng 10 chữ số và bắt đầu bằng số 0!");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtSDT, "");
            }

            string email = txtEmail.Text.Trim();
            int atIndex = email.IndexOf('@');
            int dotIndex = email.LastIndexOf('.');

            if (atIndex <= 0 || dotIndex <= atIndex + 1 || dotIndex >= email.Length - 1)
            {
                errorProvider1.SetError(txtEmail, "Email không hợp lệ (cần chứa ký tự '@' và '.' đứng sau '@')!");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            string matKhau = txtMatKhau.Text;
            if (matKhau.Length < 6)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải có tối thiểu 6 ký tự!");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtMatKhau, "");
            }

            string xacNhanMK = txtXacNhanMK.Text;
            if (string.IsNullOrEmpty(xacNhanMK))
            {
                errorProvider1.SetError(txtXacNhanMK, "Vui lòng nhập lại mật khẩu để xác nhận!");
                hopLe = false;
            }
            else if (xacNhanMK != matKhau)
            {
                errorProvider1.SetError(txtXacNhanMK, "Mật khẩu xác nhận không khớp!");
                hopLe = false;
            }
            else
            {
                errorProvider1.SetError(txtXacNhanMK, "");
            }

            return hopLe;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe())
            {
                return;
            }

            MessageBox.Show(
                "Đăng ký thành công! Chào mừng " + txtHoTen.Text.Trim(),
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.AutoValidate = AutoValidate.Disable;
            errorProvider1.Clear();
            this.Close();
        }
    }
}
