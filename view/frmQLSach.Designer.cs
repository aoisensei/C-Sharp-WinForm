
namespace QLThuVien.view
{
    partial class frmQLSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdKhong = new System.Windows.Forms.Button();
            this.cmdSua = new System.Windows.Forms.Button();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.cmdGhi = new System.Windows.Forms.Button();
            this.cmdThem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNamXB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaTG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgDanhMuc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(420, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý sách";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(340, 70);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(420, 34);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdKhong);
            this.panel1.Controls.Add(this.cmdSua);
            this.panel1.Controls.Add(this.cmdXoa);
            this.panel1.Controls.Add(this.cmdGhi);
            this.panel1.Controls.Add(this.cmdThem);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtNamXB);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtTenSach);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtMaTL);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMaNXB);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMaTG);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSL);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaSach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 185);
            this.panel1.TabIndex = 4;
            // 
            // cmdKhong
            // 
            this.cmdKhong.Location = new System.Drawing.Point(890, 130);
            this.cmdKhong.Name = "cmdKhong";
            this.cmdKhong.Size = new System.Drawing.Size(80, 40);
            this.cmdKhong.TabIndex = 18;
            this.cmdKhong.Text = "Không";
            this.cmdKhong.UseVisualStyleBackColor = true;
            this.cmdKhong.Click += new System.EventHandler(this.cmdKhong_Click);
            // 
            // cmdSua
            // 
            this.cmdSua.Location = new System.Drawing.Point(620, 130);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(80, 40);
            this.cmdSua.TabIndex = 17;
            this.cmdSua.Text = "Sửa";
            this.cmdSua.UseVisualStyleBackColor = true;
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.Location = new System.Drawing.Point(710, 130);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(80, 40);
            this.cmdXoa.TabIndex = 16;
            this.cmdXoa.Text = "Xóa";
            this.cmdXoa.UseVisualStyleBackColor = true;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdGhi
            // 
            this.cmdGhi.Location = new System.Drawing.Point(800, 130);
            this.cmdGhi.Name = "cmdGhi";
            this.cmdGhi.Size = new System.Drawing.Size(80, 40);
            this.cmdGhi.TabIndex = 15;
            this.cmdGhi.Text = "Ghi";
            this.cmdGhi.UseVisualStyleBackColor = true;
            this.cmdGhi.Click += new System.EventHandler(this.cmdGhi_Click);
            // 
            // cmdThem
            // 
            this.cmdThem.Location = new System.Drawing.Point(530, 130);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(80, 40);
            this.cmdThem.TabIndex = 14;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 28);
            this.label9.TabIndex = 13;
            this.label9.Text = "Năm XB :";
            // 
            // txtNamXB
            // 
            this.txtNamXB.Location = new System.Drawing.Point(180, 130);
            this.txtNamXB.Name = "txtNamXB";
            this.txtNamXB.Size = new System.Drawing.Size(310, 34);
            this.txtNamXB.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 28);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tên Sách :";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(180, 50);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(310, 34);
            this.txtTenSach.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(550, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 28);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mã thể loại :";
            // 
            // txtMaTL
            // 
            this.txtMaTL.Location = new System.Drawing.Point(670, 10);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(300, 34);
            this.txtMaTL.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mã NXB :";
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Location = new System.Drawing.Point(670, 50);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(300, 34);
            this.txtMaNXB.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã tác giả :";
            // 
            // txtMaTG
            // 
            this.txtMaTG.Location = new System.Drawing.Point(180, 90);
            this.txtMaTG.Name = "txtMaTG";
            this.txtMaTG.Size = new System.Drawing.Size(310, 34);
            this.txtMaTG.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(551, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng :";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(670, 90);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(300, 34);
            this.txtSL.TabIndex = 2;
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Sách :";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(180, 10);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(310, 34);
            this.txtMaSach.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTimKiem);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1011, 120);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgDanhMuc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1011, 200);
            this.panel2.TabIndex = 7;
            // 
            // dgDanhMuc
            // 
            this.dgDanhMuc.AllowUserToAddRows = false;
            this.dgDanhMuc.AllowUserToDeleteRows = false;
            this.dgDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.dgDanhMuc.Name = "dgDanhMuc";
            this.dgDanhMuc.ReadOnly = true;
            this.dgDanhMuc.RowHeadersWidth = 51;
            this.dgDanhMuc.RowTemplate.Height = 29;
            this.dgDanhMuc.Size = new System.Drawing.Size(1011, 200);
            this.dgDanhMuc.TabIndex = 0;
            this.dgDanhMuc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDanhMuc_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSach";
            this.Column1.HeaderText = "Mã sách";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSach";
            this.Column2.HeaderText = "Tên sách";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaTacGia";
            this.Column3.HeaderText = "Mã tác giả";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaTheLoai";
            this.Column4.HeaderText = "Mã thể loại";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaNXB";
            this.Column5.HeaderText = "Mã NXB";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NamXuatXu";
            this.Column6.HeaderText = "Năm xuất xứ";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "SoLuong";
            this.Column7.HeaderText = "Số lượng";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // frmQLSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 505);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLSach";
            this.Text = "frmQLSach";
            this.Load += new System.EventHandler(this.frmQLSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdKhong;
        private System.Windows.Forms.Button cmdSua;
        private System.Windows.Forms.Button cmdXoa;
        private System.Windows.Forms.Button cmdGhi;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNamXB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaTL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaTG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}