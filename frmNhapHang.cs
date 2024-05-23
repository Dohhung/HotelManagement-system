using Management_System.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System
{
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private DatabaseDataContext db;
        private DataGridViewRow r;
        private string nhanvien = "admin";

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();
            

            mtbNgayNhap.Text = DateTime.Now.ToString("dd/MM/yyyy");

            cbbNhanVienNhap.DataSource = db.NhanViens;
            cbbNhanVienNhap.DisplayMember = "hovaten";
            cbbNhanVienNhap.ValueMember = "username";
            cbbNhanVienNhap.SelectedIndex = -1;

            cbbNhaCungCap.DataSource = db.NhaCungCaps;
            cbbNhaCungCap.DisplayMember = "tenncc";
            cbbNhaCungCap.ValueMember = "ID";
            cbbNhaCungCap.SelectedIndex = -1;
            dtgvHoaDonNhap.DataSource = db.HoaDonNhaps.OrderBy(p => p.ID);
            ShowData();
        }

        private void ShowData()
        {
            var rs = from hdnhap in db.HoaDonNhaps
                     join ncc in db.NhaCungCaps on hdnhap.IDNhaCC equals ncc.ID
                     join nv in db.NhanViens on hdnhap.NhanVienNhap equals nv.Username
                     select (new
                     {
                         id = hdnhap.ID,
                         NgayNhap = hdnhap.NgayNhap,
                         tenncc = ncc.TenNCC,
                         danhap = hdnhap.DaNhap,
                         trangthai = hdnhap.DaNhap == 1 ? "Đã Nhập" : "Yêu Cầu",
                         tongtien = db.ChiTietHoaDonNhaps.Where(x => x.IDHoaDon == hdnhap.ID).Sum(y => y.SoLuong * y.DonGiaNhap),
                         dathanhtoan = hdnhap.TienThanhToan
                     });

            dtgvHoaDonNhap.DataSource = rs;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime ngaynhap;

            if (cbbNhanVienNhap.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Nhân Viên nhập hàng", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbbNhaCungCap.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Nhà Cung Cấp", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try 
            {
                ngaynhap = DateTime.ParseExact(mtbNgayNhap.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            } 
            catch 
            {
                MessageBox.Show("Ngày Nhập không hợp lệ", "CHÚ Ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try 
            {
                var od = new HoaDonNhap();

                od.NhanVienNhap = cbbNhanVienNhap.SelectedValue.ToString();
                od.IDNhaCC = int.Parse(cbbNhaCungCap.SelectedValue.ToString());
                od.NgayNhap = ngaynhap;
                od.NgayTao = DateTime.Now;
                od.NguoiTao = nhanvien;

                db.HoaDonNhaps.InsertOnSubmit(od);
                db.SubmitChanges();

                var idHDNhap = db.HoaDonNhaps.Max(x => x.ID);
                //MessageBox.Show("Thêm mới Hóa Đơn Nhập '" + idHDNhap + "' thành công", "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new frmChiTietHoaDonNhap(idHDNhap, 0).ShowDialog();
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Tạo Hóa Đơn thất bại. \n" + ex.Message, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            db.SubmitChanges();
        }

        private void dtgvHoaDonNhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                r = dtgvHoaDonNhap.Rows[e.RowIndex];
                
                new frmChiTietHoaDonNhap(long.Parse(r.Cells["id"].Value.ToString()), Convert.ToByte(r.Cells["danhap"].Value ?? 0)).ShowDialog();

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();
            {
                var id = long.Parse(dtgvHoaDonNhap.SelectedCells[0].OwningRow.Cells["id"].Value.ToString());
                HoaDonNhap delete = db.HoaDonNhaps.Where(p => p.ID.Equals(id)).SingleOrDefault();
                //var delete = db.HoaDonNhaps.FirstOrDefault(x => x.ID == id);
                db.HoaDonNhaps.DeleteOnSubmit(delete);
                ChiTietHoaDonNhap delete1 = db.ChiTietHoaDonNhaps.Where(p => p.IDHoaDon.Equals(id)).SingleOrDefault();
                db.ChiTietHoaDonNhaps.DeleteOnSubmit(delete1);
                db.SubmitChanges();

                MessageBox.Show("Xóa dữ liệu thành công!");
            }
            ShowData();
        }
    }
}
