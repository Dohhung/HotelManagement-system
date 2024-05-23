using Management_System.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System
{
    public partial class frmDonViTinh : Form
    {
        public frmDonViTinh()
        {
            InitializeComponent();
        }

        private DatabaseDataContext db;
        //private string nhanvien = "admin";

        private void frmDonViTinh_Load(object sender, EventArgs e)
        {

            db = new DatabaseDataContext();
            ShowData();
        }

        private void ShowData() 
        {
            var rs = (from d in db.DonViTinhs
                      select new 
                      { 
                          d.ID,
                          d.TenDVT,
                      }).ToList();
            dtgvDVT.DataSource = rs;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDVT.Text))
            {
                DonViTinh dvt = new DonViTinh();
                dvt.TenDVT = txtDVT.Text;
                db.DonViTinhs.InsertOnSubmit(dvt);
                db.SubmitChanges();
                MessageBox.Show("Thêm mới Đơn Vị Tính thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
                txtDVT.Text = null;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập Đơn Vị Tính","CHÚ Ý",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private DataGridViewRow r;

        private void dtgvDVT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            r = dtgvDVT.Rows[e.RowIndex];
            txtDVT.Text = r.Cells["TenDVT"].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn Đơn Vị Tính cần cập nhật", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(txtDVT.Text))
            {
                var dvt = db.DonViTinhs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
                dvt.TenDVT = txtDVT.Text;
                db.SubmitChanges();
                MessageBox.Show("Cập nhật Đơn Vị Tính thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
                r = null;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên Đơn Vị Tính", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn Đơn Vị Tính cần xóa", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (MessageBox.Show("Bạn muốn xóa Đơn Vị Tính " + r.Cells["TenDVT"].Value.ToString() + " ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var dvt = db.DonViTinhs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["id"].Value.ToString()));
                db.DonViTinhs.DeleteOnSubmit(dvt);
                db.SubmitChanges();
                MessageBox.Show("Xóa Đơn Vị Tính thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
                r = null;
            }
        }
    }
}
