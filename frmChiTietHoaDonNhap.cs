using Management_System.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System
{
    public partial class frmChiTietHoaDonNhap : Form
    {
        public frmChiTietHoaDonNhap(long idHoaDon, byte danhapkho)
        {
            this.idHoaDon = idHoaDon;
            this.danhapkho = danhapkho;

            InitializeComponent();
        }

        private long idHoaDon;
        private byte danhapkho;

        private DatabaseDataContext db;
        private DataGridViewRow r;
        //private string nhanvien = "admin";

        private void frmChiTietHoaDonNhap_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();
            ShowData();

            var hd = db.HoaDonNhaps.SingleOrDefault(x => x.ID == idHoaDon);
            if (hd.DaNhap == 1)
            {
                btnSave.Enabled = false;
                btnRemove.Enabled = false;
            }

            var rs = from mh in db.MatHangs
                     join dvt in db.DonViTinhs on mh.DVT equals dvt.ID
                     select (new
                     {
                         tenmathang = mh.TenMatHang + " - " + dvt.TenDVT,
                         mahang = mh.ID
                     });

            cbbMatHang.DataSource = rs;
            cbbMatHang.DisplayMember = "tenmathang";
            cbbMatHang.ValueMember = "mahang";
            cbbMatHang.SelectedIndex = -1;

            //dtgvMatHang.Columns["idmathang"].Visible = false;
        }

        private void ShowData()
        {
            var rs = from cthd in db.ChiTietHoaDonNhaps.Where(x => x.IDHoaDon == idHoaDon)
                     join mh in db.MatHangs on cthd.IDMatHang equals mh.ID
                     join dvt in db.DonViTinhs on mh.DVT equals dvt.ID
                     select (new
                     {
                         //idmathang = mh.ID,
                         mathang = mh.TenMatHang,
                         dvt = dvt.TenDVT,
                         sl = cthd.SoLuong,
                         dg = cthd.DonGiaNhap,
                         thanhtien = cthd.SoLuong * cthd.DonGiaNhap
                     });

            dtgvMatHang.DataSource = rs;
            txtThanhTien.Text = string.Format("{0:N0}", rs.Sum(x => x.thanhtien));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbbMatHang.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Mặt Hàng", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cthd = new ChiTietHoaDonNhap();

            cthd.IDHoaDon = idHoaDon;

            var item = db.ChiTietHoaDonNhaps.FirstOrDefault(x => x.IDHoaDon == idHoaDon && x.IDMatHang == int.Parse(cbbMatHang.SelectedValue.ToString()));

            if (item == null) 
            {
                cthd.IDMatHang = int.Parse(cbbMatHang.SelectedValue.ToString());
                cthd.DonGiaNhap = int.Parse(txtDonGiaNhap.Text);
                cthd.SoLuong = int.Parse(txtSoLuong.Text);

                db.ChiTietHoaDonNhaps.InsertOnSubmit(cthd);
                db.SubmitChanges();
            }
            else
            {
                item.SoLuong += int.Parse(txtSoLuong.Text);
                db.SubmitChanges();
            }
            ShowData();

            cbbMatHang.SelectedIndex = -1;
            txtDonGiaNhap.Text = null;
            txtSoLuong.Text = null;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (r == null)
            {
                MessageBox.Show("Vui lòng chọn Mặt Hàng cần xóa khỏi Hóa Đơn Nhập", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn muốn xóa Mặt Hàng '" + r.Cells["mathang"].Value.ToString() + "' ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var cthd = db.ChiTietHoaDonNhaps.SingleOrDefault(x => x.IDHoaDon == idHoaDon && x.IDMatHang == int.Parse(r.Cells["idmathang"].Value.ToString()));
                    db.ChiTietHoaDonNhaps.DeleteOnSubmit(cthd);
                    db.SubmitChanges();

                    MessageBox.Show("Xóa Mặt Hàng thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowData();

                    cbbMatHang.SelectedIndex = -1;
                    txtDonGiaNhap.Text = null;
                    txtSoLuong.Text = null;
                    r = null;
                }
                catch
                {
                    MessageBox.Show("Xóa Mặt Hàng thất bại", "THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dtgvMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dtgvMatHang.Rows[e.RowIndex];
                txtDonGiaNhap.Text = r.Cells["dg"].Value.ToString();
                txtSoLuong.Text = r.Cells["sl"].Value.ToString();
                int idMatHang = Convert.ToInt32(r.Cells["idmathang"].Value);
                cbbMatHang.SelectedValue = idMatHang;
            }
        }

        private void rbtNhapKho_Click(object sender, EventArgs e)
        {
            if (rbtYeuCau.Checked)
            {
                txtTienThanhToan.Enabled = false;
                txtTienThanhToan.Text = "0";
            }
            else
            {
                txtTienThanhToan.Enabled = true;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (dtgvMatHang.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm mặt hàng vào Hóa Đơn", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var hd = db.HoaDonNhaps.SingleOrDefault(x => x.ID == idHoaDon);
            hd.TienThanhToan = int.Parse(txtTienThanhToan.Text);
            hd.DaNhap = rbtYeuCau.Checked ? (byte)0 : (byte)1;
            db.SubmitChanges();
            this.Dispose();
        }

        private void InHoaDon()
        {
            pddHoaDon.Document = pdHoaDon;
            pddHoaDon.ShowDialog();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            InHoaDon();
        }

        private void pdHoaDon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var tencuahang = db.CauHinhs.SingleOrDefault(x => x.TuKhoa == "TenKhachSan").GiaTri;
            var diachi = db.CauHinhs.SingleOrDefault(x => x.TuKhoa == "DiaChi").GiaTri;
            var dienthoai = db.CauHinhs.SingleOrDefault(x => x.TuKhoa == "DienThoai").GiaTri;

            var w = pdHoaDon.DefaultPageSettings.PaperSize.Width;

            e.Graphics.DrawString(
                tencuahang.ToUpper(),
                new Font("Consolas", 14, FontStyle.Bold),
                Brushes.Black, new Point(100, 20)
                );

            e.Graphics.DrawString(
                String.Format("HÓA ĐƠN NHẬP HÀNG"),
                new Font("Consolas", 14, FontStyle.Bold),
                Brushes.Black, new Point(w / 2 + 200, 20)
                );

            e.Graphics.DrawString(
                string.Format("{0} - {1}", diachi, dienthoai),
                new Font("Consolas", 14, FontStyle.Bold),
                Brushes.Black, new Point(100, 55)
                );

            e.Graphics.DrawString(
                String.Format("{0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm")),
                new Font("Consolas", 14, FontStyle.Bold),
                Brushes.Black, new Point(w / 2 + 200, 55)
                );

            Pen blackPen = new Pen(Color.Black, 1);

            var y = 100;

            Point p1 = new Point(10, y);
            Point p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(blackPen, p1, p2);

            y = y + 20;
            e.Graphics.DrawString(
                String.Format("STT"),
                new Font("Consolas", 14, FontStyle.Bold),
                Brushes.Black, new Point(10, y)
                );

            e.Graphics.DrawString(
                String.Format("Tên Mặt Hàng"),
                new Font("Consolas", 14, FontStyle.Bold),
                Brushes.Black, new Point(50, y)
                );

            e.Graphics.DrawString(
                String.Format("Số Lượng"),
                new Font("Consolas", 14, FontStyle.Bold),
                Brushes.Black, new Point(w / 2, y)
                );

            e.Graphics.DrawString(
                String.Format("Đơn Giá"),
                new Font("Consolas", 14, FontStyle.Bold),
                Brushes.Black, new Point(w / 2 + 100, y)
                );

            e.Graphics.DrawString(
                String.Format("Thành Tiền"),
                new Font("Consolas", 14, FontStyle.Bold),
                Brushes.Black, new Point(w - 200, y)
                );

            var rs = from cthd in db.ChiTietHoaDonNhaps.Where(x => x.IDHoaDon == idHoaDon)
                     join mh in db.MatHangs on cthd.IDMatHang equals mh.ID
                     join dvt in db.DonViTinhs on mh.DVT equals dvt.ID
                     select (new
                     {
                         idmathang = mh.ID,
                         mathang = mh.TenMatHang,
                         dvt = dvt.TenDVT,
                         sl = cthd.SoLuong,
                         dg = cthd.DonGiaNhap,
                         thanhtien = cthd.SoLuong * cthd.DonGiaNhap
                     });

            int i = 1;
            y = y + 40;
            foreach (var item in rs)
            {
                //sum += item.sl * item.dg;
                e.Graphics.DrawString(
                    string.Format("{0}", i++),
                    new Font("Consolas", 12, FontStyle.Regular),
                    Brushes.Black, new Point(10, y)
                    );

                e.Graphics.DrawString(
                    item.mathang,
                    new Font("Consolas", 12, FontStyle.Regular),
                    Brushes.Black, new Point(50, y)
                    );

                e.Graphics.DrawString(
                    string.Format("{0:N0}", item.sl),
                    new Font("Consolas", 12, FontStyle.Regular),
                    Brushes.Black, new Point(w / 2, y)
                    );

                e.Graphics.DrawString(
                    string.Format("{0:N0}", item.dg),
                    new Font("Consolas", 12, FontStyle.Regular),
                    Brushes.Black, new Point(w / 2 + 100, y)
                    );

                e.Graphics.DrawString(
                    string.Format("{0:N0}", item.thanhtien),
                    new Font("Consolas", 12, FontStyle.Regular),
                    Brushes.Black, new Point(w - 200, y)
                    );
                y += 40;
            }

            y = y + 0;
            p1 = new Point(10, y);
            p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(blackPen, p1, p2);

            y = y + 20;
            e.Graphics.DrawString(
                    string.Format("Tổng Tiền: {0:N0} VNĐ", rs.Sum(x => x.thanhtien)),
                    new Font("Consolas", 14, FontStyle.Bold),
                    Brushes.Black, new Point(w - 300, y)
                    );
        }
    }
}
