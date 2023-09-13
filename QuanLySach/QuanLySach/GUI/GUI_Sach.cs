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
    public partial class GUI_Sach : Form
    {
        BUS_Sach busSach;
        public GUI_Sach()
        {
            InitializeComponent();
            busSach = new BUS_Sach();
        }

        private void HienThiDSSach()
        {
            gvSach.DataSource = null;
            busSach.LayDSSach(gvSach);
            gvSach.Columns[0].HeaderText = "Mã Sách";
            gvSach.Columns[1].HeaderText = "Tên Sách";
            gvSach.Columns[2].HeaderText = "Tác Giả";
            gvSach.Columns[3].HeaderText = "Thể Loại";
            gvSach.Columns[4].HeaderText = "NXB";
            gvSach.Columns[5].HeaderText = "Năm XB";
            gvSach.Columns[6].HeaderText = "Giá";

            gvSach.Columns[0].Width = (int)(gvSach.Width * 0.05);
            gvSach.Columns[1].Width = (int)(gvSach.Width * 0.28);
            gvSach.Columns[2].Width = (int)(gvSach.Width * 0.2);
            gvSach.Columns[3].Width = (int)(gvSach.Width * 0.15);
            gvSach.Columns[4].Width = (int)(gvSach.Width * 0.15);
            gvSach.Columns[5].Width = (int)(gvSach.Width * 0.1);
            gvSach.Columns[6].Width = (int)(gvSach.Width * 0.07);

            dateNgayXB.CustomFormat = " ";
        }

        private void Sach_Load(object sender, EventArgs e)
        {
            HienThiDSSach();
        }

        private void btThem_Click(object sender, EventArgs e)
        {            
            Sach sach = new Sach();
            if (txtTenSach.Text != "" && txtTacGia.Text != "" && txtDonGia.Text != ""
                    && cbNXB.SelectedItem != "" && dateNgayXB.Value != null && cbTheLoai.SelectedItem != "")
            {
                //txtMaSach.Enabled = true;//-------------------------
                sach.TenSach = txtTenSach.Text.ToString();
                sach.TacGia = txtTacGia.Text.ToString();
                sach.DonGia = float.Parse(txtDonGia.Text.ToString());
                sach.NXB = cbNXB.SelectedItem.ToString();
                sach.NamXB = dateNgayXB.Value;
                sach.TheLoai = cbTheLoai.SelectedItem.ToString();
                //Gọi sự kiện thêm BUS
                if (busSach.ThemSach(sach))
                {                   
                    MessageBox.Show("Thêm sách thành công");
                    busSach.LayDSSach(gvSach);
                    
                    txtTenSach.Text = "";
                    txtTacGia.Text = "";
                    txtDonGia.Text = "";
                    cbNXB.SelectedItem = "";
                    dateNgayXB.CustomFormat = "";
                    cbTheLoai.SelectedItem = "";
                    //-------------------------------
                    cbNXB.SelectedItem = null;
                    cbTheLoai.SelectedItem = null;

                }
                else
                {
                    MessageBox.Show("Thêm sách không thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }

        }

        private void gvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //đưa thông tin từ bảng dữ liệu đưa lên các textbox
            if (e.RowIndex >= 0 && e.RowIndex <= gvSach.Rows.Count)
            {
                txtMaSach.Text = gvSach.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenSach.Text = gvSach.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTacGia.Text = gvSach.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtDonGia.Text = gvSach.Rows[e.RowIndex].Cells[6].Value.ToString();
                cbNXB.Text = gvSach.Rows[e.RowIndex].Cells[4].Value.ToString();
                dateNgayXB.Text = gvSach.Rows[e.RowIndex].Cells[5].Value.ToString();
                cbTheLoai.Text = gvSach.Rows[e.RowIndex].Cells[3].Value.ToString();                
            }
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            
            if (txtTenSach.Text != "" && txtTacGia.Text != "" && txtDonGia.Text != ""
                   && cbNXB.SelectedItem != "" && dateNgayXB.Value != null && cbTheLoai.SelectedItem != "")
            {
                Sach sach = new Sach();

                sach.MaSach = int.Parse(txtMaSach.Text.ToString());//Lấy mã sách để tiến hành tìm kiếm và thực hiện chỉnh sửa
                sach.TenSach = txtTenSach.Text.ToString();
                sach.TacGia = txtTacGia.Text.ToString();
                sach.DonGia = float.Parse(txtDonGia.Text.ToString());
                sach.NXB = cbNXB.SelectedItem.ToString();
                sach.NamXB = dateNgayXB.Value;
                sach.TheLoai = cbTheLoai.SelectedItem.ToString();

                //Gọi sự kiện thêm BUS
                if (busSach.CapNhatSach(sach))
                {
                    MessageBox.Show("Cập nhật thông tin thành công");
                    busSach.LayDSSach(gvSach);

                    txtMaSach.Text = "";
                    txtTenSach.Text = "";
                    txtTacGia.Text = "";
                    txtDonGia.Text = "";
                    cbNXB.SelectedItem = "";
                    dateNgayXB.CustomFormat = "";
                    cbTheLoai.SelectedItem = "";
                    //-------------------------------
                    cbNXB.SelectedItem = null;
                    cbTheLoai.SelectedItem = null;

                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtTenSach.Text != "" && txtTacGia.Text != "" && txtDonGia.Text != ""
                   && cbNXB.SelectedItem != "" && dateNgayXB.Value != null && cbTheLoai.SelectedItem != "")
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa sách này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    Sach sach = new Sach();
                    sach.MaSach = int.Parse(txtMaSach.Text);
                    if (busSach.XoaSach(sach))
                    {
                        MessageBox.Show("Xóa thông tin thành công");
                        busSach.LayDSSach(gvSach);

                        txtMaSach.Text = "";
                        txtTenSach.Text = "";
                        txtTacGia.Text = "";
                        txtDonGia.Text = "";
                        cbNXB.SelectedItem = "";
                        dateNgayXB.CustomFormat = "";
                        cbTheLoai.SelectedItem = "";
                        //----------------------------------
                        cbNXB.SelectedItem = null;
                        cbTheLoai.SelectedItem = null;
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
                else if (result == DialogResult.Cancel)
                {

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách để xóa");
            }



        }
    }
}
