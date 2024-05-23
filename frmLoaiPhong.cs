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
    public partial class frmLoaiPhong : Form
    {
        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        private DatabaseDataContext db;
        private DataGridViewRow r;


        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();
            ShowData();
        }

        private void ShowData() 
        {
            var rs = from l in db.LoaiPhongs
                     select new
                     {
                         l.ID,
                         l.TenLoaiPhong,
                         l.DonGia
                     };
            dtgvLoaiPhong.DataSource = rs;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenLoaiPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập Loại Phòng", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLoaiPhong.Select();
                return;
            }

            if (string.IsNullOrEmpty(txtDonGiaLoaiPhong.Text))
            {
                MessageBox.Show("Vui lòng nhập Đơn Giá", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGiaLoaiPhong.Select();
                return;
            }

            LoaiPhong l = new LoaiPhong();
            l.TenLoaiPhong = txtTenLoaiPhong.Text;
            l.DonGia = int.Parse(txtDonGiaLoaiPhong.Text);

            db.LoaiPhongs.InsertOnSubmit(l);
            db.SubmitChanges();

            ShowData();
            MessageBox.Show("Thêm mới Loại Phòng thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTenLoaiPhong.Text = null;
            txtDonGiaLoaiPhong.Text = "0";
        }

        private void txtDonGiaLoaiPhong_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Vui lòng chọn Loại Phòng cần cập nhật", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var l = db.LoaiPhongs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));

            l.TenLoaiPhong = txtTenLoaiPhong.Text;
            l.DonGia = int.Parse(txtDonGiaLoaiPhong.Text);


            db.SubmitChanges();

            ShowData();
            MessageBox.Show("Cập nhật Loại Phòng thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtTenLoaiPhong.Text = null;
            txtDonGiaLoaiPhong.Text = "0";
            r = null;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn Loại Phòng cần xóa", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn muốn xóa Loại Phòng '" + r.Cells["tenloaiphong"].Value.ToString() + "' ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try 
                {
                    var l = db.LoaiPhongs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
                    db.LoaiPhongs.DeleteOnSubmit(l);
                    db.SubmitChanges() ;
                    
                    MessageBox.Show("Xóa Loại Phòng thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowData();
                    
                    txtTenLoaiPhong.Text = null;
                    txtDonGiaLoaiPhong.Text = "0";
                    r = null;
                } 
                catch 
                {
                    MessageBox.Show("Xóa Loại Phòng thất bại", "THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dtgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dtgvLoaiPhong.Rows[e.RowIndex];
                txtTenLoaiPhong.Text = r.Cells["tenloaiphong"].Value.ToString();
                txtDonGiaLoaiPhong.Text = r.Cells["dongia"].Value.ToString();
            }
        }

    }
}
