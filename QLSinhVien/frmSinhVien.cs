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
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMaSV_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // Viết một hàm riêng để load dữ liệu cho dễ gọi lại về sau
        private void LoadSinhVien()
        {
            using (QLSVDataContext db = new QLSVDataContext())
            {
                // Lấy dữ liệu từ bảng SinhViens trong database
                var ds = db.SinhViens.Select(sv => new
                {
                    sv.MaSV,
                    sv.HoTen,
                    sv.NgaySinh,
                    sv.MaLop
                }).ToList();

                // Gán dữ liệu vào DataGridView
                dgvSinhVien.DataSource = ds;
            }
        }

        // Gọi hàm LoadSinhVien khi form vừa tải lên
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            LoadSinhVien();
        }
<<<<<<< Updated upstream
=======

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra để tránh lỗi khi người dùng click vào phần tiêu đề cột (RowIndex = -1)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];

                txtMaSV.Text = row.Cells["MaSV"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtMaLop.Text = row.Cells["MaLop"].Value.ToString();

                // ép kiểu ngày sinh về DateTime
                if (row.Cells["NgaySinh"].Value != null)
                {
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (QLSVDataContext db = new QLSVDataContext())
            {
                string maCanSua = txtMaSV.Text.Trim();
                // Tìm sinh viên cần sửa
                var sv = db.SinhViens.FirstOrDefault(x => x.MaSV == maCanSua);

                if (sv != null)
                {
                    sv.HoTen = txtHoTen.Text.Trim();
                    sv.NgaySinh = dtpNgaySinh.Value.Date;
                    sv.MaLop = txtMaLop.Text.Trim();

                    db.SubmitChanges(); // Lưu thay đổi xuống database
                    MessageBox.Show("Cập nhật thành công!");
                    LoadSinhVien();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã sinh viên để sửa!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!");
                return;
            }

            // Hỏi lại cho chắc chắn trước khi xóa
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (QLSVDataContext db = new QLSVDataContext())
                {
                    string maSV = dgvSinhVien.CurrentRow.Cells["MaSV"].Value.ToString();
                    var sv = db.SinhViens.FirstOrDefault(x => x.MaSV == maSV);

                    if (sv != null)
                    {
                        db.SinhViens.DeleteOnSubmit(sv);
                        db.SubmitChanges(); // Thực thi lệnh xóa
                        LoadSinhVien();
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (QLSVDataContext db = new QLSVDataContext())
            {
                string tuKhoa = txtTimKiem.Text.Trim();

                // Tìm những sinh viên có Họ Tên HOẶC Mã SV chứa từ khóa
                var ds = db.SinhViens
                           .Where(sv => sv.HoTen.Contains(tuKhoa) || sv.MaSV.Contains(tuKhoa))
                           .Select(sv => new
                           {
                               sv.MaSV,
                               sv.HoTen,
                               sv.NgaySinh,
                               sv.MaLop
                           })
                           .ToList();

                dgvSinhVien.DataSource = ds;
            }
        }

        private void txtMaLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLop f = new frmLop();
            f.ShowDialog();
           
        }
>>>>>>> Stashed changes
    }
}
