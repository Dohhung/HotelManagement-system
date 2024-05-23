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
    public partial class frmDoanhThu : Form
    {
        private DatabaseDataContext db;

        public frmDoanhThu()
        {
            InitializeComponent();
        }
        
        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();

            mtbNgayBatDau.Text = DateTime.Now.ToString("dd/MM/yyyy 00:01");
            mtbNgayKetThuc.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            btnThongKe.PerformClick();

            dtgvDoanhThu.Columns["mahang"].Visible = false;
            dtgvDoanhThu.Columns["thanhtien"].HeaderText = "Thành tiền";
            dtgvDoanhThu.Columns["thanhtien"].Width = 150;
            dtgvDoanhThu.Columns["thanhtien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dtgvDoanhThu.Columns["thanhtien"].DefaultCellStyle.Format = "N0";
            dtgvDoanhThu.Columns["thanhtien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau, ngayKetThuc;
            string tuKhoa = null;

            try 
            {
                ngayBatDau = DateTime.ParseExact(mtbNgayBatDau.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                ngayKetThuc = DateTime.ParseExact(mtbNgayKetThuc.Text, "dd/MM/yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
                if (ngayKetThuc <= ngayBatDau)
                {
                    MessageBox.Show("Thời Gian không hợp lệ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } 
            catch (Exception)
            {
                MessageBox.Show("Thời Gian không hợp lệ", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<LineHang> result;

            if (rbtPhong.Checked)
            {
                result = ThongKePhong(ngayBatDau, ngayKetThuc, tuKhoa);
            }
            else
            if (rbtMatHang.Checked)
            {
                result = ThongKeMatHang(ngayBatDau, ngayKetThuc, tuKhoa);
            }
            else
            {
                result = ThongKePhong(ngayBatDau, ngayKetThuc, null);
                result.AddRange(ThongKeMatHang(ngayBatDau, ngayKetThuc, null));
            }
            dtgvDoanhThu.DataSource = result.OrderBy(x => x.ngaygd).ToList();
            tuKhoa = null;
        }

        private List<LineHang> ThongKePhong(DateTime ngayBatDau, DateTime ngayKetThuc, string tuKhoa) 
        {
            var result = from hd in db.HoaDonBanHangs.Where(x => x.ThoiGianKThuc != null && x.ThoiGianBDau >= ngayBatDau && x.ThoiGianBDau <= ngayKetThuc)
                         join p in db.Phongs on hd.IDPhong equals p.ID
                         select (new LineHang
                         {
                             ngaygd = DateTime.Parse(hd.ThoiGianBDau.ToString()).ToString("dd/MM/yyyy HH:mm"),
                             //mahang = Convert.ToString(p.ID),
                             mathang = p.TenPhong,
                             dvt = "Giờ",
                             sl = new LinePhong(((DateTime)hd.ThoiGianKThuc - (DateTime)hd.ThoiGianBDau).TotalHours).ToString(),
                             dg = (int)hd.DonGiaPhong,
                             thanhtien = new LinePhong().ThanhTien((((DateTime)hd.ThoiGianKThuc - (DateTime)hd.ThoiGianBDau).TotalHours), (int)hd.DonGiaPhong)
                         });
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                return result.ToList().Where(x => x.mahang == tuKhoa).ToList();
            }
            return result.ToList();
        }

        private List<LineHang> ThongKeMatHang(DateTime ngayBatDau, DateTime ngayKetThuc, string tuKhoa) 
        {
            var result = from hd in db.HoaDonBanHangs.Where(x => x.ThoiGianKThuc != null && x.ThoiGianBDau >= ngayBatDau && x.ThoiGianBDau <= ngayKetThuc)
                         join ct in db.ChiTietHoaDonBans on hd.IDHoaDon equals ct.IDHoaDon
                         join h in db.MatHangs on ct.IDMatHang equals h.ID
                         join dv in db.DonViTinhs on h.DVT equals dv.ID
                         select (new LineHang
                         {
                             ngaygd = DateTime.Parse(hd.ThoiGianBDau.ToString()).ToString("dd/MM/yyyy HH:mm"),
                             //mahang = Convert.ToString(h.ID),
                             mathang = h.TenMatHang,
                             dvt = dv.TenDVT,
                             sl = Convert.ToString(ct.SoLuong),
                             dg = (int)ct.DonGia,
                             thanhtien = (int)(ct.SoLuong * ct.DonGia)
                         });
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                return result.ToList().Where(x => x.mahang == tuKhoa).ToList();
            }
            return result.ToList();
        }
    }
}
