using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySach.DAO
{
    class DAO_Sach
    {
        SachDbEntities db;

        public DAO_Sach()
        {
            db = new SachDbEntities();
        }

        public dynamic LayDSSanPham()
        {
            var ds = db.Saches.Select(s => new
            {
                s.MaSach,
                s.TenSach,
                s.TacGia,
                s.TheLoai,
                s.NXB,
                s.NamXB,
                s.DonGia
            }).ToList();
            return ds;
        }
       
        public void ThemSach(Sach sach)
        {
            //Thêm sách vào bảng
            db.Saches.Add(sach);
            db.SaveChanges();
        }

        public void CapNhatSach(Sach sach)
        {
            Sach s = db.Saches.Find(sach.MaSach);//khởi tạo s lấy các giá trị cũ
            s.TenSach = sach.TenSach;//sách dựa theo mã và lấy những giá trị mới nhập vào
            s.TacGia = sach.TacGia;//sau đó cập nhật giá trị mới
            s.NXB = sach.NXB;
            s.TheLoai = sach.TheLoai;
            s.NamXB = sach.NamXB;
            s.DonGia = sach.DonGia;
            db.SaveChanges();
        }

        public bool KiemTraSach(Sach sach)
        {
            //Kiểm tra xem sách có trong bảng hay ko
            Sach s = db.Saches.Find(sach.MaSach);
            if (sach != null)
            {
                return true;
            }                
            else
                return false;
        }

        public void XoaSach(Sach sach)
        {
            Sach s = db.Saches.Find(sach.MaSach);
            db.Saches.Remove(s);
            db.SaveChanges();
        }

        public Sach LayTTSach(int maSach)
        {
            Sach sach = db.Saches.Where(s => s.MaSach == maSach).FirstOrDefault();
            return sach;
        }
    }
}
