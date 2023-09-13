using QuanLySach.DAO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach.BUS
{
    class BUS_Sach
    {
        DAO_Sach dSach;

        public BUS_Sach()
        {
            dSach = new DAO_Sach();
        }

        public void LayDSSach(DataGridView gvSach)
        {
            gvSach.DataSource = dSach.LayDSSanPham();
        }

        public bool ThemSach(Sach sach)
        {
            try
            {
                //Trường hợp thêm thành công
                dSach.ThemSach(sach);
                return true;
            }
            catch (Exception)
            {
                //Bắt ngoại lệ thất bại
                return false;
            }                
        }

        public bool CapNhatSach(Sach sach)
        {
            //kiểm tra đơn có tồn tại ko, nếu có mới sửa
            if(dSach.KiemTraSach(sach))
            {
                try
                {
                    //Kiểm tra thành công sách có tồn tại
                    dSach.CapNhatSach(sach);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    //Ngoại lệ ko có sách
                    return true;
                }
            }
            else
            {
                return true;
            }
                
        }

        public bool XoaSach(Sach sach)
        {
            if (dSach.KiemTraSach(sach))
            {
                try
                {
                    dSach.XoaSach(sach);
                    return true;
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show(ex.Message);
                    //Ngoại lệ ko có sách
                    return false;
                }
            }
                                           
            else
                return false;
        }

        public Sach LayTTSach(int maSach)
        {
            return dSach.LayTTSach(maSach);
        }
    }
}
