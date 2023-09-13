namespace QuanLySach.GUI
{
    partial class GUI_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btKhachHang = new System.Windows.Forms.Button();
            this.btHoaDon = new System.Windows.Forms.Button();
            this.btQuanLySach = new System.Windows.Forms.Button();
            this.btDangXuat = new System.Windows.Forms.Button();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.btKhachHang);
            this.groupBox1.Controls.Add(this.btHoaDon);
            this.groupBox1.Controls.Add(this.btQuanLySach);
            this.groupBox1.Controls.Add(this.btDangXuat);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 549);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btKhachHang
            // 
            this.btKhachHang.BackColor = System.Drawing.Color.LightBlue;
            this.btKhachHang.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKhachHang.Location = new System.Drawing.Point(29, 227);
            this.btKhachHang.Name = "btKhachHang";
            this.btKhachHang.Size = new System.Drawing.Size(135, 36);
            this.btKhachHang.TabIndex = 2;
            this.btKhachHang.Text = "Khách Hàng";
            this.btKhachHang.UseVisualStyleBackColor = false;
            this.btKhachHang.Click += new System.EventHandler(this.btKhachHang_Click);
            // 
            // btHoaDon
            // 
            this.btHoaDon.BackColor = System.Drawing.Color.LightBlue;
            this.btHoaDon.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHoaDon.Location = new System.Drawing.Point(29, 164);
            this.btHoaDon.Name = "btHoaDon";
            this.btHoaDon.Size = new System.Drawing.Size(135, 34);
            this.btHoaDon.TabIndex = 2;
            this.btHoaDon.Text = "Hóa Đơn";
            this.btHoaDon.UseVisualStyleBackColor = false;
            this.btHoaDon.Click += new System.EventHandler(this.btHoaDon_Click);
            // 
            // btQuanLySach
            // 
            this.btQuanLySach.BackColor = System.Drawing.Color.LightBlue;
            this.btQuanLySach.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuanLySach.Location = new System.Drawing.Point(29, 102);
            this.btQuanLySach.Name = "btQuanLySach";
            this.btQuanLySach.Size = new System.Drawing.Size(136, 36);
            this.btQuanLySach.TabIndex = 1;
            this.btQuanLySach.Text = "Quản Lý Sách";
            this.btQuanLySach.UseVisualStyleBackColor = false;
            this.btQuanLySach.Click += new System.EventHandler(this.btQuanLySach_Click);
            // 
            // btDangXuat
            // 
            this.btDangXuat.BackColor = System.Drawing.Color.LightCoral;
            this.btDangXuat.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangXuat.Location = new System.Drawing.Point(29, 497);
            this.btDangXuat.Name = "btDangXuat";
            this.btDangXuat.Size = new System.Drawing.Size(135, 37);
            this.btDangXuat.TabIndex = 0;
            this.btDangXuat.Text = "Đăng Xuất";
            this.btDangXuat.UseVisualStyleBackColor = false;
            this.btDangXuat.Click += new System.EventHandler(this.btDangXuat_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Location = new System.Drawing.Point(224, 12);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(908, 549);
            this.pnlBody.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 571);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Button btDangXuat;
        private System.Windows.Forms.Button btQuanLySach;
        private System.Windows.Forms.Button btKhachHang;
        private System.Windows.Forms.Button btHoaDon;
    }
}