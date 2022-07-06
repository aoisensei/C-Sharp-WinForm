
namespace QLThuVien.view
{
    partial class QuanLyTaiKhoan
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
            this.chkChonNgayThang = new System.Windows.Forms.CheckBox();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgListTaiKhoan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.optNu = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.optNam = new System.Windows.Forms.RadioButton();
            this.btnThemTK = new System.Windows.Forms.Button();
            this.btnXoaTK = new System.Windows.Forms.Button();
            this.btnSuaTK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnGhi = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnKhong = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListTaiKhoan)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkChonNgayThang
            // 
            this.chkChonNgayThang.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkChonNgayThang.Location = new System.Drawing.Point(990, 100);
            this.chkChonNgayThang.Margin = new System.Windows.Forms.Padding(0);
            this.chkChonNgayThang.Name = "chkChonNgayThang";
            this.chkChonNgayThang.Size = new System.Drawing.Size(120, 30);
            this.chkChonNgayThang.TabIndex = 47;
            this.chkChonNgayThang.Text = "Tích chọn";
            this.chkChonNgayThang.UseVisualStyleBackColor = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "GioiTinh";
            this.Column8.HeaderText = "Giới Tính";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(800, 20);
            this.txtPassWord.MaxLength = 18;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(290, 27);
            this.txtPassWord.TabIndex = 35;
            this.txtPassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassWord_KeyDown);
            this.txtPassWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassWord_KeyPress);
            this.txtPassWord.Leave += new System.EventHandler(this.txtPassWord_Leave);
            // 
            // txtTenDN
            // 
            this.txtTenDN.Location = new System.Drawing.Point(270, 20);
            this.txtTenDN.MaxLength = 18;
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(290, 27);
            this.txtTenDN.TabIndex = 34;
            this.txtTenDN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenDN_KeyDown);
            this.txtTenDN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenDN_KeyPress);
            this.txtTenDN.Leave += new System.EventHandler(this.txtTenDN_Leave);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(270, 60);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(290, 27);
            this.txtHoTen.TabIndex = 36;
            this.txtHoTen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHoTen_KeyDown);
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(630, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nhập mật khẩu :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(800, 60);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(290, 27);
            this.txtEmail.TabIndex = 37;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(60, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nhập họ và tên :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(630, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "Nhập email :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1185, 448);
            this.panel2.TabIndex = 48;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgListTaiKhoan);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1185, 275);
            this.panel4.TabIndex = 46;
            // 
            // dgListTaiKhoan
            // 
            this.dgListTaiKhoan.AllowUserToAddRows = false;
            this.dgListTaiKhoan.AllowUserToDeleteRows = false;
            this.dgListTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgListTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgListTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.dgListTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgListTaiKhoan.Name = "dgListTaiKhoan";
            this.dgListTaiKhoan.ReadOnly = true;
            this.dgListTaiKhoan.RowHeadersWidth = 51;
            this.dgListTaiKhoan.RowTemplate.Height = 29;
            this.dgListTaiKhoan.Size = new System.Drawing.Size(1185, 275);
            this.dgListTaiKhoan.TabIndex = 24;
            this.dgListTaiKhoan.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgListTaiKhoan_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenDN";
            this.Column1.HeaderText = "Tên Đăng Nhập";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PassWord";
            this.Column2.HeaderText = "PassWord";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ChucVuQL";
            this.Column3.HeaderText = "Chức Vụ QL";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "HoTen";
            this.Column4.HeaderText = "Họ Tên";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Email";
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 300;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SDT";
            this.Column6.HeaderText = "SDT";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 200;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NgaySinh";
            this.Column7.HeaderText = "Ngày Sinh";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chkChonNgayThang);
            this.panel3.Controls.Add(this.txtPassWord);
            this.panel3.Controls.Add(this.txtTenDN);
            this.panel3.Controls.Add(this.txtSDT);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dtpNgaySinh);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtHoTen);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.optNu);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.optNam);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 275);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1185, 173);
            this.panel3.TabIndex = 45;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(270, 100);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(290, 27);
            this.txtSDT.TabIndex = 38;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            this.txtSDT.Leave += new System.EventHandler(this.txtSDT_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(60, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nhập tên đăng nhập :";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Enabled = false;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(800, 100);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(160, 27);
            this.dtpNgaySinh.TabIndex = 39;
            this.dtpNgaySinh.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(60, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 22);
            this.label6.TabIndex = 40;
            this.label6.Text = "Nhập  số điện thoại :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(60, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 22);
            this.label8.TabIndex = 44;
            this.label8.Text = "Chọn giới tính :";
            // 
            // optNu
            // 
            this.optNu.AutoSize = true;
            this.optNu.Location = new System.Drawing.Point(410, 140);
            this.optNu.Name = "optNu";
            this.optNu.Size = new System.Drawing.Size(47, 24);
            this.optNu.TabIndex = 43;
            this.optNu.TabStop = true;
            this.optNu.Text = "nữ";
            this.optNu.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(630, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 22);
            this.label7.TabIndex = 41;
            this.label7.Text = "Nhập ngày sinh :";
            // 
            // optNam
            // 
            this.optNam.AutoSize = true;
            this.optNam.Location = new System.Drawing.Point(270, 140);
            this.optNam.Name = "optNam";
            this.optNam.Size = new System.Drawing.Size(59, 24);
            this.optNam.TabIndex = 42;
            this.optNam.TabStop = true;
            this.optNam.Text = "nam";
            this.optNam.UseVisualStyleBackColor = true;
            // 
            // btnThemTK
            // 
            this.btnThemTK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemTK.FlatAppearance.BorderSize = 0;
            this.btnThemTK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnThemTK.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnThemTK.Location = new System.Drawing.Point(10, 10);
            this.btnThemTK.Name = "btnThemTK";
            this.btnThemTK.Size = new System.Drawing.Size(146, 40);
            this.btnThemTK.TabIndex = 18;
            this.btnThemTK.Text = "Thêm tài khoản";
            this.btnThemTK.UseVisualStyleBackColor = false;
            this.btnThemTK.Click += new System.EventHandler(this.btnThemTK_Click);
            // 
            // btnXoaTK
            // 
            this.btnXoaTK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoaTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaTK.FlatAppearance.BorderSize = 0;
            this.btnXoaTK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnXoaTK.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnXoaTK.Location = new System.Drawing.Point(10, 10);
            this.btnXoaTK.Name = "btnXoaTK";
            this.btnXoaTK.Size = new System.Drawing.Size(133, 40);
            this.btnXoaTK.TabIndex = 21;
            this.btnXoaTK.Text = "Xóa tài khoản";
            this.btnXoaTK.UseVisualStyleBackColor = false;
            this.btnXoaTK.Click += new System.EventHandler(this.btnXoaTK_Click);
            // 
            // btnSuaTK
            // 
            this.btnSuaTK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuaTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaTK.FlatAppearance.BorderSize = 0;
            this.btnSuaTK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnSuaTK.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSuaTK.Location = new System.Drawing.Point(10, 10);
            this.btnSuaTK.Name = "btnSuaTK";
            this.btnSuaTK.Size = new System.Drawing.Size(135, 40);
            this.btnSuaTK.TabIndex = 22;
            this.btnSuaTK.Text = "Sửa tài khoản";
            this.btnSuaTK.UseVisualStyleBackColor = false;
            this.btnSuaTK.Click += new System.EventHandler(this.btnSuaTK_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 64);
            this.panel1.TabIndex = 46;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnThemTK);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(530, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(160, 64);
            this.panel9.TabIndex = 50;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnSuaTK);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(690, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(150, 64);
            this.panel8.TabIndex = 49;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnXoaTK);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(840, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(155, 64);
            this.panel7.TabIndex = 48;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnGhi);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(995, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(95, 64);
            this.panel6.TabIndex = 47;
            // 
            // btnGhi
            // 
            this.btnGhi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGhi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGhi.FlatAppearance.BorderSize = 0;
            this.btnGhi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnGhi.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGhi.Location = new System.Drawing.Point(10, 10);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(80, 40);
            this.btnGhi.TabIndex = 23;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.UseVisualStyleBackColor = false;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnKhong);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1090, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(95, 64);
            this.panel5.TabIndex = 46;
            // 
            // btnKhong
            // 
            this.btnKhong.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnKhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhong.FlatAppearance.BorderSize = 0;
            this.btnKhong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnKhong.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnKhong.Location = new System.Drawing.Point(10, 10);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(80, 40);
            this.btnKhong.TabIndex = 45;
            this.btnKhong.Text = "Không";
            this.btnKhong.UseVisualStyleBackColor = false;
            this.btnKhong.Click += new System.EventHandler(this.btnKhong_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(10, 10);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = "Nhập tên tài khoản muốn tìm...";
            this.txtTimKiem.Size = new System.Drawing.Size(340, 33);
            this.txtTimKiem.TabIndex = 20;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiem_KeyPress);
            // 
            // QuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 512);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyTaiKhoan";
            this.Text = "QuanLyTaiKhoan";
            this.Load += new System.EventHandler(this.QuanLyTaiKhoan_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListTaiKhoan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkChonNgayThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgListTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton optNu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton optNam;
        private System.Windows.Forms.Button btnThemTK;
        private System.Windows.Forms.Button btnXoaTK;
        private System.Windows.Forms.Button btnSuaTK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}