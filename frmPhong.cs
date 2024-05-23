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
    public partial class frmPhong : Form
    {
        public frmPhong()
        {
            InitializeComponent();
        }

        private DatabaseDataContext db;
        private DataGridViewRow r;
        //private string nhanvien = "admin";

        private void frmPhong_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();
            ShowData();

            cbbLoaiPhong.DataSource = db.LoaiPhongs;
            cbbLoaiPhong.DisplayMember = "tenloaiphong";
            cbbLoaiPhong.ValueMember = "id";
            cbbLoaiPhong.SelectedIndex = -1;

            dtgvPhong.Columns["id"].Width = 110;
            dtgvPhong.Columns["tenloaiphong"].Width = 250;
            dtgvPhong.Columns["tenphong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvPhong.Columns["succhua"].Width = 110;
            dtgvPhong.Columns["dongia"].Width = 125;

            dtgvPhong.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvPhong.Columns["tenloaiphong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvPhong.Columns["tenphong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvPhong.Columns["succhua"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvPhong.Columns["dongia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgvPhong.Columns["id"].HeaderText = "Mã Phòng";
            dtgvPhong.Columns["tenloaiphong"].HeaderText = "Tên Loại Phòng";
            dtgvPhong.Columns["tenphong"].HeaderText = "Tên Phòng";
            dtgvPhong.Columns["succhua"].HeaderText = "Sức Chứa";
            dtgvPhong.Columns["dongia"].HeaderText = "Đơn Giá";

            dtgvPhong.Columns["dongia"].DefaultCellStyle.Format = "N0";
        }

        private void ShowData()
        {
            var rs = from p in db.Phongs
                     join l in db.LoaiPhongs on p.IDLoaiPhong equals l.ID
                     select new
                     {
                         p.ID,
                         l.TenLoaiPhong,
                         p.TenPhong,
                         l.DonGia,
                         p.SucChua
                     };
            dtgvPhong.DataSource = rs;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Phòng", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenPhong.Select();
                return;
            }

            if (cbbLoaiPhong.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Loại Phòng", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtSucChua.Text) || int.Parse(txtSucChua.Text) <= 0)
            {
                MessageBox.Show("Sức Chứa của phòng phải lớn hơn 0", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSucChua.Select();
                return;
            }

            var p = new Phong();
            p.TenPhong = txtTenPhong.Text;
            p.IDLoaiPhong = int.Parse(cbbLoaiPhong.SelectedValue.ToString());
            p.SucChua = int.Parse(txtSucChua.Text);


            db.Phongs.InsertOnSubmit(p);
            db.SubmitChanges();

            ShowData();
            MessageBox.Show("Thêm mới Phòng thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTenPhong.Text = null;
            txtSucChua.Text = null;
            cbbLoaiPhong.SelectedIndex = -1;
        }

        private void txtSucChua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn Phòng cần cập nhật", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var p = db.Phongs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));

            p.TenPhong = txtTenPhong.Text;
            p.IDLoaiPhong = int.Parse(cbbLoaiPhong.SelectedValue.ToString());
            p.SucChua = int.Parse(txtSucChua.Text);


            db.SubmitChanges();

            ShowData();
            MessageBox.Show("Cập nhật Phòng thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTenPhong.Text = null;
            txtSucChua.Text = null;
            cbbLoaiPhong.SelectedIndex = -1;
            r = null;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn Phòng cần xóa", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn muốn xóa Phòng '" + r.Cells["tenphong"].Value.ToString() + "' ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var p = db.Phongs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
                    db.Phongs.DeleteOnSubmit(p);
                    db.SubmitChanges();

                    MessageBox.Show("Xóa Phòng thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowData();

                    txtTenPhong.Text = null;
                    txtSucChua.Text = null;
                    cbbLoaiPhong.SelectedIndex = -1;
                    r = null;
                }
                catch
                {
                    MessageBox.Show("Xóa Loại Phòng thất bại", "THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dtgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dtgvPhong.Rows[e.RowIndex];
                txtTenPhong.Text = r.Cells["tenphong"].Value.ToString();
                cbbLoaiPhong.Text = r.Cells["tenloaiphong"].Value.ToString();
                txtSucChua.Text = r.Cells["succhua"].Value.ToString();
            }
        }
    }
}
