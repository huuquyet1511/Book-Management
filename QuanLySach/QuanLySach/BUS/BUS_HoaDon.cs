using QuanLySach.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using QuanLySach.DAO;

namespace QuanLySach.BUS
{
    class BUS_HoaDon
    {
        DAO_HoaDon dHoaDon;
        
        public BUS_HoaDon()
        {
            dHoaDon = new DAO_HoaDon();
            
        }

        public void LayDSHoaDon(DataGridView gvHoaDon)
        {
            gvHoaDon.DataSource = dHoaDon.LayDSHoaDon();
        }

        public void LayDSTenKH(ComboBox cbTenKH)
        {
            cbTenKH.DataSource = dHoaDon.LayDSTenKH();
            cbTenKH.DisplayMember = "TenKH";
            cbTenKH.ValueMember = "MaKH";
        }

        public void LayDSTenNV(ComboBox cbtenNV)
        {
            cbtenNV.DataSource = dHoaDon.LayDSTenNV();
            cbtenNV.DisplayMember = "TenNV";
            cbtenNV.ValueMember = "MaNV";
        }

        public bool ThemHD(HoaDon hd)
        {
            try
            {
                //Trường hợp thêm thành công
                dHoaDon.ThemHD(hd);
                return true;
            }
            catch (Exception)
            {
                //Bắt ngoại lệ thất bại
                return false;
            }
        }

    }
}
