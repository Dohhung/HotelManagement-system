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
    public partial class frmOrder : Form
    {
        private long idHoaDon;
        private string tenphong;
        private DataGridViewRow r;
        private DatabaseDataContext db;

        public frmOrder(long idHoaDon, string tenphong, DataGridViewRow r)
        {
            this.idHoaDon = idHoaDon;
            this.r = r;
            this.tenphong = tenphong;

            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();

            this.lblTenMatHang.Text = "Mặt hàng yêu cầu: " + r.Cells["tenhang"].Value.ToString() + " - " + r.Cells["dvt"].Value.ToString();
            this.lblPhong.Text = string.Format("Phòng yêu cầu: {0}", tenphong);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int sl = 0;
            try
            {
                sl = int.Parse(txtSoLuong.Text);
                if (sl == 0)
                {
                    MessageBox.Show("Số Lượng không hợp lệ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoLuong.Select();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Số Lượng không hợp lệ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuong.Select();
                return;
            }

            var item = db.ChiTietHoaDonBans.SingleOrDefault(x => x.IDHoaDon == idHoaDon && x.IDMatHang == int.Parse(r.Cells["mahang"].Value.ToString()));
            if (item != null)
            {
                item.SoLuong = item.SoLuong + sl;
                db.SubmitChanges();
            }
            else
            {
                var cthdb = new ChiTietHoaDonBan();
                cthdb.IDHoaDon = idHoaDon;
                cthdb.IDMatHang = int.Parse(r.Cells["mahang"].Value.ToString());
                cthdb.SoLuong = sl;

                var mh = db.MatHangs.SingleOrDefault(x => x.ID == int.Parse(r.Cells["mahang"].Value.ToString()));
                cthdb.DonGia = mh.DonGiaBan;

                db.ChiTietHoaDonBans.InsertOnSubmit(cthdb);
                db.SubmitChanges();
            }
            MessageBox.Show("Thêm Mặt Hàng vào '" + tenphong + "' thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) 
            {
                e.Handled = true;
            }
        }
    }
}
