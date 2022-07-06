
namespace QLThuVien.view
{
    partial class TaiKhoan
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLuuTT = new System.Windows.Forms.Button();
            this.optNam = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.optNu = new System.Windows.Forms.RadioButton();
            this.chkChonNgayThang = new System.Windows.Forms.CheckBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSuaTT = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(143)))), ((int)(((byte)(235)))));
            this.panel3.Controls.Add(this.txtHoTen);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnLuuTT);
            this.panel3.Controls.Add(this.optNam);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.optNu);
            this.panel3.Controls.Add(this.chkChonNgayThang);
            this.panel3.Controls.Add(this.dtpNgaySinh);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnSuaTT);
            this.panel3.Controls.Add(this.txtSDT);
            this.panel3.Location = new System.Drawing.Point(220, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(630, 350);
            this.panel3.TabIndex = 39;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(230, 10);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(350, 27);
            this.txtHoTen.TabIndex = 25;
            this.txtHoTen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHoTen_KeyDown);
            this.txtHoTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHoTen_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nhập họ và tên :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(29, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 22);
            this.label7.TabIndex = 30;
            this.label7.Text = "Nhập ngày sinh :";
            // 
            // btnLuuTT
            // 
            this.btnLuuTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(232)))));
            this.btnLuuTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuuTT.FlatAppearance.BorderSize = 0;
            this.btnLuuTT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnLuuTT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLuuTT.Location = new System.Drawing.Point(340, 270);
            this.btnLuuTT.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLuuTT.Name = "btnLuuTT";
            this.btnLuuTT.Size = new System.Drawing.Size(186, 50);
            this.btnLuuTT.TabIndex = 38;
            this.btnLuuTT.Text = "Lưu Thông Tin";
            this.btnLuuTT.UseVisualStyleBackColor = false;
            this.btnLuuTT.Click += new System.EventHandler(this.btnLuuTT_Click);
            // 
            // optNam
            // 
            this.optNam.AutoSize = true;
            this.optNam.Location = new System.Drawing.Point(232, 210);
            this.optNam.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.optNam.Name = "optNam";
            this.optNam.Size = new System.Drawing.Size(59, 24);
            this.optNam.TabIndex = 31;
            this.optNam.TabStop = true;
            this.optNam.Text = "nam";
            this.optNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(29, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nhập email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(29, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 22);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nhập  số điện thoại :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(230, 60);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(350, 27);
            this.txtEmail.TabIndex = 24;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // optNu
            // 
            this.optNu.AutoSize = true;
            this.optNu.Location = new System.Drawing.Point(460, 210);
            this.optNu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.optNu.Name = "optNu";
            this.optNu.Size = new System.Drawing.Size(47, 24);
            this.optNu.TabIndex = 32;
            this.optNu.TabStop = true;
            this.optNu.Text = "nữ";
            this.optNu.UseVisualStyleBackColor = true;
            // 
            // chkChonNgayThang
            // 
            this.chkChonNgayThang.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkChonNgayThang.Location = new System.Drawing.Point(440, 160);
            this.chkChonNgayThang.Margin = new System.Windows.Forms.Padding(0);
            this.chkChonNgayThang.Name = "chkChonNgayThang";
            this.chkChonNgayThang.Size = new System.Drawing.Size(195, 38);
            this.chkChonNgayThang.TabIndex = 35;
            this.chkChonNgayThang.Text = "Tích chọn";
            this.chkChonNgayThang.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(230, 160);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(170, 27);
            this.dtpNgaySinh.TabIndex = 28;
            this.dtpNgaySinh.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(31, 215);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 22);
            this.label8.TabIndex = 33;
            this.label8.Text = "Chọn giới tính :";
            // 
            // btnSuaTT
            // 
            this.btnSuaTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(232)))));
            this.btnSuaTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaTT.FlatAppearance.BorderSize = 0;
            this.btnSuaTT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnSuaTT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSuaTT.Location = new System.Drawing.Point(70, 270);
            this.btnSuaTT.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSuaTT.Name = "btnSuaTT";
            this.btnSuaTT.Size = new System.Drawing.Size(180, 50);
            this.btnSuaTT.TabIndex = 34;
            this.btnSuaTT.Text = "Sửa Thông Tin";
            this.btnSuaTT.UseVisualStyleBackColor = false;
            this.btnSuaTT.Click += new System.EventHandler(this.btnSuaTT_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(230, 110);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(350, 27);
            this.txtSDT.TabIndex = 27;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTaiKhoan.ForeColor = System.Drawing.Color.Blue;
            this.lblTaiKhoan.Location = new System.Drawing.Point(0, 0);
            this.lblTaiKhoan.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(270, 50);
            this.lblTaiKhoan.TabIndex = 39;
            this.lblTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-115, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1063, 482);
            this.panel2.TabIndex = 43;
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDoiMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMK.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDoiMK.FlatAppearance.BorderSize = 0;
            this.btnDoiMK.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnDoiMK.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDoiMK.Location = new System.Drawing.Point(704, 0);
            this.btnDoiMK.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(128, 50);
            this.btnDoiMK.TabIndex = 37;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = false;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.lblTaiKhoan);
            this.panel1.Controls.Add(this.btnDoiMK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 50);
            this.panel1.TabIndex = 42;
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "TaiKhoan";
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLuuTT;
        private System.Windows.Forms.RadioButton optNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RadioButton optNu;
        private System.Windows.Forms.CheckBox chkChonNgayThang;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSuaTT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Panel panel1;
    }
}