
namespace QLThuVien.view
{
    partial class DangNhap
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
            this.btnQuenMk = new System.Windows.Forms.Button();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ptbShow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuenMk
            // 
            this.btnQuenMk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(101)))), ((int)(((byte)(235)))));
            this.btnQuenMk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuenMk.FlatAppearance.BorderSize = 0;
            this.btnQuenMk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnQuenMk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuenMk.Location = new System.Drawing.Point(250, 330);
            this.btnQuenMk.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuenMk.Name = "btnQuenMk";
            this.btnQuenMk.Size = new System.Drawing.Size(170, 52);
            this.btnQuenMk.TabIndex = 46;
            this.btnQuenMk.Text = "Quên Mật Khẩu";
            this.btnQuenMk.UseVisualStyleBackColor = false;
            this.btnQuenMk.Click += new System.EventHandler(this.btnQuenMk_Click);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTaiKhoan.Location = new System.Drawing.Point(30, 130);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaiKhoan.MaxLength = 25;
            this.txtTaiKhoan.Multiline = true;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(390, 40);
            this.txtTaiKhoan.TabIndex = 39;
            this.txtTaiKhoan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTaiKhoan_KeyDown);
            this.txtTaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaiKhoan_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(111)))), ((int)(((byte)(222)))));
            this.label1.Location = new System.Drawing.Point(130, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 41);
            this.label1.TabIndex = 45;
            this.label1.Text = "Đăng Nhập";
            // 
            // txtPassWord
            // 
            this.txtPassWord.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassWord.Location = new System.Drawing.Point(30, 250);
            this.txtPassWord.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassWord.MaxLength = 25;
            this.txtPassWord.Multiline = true;
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.PasswordChar = '*';
            this.txtPassWord.Size = new System.Drawing.Size(390, 42);
            this.txtPassWord.TabIndex = 40;
            this.txtPassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassWord_KeyDown);
            this.txtPassWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassWord_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 31);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nhập mật khẩu :";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(101)))), ((int)(((byte)(235)))));
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnDangNhap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDangNhap.Location = new System.Drawing.Point(30, 330);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(129, 52);
            this.btnDangNhap.TabIndex = 41;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 31);
            this.label3.TabIndex = 43;
            this.label3.Text = "Nhập tên tài khoản :";
            // 
            // ptbShow
            // 
            this.ptbShow.Location = new System.Drawing.Point(380, 250);
            this.ptbShow.Margin = new System.Windows.Forms.Padding(0);
            this.ptbShow.Name = "ptbShow";
            this.ptbShow.Size = new System.Drawing.Size(40, 40);
            this.ptbShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbShow.TabIndex = 0;
            this.ptbShow.TabStop = false;
            this.ptbShow.Click += new System.EventHandler(this.ptbShow_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 416);
            this.Controls.Add(this.ptbShow);
            this.Controls.Add(this.btnQuenMk);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DangNhap_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DangNhap_FormClosed);
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuenMk;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptbShow;
    }
}