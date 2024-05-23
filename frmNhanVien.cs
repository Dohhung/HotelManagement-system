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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private DatabaseDataContext db;
        private DataGridViewRow r;
        //private string nhanvien = "admin";

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();
            ShowData();

            dtgvNhanVien.Columns["password"].Visible = false;

            dtgvNhanVien.Columns["username"].Width = 175;
            dtgvNhanVien.Columns["hovaten"].Width = 200;
            dtgvNhanVien.Columns["dienthoai"].Width = 150;
            dtgvNhanVien.Columns["diachi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dtgvNhanVien.Columns["username"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dtgvNhanVien.Columns["hovaten"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dtgvNhanVien.Columns["dienthoai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dtgvNhanVien.Columns["diachi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dtgvNhanVien.Columns["username"].HeaderText = "Tên Tài Khoản";
            dtgvNhanVien.Columns["hovaten"].HeaderText = "Họ Tên";
            dtgvNhanVien.Columns["dienthoai"].HeaderText = "Điện Thoại";
            dtgvNhanVien.Columns["diachi"].HeaderText = "Địa Chỉ";
        }

        private void ShowData()
        {
            var rs = from nv in db.NhanViens
                     select new
                     {
                         nv.Username,
                         nv.Password,
                         nv.HoVaTen,
                         nv.DienThoai,
                         nv.DiaChi
                     };
            dtgvNhanVien.DataSource = rs;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Tài Khoản", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập Mật Khẩu", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ Tên", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập Số Điện Thoại", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDienThoai.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập Địa Chỉ", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Select();
                return;
            }

            var c = db.NhanViens.Where(x => x.Username.Trim().ToLower() == txtTaiKhoan.Text.Trim().ToLower()).Count();
            if (c > 0)
            {
                MessageBox.Show("Tài Khoản đã tồn tại", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Select();
                return;
            }

            var nv = new NhanVien();
            nv.Username = txtTaiKhoan.Text;
            nv.Password = txtMatKhau.Text;
            nv.HoVaTen = txtHoTen.Text;
            nv.DienThoai = txtDienThoai.Text;
            nv.DiaChi = txtDiaChi.Text;

            db.NhanViens.InsertOnSubmit(nv);
            db.SubmitChanges();

            ShowData();
            MessageBox.Show("Thêm mới Nhân Viên thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTaiKhoan.Text = null;
            txtMatKhau.Text = null;
            txtHoTen.Text = null;
            txtDienThoai.Text = null;
            txtDiaChi.Text = null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn Nhân Viên cần cập nhật", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nv = db.NhanViens.SingleOrDefault(x => x.Username == r.Cells["username"].Value.ToString());

            nv.Password = txtMatKhau.Text;
            nv.HoVaTen = txtHoTen.Text;
            nv.DienThoai = txtDienThoai.Text;
            nv.DiaChi = txtDiaChi.Text;

            db.SubmitChanges();

            ShowData();
            MessageBox.Show("Cập nhật Nhân Viên thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTaiKhoan.Text = null;
            txtMatKhau.Text = null;
            txtHoTen.Text = null;
            txtDienThoai.Text = null;
            txtDiaChi.Text = null;
            r = null;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn Nhân Viên cần xóa", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn muốn xóa Nhân Viên '" + r.Cells["username"].Value.ToString() + "' ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var nv = db.NhanViens.SingleOrDefault(x => x.Username == r.Cells["username"].Value.ToString());
                    db.NhanViens.DeleteOnSubmit(nv);
                    db.SubmitChanges();

                    MessageBox.Show("Xóa Nhân Viên thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowData();

                    txtTaiKhoan.Text = null;
                    txtMatKhau.Text = null;
                    txtHoTen.Text = null;
                    txtDienThoai.Text = null;
                    txtDiaChi.Text = null;
                    r = null;
                }
                catch
                {
                    MessageBox.Show("Xóa Nhân Viên thất bại", "THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dtgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dtgvNhanVien.Rows[e.RowIndex];
                txtTaiKhoan.Text = r.Cells["username"].Value.ToString();
                txtMatKhau.Text = r.Cells["password"].Value.ToString();
                txtHoTen.Text = r.Cells["hovaten"].Value.ToString();
                txtDienThoai.Text = r.Cells["dienthoai"].Value.ToString();
                txtDiaChi.Text = r.Cells["diachi"].Value.ToString();
            }
        }
    }
}
