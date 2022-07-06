
namespace QLThuVien.view
{
    partial class frmTacGia
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaTG = new System.Windows.Forms.TextBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgDanhMuc = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdKhong
            // 
            this.cmdKhong.Location = new System.Drawing.Point(730, 70);
            this.cmdKhong.Name = "cmdKhong";
            this.cmdKhong.Size = new System.Drawing.Size(150, 40);
            this.cmdKhong.TabIndex = 18;
            this.cmdKhong.Text = "Không";
            this.cmdKhong.UseVisualStyleBackColor = true;
            this.cmdKhong.Click += new System.EventHandler(this.cmdKhong_Click);
            // 
            // cmdSua
            // 
            this.cmdSua.Location = new System.Drawing.Point(220, 70);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(150, 40);
            this.cmdSua.TabIndex = 17;
            this.cmdSua.Text = "Sửa";
            this.cmdSua.UseVisualStyleBackColor = true;
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // cmdXoa
            // 
            this.cmdXoa.Location = new System.Drawing.Point(390, 70);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(150, 40);
            this.cmdXoa.TabIndex = 16;
            this.cmdXoa.Text = "Xóa";
            this.cmdXoa.UseVisualStyleBackColor = true;
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdGhi
            // 
            this.cmdGhi.Location = new System.Drawing.Point(560, 70);
            this.cmdGhi.Name = "cmdGhi";
            this.cmdGhi.Size = new System.Drawing.Size(150, 40);
            this.cmdGhi.TabIndex = 15;
            this.cmdGhi.Text = "Ghi";
            this.cmdGhi.UseVisualStyleBackColor = true;
            this.cmdGhi.Click += new System.EventHandler(this.cmdGhi_Click);
            // 
            // cmdThem
            // 
            this.cmdThem.Location = new System.Drawing.Point(50, 70);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(150, 40);
            this.cmdThem.TabIndex = 14;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tên tác giả:";
            // 
            // txtTenTG
            // 
            this.txtTenTG.Location = new System.Drawing.Point(600, 20);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(300, 32);
            this.txtTenTG.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdKhong);
            this.panel1.Controls.Add(this.cmdSua);
            this.panel1.Controls.Add(this.cmdXoa);
            this.panel1.Controls.Add(this.cmdGhi);
            this.panel1.Controls.Add(this.cmdThem);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTenTG);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMaTG);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 125);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã tác giả :";
            // 
            // txtMaTG
            // 
            this.txtMaTG.Location = new System.Drawing.Point(150, 20);
            this.txtMaTG.Name = "txtMaTG";
            this.txtMaTG.Size = new System.Drawing.Size(310, 32);
            this.txtMaTG.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(350, 70);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(350, 32);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(370, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý tác giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgDanhMuc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 322);
            this.panel2.TabIndex = 10;
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
            this.dgDanhMuc.Size = new System.Drawing.Size(920, 322);
            this.dgDanhMuc.TabIndex = 0;
            this.dgDanhMuc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDanhMuc_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaTacGia";
            this.Column1.HeaderText = "Mã Tác Giả";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenTacGia";
            this.Column2.HeaderText = "Tên Tác Giả";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtTimKiem);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(920, 120);
            this.panel3.TabIndex = 9;
            // 
            // frmTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 442);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "frmTacGia";
            this.Text = "frmTacGia";
            this.Load += new System.EventHandler(this.frmTacGia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdKhong;
        private System.Windows.Forms.Button cmdSua;
        private System.Windows.Forms.Button cmdXoa;
        private System.Windows.Forms.Button cmdGhi;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaTG;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel panel3;
    }
}