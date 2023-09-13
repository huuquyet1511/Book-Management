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
//using QuanLySach.GUI.Main;

namespace QuanLySach.GUI
{
    public partial class GUI_HoaDon : Form
    {
        BUS_HoaDon busHoaDon;       
        GUI_ChiTietHD fchiTietHD = new GUI_ChiTietHD();
        public GUI_HoaDon()
        {
            InitializeComponent();
            busHoaDon = new BUS_HoaDon();            
        }

        private void btTaoHD_Click(object sender, EventArgs e)
        {
            
            int ma = int.Parse(gvHoaDon.CurrentRow.Cells[0].Value.ToString());
            GUI_ChiTietHD fchiTietHD = new GUI_ChiTietHD();
            fchiTietHD.maHD = ma;
            fchiTietHD.Show();
        }

        private void HienThiDSHoaDon()
        {
            gvHoaDon.DataSource = null;                           
            busHoaDon.LayDSHoaDon(gvHoaDon);
            gvHoaDon.Columns[0].HeaderText = "Mã Hóa Đơn";
            gvHoaDon.Columns[1].HeaderText = "Tên Nhân Viên";
            gvHoaDon.Columns[2].HeaderText = "Tên Khách Hàng";            
            gvHoaDon.Columns[3].HeaderText = "Ngày Mua";
            gvHoaDon.Columns[4].HeaderText = "Tổng Tiền";            
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            HienThiDSHoaDon();
            busHoaDon.LayDSTenNV(cbTenNV);
            busHoaDon.LayDSTenKH(cbTenKH);
        }

        private void gvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.RowIndex <= gvHoaDon.Rows.Count)
            {
                txtMaHD.Text = gvHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbTenNV.Text = gvHoaDon.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbTenKH.Text = gvHoaDon.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtNgayTao.Text = gvHoaDon.Rows[e.RowIndex].Cells["NgayMua"].Value.ToString();
            }
            btTaoHD.Enabled = true;
        }

        private bool KiemTraTT()
        {
            if (cbTenKH.Text != "" && cbTenNV.Text != "")
                return true;
            else
                return false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (KiemTraTT())
            {
                HoaDon hd = new HoaDon();
                hd.MaKH = Int32.Parse(cbTenKH.SelectedValue.ToString());
                hd.MaNV = Int32.Parse(cbTenNV.SelectedValue.ToString());
                hd.NgayMua = DateTime.Now;
                txtNgayTao.Text = hd.NgayMua.ToString("yyyy-MM-dd HH:mm:ss");
                //hd.TongTien = 
                //Gọi sự kiện thêm BUS
                if (busHoaDon.ThemHD(hd))
                {
                    MessageBox.Show("Thêm hóa đơn thành công");
                    busHoaDon.LayDSHoaDon(gvHoaDon);

                    txtMaHD.Text = "";
                    txtNgayTao.Text = "";
                    cbTenKH.SelectedItem = "";
                    cbTenNV.SelectedItem = "";
                    //-------------------------------
                    cbTenKH.SelectedItem = null;
                    cbTenNV.SelectedItem = null;

                }
                else
                {
                    MessageBox.Show("Thêm sách không thành công");
                }
            }
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
        }

        private void gvHoaDon_DoubleClick(object sender, EventArgs e)
        {
            int ma = int.Parse(gvHoaDon.CurrentRow.Cells[0].Value.ToString());
            GUI_ChiTietHD f = new GUI_ChiTietHD();
            f.maHD = ma;
            f.Show();
        }

        //private void KiemTraClick()
        //{
        //    if(gvHoaDon_CellClick(sender, e))
        //}
    }
}
