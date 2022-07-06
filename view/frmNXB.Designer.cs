
namespace QLThuVien.view
{
    partial class frmNXB
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
            this.cmdKhong = new System.Windows.Forms.Button();
            this.cmdSua = new System.Windows.Forms.Button();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.cmdGhi = new System.Windows.Forms.Button();
            this.cmdThem = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgDanhMuc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdKhong
            // 
            this.cmdKhong.Location = new System.Drawing.Point(870, 110);
            this.cmdKhong.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmdKhong.Name = "cmdKhong";
            this.cmdKhong.Size = new System.Drawing.Size(100, 50);
            this.cmdKhong.TabIndex = 18;
            this.cmdKhong.Text = "Không";
            this.cmdKhong.UseVisualStyleBackColor = true;
            this.cmdKhong.Click += new System.EventHandler(this.cmdKhong_Click);
            // 
            // cmdSua
            // 
            this.cmdSua.Location = new System.Drawing.Point(540, 110);
            this.cmdSua.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(98, 50);
            this.cmdSua.TabIndex = 17;
            this.cmdSua.Text = "Sửa";
            this.cmdSua.UseVisualStyleBackColor = true;
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.Location = new System.Drawing.Point(650, 110);
            this.cmdXoa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(102, 50);
            this.cmdXoa.TabIndex = 16;
            this.cmdXoa.Text = "Xóa";
            this.cmdXoa.UseVisualStyleBackColor = true;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdGhi
            // 
            this.cmdGhi.Location = new System.Drawing.Point(760, 110);
            this.cmdGhi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmdGhi.Name = "cmdGhi";
            this.cmdGhi.Size = new System.Drawing.Size(96, 50);
            this.cmdGhi.TabIndex = 15;
            this.cmdGhi.Text = "Ghi";
            this.cmdGhi.UseVisualStyleBackColor = true;
            this.cmdGhi.Click += new System.EventHandler(this.cmdGhi_Click);
            // 
            // cmdThem
            // 
            this.cmdThem.Location = new System.Drawing.Point(435, 110);
            this.cmdThem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(95, 50);
            this.cmdThem.TabIndex = 14;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 120);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "SDT :";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(123, 120);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(287, 32);
            this.txtSDT.TabIndex = 12;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Địa chỉ :";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(120, 70);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(290, 32);
            this.txtDiaChi.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tên NXB :";
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(620, 20);
            this.txtTenNXB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(350, 32);
            this.txtTenNXB.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(620, 70);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(350, 32);
            this.txtEmail.TabIndex = 6;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(400, 80);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(350, 32);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(380, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý nhà xuất bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 130);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdKhong);
            this.panel1.Controls.Add(this.cmdSua);
            this.panel1.Controls.Add(this.cmdXoa);
            this.panel1.Controls.Add(this.cmdGhi);
            this.panel1.Controls.Add(this.cmdThem);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtSDT);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTenNXB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaNXB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 370);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 192);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã NXB :";
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Location = new System.Drawing.Point(120, 20);
            this.txtMaNXB.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(290, 32);
            this.txtMaNXB.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgDanhMuc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1019, 240);
            this.panel3.TabIndex = 11;
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
            this.Column5});
            this.dgDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.dgDanhMuc.Name = "dgDanhMuc";
            this.dgDanhMuc.ReadOnly = true;
            this.dgDanhMuc.RowHeadersWidth = 51;
            this.dgDanhMuc.RowTemplate.Height = 29;
            this.dgDanhMuc.Size = new System.Drawing.Size(1019, 240);
            this.dgDanhMuc.TabIndex = 0;
            this.dgDanhMuc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDanhMuc_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNXB";
            this.Column1.HeaderText = "Mã NXB";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNXB";
            this.Column2.HeaderText = "Tên NXB";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DiaChi";
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Email";
            this.Column4.HeaderText = "Email";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 250;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SDT";
            this.Column5.HeaderText = "SDT";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 250;
            // 
            // frmNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 562);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmNXB";
            this.Text = "frmNXB";
            this.Load += new System.EventHandler(this.frmNXB_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdKhong;
        private System.Windows.Forms.Button cmdSua;
        private System.Windows.Forms.Button cmdXoa;
        private System.Windows.Forms.Button cmdGhi;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}