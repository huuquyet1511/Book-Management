using QuanLySach.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySach.GUI
{
    public partial class GUI_KhachHang : Form
    {
        BUS_KhachHang busKhachHang;
        public GUI_KhachHang()
        {
            InitializeComponent();
            busKhachHang = new BUS_KhachHang();
        }

        public void HienThiDSKhachHang()
        {
            gvKhachHang.DataSource = null;
            busKhachHang.LayDSKhachHang(gvKhachHang);
            gvKhachHang.Columns[0].HeaderText = "Mã Khách Hàng";
            gvKhachHang.Columns[1].HeaderText = "Tên Khách Hàng";
            gvKhachHang.Columns[2].HeaderText = "Địa Chỉ";
            gvKhachHang.Columns[3].HeaderText = "Số Điện Thoại";

            gvKhachHang.Columns[0].Width = (int)(gvKhachHang.Width * 0.15);
            gvKhachHang.Columns[1].Width = (int)(gvKhachHang.Width * 0.25);
            gvKhachHang.Columns[2].Width = (int)(gvKhachHang.Width * 0.4);
            gvKhachHang.Columns[3].Width = (int)(gvKhachHang.Width * 0.2);
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            HienThiDSKhachHang();
        }
    }
}
