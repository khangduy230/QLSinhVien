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
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }
        // Load dữ liệu lên lưới
        private void LoadLop()
        {
            using (QLSVDataContext db = new QLSVDataContext())
            {
                dgvLop.DataSource = db.Lops.Select(l => new { l.MaLop, l.TenLop }).ToList();
            }
        }
        private void frmLop_Load(object sender, EventArgs e)
        {
            LoadLop();
        }
        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaLop.Text = Convert.ToString(dgvLop.Rows[e.RowIndex].Cells["MaLop"].Value);
                txtTenLop.Text = Convert.ToString(dgvLop.Rows[e.RowIndex].Cells["TenLop"].Value);
            }
        }
        private void dgvLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            using (QLSVDataContext db = new QLSVDataContext())
            {
                if (db.Lops.Any(x => x.MaLop == txtMaLop.Text.Trim()))
                {
                    MessageBox.Show("Mã lớp đã tồn tại!"); return;
                }

                Lop lMoi = new Lop();
                lMoi.MaLop = txtMaLop.Text.Trim();
                lMoi.TenLop = txtTenLop.Text.Trim();

                db.Lops.InsertOnSubmit(lMoi);
                db.SubmitChanges();
                LoadLop();
                MessageBox.Show("Thêm thành công!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (QLSVDataContext db = new QLSVDataContext())
            {
                string maCanSua = txtMaLop.Text.Trim();
                var l = db.Lops.FirstOrDefault(x => x.MaLop == maCanSua);

                if (l != null)
                {
                    l.TenLop = txtTenLop.Text.Trim(); // Chỉ sửa tên, không sửa mã
                    db.SubmitChanges();
                    LoadLop();
                    MessageBox.Show("Sửa thành công!");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvLop.CurrentRow == null) return;

            using (QLSVDataContext db = new QLSVDataContext())
            {
                var maLop = Convert.ToString(dgvLop.CurrentRow.Cells["MaLop"].Value);


                if (db.SinhViens.Any(sv => sv.MaLop == maLop))
                {
                    MessageBox.Show("Lớp này đang có sinh viên, không thể xóa!");
                    return;
                }

                var l = db.Lops.FirstOrDefault(x => x.MaLop == maLop);
                if (l != null)
                {
                    db.Lops.DeleteOnSubmit(l);
                    db.SubmitChanges();
                    LoadLop();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            using (QLSVDataContext db = new QLSVDataContext())
            {
                // Lấy từ khóa người dùng nhập vào và xóa khoảng trắng thừa
                string tuKhoa = txtTimKiem.Text.Trim();

                // Lọc danh sách: Lấy những lớp có Mã Lớp HOẶC Tên Lớp chứa từ khóa
                var ds = db.Lops
                           .Where(l => l.MaLop.Contains(tuKhoa) || l.TenLop.Contains(tuKhoa))
                           .Select(l => new
                           {
                               l.MaLop,
                               l.TenLop
                           })
                           .ToList();

                // Cập nhật lại lưới hiển thị
                dgvLop.DataSource = ds;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
