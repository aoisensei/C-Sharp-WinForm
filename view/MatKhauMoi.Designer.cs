
namespace QLThuVien.view
{
    partial class MatKhauMoi
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
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatKhauNL = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.panelMKM = new System.Windows.Forms.Panel();
            this.ptbMKM = new System.Windows.Forms.PictureBox();
            this.panelMKNL = new System.Windows.Forms.Panel();
            this.ptbMKNL = new System.Windows.Forms.PictureBox();
            this.panelMKM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMKM)).BeginInit();
            this.panelMKNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMKNL)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(130, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vui lòng nhập mật khẩu mới";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(310, 90);
            this.txtMatKhauMoi.Multiline = true;
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(315, 30);
            this.txtMatKhauMoi.TabIndex = 1;
            this.txtMatKhauMoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhauMoi_KeyDown);
            this.txtMatKhauMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhauMoi_KeyPress);
            this.txtMatKhauMoi.Leave += new System.EventHandler(this.txtMatKhauMoi_Leave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(100, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập mật khẩu mới :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(100, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nhập lại mật khẩu :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMatKhauNL
            // 
            this.txtMatKhauNL.Location = new System.Drawing.Point(310, 150);
            this.txtMatKhauNL.Multiline = true;
            this.txtMatKhauNL.Name = "txtMatKhauNL";
            this.txtMatKhauNL.PasswordChar = '*';
            this.txtMatKhauNL.Size = new System.Drawing.Size(315, 30);
            this.txtMatKhauNL.TabIndex = 5;
            this.txtMatKhauNL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatKhauNL_KeyDown);
            this.txtMatKhauNL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMatKhauNL_KeyPress);
            this.txtMatKhauNL.Leave += new System.EventHandler(this.txtMatKhauNL_Leave);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(280, 210);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(150, 40);
            this.btnXacNhan.TabIndex = 7;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // panelMKM
            // 
            this.panelMKM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMKM.Controls.Add(this.ptbMKM);
            this.panelMKM.Location = new System.Drawing.Point(600, 90);
            this.panelMKM.Name = "panelMKM";
            this.panelMKM.Size = new System.Drawing.Size(30, 30);
            this.panelMKM.TabIndex = 8;
            // 
            // ptbMKM
            // 
            this.ptbMKM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMKM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbMKM.Location = new System.Drawing.Point(0, 0);
            this.ptbMKM.Name = "ptbMKM";
            this.ptbMKM.Size = new System.Drawing.Size(30, 30);
            this.ptbMKM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMKM.TabIndex = 0;
            this.ptbMKM.TabStop = false;
            this.ptbMKM.Click += new System.EventHandler(this.ptbMKM_Click);
            // 
            // panelMKNL
            // 
            this.panelMKNL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMKNL.Controls.Add(this.ptbMKNL);
            this.panelMKNL.Location = new System.Drawing.Point(600, 150);
            this.panelMKNL.Name = "panelMKNL";
            this.panelMKNL.Size = new System.Drawing.Size(30, 30);
            this.panelMKNL.TabIndex = 9;
            // 
            // ptbMKNL
            // 
            this.ptbMKNL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbMKNL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbMKNL.Location = new System.Drawing.Point(0, 0);
            this.ptbMKNL.Name = "ptbMKNL";
            this.ptbMKNL.Size = new System.Drawing.Size(30, 30);
            this.ptbMKNL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbMKNL.TabIndex = 0;
            this.ptbMKNL.TabStop = false;
            this.ptbMKNL.Click += new System.EventHandler(this.ptbMKNL_Click);
            // 
            // MatKhauMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 266);
            this.Controls.Add(this.panelMKNL);
            this.Controls.Add(this.panelMKM);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatKhauNL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MatKhauMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MatKhauMoi";
            this.Load += new System.EventHandler(this.MatKhauMoi_Load);
            this.panelMKM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMKM)).EndInit();
            this.panelMKNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMKNL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatKhauNL;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Panel panelMKM;
        private System.Windows.Forms.Panel panelMKNL;
        private System.Windows.Forms.PictureBox ptbMKM;
        private System.Windows.Forms.PictureBox ptbMKNL;
    }
}