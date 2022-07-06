
namespace QLThuVien.view
{
    partial class ThongKeDocGia
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
            this.btnChuaTra = new System.Windows.Forms.Button();
            this.btnTreHan = new System.Windows.Forms.Button();
            this.btnXuatEX = new System.Windows.Forms.Button();
            this.btnDaTra = new System.Windows.Forms.Button();
            this.btnTatCa = new System.Windows.Forms.Button();
            this.cbbTuyChon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgDanhSach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTenDG = new System.Windows.Forms.Label();
            this.lblMaDG = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSach)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 140);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChuaTra);
            this.groupBox1.Controls.Add(this.btnTreHan);
            this.groupBox1.Controls.Add(this.btnXuatEX);
            this.groupBox1.Controls.Add(this.btnDaTra);
            this.groupBox1.Controls.Add(this.btnTatCa);
            this.groupBox1.Controls.Add(this.cbbTuyChon);
            this.groupBox1.Location = new System.Drawing.Point(40, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chọn thống kê";
            // 
            // btnChuaTra
            // 
            this.btnChuaTra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChuaTra.Location = new System.Drawing.Point(480, 40);
            this.btnChuaTra.Name = "btnChuaTra";
            this.btnChuaTra.Size = new System.Drawing.Size(120, 39);
            this.btnChuaTra.TabIndex = 6;
            this.btnChuaTra.Text = "Chưa trả";
            this.btnChuaTra.UseVisualStyleBackColor = true;
            this.btnChuaTra.Click += new System.EventHandler(this.btnChuaTra_Click);
            // 
            // btnTreHan
            // 
            this.btnTreHan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTreHan.Location = new System.Drawing.Point(610, 40);
            this.btnTreHan.Name = "btnTreHan";
            this.btnTreHan.Size = new System.Drawing.Size(100, 39);
            this.btnTreHan.TabIndex = 5;
            this.btnTreHan.Text = "Trễ hạn";
            this.btnTreHan.UseVisualStyleBackColor = true;
            this.btnTreHan.Click += new System.EventHandler(this.btnTreHan_Click);
            // 
            // btnXuatEX
            // 
            this.btnXuatEX.Location = new System.Drawing.Point(830, 20);
            this.btnXuatEX.Name = "btnXuatEX";
            this.btnXuatEX.Size = new System.Drawing.Size(144, 39);
            this.btnXuatEX.TabIndex = 4;
            this.btnXuatEX.Text = "Xuất Excel";
            this.btnXuatEX.UseVisualStyleBackColor = true;
            this.btnXuatEX.Click += new System.EventHandler(this.btnXuatEX_Click);
            // 
            // btnDaTra
            // 
            this.btnDaTra.Location = new System.Drawing.Point(380, 40);
            this.btnDaTra.Name = "btnDaTra";
            this.btnDaTra.Size = new System.Drawing.Size(94, 39);
            this.btnDaTra.TabIndex = 3;
            this.btnDaTra.Text = "Đã Trả";
            this.btnDaTra.UseVisualStyleBackColor = true;
            this.btnDaTra.Click += new System.EventHandler(this.btnDaTra_Click);
            // 
            // btnTatCa
            // 
            this.btnTatCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTatCa.Location = new System.Drawing.Point(280, 40);
            this.btnTatCa.Name = "btnTatCa";
            this.btnTatCa.Size = new System.Drawing.Size(94, 40);
            this.btnTatCa.TabIndex = 2;
            this.btnTatCa.Text = "Tất cả";
            this.btnTatCa.UseVisualStyleBackColor = true;
            this.btnTatCa.Click += new System.EventHandler(this.btnTatCa_Click);
            // 
            // cbbTuyChon
            // 
            this.cbbTuyChon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTuyChon.FormattingEnabled = true;
            this.cbbTuyChon.Location = new System.Drawing.Point(60, 40);
            this.cbbTuyChon.Name = "cbbTuyChon";
            this.cbbTuyChon.Size = new System.Drawing.Size(200, 33);
            this.cbbTuyChon.TabIndex = 1;
            this.cbbTuyChon.SelectedValueChanged += new System.EventHandler(this.cbbTuyChon_SelectedValueChanged);
            this.cbbTuyChon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbTuyChon_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(180, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(699, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo thống kê sách mượn của độc giả";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 468);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1044, 45);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 140);
            this.panel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1044, 328);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgDanhSach);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 38);
            this.panel5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1044, 290);
            this.panel5.TabIndex = 1;
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
            this.Column8,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDanhSach.Location = new System.Drawing.Point(0, 0);
            this.dgDanhSach.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgDanhSach.Name = "dgDanhSach";
            this.dgDanhSach.ReadOnly = true;
            this.dgDanhSach.RowHeadersWidth = 51;
            this.dgDanhSach.RowTemplate.Height = 29;
            this.dgDanhSach.Size = new System.Drawing.Size(1044, 290);
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
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaPhieuMT";
            this.Column3.HeaderText = "Mã phiếu mượn";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "HoTen";
            this.Column8.HeaderText = "Người lập phiếu";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 300;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TinhTrang";
            this.Column4.HeaderText = "Tình trạng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NgayMuon";
            this.Column5.HeaderText = "Ngày Mượn";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NgayPhaiTra";
            this.Column6.HeaderText = "Ngày Phải Trả";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 200;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NgayTra";
            this.Column7.HeaderText = "Ngày trả";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 200;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.lblSoLuong);
            this.panel4.Controls.Add(this.lblTenDG);
            this.panel4.Controls.Add(this.lblMaDG);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1044, 38);
            this.panel4.TabIndex = 0;
            // 
            // lblTenDG
            // 
            this.lblTenDG.Location = new System.Drawing.Point(130, 10);
            this.lblTenDG.Name = "lblTenDG";
            this.lblTenDG.Size = new System.Drawing.Size(250, 25);
            this.lblTenDG.TabIndex = 1;
            // 
            // lblMaDG
            // 
            this.lblMaDG.Location = new System.Drawing.Point(10, 10);
            this.lblMaDG.Name = "lblMaDG";
            this.lblMaDG.Size = new System.Drawing.Size(100, 25);
            this.lblMaDG.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(790, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 35);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số lượng : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.ForeColor = System.Drawing.Color.Red;
            this.lblSoLuong.Location = new System.Drawing.Point(900, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(140, 35);
            this.lblSoLuong.TabIndex = 10;
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ThongKeDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 513);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ThongKeDocGia";
            this.Text = "ThongKeDocGia";
            this.Load += new System.EventHandler(this.ThongKeDocGia_Load);
            this.Shown += new System.EventHandler(this.ThongKeDocGia_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhSach)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbTuyChon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgDanhSach;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnXuatEX;
        private System.Windows.Forms.Button btnDaTra;
        private System.Windows.Forms.Button btnTatCa;
        private System.Windows.Forms.Button btnTreHan;
        private System.Windows.Forms.Button btnChuaTra;
        private System.Windows.Forms.Label lblTenDG;
        private System.Windows.Forms.Label lblMaDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSoLuong;
    }
}