using QuanLySach.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach.BUS
{
    class BUS_KhachHang
    {
        DAO_KhachHang dKhachHang;

        public BUS_KhachHang()
        {
            dKhachHang = new DAO_KhachHang();
        }

        public void LayDSKhachHang(DataGridView gvKhachHang)
        {
            gvKhachHang.DataSource = dKhachHang.LayDSKhachHang();
        }

    }
}
