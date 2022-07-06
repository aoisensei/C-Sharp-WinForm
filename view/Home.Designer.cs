
namespace QLThuVien.view
{
    partial class Home
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
            this.panelBody = new System.Windows.Forms.Panel();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQLTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLSach = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQLTacGia = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQLNXB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQLTheLoai = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuQLDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhieuMuonTra = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSach = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDocGia = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ptbHome = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.llbHoTro = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHome)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BackgroundImage = global::QLThuVien.Properties.Resources.bg_DangNhap;
            this.panelBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 30);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1161, 500);
            this.panelBody.TabIndex = 14;
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.mnuQLTaiKhoan,
            this.toolStripMenuItem2,
            this.mnuTaiKhoan,
            this.toolStripMenuItem3,
            this.mnuDangXuat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(88, 24);
            this.mnuHeThong.Text = "Hệ Thống";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(209, 6);
            // 
            // mnuQLTaiKhoan
            // 
            this.mnuQLTaiKhoan.Name = "mnuQLTaiKhoan";
            this.mnuQLTaiKhoan.Size = new System.Drawing.Size(212, 26);
            this.mnuQLTaiKhoan.Text = "Quản Lý Tài Khoản";
            this.mnuQLTaiKhoan.Click += new System.EventHandler(this.mnuQLTaiKhoan_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(209, 6);
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Size = new System.Drawing.Size(212, 26);
            this.mnuTaiKhoan.Text = "Tài Khoản";
            this.mnuTaiKhoan.Click += new System.EventHandler(this.mnuTaiKhoan_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(209, 6);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(212, 26);
            this.mnuDangXuat.Text = "Đăng Xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.danhMụcToolStripMenuItem,
            this.mnuPhieuMuonTra,
            this.mnuThongKe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1161, 30);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLSach,
            this.toolStripMenuItem4,
            this.mnuQLTacGia,
            this.toolStripMenuItem5,
            this.mnuQLNXB,
            this.toolStripMenuItem6,
            this.mnuQLTheLoai,
            this.toolStripMenuItem7,
            this.mnuQLDocGia});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // mnuQLSach
            // 
            this.mnuQLSach.Name = "mnuQLSach";
            this.mnuQLSach.Size = new System.Drawing.Size(196, 26);
            this.mnuQLSach.Text = "Quản lý sách";
            this.mnuQLSach.Click += new System.EventHandler(this.mnuQLSach_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(193, 6);
            // 
            // mnuQLTacGia
            // 
            this.mnuQLTacGia.Name = "mnuQLTacGia";
            this.mnuQLTacGia.Size = new System.Drawing.Size(196, 26);
            this.mnuQLTacGia.Text = "Quản lý tác giả";
            this.mnuQLTacGia.Click += new System.EventHandler(this.mnuQLTacGia_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(193, 6);
            // 
            // mnuQLNXB
            // 
            this.mnuQLNXB.Name = "mnuQLNXB";
            this.mnuQLNXB.Size = new System.Drawing.Size(196, 26);
            this.mnuQLNXB.Text = "Quản lý NXB";
            this.mnuQLNXB.Click += new System.EventHandler(this.mnuQLNXB_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(193, 6);
            // 
            // mnuQLTheLoai
            // 
            this.mnuQLTheLoai.Name = "mnuQLTheLoai";
            this.mnuQLTheLoai.Size = new System.Drawing.Size(196, 26);
            this.mnuQLTheLoai.Text = "Quản lý thể loại";
            this.mnuQLTheLoai.Click += new System.EventHandler(this.mnuQLTheLoai_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(193, 6);
            // 
            // mnuQLDocGia
            // 
            this.mnuQLDocGia.Name = "mnuQLDocGia";
            this.mnuQLDocGia.Size = new System.Drawing.Size(196, 26);
            this.mnuQLDocGia.Text = "Quản lý độc giả";
            this.mnuQLDocGia.Click += new System.EventHandler(this.mnuQLDocGia_Click);
            // 
            // mnuPhieuMuonTra
            // 
            this.mnuPhieuMuonTra.Name = "mnuPhieuMuonTra";
            this.mnuPhieuMuonTra.Size = new System.Drawing.Size(126, 24);
            this.mnuPhieuMuonTra.Text = "Phiếu Mượn Trả";
            this.mnuPhieuMuonTra.Click += new System.EventHandler(this.mnuPhieuMuonTra_Click);
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSach,
            this.sáchToolStripMenuItem,
            this.mnuDocGia});
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(86, 24);
            this.mnuThongKe.Text = "Thống Kê";
            // 
            // mnuSach
            // 
            this.mnuSach.Name = "mnuSach";
            this.mnuSach.Size = new System.Drawing.Size(224, 26);
            this.mnuSach.Text = "Sách";
            this.mnuSach.Click += new System.EventHandler(this.mnuSach_Click);
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuDocGia
            // 
            this.mnuDocGia.Name = "mnuDocGia";
            this.mnuDocGia.Size = new System.Drawing.Size(224, 26);
            this.mnuDocGia.Text = "Độc giả";
            this.mnuDocGia.Click += new System.EventHandler(this.mnuDocGia_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(520, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 30);
            this.panel1.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ptbHome);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(110, 30);
            this.panel4.TabIndex = 2;
            // 
            // ptbHome
            // 
            this.ptbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbHome.Image = global::QLThuVien.Properties.Resources.logo;
            this.ptbHome.Location = new System.Drawing.Point(0, 0);
            this.ptbHome.Name = "ptbHome";
            this.ptbHome.Size = new System.Drawing.Size(50, 30);
            this.ptbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbHome.TabIndex = 0;
            this.ptbHome.TabStop = false;
            this.ptbHome.Click += new System.EventHandler(this.ptbHome_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.llbHoTro);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(420, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 30);
            this.panel3.TabIndex = 1;
            // 
            // llbHoTro
            // 
            this.llbHoTro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llbHoTro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbHoTro.Location = new System.Drawing.Point(0, 0);
            this.llbHoTro.Name = "llbHoTro";
            this.llbHoTro.Size = new System.Drawing.Size(80, 30);
            this.llbHoTro.TabIndex = 0;
            this.llbHoTro.TabStop = true;
            this.llbHoTro.Text = "Hỗ Trợ";
            this.llbHoTro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llbHoTro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbHoTro_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTaiKhoan);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(500, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 30);
            this.panel2.TabIndex = 0;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTaiKhoan.ForeColor = System.Drawing.Color.Blue;
            this.lblTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(140, 30);
            this.lblTaiKhoan.TabIndex = 0;
            this.lblTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 530);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbHome)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuQLTaiKhoan;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPhieuMuonTra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel llbHoTro;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox ptbHome;
        private System.Windows.Forms.ToolStripMenuItem mnuQLSach;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mnuQLTacGia;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem mnuQLNXB;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem mnuQLTheLoai;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem mnuQLDocGia;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuSach;
        private System.Windows.Forms.ToolStripSeparator sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDocGia;
    }
}