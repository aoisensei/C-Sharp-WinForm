
namespace QLThuVien.view
{
    partial class frmPhieuMuonTra
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
            this.cmdthem = new System.Windows.Forms.Button();
            this.cmdsua = new System.Windows.Forms.Button();
            this.cmdxoa = new System.Windows.Forms.Button();
            this.cmdkhong = new System.Windows.Forms.Button();
            this.cmdghi = new System.Windows.Forms.Button();
            this.cmdxoa1 = new System.Windows.Forms.Button();
            this.cmdsua1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ds1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaPhieu2 = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.ngaymuon = new System.Windows.Forms.DateTimePicker();
            this.ngayhen = new System.Windows.Forms.DateTimePicker();
            this.ds2 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbTinhTrang = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNgayGiaHan = new System.Windows.Forms.TextBox();
            this.cbbSMaDG = new System.Windows.Forms.ComboBox();
            this.cbbMaSach = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdthem
            // 
            this.cmdthem.Location = new System.Drawing.Point(20, 70);
            this.cmdthem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmdthem.Name = "cmdthem";
            this.cmdthem.Size = new System.Drawing.Size(94, 36);
            this.cmdthem.TabIndex = 0;
            this.cmdthem.Text = "Thêm";
            this.cmdthem.UseVisualStyleBackColor = true;
            this.cmdthem.Click += new System.EventHandler(this.cmdthem_Click);
            // 
            // cmdsua
            // 
            this.cmdsua.Location = new System.Drawing.Point(140, 70);
            this.cmdsua.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmdsua.Name = "cmdsua";
            this.cmdsua.Size = new System.Drawing.Size(94, 36);
            this.cmdsua.TabIndex = 1;
            this.cmdsua.Text = "Sửa";
            this.cmdsua.UseVisualStyleBackColor = true;
            this.cmdsua.Click += new System.EventHandler(this.cmdsua_Click);
            // 
            // cmdxoa
            // 
            this.cmdxoa.Location = new System.Drawing.Point(20, 170);
            this.cmdxoa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmdxoa.Name = "cmdxoa";
            this.cmdxoa.Size = new System.Drawing.Size(94, 36);
            this.cmdxoa.TabIndex = 3;
            this.cmdxoa.Text = "Xóa";
            this.cmdxoa.UseVisualStyleBackColor = true;
            this.cmdxoa.Click += new System.EventHandler(this.cmdxoa_Click);
            // 
            // cmdkhong
            // 
            this.cmdkhong.Location = new System.Drawing.Point(140, 120);
            this.cmdkhong.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmdkhong.Name = "cmdkhong";
            this.cmdkhong.Size = new System.Drawing.Size(94, 36);
            this.cmdkhong.TabIndex = 4;
            this.cmdkhong.Text = "Không";
            this.cmdkhong.UseVisualStyleBackColor = true;
            this.cmdkhong.Click += new System.EventHandler(this.cmdkhong_Click);
            // 
            // cmdghi
            // 
            this.cmdghi.Location = new System.Drawing.Point(20, 120);
            this.cmdghi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmdghi.Name = "cmdghi";
            this.cmdghi.Size = new System.Drawing.Size(94, 36);
            this.cmdghi.TabIndex = 5;
            this.cmdghi.Text = "Ghi";
            this.cmdghi.UseVisualStyleBackColor = true;
            this.cmdghi.Click += new System.EventHandler(this.cmdghi_Click);
            // 
            // cmdxoa1
            // 
            this.cmdxoa1.Location = new System.Drawing.Point(990, 410);
            this.cmdxoa1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmdxoa1.Name = "cmdxoa1";
            this.cmdxoa1.Size = new System.Drawing.Size(140, 36);
            this.cmdxoa1.TabIndex = 9;
            this.cmdxoa1.Text = "Trả sách";
            this.cmdxoa1.UseVisualStyleBackColor = true;
            this.cmdxoa1.Click += new System.EventHandler(this.cmdxoa1_Click);
            // 
            // cmdsua1
            // 
            this.cmdsua1.Location = new System.Drawing.Point(990, 470);
            this.cmdsua1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmdsua1.Name = "cmdsua1";
            this.cmdsua1.Size = new System.Drawing.Size(140, 36);
            this.cmdsua1.TabIndex = 7;
            this.cmdsua1.Text = "Gia hạn";
            this.cmdsua1.UseVisualStyleBackColor = true;
            this.cmdsua1.Click += new System.EventHandler(this.cmdsua1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã phiếu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã độc giả :";
            // 
            // ds1
            // 
            this.ds1.AllowUserToAddRows = false;
            this.ds1.AllowUserToDeleteRows = false;
            this.ds1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ds1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column8,
            this.Column3});
            this.ds1.Location = new System.Drawing.Point(700, 60);
            this.ds1.Name = "ds1";
            this.ds1.ReadOnly = true;
            this.ds1.RowHeadersWidth = 51;
            this.ds1.RowTemplate.Height = 29;
            this.ds1.Size = new System.Drawing.Size(720, 170);
            this.ds1.TabIndex = 15;
            this.ds1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ds1_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaPhieuMT";
            this.Column1.HeaderText = "Mã phiếu";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaDG";
            this.Column2.HeaderText = "Mã độc giả";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MaSach";
            this.Column8.HeaderText = "Mã sách";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "HoTen";
            this.Column3.HeaderText = "Người lập phiếu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 280;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(410, 70);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.ReadOnly = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(270, 32);
            this.txtMaPhieu.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(950, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 34);
            this.label4.TabIndex = 19;
            this.label4.Text = "Lập phiếu mượn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(250, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(329, 34);
            this.label5.TabIndex = 20;
            this.label5.Text = "Chi tiết phiếu mượn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Mã phiếu mượn :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Mã sách :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 25);
            this.label8.TabIndex = 23;
            this.label8.Text = "Ngày mượn :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(510, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 25);
            this.label9.TabIndex = 24;
            this.label9.Text = "Ngày hẹn trả :";
            // 
            // txtMaPhieu2
            // 
            this.txtMaPhieu2.Location = new System.Drawing.Point(210, 270);
            this.txtMaPhieu2.Name = "txtMaPhieu2";
            this.txtMaPhieu2.Size = new System.Drawing.Size(260, 32);
            this.txtMaPhieu2.TabIndex = 25;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(630, 270);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(260, 32);
            this.txtMaSach.TabIndex = 26;
            // 
            // ngaymuon
            // 
            this.ngaymuon.CustomFormat = "dd/MM/yyyy";
            this.ngaymuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaymuon.Location = new System.Drawing.Point(210, 310);
            this.ngaymuon.Name = "ngaymuon";
            this.ngaymuon.Size = new System.Drawing.Size(220, 32);
            this.ngaymuon.TabIndex = 27;
            // 
            // ngayhen
            // 
            this.ngayhen.CustomFormat = "dd/MM/yyyy";
            this.ngayhen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngayhen.Location = new System.Drawing.Point(680, 310);
            this.ngayhen.Name = "ngayhen";
            this.ngayhen.Size = new System.Drawing.Size(210, 32);
            this.ngayhen.TabIndex = 28;
            // 
            // ds2
            // 
            this.ds2.AllowUserToAddRows = false;
            this.ds2.AllowUserToDeleteRows = false;
            this.ds2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ds2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.ds2.Location = new System.Drawing.Point(20, 360);
            this.ds2.Name = "ds2";
            this.ds2.ReadOnly = true;
            this.ds2.RowHeadersWidth = 51;
            this.ds2.RowTemplate.Height = 29;
            this.ds2.Size = new System.Drawing.Size(870, 188);
            this.ds2.TabIndex = 29;
            this.ds2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ds2_CellMouseClick);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaPhieuMT";
            this.Column4.HeaderText = "Mã phiếu";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaSach";
            this.Column5.HeaderText = "Mã sách";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 140;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NgayMuon";
            this.Column6.HeaderText = "Ngày mượn";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 200;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NgayPhaiTra";
            this.Column7.HeaderText = "Ngày hẹn trả";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 200;
            // 
            // cbbTinhTrang
            // 
            this.cbbTinhTrang.FormattingEnabled = true;
            this.cbbTinhTrang.Items.AddRange(new object[] {
            "Tốt",
            "Bình thường",
            "Hỏng"});
            this.cbbTinhTrang.Location = new System.Drawing.Point(1130, 370);
            this.cbbTinhTrang.Name = "cbbTinhTrang";
            this.cbbTinhTrang.Size = new System.Drawing.Size(160, 33);
            this.cbbTinhTrang.TabIndex = 30;
            this.cbbTinhTrang.Text = "Tốt";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(990, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "Tình trạng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Mã sách :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNgayGiaHan);
            this.panel1.Controls.Add(this.cbbSMaDG);
            this.panel1.Controls.Add(this.cbbMaSach);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cbbTinhTrang);
            this.panel1.Controls.Add(this.cmdthem);
            this.panel1.Controls.Add(this.ds2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ngayhen);
            this.panel1.Controls.Add(this.cmdsua);
            this.panel1.Controls.Add(this.ngaymuon);
            this.panel1.Controls.Add(this.cmdxoa);
            this.panel1.Controls.Add(this.txtMaSach);
            this.panel1.Controls.Add(this.cmdkhong);
            this.panel1.Controls.Add(this.txtMaPhieu2);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmdghi);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ds1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMaPhieu);
            this.panel1.Controls.Add(this.cmdxoa1);
            this.panel1.Controls.Add(this.cmdsua1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1443, 607);
            this.panel1.TabIndex = 34;
            // 
            // txtNgayGiaHan
            // 
            this.txtNgayGiaHan.Location = new System.Drawing.Point(1140, 470);
            this.txtNgayGiaHan.Name = "txtNgayGiaHan";
            this.txtNgayGiaHan.Size = new System.Drawing.Size(160, 32);
            this.txtNgayGiaHan.TabIndex = 36;
            this.txtNgayGiaHan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNgayGiaHan_KeyPress);
            // 
            // cbbSMaDG
            // 
            this.cbbSMaDG.FormattingEnabled = true;
            this.cbbSMaDG.Location = new System.Drawing.Point(410, 110);
            this.cbbSMaDG.Name = "cbbSMaDG";
            this.cbbSMaDG.Size = new System.Drawing.Size(151, 33);
            this.cbbSMaDG.TabIndex = 35;
            // 
            // cbbMaSach
            // 
            this.cbbMaSach.FormattingEnabled = true;
            this.cbbMaSach.Location = new System.Drawing.Point(410, 170);
            this.cbbMaSach.Name = "cbbMaSach";
            this.cbbMaSach.Size = new System.Drawing.Size(151, 33);
            this.cbbMaSach.TabIndex = 34;
            // 
            // frmPhieuMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 607);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmPhieuMuonTra";
            this.Text = "frmPhieuMuonTra";
            this.Load += new System.EventHandler(this.frmPhieuMuonTra_Load);
            this.Shown += new System.EventHandler(this.frmPhieuMuonTra_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ds1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdthem;
        private System.Windows.Forms.Button cmdsua;
        private System.Windows.Forms.Button cmdxoa;
        private System.Windows.Forms.Button cmdkhong;
        private System.Windows.Forms.Button cmdghi;
        private System.Windows.Forms.Button cmdxoa1;
        private System.Windows.Forms.Button cmdsua1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ds1;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaPhieu2;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.DateTimePicker ngaymuon;
        private System.Windows.Forms.DateTimePicker ngayhen;
        private System.Windows.Forms.DataGridView ds2;
        private System.Windows.Forms.ComboBox cbbTinhTrang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ComboBox cbbSMaDG;
        private System.Windows.Forms.ComboBox cbbMaSach;
        private System.Windows.Forms.TextBox txtNgayGiaHan;
    }
}