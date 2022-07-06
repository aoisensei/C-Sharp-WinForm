using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien.view
{
    public partial class MatKhauMoi : Form
    {
        SqlConnection conn = new SqlConnection();
        string sql = "";
        private string TaiKhoan="";
        bool show1 = false, show2 = false;
        public MatKhauMoi()
        {
            InitializeComponent();
        }

        public MatKhauMoi(string taikhoan)
        {
            InitializeComponent();
            this.TaiKhoan = taikhoan;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (TaiKhoan != "")
            {
                if (BoDieuKhien.checkEmail(TaiKhoan))
                    sql = "update taikhoan set PassWord = '" + txtMatKhauMoi.Text + "' where Email = '" + TaiKhoan + "' ";
                else
                    sql = "update taikhoan set PassWord = '" + txtMatKhauMoi.Text + "' where SDT = '" + TaiKhoan + "' ";
                
                try
                {
                    BoDieuKhien.ThucHienCauLenh(sql, conn);
                    MessageBox.Show("Bạn đã thay đổi mật khẩu thành công!", "Thông báo");
                    this.Close();
                }catch(Exception ev)
                {
                    MessageBox.Show(ev.ToString());
                }
                
            }
        }

        private void txtMatKhauMoi_Leave(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text.Length < 6 && txtMatKhauMoi.Text.Length > 0)
            {
                MessageBox.Show("Vui lòng nhập password >= 6 ký tự", "Erorr", MessageBoxButtons.OK);
                txtMatKhauMoi.Focus();
            }
        }

        private void txtMatKhauMoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatKhauNL.Focus();
            }
        }

        private void txtMatKhauMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        private void txtMatKhauNL_Leave(object sender, EventArgs e)
        {
            if(txtMatKhauMoi.Text != txtMatKhauNL.Text)
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng!", "Thông báo");
                txtMatKhauNL.Text = "";
                txtMatKhauNL.Focus();
            }
        }

        private void MatKhauMoi_Load(object sender, EventArgs e)
        {
            ptbMKM.Image = Image.FromFile("E:\\C#\\img\\nohienthi.jpg");
            ptbMKNL.Image = Image.FromFile("E:\\C#\\img\\nohienthi.jpg");
        }

        private void ptbMKM_Click(object sender, EventArgs e)
        {
            show1 = !show1;
            if (show1)
            {
                ptbMKM.Image = Image.FromFile("E:\\C#\\img\\showmk.png");
                txtMatKhauMoi.PasswordChar = '\0';
            }
            else
            {
                ptbMKM.Image = Image.FromFile("E:\\C#\\img\\nohienthi.jpg");
                txtMatKhauMoi.PasswordChar = '*';
            }
        }

        private void txtMatKhauNL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnXacNhan_Click(sender,e);
            }
        }

        private void txtMatKhauNL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        private void ptbMKNL_Click(object sender, EventArgs e)
        {
            show2 = !show2;
            if (show2)
            {
                ptbMKNL.Image = Image.FromFile("E:\\C#\\img\\showmk.png");
                txtMatKhauNL.PasswordChar = '\0';
            }
            else
            {
                ptbMKNL.Image = Image.FromFile("E:\\C#\\img\\nohienthi.jpg");
                txtMatKhauNL.PasswordChar = '*';
            }
        }
    }
}
