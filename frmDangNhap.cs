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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private DatabaseDataContext db;
        public NhanVien nv;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                MessageBox.Show("Vui lòng nhập Tài Khoản", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập Mật Khẩu", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Select();
                return;
            }

            db = new DatabaseDataContext();
            var tk = db.NhanViens.SingleOrDefault(x => x.Username == txtTaiKhoan.Text && x.Password == txtMatKhau.Text);
            if (tk != null)
            {
                this.Hide();
                frmMain mainForm = new frmMain();
                mainForm.Tag = tk.Chucvu; // Lưu chức vụ vào Tag của form chính
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Đăng Nhập thất bại!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTaiKhoan.Select();
                return;
            }
        }



        private void checkboxHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.UseSystemPasswordChar = checkboxHienMatKhau.Checked ? false : true;
        }
    }
}
