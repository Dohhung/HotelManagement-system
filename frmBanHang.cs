using Management_System.DB;
using Management_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Management_System
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        private DatabaseDataContext db;
        private ListView lv;
        //private DataGridViewRow r;
        private string nhanvien = "admin";

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();
            var dsLoaiPhong = db.LoaiPhongs;
            foreach (var l in dsLoaiPhong)
            {
                TabPage tp = new TabPage(l.TenLoaiPhong);
                tp.Name = l.ID.ToString();
                tbcContent.Controls.Add(tp);

            }
            idLoaiPhong = db.LoaiPhongs.Min(x => x.ID);
            LoadPhong(idLoaiPhong, tabIndex);

            ShowMatHang();
            ShowLichSuDatPhong();
            dtgvDanhSachMatHang.Columns["mahang"].Visible = false;
            dtgvDanhSachMatHang.ScrollBars = ScrollBars.Both;
            dtgvMatHangSuDung.ScrollBars = ScrollBars.Both;
            dtgvLichSuDatPhong.Columns["idHoaDon"].Visible = false;
        }

        private void LoadPhong(int loaiphong, int tabIndex) 
        {
            tbcContent.TabPages[tabIndex].Controls.Clear();
            lv = new ListView();
            lv.Dock = DockStyle.Fill;
            lv.SelectedIndexChanged += lv_SelectedIndexChanged;

            ImageList img = new ImageList();
            img.ImageSize = new Size(120, 120);
            img.Images.Add(Properties.Resources.icon_open);
            img.Images.Add(Properties.Resources.icon_close);
            lv.LargeImageList = img;
            
            var dsPhong = db.Phongs.Where(x => x.IDLoaiPhong == loaiphong);
            foreach (var p in dsPhong)
            {
                if (p.TrangThai == 1)
                {
                    lv.Items.Add(new ListViewItem { ImageIndex = 1, Text = p.TenPhong, Name = p.ID.ToString(), Tag = true });
                }
                else
                {
                    lv.Items.Add(new ListViewItem { ImageIndex = 0, Text = p.TenPhong, Name = p.ID.ToString(), Tag = false });
                }
            }
            tbcContent.TabPages[tabIndex].Controls.Add(lv);
        }

        int idLoaiPhong = 0;
        private string tenphong;
        private long idHoaDon = 0;
        private int idPhong = 0;
        private int tabIndex = 0;

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idx = lv.SelectedIndices;
            if (idx.Count > 0) 
            {
                idPhong = int.Parse(lv.SelectedItems[0].Name);
                tenphong = lv.SelectedItems[0].Text.ToUpper();
                lblPhongDangChon.Text = tenphong;
                if ((bool)lv.SelectedItems[0].Tag)
                {
                    btnBatDau.Visible = false;
                    btnKetThuc.Visible = true;

                    var hd = db.HoaDonBanHangs.FirstOrDefault(x => x.IDHoaDon == db.HoaDonBanHangs.Where(y => y.IDPhong == idPhong).Max(z => z.IDHoaDon));
                    idHoaDon = hd.IDHoaDon;

                    mtbNgayBatDau.Text = ((DateTime)hd.ThoiGianBDau).ToString("dd/MM/yyyy HH:mm");
                    mtbNgayKetThuc.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");

                    ShowChiTietHoaDon();
                }
                else
                {
                    dtgvMatHangSuDung.DataSource = null;
                    mtbNgayBatDau.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    btnBatDau.Visible = true;
                    btnKetThuc.Visible = false;
                }
            }
        }

        private void ShowMatHang() 
        {
            #region Ton_Kho_Cha
            var details = from ct in db.ChiTietHoaDonNhaps
                          join hd in db.HoaDonNhaps.Where(x => x.DaNhap == 1)
                          on ct.IDHoaDon equals hd.ID
                          select (new 
                          { 
                              mahang = ct.IDMatHang,
                              sl = ct.SoLuong
                          });

            var nhapCha = from ct in details.GroupBy(x => x.mahang)
                          join h in db.MatHangs.Where(x => x.IDCha == null || x.IDCha <= 0) on ct.First().mahang equals h.ID
                          join d in db.DonViTinhs on h.DVT equals d.ID
                          select (new
                          {
                              mahang = ct.First().mahang,
                              tenhang = h.TenMatHang,
                              dvt = d.TenDVT,
                              dg = h.DonGiaBan,
                              soluong = ct.Sum(x => x.sl)
                          });

            var xuatCha = from p in db.ChiTietHoaDonBans.GroupBy(x => x.IDMatHang)
                          join h in db.MatHangs.Where(x => x.IDCha == null || x.IDCha <= 0)
                          on p.First().IDMatHang equals h.ID
                          select (new
                          {
                              mahang = h.ID,
                              soluong = p.Sum(x => x.SoLuong)
                          });

            var xuatQuyRaCha = from ct in db.ChiTietHoaDonBans.GroupBy(x => x.IDMatHang)
                               join h in db.MatHangs.Where(x => x.IDCha > 0)
                               on ct.First().IDMatHang equals h.ID
                               select (new
                               {
                                   mahang = (int)h.IDCha,
                                   soluong = ct.Sum(x => x.SoLuong) == 0 ? ct.Sum(x => x.SoLuong) : ct.Sum(x => x.SoLuong)+ 1
                               });

            var tongXuatCha = from xc in xuatCha.Union(xuatQuyRaCha).GroupBy(x => x.mahang)
                              select (new
                              {
                                  mahang = xc.First().mahang,
                                  soluong = xc.Sum(x => x.soluong)
                              });

            var tonKhoCha = from p in nhapCha
                            join q in tongXuatCha on p.mahang equals q.mahang into tmp
                            from t in tmp.DefaultIfEmpty()
                            select (new
                            {
                                mahang = p.mahang,
                                tenhang = p.tenhang,
                                dvt = p.dvt,
                                dg = p.dg,
                                tonkho = (int)(p.soluong - (t == null ? 0 : t.soluong))
                            });
            #endregion

            #region Ton_Kho_Con
            var nhapCon = from ct in nhapCha
                          join h in db.MatHangs on ct.mahang equals h.IDCha
                          join d in db.DonViTinhs on h.DVT equals d.ID
                          select (new
                          {
                              mahang = h.ID,
                              tenhang = h.TenMatHang,
                              dvt = d.TenDVT,
                              dg = h.DonGiaBan,
                              soluong = ct.soluong
                          });

            var xuatConQuyTuCha = from xc in xuatCha
                                  join h in db.MatHangs.Where(x => x.IDCha > 0)
                                  on xc.mahang equals h.IDCha
                                  select (new
                                  {
                                      mahang = h.ID,
                                      soluong = xc.soluong
                                  });

            var xuatCon = from ct in db.ChiTietHoaDonBans.GroupBy(x => x.IDMatHang)
                          join h in db.MatHangs.Where(x => x.IDCha > 0)
                          on ct.First().IDMatHang equals h.IDCha
                          select (new
                          {
                              mahang = h.ID,
                              soluong = ct.Sum(x => x.SoLuong)
                          });

            var tongXuatCon = from ct in xuatConQuyTuCha.Union(xuatCon).GroupBy(x => x.mahang)
                              select (new
                              {
                                  mahang = ct.First().mahang,
                                  slXuat = ct.Sum(x => x.soluong)
                              });

            var tonKhoCon = from nc in nhapCon
                            join xc in tongXuatCon on nc.mahang equals xc.mahang into tmp
                            from x in tmp.DefaultIfEmpty()
                            select (new
                            {
                                mahang = nc.mahang,
                                tenhang = nc.tenhang,
                                dvt = nc.dvt,
                                dg = nc.dg,
                                tonkho = (int)(nc.soluong - (x == null ? 0 :x.slXuat))
                            });
            #endregion

            var tonkho = tonKhoCha.Concat(tonKhoCon).OrderBy(x => x.tenhang);
            dtgvDanhSachMatHang.DataSource = tonkho;

        }

        private void dtgvDanhSachMatHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (idPhong == 0)
            {
                MessageBox.Show("Vui lòng chọn Phòng", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (e.RowIndex < 0)
            {
                return;
            }

            var phong = db.Phongs.SingleOrDefault(x => x.ID == idPhong);
            if (phong.TrangThai == 1)
            {
                var r = dtgvDanhSachMatHang.Rows[e.RowIndex];
                new frmOrder(idHoaDon, tenphong, r).ShowDialog();
                ShowMatHang();
                ShowChiTietHoaDon();
            }
        }

        private void ShowChiTietHoaDon() 
        {
            var rs = from cthdb in db.ChiTietHoaDonBans.Where(x => x.IDHoaDon == idHoaDon)
                     join mh in db.MatHangs on cthdb.IDMatHang equals mh.ID
                     join dvt in db.DonViTinhs on mh.DVT equals dvt.ID
                     select (new
                     {
                         mahang = mh.ID,
                         tenhang = mh.TenMatHang,
                         dvt = dvt.TenDVT,
                         sl = cthdb.SoLuong,
                         dg = cthdb.DonGia,
                         thanhtien = cthdb.SoLuong * cthdb.DonGia
                     });
            dtgvMatHangSuDung.DataSource = rs;

            dtgvMatHangSuDung.Columns["mahang"].Visible = false;

            dtgvMatHangSuDung.Columns["tenhang"].Width = 197;
            dtgvMatHangSuDung.Columns["dvt"].Width = 100;
            dtgvMatHangSuDung.Columns["sl"].Width = 150;
            dtgvMatHangSuDung.Columns["dg"].Width = 150;
            dtgvMatHangSuDung.Columns["thanhtien"].Width = 150;

            dtgvMatHangSuDung.Columns["tenhang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvMatHangSuDung.Columns["dvt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvMatHangSuDung.Columns["sl"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvMatHangSuDung.Columns["dg"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvMatHangSuDung.Columns["thanhtien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgvMatHangSuDung.Columns["tenhang"].HeaderText = "Tên Mặt Hàng";
            dtgvMatHangSuDung.Columns["dvt"].HeaderText = "ĐVT";
            dtgvMatHangSuDung.Columns["sl"].HeaderText = "Số Lượng";
            dtgvMatHangSuDung.Columns["dg"].HeaderText = "Đơn Giá";
            dtgvMatHangSuDung.Columns["thanhtien"].HeaderText = "Thành Tiền";

            dtgvMatHangSuDung.Columns["dg"].DefaultCellStyle.Format = "N0";
            dtgvMatHangSuDung.Columns["thanhtien"].DefaultCellStyle.Format = "N0";
        }

        private void tbcContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            idLoaiPhong = int.Parse(tbcContent.SelectedTab.Name);
            tabIndex = tbcContent.SelectedIndex;
            LoadPhong(idLoaiPhong, tabIndex);
        }

        private void btnBatDau_Click(object sender, EventArgs e)
        {
            try
            {
                var phong = db.Phongs.SingleOrDefault(x => x.ID == idPhong);
                var lp = db.LoaiPhongs.SingleOrDefault(x => x.ID == phong.IDLoaiPhong);

                var od = new HoaDonBanHang();
                od.IDPhong = idPhong;
                od.NguoiBan = nhanvien;
                od.ThoiGianBDau = DateTime.ParseExact(mtbNgayBatDau.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                od.NgayTao = DateTime.Now;
                od.NguoiTao = nhanvien;
                od.DonGiaPhong = lp.DonGia;

                db.HoaDonBanHangs.InsertOnSubmit(od);
                db.SubmitChanges();

                phong.TrangThai = 1;
                db.SubmitChanges();

                LoadPhong(idLoaiPhong, tabIndex);
                btnBatDau.Visible = false;
                btnKetThuc.Visible = true;
                MessageBox.Show("Chọn Phòng thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Chọn Phòng thất bại", "THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            try
            {
                var hd = db.HoaDonBanHangs.SingleOrDefault(x => x.IDHoaDon == idHoaDon);
                hd.ThoiGianKThuc = DateTime.ParseExact(mtbNgayKetThuc.Text, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                db.SubmitChanges();

                var p = db.Phongs.SingleOrDefault(x => x.ID == idPhong);
                p.TrangThai = 0;
                db.SubmitChanges();

                LoadPhong(idLoaiPhong, tabIndex);
                mtbNgayBatDau.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                btnBatDau.Visible = true;
                btnKetThuc.Visible = false;
                MessageBox.Show("Thanh toán Phòng thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowLichSuDatPhong();
                idHoaDon = hd.IDHoaDon;
                InHoaDon();
            }
            catch
            {
                MessageBox.Show("Thanh toán Phòng thất bại", "THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ShowLichSuDatPhong() 
        {
            var result = from hdban in db.HoaDonBanHangs.Where(x => x.ThoiGianKThuc != null)
                         join phong in db.Phongs on hdban.IDPhong equals phong.ID
                         join cthd in db.ChiTietHoaDonBans.GroupBy(t => t.IDHoaDon) on hdban.IDHoaDon equals cthd.First().IDHoaDon
                         select (new
                         {
                             idHoaDon = hdban.IDHoaDon,
                             phong = phong.TenPhong,
                             tgBatdau = DateTime.Parse(hdban.ThoiGianBDau.ToString()).ToString("dd/MM/yyyy HH:mm"),
                             tgKetthuc = DateTime.Parse(hdban.ThoiGianKThuc.ToString()).ToString("dd/MM/yyyy HH:mm"),
                             soTien = ((TimeSpan)((DateTime)hdban.ThoiGianKThuc - (DateTime)hdban.ThoiGianBDau)).TotalHours * hdban.DonGiaPhong + cthd.Sum(x => x.SoLuong * x.DonGia)
                         });

            dtgvLichSuDatPhong.DataSource = result;
        }

        private void dtgvLichSuDatPhong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idHoaDon = long.Parse(dtgvLichSuDatPhong.Rows[e.RowIndex].Cells["idHoaDon"].Value.ToString());
                InHoaDon();
            }
        }

        private void InHoaDon()
        {
            pddHoaDon.Document = pdHoaDon;
            pddHoaDon.ShowDialog();
        }

        private void pdHoaDon_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var tencuahang = db.CauHinhs.SingleOrDefault(x => x.TuKhoa == "TenKhachSan").GiaTri;
            var diachi = db.CauHinhs.SingleOrDefault(x => x.TuKhoa == "DiaChi").GiaTri;
            var dienthoai = db.CauHinhs.SingleOrDefault(x => x.TuKhoa == "DienThoai").GiaTri;

            var hd = db.HoaDonBanHangs.SingleOrDefault(x => x.IDHoaDon == idHoaDon);

            var w = pdHoaDon.DefaultPageSettings.PaperSize.Width;

            e.Graphics.DrawString(
                tencuahang.ToUpper(),
                new Font("Consolas", 14, FontStyle.Bold),
                Brushes.Black, new Point(100,20)
                );

            e.Graphics.DrawString(
                String.Format("HD{0}", hd.IDHoaDon),
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
                String.Format("Ngày Bắt Đầu: {0}", ((DateTime)hd.ThoiGianBDau).ToString("dd/MM/yyyy HH:mm")),
                new Font("Consolas", 12, FontStyle.Regular),
                Brushes.Black, new Point(10, y)
                );

            e.Graphics.DrawString(
                String.Format("Ngày Kết Thúc: {0}", ((DateTime)hd.ThoiGianBDau).ToString("dd/MM/yyyy HH:mm")),
                new Font("Consolas", 12, FontStyle.Regular),
                Brushes.Black, new Point(w / 2, y)
                );

            y = y + 40;
            int sum = 0;
            var tgiansudung = ((DateTime)hd.ThoiGianKThuc - (DateTime)hd.ThoiGianBDau).TotalMinutes;
            var gio = (int)(tgiansudung / 60);
            var phut = tgiansudung % 60;
            var tienphong = (int)Math.Round((double)(tgiansudung / 60 * hd.DonGiaPhong) / 1000, 3) * 1000;
            sum += tienphong;

            e.Graphics.DrawString(
                String.Format("Thời Gian Sử Dụng: {0}:{1}", gio, phut),
                new Font("Consolas", 12, FontStyle.Regular),
                Brushes.Black, new Point(10, y)
                );

            e.Graphics.DrawString(
                String.Format("Thành Tiền: {0:N0} VNĐ", tienphong),
                new Font("Consolas", 12, FontStyle.Regular),
                Brushes.Black, new Point(w / 2, y)
                );

            y = y + 40;
            p1 = new Point(10, y);
            p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(blackPen, p1, p2);

            y = y + 20;
            e.Graphics.DrawString(
                String.Format("STT"),
                new Font("Consolas", 14, FontStyle.Bold),
                Brushes.Black, new Point(10, y)
                );

            e.Graphics.DrawString(
                String.Format("Mặt Hàng"),
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

            var result = from ct in db.ChiTietHoaDonBans.Where(x => x.IDHoaDon == idHoaDon)
                         join mh in db.MatHangs on ct.IDMatHang equals mh.ID
                         join dvt in db.DonViTinhs on mh.DVT equals dvt.ID
                         select (new
                         {
                             tenmathang = mh.TenMatHang,
                             dvt = dvt.TenDVT,
                             sl = (int)ct.SoLuong,
                             dg = (int)ct.DonGia,
                             thanhtien = ct.SoLuong * ct.DonGia
                         });

            int i = 1;
            y = y + 80;
            foreach (var item in result)
            {
                sum += item.sl * item.dg;
                e.Graphics.DrawString(
                    string.Format("{0}", i++),
                    new Font("Consolas", 12, FontStyle.Regular),
                    Brushes.Black, new Point(10, y)
                    );

                e.Graphics.DrawString(
                    item.tenmathang,
                    new Font("Consolas", 12, FontStyle.Regular),
                    Brushes.Black, new Point(50, y)
                    );

                e.Graphics.DrawString(
                    string.Format("{0:N0}", item.sl),
                    new Font("Consolas", 12, FontStyle.Bold),
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
                y += 30;
            }

            y = y + 60;
            p1 = new Point(10, y);
            p2 = new Point(w - 10, y);
            e.Graphics.DrawLine(blackPen, p1, p2);

            y = y + 20;
            e.Graphics.DrawString(
                    string.Format("Tổng Tiền: {0:N0} VNĐ", sum),
                    new Font("Consolas", 14, FontStyle.Regular),
                    Brushes.Black, new Point(w - 300, y)
                    );
            /*
            // Thêm Class Đổi Số Thành Chữ
            y = y + 30;
            e.Graphics.DrawString(
                    string.Format("Thành Chữ: {0}", new SoThanhChu()),
                    new Font("Consolas", 14, FontStyle.Bold),
                    Brushes.Black, new Point(w - 300, y)
                    );
            */
            y = y + 40;
            e.Graphics.DrawString(
                    "Xin chân thành cảm ơn sự ủng hộ của quý khách!",
                    new Font("Consolas", 14, FontStyle.Bold),
                    Brushes.Black, new Point(w - 500, y)
                    );
        }
    }
}
