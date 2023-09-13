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
    public partial class GUI_ChiTietHD : Form
    {
        public int maHD;
        BUS_ChiTietHD busChiTietHD;
        BUS_HoaDon busHD;
        BUS_Sach busSach;
        bool co;
        public GUI_ChiTietHD()
        {
            InitializeComponent();
            busChiTietHD = new BUS_ChiTietHD();
            busHD = new BUS_HoaDon();
            busSach = new BUS_Sach();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            
        }

        private void HienThiDSChiTietHD()
        {
            gvChiTietHD.DataSource = null;
            busChiTietHD.LayDSChiTietHD(gvChiTietHD, maHD);
            
            gvChiTietHD.Columns[0].HeaderText = "Mã Sách";
            gvChiTietHD.Columns[1].HeaderText = "Tên Sách";
            gvChiTietHD.Columns[2].HeaderText = "Đơn Giá";
            gvChiTietHD.Columns[3].HeaderText = "Số Lượng";
            gvChiTietHD.Columns[4].HeaderText = "Thành Tiền";

            gvChiTietHD.Columns[0].Width = (int)(gvChiTietHD.Width * 0.15);
            gvChiTietHD.Columns[1].Width = (int)(gvChiTietHD.Width * 0.4);
            gvChiTietHD.Columns[2].Width = (int)(gvChiTietHD.Width * 0.15);
            gvChiTietHD.Columns[3].Width = (int)(gvChiTietHD.Width * 0.15);
            gvChiTietHD.Columns[4].Width = (int)(gvChiTietHD.Width * 0.15);
        }

        private void LayDSChiTietHD(int ma)
        {
            HienThiDSChiTietHD();
        }

        private void ChiTietHD_Load(object sender, EventArgs e)
        {
            
            LayDSChiTietHD(maHD);
            //cbTenSach.SelectedValue = 0;
            //cbTenSach.Text = "";
            co = true;
            busChiTietHD.LayDSTenSach(cbTenSach);
            txtMaDH.Text = maHD.ToString();
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvChiTietHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= gvChiTietHD.Rows.Count)
            {
                txtMaSach.Text = gvChiTietHD.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbTenSach.Text = gvChiTietHD.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDonGia.Text = gvChiTietHD.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSoLuong.Text = gvChiTietHD.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtThanhTien.Text = gvChiTietHD.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtMaDH.Text = gvChiTietHD.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtTheLoai.Text = gvChiTietHD.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
        }



        private void cbTenSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            //sau khi chọn sách sẽ hiển thị thông tin sách
            //dựa vào mã sách để lấy thông tin sách
            Sach s;
            int maSach;           
                if (int.TryParse(cbTenSach.SelectedValue.ToString(), out maSach))
                {
                    maSach = int.Parse(cbTenSach.SelectedValue.ToString());
                    s = busSach.LayTTSach(maSach);
                    txtMaSach.Text = s.MaSach.ToString();
                    txtTheLoai.Text = s.TheLoai;
                    txtDonGia.Text = s.DonGia.ToString();
                    txtSoLuong.Text = "1";
                    
                    txtThanhTien.Text = (int.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text)).ToString();
                    
                }
                else
                {
                    //MessageBox.Show("Mã sách không hợp lệ!");
                }               
            
        }
    }
}
