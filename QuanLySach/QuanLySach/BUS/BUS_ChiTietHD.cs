using QuanLySach.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach.BUS
{
    class BUS_ChiTietHD
    {
        DAO_ChiTietHD dChiTietHD;

        public BUS_ChiTietHD()
        {
            dChiTietHD = new DAO_ChiTietHD();
        }

        public void LayDSChiTietHD(DataGridView gvChiTietHD, int maDH)
        {
            gvChiTietHD.DataSource = dChiTietHD.LayDSChiTietHD(maDH);
            gvChiTietHD.Columns[5].Visible = false;
            gvChiTietHD.Columns[6].Visible = false;
        }

        //public void LayDSTenNV(ComboBox cbtenNV)
        //{
        //    cbtenNV.DataSource = dChiTietHD.LayDSTenNV();
        //    cbtenNV.DisplayMember = "TenNV";
        //    cbtenNV.ValueMember = "MaNV";
        //}

        //public void LayDSTenKH(ComboBox cbTenKH)
        //{
        //    cbTenKH.DataSource = dChiTietHD.LayDSTenKH();
        //    cbTenKH.DisplayMember = "TenKH";
        //    cbTenKH.ValueMember = "MaKH";
        //}

        public void LayDSTenSach(ComboBox cbTenSach)
        {
            cbTenSach.DataSource = dChiTietHD.LayDSTenSach();
            cbTenSach.DisplayMember = "TenSach";
            cbTenSach.ValueMember = "MaSach";
        }

        

        //public void LayDonGia(TextBox txtDonGia)
        //{
        //    txtDonGia.Text = dChiTietHD.LayDonGia();
        //    txtDonGia.Text = "DonGia";
        //    //cbTenSach.ValueMember = "MaSach";
        //}
    }
}
