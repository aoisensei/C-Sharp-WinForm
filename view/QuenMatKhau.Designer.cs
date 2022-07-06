
namespace QLThuVien.view
{
    partial class QuenMatKhau
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaOPT = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnGuiYeuCau = new System.Windows.Forms.Button();
            this.txtEmailOrSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPause = new System.Windows.Forms.Panel();
            this.panelChange = new System.Windows.Forms.Panel();
            this.panelChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(10, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nhập mã OTP :";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nhập Email or SDT :";
            // 
            // txtMaOPT
            // 
            this.txtMaOPT.Location = new System.Drawing.Point(210, 190);
            this.txtMaOPT.Name = "txtMaOPT";
            this.txtMaOPT.Size = new System.Drawing.Size(340, 27);
            this.txtMaOPT.TabIndex = 13;
            this.txtMaOPT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaOPT_KeyPress);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(250, 260);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(134, 40);
            this.btnXacNhan.TabIndex = 12;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnGuiYeuCau
            // 
            this.btnGuiYeuCau.AutoSize = true;
            this.btnGuiYeuCau.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuiYeuCau.Location = new System.Drawing.Point(570, 140);
            this.btnGuiYeuCau.Name = "btnGuiYeuCau";
            this.btnGuiYeuCau.Size = new System.Drawing.Size(120, 30);
            this.btnGuiYeuCau.TabIndex = 11;
            this.btnGuiYeuCau.Text = "gửi yêu cầu";
            this.btnGuiYeuCau.UseVisualStyleBackColor = true;
            this.btnGuiYeuCau.Click += new System.EventHandler(this.btnGuiYeuCau_Click);
            // 
            // txtEmailOrSDT
            // 
            this.txtEmailOrSDT.Location = new System.Drawing.Point(210, 140);
            this.txtEmailOrSDT.Name = "txtEmailOrSDT";
            this.txtEmailOrSDT.Size = new System.Drawing.Size(340, 27);
            this.txtEmailOrSDT.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(690, 50);
            this.label2.TabIndex = 9;
            this.label2.Text = "Bạn quên mật khẩu đăng nhập? Xin vui lòng nhập địa chỉ email hoặc số điện thoại đ" +
    "ăng ký tài khoản. Chúng tôi sẽ gửi mã OTP qua cho bạn !";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(230, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quên Mật Khẩu";
            // 
            // panelPause
            // 
            this.panelPause.BackgroundImage = global::QLThuVien.Properties.Resources.left_arrow_alt_regular_24;
            this.panelPause.Location = new System.Drawing.Point(0, 0);
            this.panelPause.Name = "panelPause";
            this.panelPause.Size = new System.Drawing.Size(30, 30);
            this.panelPause.TabIndex = 16;
            this.panelPause.Click += new System.EventHandler(this.panelPause_Click);
            // 
            // panelChange
            // 
            this.panelChange.Controls.Add(this.label1);
            this.panelChange.Controls.Add(this.label2);
            this.panelChange.Controls.Add(this.label4);
            this.panelChange.Controls.Add(this.txtEmailOrSDT);
            this.panelChange.Controls.Add(this.label3);
            this.panelChange.Controls.Add(this.btnGuiYeuCau);
            this.panelChange.Controls.Add(this.txtMaOPT);
            this.panelChange.Controls.Add(this.btnXacNhan);
            this.panelChange.Location = new System.Drawing.Point(30, 0);
            this.panelChange.Name = "panelChange";
            this.panelChange.Size = new System.Drawing.Size(710, 300);
            this.panelChange.TabIndex = 17;
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 312);
            this.Controls.Add(this.panelChange);
            this.Controls.Add(this.panelPause);
            this.Name = "QuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuenMatKhau";
            this.panelChange.ResumeLayout(false);
            this.panelChange.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaOPT;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnGuiYeuCau;
        private System.Windows.Forms.TextBox txtEmailOrSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelPause;
        private System.Windows.Forms.Panel panelChange;
    }
}