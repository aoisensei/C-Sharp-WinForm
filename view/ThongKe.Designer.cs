
namespace QLThuVien.view
{
    partial class ThongKe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.btnXuatEx = new System.Windows.Forms.Button();
            this.cbbThongKe = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgDanhSach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 190);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblSoLuong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnThongKe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpNgayKT);
            this.groupBox1.Controls.Add(this.dtpNgayBD);
            this.groupBox1.Controls.Add(this.btnXuatEx);
            this.groupBox1.Controls.Add(this.cbbThongKe);
            this.groupBox1.Location = new System.Drawing.Point(40, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1100, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn thống kê";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số lượng : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.ForeColor = System.Drawing.Color.Red;
            this.lblSoLuong.Location = new System.Drawing.Point(130, 70);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(140, 35);
            this.lblSoLuong.TabIndex = 8;
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày mượn từ ";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThongKe.Location = new System.Drawing.Point(820, 30);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(110, 40);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "đến";
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(650, 40);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(130, 29);
            this.dtpNgayKT.TabIndex = 4;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(460, 40);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(130, 29);
            this.dtpNgayBD.TabIndex = 3;
            // 
            // btnXuatEx
            // 
            this.btnXuatEx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatEx.Location = new System.Drawing.Point(950, 30);
            this.btnXuatEx.Name = "btnXuatEx";
            this.btnXuatEx.Size = new System.Drawing.Size(130, 39);
            this.btnXuatEx.TabIndex = 2;
            this.btnXuatEx.Text = "Xuất Excel";
            this.btnXuatEx.UseVisualStyleBackColor = true;
            this.btnXuatEx.Click += new System.EventHandler(this.btnXuatEx_Click);
            // 
            // cbbThongKe
            // 
            this.cbbThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbThongKe.FormattingEnabled = true;
            this.cbbThongKe.Items.AddRange(new object[] {
            "Tất cả các sách",
            "Sách đã trả",
            "Sách chưa trả",
            "Sách trễ hạn"});
            this.cbbThongKe.Location = new System.Drawing.Point(20, 40);
            this.cbbThongKe.Name = "cbbThongKe";
            this.cbbThongKe.Size = new System.Drawing.Size(230, 30);
            this.cbbThongKe.TabIndex = 0;
            this.cbbThongKe.Text = "Tất cả các sách";
            this.cbbThongKe.SelectedValueChanged += new System.EventHandler(this.cbbThongKe_SelectedValueChanged);
            this.cbbThongKe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbThongKe_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(240, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(808, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo thống kê sách mượn trả trong thư viện";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 473);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1221, 55);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgDanhSach);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 190);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1221, 283);
            this.panel3.TabIndex = 2;
            // 
            // dgDanhSach
            // 
            this.dgDanhSach.AllowUserToAddRows = false;
            this.dgDanhSach.AllowUserToDeleteRows = false;
            this.dgDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDanhSach.Location = new System.Drawing.Point(0, 0);
            this.dgDanhSach.Name = "dgDanhSach";
            this.dgDanhSach.ReadOnly = true;
            this.dgDanhSach.RowHeadersWidth = 51;
            this.dgDanhSach.RowTemplate.Height = 29;
            this.dgDanhSach.Size = new System.Drawing.Size(1221, 283);
            this.dgDanhSach.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSach";
            this.Column1.HeaderText = "Mã Sách";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenSach";
            this.Column2.HeaderText = "Tên Sách";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
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
            this.Column4.DataPropertyName = "TenTacGia";
            this.Column4.HeaderText = "Tên tác giả";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaTheLoai";
            this.Column5.HeaderText = "Mã thể loại";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TheLoai";
            this.Column6.HeaderText = "Tên thể loại";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 250;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MaNXB";
            this.Column7.HeaderText = "Mã NXB";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "TenNXB";
            this.Column8.HeaderText = "Tên NXB";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 250;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "NamXuatXu";
            this.Column9.HeaderText = "Năm xuất xứ";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 150;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "MaDG";
            this.Column13.HeaderText = "MaDG";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 150;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "TenDG";
            this.Column14.HeaderText = "Tên độc giả";
            this.Column14.MinimumWidth = 6;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 260;
            // 
            // Column15
            // 
            this.Column15.DataPropertyName = "TenDN";
            this.Column15.HeaderText = "Người lập phiếu";
            this.Column15.MinimumWidth = 6;
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            this.Column15.Width = 260;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "NgayMuon";
            this.Column10.HeaderText = "Ngày mượn";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 150;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "NgayPhaiTra";
            this.Column11.HeaderText = "Ngày phải trả";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 150;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "NgayTra";
            this.Column12.HeaderText = "Ngày trả";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 150;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 528);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ThongKe";
            this.Text = "Thống kê sách";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbThongKe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnXuatEx;
        private System.Windows.Forms.DataGridView dgDanhSach;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
    }
}