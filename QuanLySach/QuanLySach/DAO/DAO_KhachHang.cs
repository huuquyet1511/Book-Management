using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DAO
{
    class DAO_KhachHang
    {
        SachDbEntities db;
        public DAO_KhachHang()
        {
            db = new SachDbEntities();
        }

        public dynamic LayDSKhachHang()
        {
            var ds = db.KhachHangs.Select(s => new
            {
                s.MaKH,
                s.TenKH,
                s.DiaChi,
                s.SDT
            }).ToList();
            return ds;
        }
    }
}
