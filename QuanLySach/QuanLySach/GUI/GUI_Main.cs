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
    public partial class GUI_Main : Form
    {

        //QuanLySach quanLySach = new QuanLySach();
        GUI_Sach fSach = new GUI_Sach();
        GUI_HoaDon fhoaDon = new GUI_HoaDon();
        GUI_KhachHang fkhachHang = new GUI_KhachHang();

        public GUI_Main()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            fSach.TopLevel = false;
            pnlBody.Controls.Add(fSach);
            fSach.Dock = DockStyle.Fill;
            fSach.Show();
        }

        private void btQuanLySach_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            fSach.TopLevel = false;
            pnlBody.Controls.Add(fSach);
            fSach.Dock = DockStyle.Fill;
            fSach.Show();
        }

        private void btHoaDon_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            fhoaDon.TopLevel = false;
            pnlBody.Controls.Add(fhoaDon);
            fhoaDon.Dock = DockStyle.Fill;
            fhoaDon.Show();
        }

        private void btKhachHang_Click(object sender, EventArgs e)
        {
            pnlBody.Controls.Clear();
            fkhachHang.TopLevel = false;
            pnlBody.Controls.Add(fkhachHang);
            fkhachHang.Dock = DockStyle.Fill;
            fkhachHang.Show();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            Close();

            GUI_DangNhap f = new GUI_DangNhap();
           
            f.Show();
           
        }
    }
}
