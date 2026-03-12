using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            using (QLSVDataContext db = new QLSVDataContext())
            {
                string user = txtTaiKhoan.Text.Trim();
                string pass = txtMatKhau.Text.Trim();

                // Kiểm tra tài khoản trong database
                var tk = db.TaiKhoans.FirstOrDefault(x => x.TenDangNhap == user && x.MatKhau == pass);

                if (tk != null)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo");

                    // Mở form Sinh Viên
                    frmSinhVien frmSV = new frmSinhVien(); // Tạm thời tạo form trống, sau này bạn thay bằng frmSinhVien
                    frmSV.Show();

                    this.Hide(); // Ẩn form đăng nhập đi
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
