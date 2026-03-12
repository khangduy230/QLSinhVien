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
    }
}
