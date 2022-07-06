
namespace QLThuVien.view
{
    partial class frmTL
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
            this.dgDanhMuc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdKhong = new System.Windows.Forms.Button();
            this.cmdSua = new System.Windows.Forms.Button();
            this.cmdXoa = new System.Windows.Forms.Button();
            this.cmdGhi = new System.Windows.Forms.Button();
            this.cmdThem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenTL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgDanhMuc
            // 
            this.dgDanhMuc.AllowUserToAddRows = false;
            this.dgDanhMuc.AllowUserToDeleteRows = false;
            this.dgDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.dgDanhMuc.Name = "dgDanhMuc";
            this.dgDanhMuc.ReadOnly = true;
            this.dgDanhMuc.RowHeadersWidth = 51;
            this.dgDanhMuc.RowTemplate.Height = 29;
            this.dgDanhMuc.Size = new System.Drawing.Size(905, 220);
            this.dgDanhMuc.TabIndex = 0;
            this.dgDanhMuc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDanhMuc_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaTheLoai";
            this.Column1.HeaderText = "Mã thể loại";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TheLoai";
            this.Column2.HeaderText = "Tên thể loại";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgDanhMuc);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(905, 220);
            this.panel3.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdKhong);
            this.panel1.Controls.Add(this.cmdSua);
            this.panel1.Controls.Add(this.cmdXoa);
            this.panel1.Controls.Add(this.cmdGhi);
            this.panel1.Controls.Add(this.cmdThem);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTenTL);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaTL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 161);
            this.panel1.TabIndex = 12;
            // 
            // cmdKhong
            // 
            this.cmdKhong.Location = new System.Drawing.Point(722, 85);
            this.cmdKhong.Name = "cmdKhong";
            this.cmdKhong.Size = new System.Drawing.Size(150, 40);
            this.cmdKhong.TabIndex = 27;
            this.cmdKhong.Text = "Không";
            this.cmdKhong.UseVisualStyleBackColor = true;
            this.cmdKhong.Click += new System.EventHandler(this.cmdKhong_Click);
            // 
            // cmdSua
            // 
            this.cmdSua.Location = new System.Drawing.Point(212, 85);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(150, 40);
            this.cmdSua.TabIndex = 26;
            this.cmdSua.Text = "Sửa";
            this.cmdSua.UseVisualStyleBackColor = true;
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.Location = new System.Drawing.Point(382, 85);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(150, 40);
            this.cmdXoa.TabIndex = 25;
            this.cmdXoa.Text = "Xóa";
            this.cmdXoa.UseVisualStyleBackColor = true;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdGhi
            // 
            this.cmdGhi.Location = new System.Drawing.Point(552, 85);
            this.cmdGhi.Name = "cmdGhi";
            this.cmdGhi.Size = new System.Drawing.Size(150, 40);
            this.cmdGhi.TabIndex = 24;
            this.cmdGhi.Text = "Ghi";
            this.cmdGhi.UseVisualStyleBackColor = true;
            this.cmdGhi.Click += new System.EventHandler(this.cmdGhi_Click);
            // 
            // cmdThem
            // 
            this.cmdThem.Location = new System.Drawing.Point(42, 85);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(150, 40);
            this.cmdThem.TabIndex = 23;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(438, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Tên thể loại :";
            // 
            // txtTenTL
            // 
            this.txtTenTL.Location = new System.Drawing.Point(590, 30);
            this.txtTenTL.Name = "txtTenTL";
            this.txtTenTL.Size = new System.Drawing.Size(278, 32);
            this.txtTenTL.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã thể loại :";
            // 
            // txtMaTL
            // 
            this.txtMaTL.Location = new System.Drawing.Point(150, 30);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.Size = new System.Drawing.Size(280, 32);
            this.txtMaTL.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(360, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý thể loại";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(340, 70);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(350, 32);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
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
            this.panel2.Size = new System.Drawing.Size(905, 130);
            this.panel2.TabIndex = 13;
            // 
            // frmTL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 511);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmTL";
            this.Text = "frmTL";
            this.Load += new System.EventHandler(this.frmTL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDanhMuc;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdKhong;
        private System.Windows.Forms.Button cmdSua;
        private System.Windows.Forms.Button cmdXoa;
        private System.Windows.Forms.Button cmdGhi;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenTL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}