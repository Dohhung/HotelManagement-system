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
    public partial class frmTonKho : Form
    {
        public frmTonKho()
        {
            InitializeComponent();
        }

        private DatabaseDataContext db;

        private void frmTonKho_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();
            btnThongKe.PerformClick();

            dtgvTonKho.Columns["mahang"].Visible = false;
            dtgvTonKho.Columns["dg"].Visible = false;

            dtgvTonKho.Columns["tenhang"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; ;
            dtgvTonKho.Columns["dvt"].Width = 100;
            dtgvTonKho.Columns["tonkho"].Width = 100;

            dtgvTonKho.Columns["tenhang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dtgvTonKho.Columns["dvt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dtgvTonKho.Columns["tonkho"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgvTonKho.Columns["tenhang"].HeaderText = "Tên Mặt Hàng";
            dtgvTonKho.Columns["dvt"].HeaderText = "ĐVT";
            dtgvTonKho.Columns["tonkho"].HeaderText = "Tồn Kho";
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (rbtTatCa.Checked)
            {
                ThongKe(1);
                return;
            }

            if (rbtSapHet.Checked)
            {
                ThongKe(-1);
                return;
            }

            if (rbtDaHet.Checked)
            {
                ThongKe(0);
                return;
            }
        }

        private void ThongKe(int dieuKien)
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
                                   soluong = ct.Sum(x => x.SoLuong)  == 0 ? ct.Sum(x => x.SoLuong): ct.Sum(x => x.SoLuong) + 1
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
                                tonkho = (int)(nc.soluong - (x == null ? 0 : x.slXuat))
                            });
            #endregion

            var tonkho = tonKhoCha.Concat(tonKhoCon).OrderBy(x => x.tenhang);

            if (dieuKien == 0)
            {
                var result = tonkho.Where(x => x.tonkho == 0);
                dtgvTonKho.DataSource = result;
                return;
            }

            if (dieuKien == 1)
            {
                dtgvTonKho.DataSource = tonkho;
                return;
            }

            if (dieuKien == -1)
            {
                var ganhet = int.Parse(db.CauHinhs.SingleOrDefault(x => x.TuKhoa == "GanHet").GiaTri);
                var result = tonkho.Where(x => x.tonkho <= ganhet);
                dtgvTonKho.DataSource = result;
                return;
            }
        }
    }
}
