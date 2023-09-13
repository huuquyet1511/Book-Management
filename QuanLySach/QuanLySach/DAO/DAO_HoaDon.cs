using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DAO
{
    class DAO_HoaDon
    {

        SachDbEntities db;
        public DAO_HoaDon()
        {
            db = new SachDbEntities();
        }       

        public dynamic LayDSHoaDon()
        {
            var ds = from hd in db.HoaDons
                     join nv in db.NhanViens on hd.MaNV equals nv.MaNV
                     join kh in db.KhachHangs on hd.MaKH equals kh.MaKH
                     select (new
                     {
                         hd.MaHD,
                         nv.TenNV,
                         kh.TenKH,                        
                         hd.NgayMua,
                         hd.TongTien                         
                     });            
            return ds.ToList();
        }

        public dynamic LayDSTenNV()
        {
            var ds = db.NhanViens.Select(s => new
            {
                s.MaNV,
                s.TenNV
            }).ToList();
            return ds;
        }

        public dynamic LayDSTenKH()
        {
            var ds = db.KhachHangs.Select(s => new
            {
                s.MaKH,
                s.TenKH
            }).ToList();
            return ds;
        }

        public bool KiemTraSach(HoaDon hd)
        {
            //Kiểm tra xem Hóa Đơn có trong bảng hay ko
            HoaDon s = db.HoaDons.Find(hd.MaHD);
            if (hd != null)
            {
                return true;
            }
            else
                return false;
        }

        public void ThemHD(HoaDon hd)
        {
            //Thêm Hóa Đơn vào bảng
            db.HoaDons.Add(hd);
            db.SaveChanges();
        }

    }
}
