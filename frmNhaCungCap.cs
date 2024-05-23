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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private DatabaseDataContext db;
        private DataGridViewRow r;
        //private string nhanvien = "admin";

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();
            ShowData();
            dtgvNhaCungCap.Columns["id"].Visible = false;

            dtgvNhaCungCap.Columns["tenncc"].Width = 250;
            dtgvNhaCungCap.Columns["dienthoai"].Width = 250;
            dtgvNhaCungCap.Columns["email"].Width = 250;
            dtgvNhaCungCap.Columns["diachi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dtgvNhaCungCap.Columns["tenncc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvNhaCungCap.Columns["dienthoai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvNhaCungCap.Columns["email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvNhaCungCap.Columns["diachi"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgvNhaCungCap.Columns["tenncc"].HeaderText = "Tên Nhà Cung Cấp";
            dtgvNhaCungCap.Columns["dienthoai"].HeaderText = "Điện Thoại";
            dtgvNhaCungCap.Columns["email"].HeaderText = "Email";
            dtgvNhaCungCap.Columns["diachi"].HeaderText = "Địa Chỉ";
        }

        private void ShowData()
        {
            var rs = from n in db.NhaCungCaps
                     select new
                     {
                         n.ID,
                         n.TenNCC,
                         n.DienThoai,
                         n.Email,
                         n.DiaChi
                     };
            dtgvNhaCungCap.DataSource = rs;
        }

        private bool EmailHopLe(string email)
        {
            try
            {
                var diaChiEmail = new System.Net.Mail.MailAddress(email);
                return diaChiEmail.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenNCC.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Nhà Cung Cấp", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNCC.Select();
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

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập Email", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Select();
                return;
            }

            if (!EmailHopLe(txtEmail.Text))
            {
                MessageBox.Show("Email không hợp lệ, vui lòng nhập lại!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Select();
                return;
            }

            NhaCungCap ncc = new NhaCungCap();
            ncc.TenNCC = txtTenNCC.Text;
            ncc.DienThoai = txtDienThoai.Text;
            ncc.Email = txtEmail.Text;
            ncc.DiaChi = txtDiaChi.Text;

            db.NhaCungCaps.InsertOnSubmit(ncc);
            db.SubmitChanges();

            ShowData();
            MessageBox.Show("Thêm mới Nhà Cung Cấp thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTenNCC.Text = null;
            txtDienThoai.Text = null;
            txtEmail.Text = null;
            txtDiaChi.Text = null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn Nhà Cung Cấp cần cập nhật", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var ncc = db.NhaCungCaps.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));

            ncc.TenNCC = txtTenNCC.Text;
            ncc.DienThoai = txtDienThoai.Text;
            ncc.Email = txtEmail.Text;
            ncc.DiaChi = txtDiaChi.Text;

            db.SubmitChanges();

            ShowData();
            MessageBox.Show("Cập nhật Nhà Cung Cấp thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTenNCC.Text = null;
            txtDienThoai.Text = null;
            txtEmail.Text = null;
            txtDiaChi.Text = null;
            r = null;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn Nhà Cung Cấp cần xóa", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn muốn xóa Nhà Cung Cấp '" + r.Cells["tenncc"].Value.ToString() + "' ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var ncc = db.NhaCungCaps.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
                    db.NhaCungCaps.DeleteOnSubmit(ncc);
                    db.SubmitChanges();

                    MessageBox.Show("Xóa Nhà Cung Cấp thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowData();

                    txtTenNCC.Text = null;
                    txtDienThoai.Text = null;
                    txtEmail.Text = null;
                    txtDiaChi.Text = null;
                    r = null;
                }
                catch
                {
                    MessageBox.Show("Xóa Nhà Cung Cấp thất bại", "THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dtgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dtgvNhaCungCap.Rows[e.RowIndex];
                txtTenNCC.Text = r.Cells["tenncc"].Value.ToString();
                txtDienThoai.Text = r.Cells["dienthoai"].Value.ToString();
                txtEmail.Text = r.Cells["email"].Value.ToString();
                txtDiaChi.Text = r.Cells["diachi"].Value.ToString();
            }
        }
    }
}
