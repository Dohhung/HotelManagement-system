using Management_System.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System
{
    public partial class frmMain : Form
    {

        private DatabaseDataContext db;
        private string userRole;

        public frmMain()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            userRole = this.Tag as string; // Lấy chức vụ từ Tag
            ApplyRolePermissions();
        }

        private void ApplyRolePermissions()
        {
            if (userRole != "Quản lý") // Chỉ cho phép Quản lý truy cập các chức năng đặc biệt
            {
                nhanVienToolStripMenuItem.Enabled = false; // Hoặc ẩn đi nếu cần thiết
            }
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userRole == "Quản lý")
            {
                var f = new frmNhanVien();
                addForm(f);
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            db = new DatabaseDataContext();
            var ten = db.CauHinhs.SingleOrDefault(x => x.TuKhoa == "TenKhachSan").GiaTri;
            var diachi = db.CauHinhs.SingleOrDefault(x => x.TuKhoa == "DiaChi").GiaTri;
            var dienthoai = db.CauHinhs.SingleOrDefault(x => x.TuKhoa == "DienThoai").GiaTri;
            lblTitle.Text = String.Format("{0} - {1} - {2}", ten, diachi, dienthoai);


        }


        private void addForm(Form f)
        {
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            f.TopMost = true;
            grbContent.Controls.Clear();
            grbContent.Controls.Add(f);
            f.Show();
        }

        private void donViTinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDonViTinh();
            addForm(f);
        }

        private void loaiPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmLoaiPhong();
            addForm(f);
        }
        private void matHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmMatHang();
            addForm(f);
        }

        private void nhaCungCapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmNhaCungCap();
            addForm(f);
        }

        private void phongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmPhong();
            addForm(f);
        }

        private void nhapHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmNhapHang();
            addForm(f);
        }

        private void banHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmBanHang();
            addForm(f);
        }

        private void doanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmDoanhThu();
            addForm(f);
        }

        private void tonKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmTonKho();
            addForm(f);
        }

        private void GioiThieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmGioithieu();
            addForm (f);
        }

        private void DangxuatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmDangNhap().ShowDialog();
        }
    }
}
