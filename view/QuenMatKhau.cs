using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace QLThuVien.view
{
    public partial class QuenMatKhau : Form
    {
        int maOTP;
        public Form childForm;

        private void OpenFormChild(Form child)
        {
            if (childForm != null)
            {
                childForm.Close();
            }
            childForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panelChange.Controls.Add(child);
            panelChange.Tag = child;
            child.BringToFront();
            child.Show();
        }
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            if (txtEmailOrSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại hoặc email!");
                txtEmailOrSDT.Focus();
            }
            else
            {
                try
                {
                    if (BoDieuKhien.isEmail(txtEmailOrSDT.Text))
                    {
                        if (BoDieuKhien.checkEmail(txtEmailOrSDT.Text))
                            maOTP = BoDieuKhien.Email(txtEmailOrSDT.Text);
                        else
                        {
                            MessageBox.Show("Email này chưa được đăng ký tài khoản", "Thông báo");
                            txtEmailOrSDT.Focus();
                        }
                    }
                    else
                    {
                        if (BoDieuKhien.checkSDT(txtEmailOrSDT.Text))
                            maOTP = BoDieuKhien.SDT(txtEmailOrSDT.Text);
                        else
                        {
                            MessageBox.Show("Số điện thoại này chưa được đăng ký tài khoản", "Thông báo");
                            txtEmailOrSDT.Focus();
                        }
                    }
                }
                catch (Exception ev)
                {
                    MessageBox.Show(ev.Message);
                }
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(txtMaOPT.Text == maOTP.ToString())
            {
                OpenFormChild(new MatKhauMoi(txtEmailOrSDT.Text));
            }
            else
            {
                MessageBox.Show("Mã OPT không khớp! Vui lòng nhập lại mã.", "Thông báo");
            }
        }

        private void panelPause_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMaOPT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }
    }
}
