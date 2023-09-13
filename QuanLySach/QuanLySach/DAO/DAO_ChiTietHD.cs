using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DAO
{
    class DAO_ChiTietHD
    {
        SachDbEntities db;
        public DAO_ChiTietHD()
        {
            db = new SachDbEntities();
        }

        //public dynamic LayDSChiTietHD()
        //{
        //    var ds = from  ct in db.ChiTietHDs                    
        //             join sa in db.Saches on ct.MaSach equals sa.MaSach                                        
        //             select (new
        //             {
                        
        //                 sa.MaSach,                         
        //                 sa.TenSach,
        //                 sa.DonGia,
        //                 ct.Soluong,
        //                 ct.ThanhTien,
        //                 ct.MaHD
        //             });            
        //    return ds.ToList();
        //}

        public dynamic LayDSTenNV()
        {
            var ds = db.NhanViens.Select(s => new
            {
                s.MaNV,
                s.TenNV
            }).ToList();
            return ds;
        }//------------------------

        public dynamic LayDSTenKH()//-----------------------
        {
            var ds = db.KhachHangs.Select(s => new
            {
                s.MaKH,
                s.TenKH
            }).ToList();
            return ds;
        }

        public dynamic LayDSTenSach()
        {
            var ds = db.Saches.Select(s => new
            {
                s.MaSach,
                s.TenSach
            }).ToList();
            return ds;
        }

        public dynamic LayDSChiTietHD(int maHD)
        {
            var ds = db.ChiTietHDs.Where(s => s.MaHD == maHD)
                .Select(s=>new
                {
                                      
                    s.Sach.MaSach,
                    s.Sach.TenSach,
                    s.DonGia,
                    s.Soluong,
                    s.ThanhTien,
                    s.MaHD,
                    s.Sach.TheLoai
                }).ToList();

            return ds;
        }

        //public dynamic LayDonGia()
        //{
        //    var ds = db.Saches.Select(s => new
        //    {
        //        s.MaSach,
        //        s.DonGia
        //    }).ToList();
        //    return ds;
        //}
    }
}
