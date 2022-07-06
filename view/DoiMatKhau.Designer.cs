
namespace QLThuVien.view
{
    partial class DoiMatKhau
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
            this.btnDoiMK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMatKhauMoiNL = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ptbMKC = new System.Windows.Forms.PictureBox();
            this.ptbMKM = new System.Windows.Forms.PictureBox();
            this.ptbMKNL = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMKC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMKM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMKNL)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDoiMK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMK.FlatAppearance.BorderSize = 0;
            this.btnDoiMK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnDoiMK.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDoiMK.Location = new System.Drawing.Point(120, 250);
            this.btnDoiMK.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(170, 52);
            this.btnDoiMK.TabIndex = 46;
            this.btnDoiMK.Text = "Đổi mật khẩu";
            this.btnDoiMK.UseVisualStyleBackColor = false;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 23);
            this.label4.TabIndex = 45;
            this.label4.Text = "Nhập lại mật khẩu  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "Mật khẩu mới :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "Mật khẩu cũ :";
            // 
            // txtMatKhauMoiNL
            // 
            this.txtMatKhauMoiNL.Location = new System.Drawing.Point(190, 180);
            this.txtMatKhauMoiNL.Multiline = true;
            this.txtMatKhauMoiNL.Name = "txtMatKhauMoiNL";
            this.txtMatKhauMoiNL.PasswordChar = '*';
            this.txtMatKhauMoiNL.Size = new System.Drawing.Size(250, 32);
            this.txtMatKhauMoiNL.TabIndex = 39;
            this.txtMatKhauMoiNL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhauMoiNL_KeyDown);
            this.txtMatKhauMoiNL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhauMoiNL_KeyPress);
            this.txtMatKhauMoiNL.Leave += new System.EventHandler(this.txtMatKhauMoiNL_Leave);
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(190, 130);
            this.txtMatKhauMoi.Multiline = true;
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(250, 32);
            this.txtMatKhauMoi.TabIndex = 38;
            this.txtMatKhauMoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhauMoi_KeyDown);
            this.txtMatKhauMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhauMoi_KeyPress);
            this.txtMatKhauMoi.Leave += new System.EventHandler(this.txtMatKhauMoi_Leave);
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Location = new System.Drawing.Point(190, 80);
            this.txtMatKhauCu.Multiline = true;
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.PasswordChar = '*';
            this.txtMatKhauCu.Size = new System.Drawing.Size(250, 32);
            this.txtMatKhauCu.TabIndex = 37;
            this.txtMatKhauCu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhauCu_KeyDown);
            this.txtMatKhauCu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhauCu_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(110, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 36);
            this.label1.TabIndex = 36;
            this.label1.Text = "Đổi Mật Khẩu";
            // 
            // ptbMKC
            // 
            this.ptbMKC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptbMKC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMKC.Location = new System.Drawing.Point(410, 80);
            this.ptbMKC.Name = "ptbMKC";
            this.ptbMKC.Size = new System.Drawing.Size(30, 30);
            this.ptbMKC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMKC.TabIndex = 47;
            this.ptbMKC.TabStop = false;
            this.ptbMKC.Click += new System.EventHandler(this.ptbMKC_Click);
            // 
            // ptbMKM
            // 
            this.ptbMKM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptbMKM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMKM.Location = new System.Drawing.Point(410, 130);
            this.ptbMKM.Name = "ptbMKM";
            this.ptbMKM.Size = new System.Drawing.Size(30, 30);
            this.ptbMKM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMKM.TabIndex = 48;
            this.ptbMKM.TabStop = false;
            this.ptbMKM.Click += new System.EventHandler(this.ptbMKM_Click);
            // 
            // ptbMKNL
            // 
            this.ptbMKNL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbMKNL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMKNL.Location = new System.Drawing.Point(410, 180);
            this.ptbMKNL.Name = "ptbMKNL";
            this.ptbMKNL.Size = new System.Drawing.Size(30, 30);
            this.ptbMKNL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMKNL.TabIndex = 49;
            this.ptbMKNL.TabStop = false;
            this.ptbMKNL.Click += new System.EventHandler(this.ptbMKNL_Click);
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 322);
            this.Controls.Add(this.ptbMKNL);
            this.Controls.Add(this.ptbMKM);
            this.Controls.Add(this.ptbMKC);
            this.Controls.Add(this.btnDoiMK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatKhauMoiNL);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoiMatKhau";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoiMatKhau_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DoiMatKhau_FormClosed);
            this.Load += new System.EventHandler(this.DoiMatKhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMKC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMKM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMKNL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoiMK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatKhauMoiNL;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbMKC;
        private System.Windows.Forms.PictureBox ptbMKM;
        private System.Windows.Forms.PictureBox ptbMKNL;
    }
}