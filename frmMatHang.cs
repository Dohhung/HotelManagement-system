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
    public partial class frmMatHang : Form
    {
        public frmMatHang()
        {
            //this.nhanvien = nv;
            InitializeComponent();
        }

        private DatabaseDataContext db;
        //private string nhanvien;
        private DataGridViewRow r;

        private void frmMatHang_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();
            ShowData();

            dtgvMatHang.Columns["id"].Width = 100;
            dtgvMatHang.Columns["tenmathang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgvMatHang.Columns["tendvt"].Width = 150;
            dtgvMatHang.Columns["dongiaban"].Width = 100;

            dtgvMatHang.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dtgvMatHang.Columns["tenmathang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dtgvMatHang.Columns["tendvt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dtgvMatHang.Columns["dongiaban"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dtgvMatHang.Columns["id"].HeaderText = "Mã Hàng";
            dtgvMatHang.Columns["tenmathang"].HeaderText = "Tên Mặt Hàng";
            dtgvMatHang.Columns["tendvt"].HeaderText = "Đơn Vị Tính";
            dtgvMatHang.Columns["dongiaban"].HeaderText = "Đơn Giá";

            dtgvMatHang.Columns["dongiaban"].DefaultCellStyle.Format = "N0";

            cbbDVT.DataSource = db.DonViTinhs;
            cbbDVT.DisplayMember = "TenDVT";
            cbbDVT.ValueMember = "ID";
            cbbDVT.SelectedIndex = -1;
        }

        private void ShowData()
        {
            var rs = from h in db.MatHangs
                     join d in db.DonViTinhs on h.DVT equals d.ID
                     select new
                     {
                         h.ID,
                         h.TenMatHang,
                         d.TenDVT,
                         h.DonGiaBan

                     };
            dtgvMatHang.DataSource = rs;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenMatHang.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Mặt Hàng", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMatHang.Select();
                return;
            }

            if (cbbDVT.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Đơn Vị Tính", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtDonGiaBan.Text))
            {
                MessageBox.Show("Vui lòng nhập Đơn Giá Bán", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGiaBan.Select();
                return;
            }

            var mh = new MatHang();
            mh.TenMatHang = txtTenMatHang.Text;
            mh.DVT = int.Parse(cbbDVT.SelectedValue.ToString());
            mh.DonGiaBan = int.Parse(txtDonGiaBan.Text);


            db.MatHangs.InsertOnSubmit(mh);
            db.SubmitChanges();

            ShowData();
            MessageBox.Show("Thêm mới Mặt Hàng thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTenMatHang.Text = null;
            txtDonGiaBan.Text = "0";
            cbbDVT.SelectedIndex = -1;
        }

        private void txtDonGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenMatHang.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên Mặt Hàng", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMatHang.Select();
                return;
            }

            if (cbbDVT.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Đơn Vị Tính", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtDonGiaBan.Text))
            {
                MessageBox.Show("Vui lòng nhập Đơn Giá Bán", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGiaBan.Select();
                return;
            }

            var mh = db.MatHangs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));

            mh.TenMatHang = txtTenMatHang.Text;
            mh.DVT = int.Parse(cbbDVT.SelectedValue.ToString());
            mh.DonGiaBan = int.Parse(txtDonGiaBan.Text);

            db.SubmitChanges();

            ShowData();
            MessageBox.Show("Cập nhật Mặt Hàng thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTenMatHang.Text = null;
            txtDonGiaBan.Text = "0";
            cbbDVT.SelectedIndex = -1;
        }

        private void dtgvMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dtgvMatHang.Rows[e.RowIndex];

                txtTenMatHang.Text = r.Cells["tenmathang"].Value.ToString();
                cbbDVT.Text = r.Cells["tendvt"].Value.ToString();
                txtDonGiaBan.Text = r.Cells["dongiaban"].Value.ToString();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn Mặt Hàng cần xóa", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (MessageBox.Show("Bạn muốn xóa Mặt Hàng " + r.Cells["tenmathang"].Value.ToString() + " ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try 
                {
                    var mh = db.MatHangs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
                    db.MatHangs.DeleteOnSubmit(mh);
                    db.SubmitChanges();
                    MessageBox.Show("Xóa Mặt Hàng thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
                catch 
                {
                    MessageBox.Show("Xóa Mặt Hàng thất bại", "THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ShowData();

                txtTenMatHang.Text = null;
                txtDonGiaBan.Text = "0";
                cbbDVT.SelectedIndex = -1;
            }
        }
    }
}
