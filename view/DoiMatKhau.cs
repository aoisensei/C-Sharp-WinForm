using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLThuVien.view
{
    public partial class DoiMatKhau : Form
    {
        SqlConnection conn = new SqlConnection();
        private string tenDn = "";
        string sql = "";
        bool show1=false, show2=false, show3=false;

        public DoiMatKhau()
        {
            InitializeComponent();
        }

        public DoiMatKhau(string tenDn)
        {
            InitializeComponent();
            this.tenDn = tenDn;
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            conn = ketNoi.connectDB();
            ptbMKC.Image = Image.FromFile("E:\\C#\\img\\nohienthi.jpg");
            ptbMKM.Image = Image.FromFile("E:\\C#\\img\\nohienthi.jpg");
            ptbMKNL.Image = Image.FromFile("E:\\C#\\img\\nohienthi.jpg");
        }

        private void DoiMatKhau_FormClosed(object sender, FormClosedEventArgs e)
        {
            TaiKhoan tk = new TaiKhoan(tenDn);
            if (tk.childForm != null)
            {
                tk.childForm = null;
                tk.childForm.Close();
            }
        }

        private void DoiMatKhau_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát form đổi mật khẩu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
        private void txtMatKhauCu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatKhauMoi.Focus();
            }
        }

        private void txtMatKhauCu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        private void txtMatKhauMoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMatKhauMoiNL.Focus();
            }
        }

        private void txtMatKhauMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        private void txtMatKhauMoi_Leave(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text.Length < 6 && txtMatKhauMoi.Text.Length > 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu từ 6 ký tự trở lên!", "Thông báo", MessageBoxButtons.OK);
                txtMatKhauMoi.Focus();
            }
        }

        private void txtMatKhauMoiNL_Leave(object sender, EventArgs e)
        {
            if (txtMatKhauMoiNL.Text != txtMatKhauMoi.Text && txtMatKhauMoiNL.Text.Length > 0)
            {
                MessageBox.Show("Vui lòng nhập mật khẩu lại mật khẩu chính xác!", "Thông báo", MessageBoxButtons.OK);
                txtMatKhauMoiNL.Text = "";
                txtMatKhauMoiNL.Focus();
            }
        }
        private void txtMatKhauMoiNL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDoiMK_Click(sender, e);
            }
        }

        private void txtMatKhauMoiNL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            if (txtMatKhauMoi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!","Thông báo");
                txtMatKhauMoi.Focus();
                return;
            }
            if (txtMatKhauMoiNL.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu mới!", "Thông báo");
                txtMatKhauMoiNL.Focus();
                return;
            }
            sql = "update TaiKhoan set PassWord='" + txtMatKhauMoi.Text + "' where TenDN='" + tenDn + "'";
            DataTable dt = new DataTable();
            dt = ketNoi.GetData("select * from TaiKhoan where TenDN='" + tenDn + "'");

            if (txtMatKhauCu.Text != dt.Rows[0][1].ToString())
            {
                MessageBox.Show("Mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhauCu.Text = "";
                txtMatKhauCu.Focus();
            }
            else
            {
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK);
                txtMatKhauCu.Text = "";
                txtMatKhauMoi.Text = "";
                txtMatKhauMoiNL.Text = "";
            }
        }

        private void ptbMKC_Click(object sender, EventArgs e)
        {
            show1 = !show1;
            if (show1)
            {
                ptbMKC.Image = Image.FromFile("E:\\C#\\img\\showmk.png");
                txtMatKhauCu.PasswordChar = '\0';
            }
            else
            {
                ptbMKC.Image = Image.FromFile("E:\\C#\\img\\nohienthi.jpg");
                txtMatKhauCu.PasswordChar = '*';
            }
        }

        private void ptbMKM_Click(object sender, EventArgs e)
        {
            show2 = !show2;
            if (show2)
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

        private void ptbMKNL_Click(object sender, EventArgs e)
        {
            show3 = !show3;
            if (show3)
            {
                ptbMKNL.Image = Image.FromFile("E:\\C#\\img\\showmk.png");
                txtMatKhauMoiNL.PasswordChar = '\0';
            }
            else
            {
                ptbMKNL.Image = Image.FromFile("E:\\C#\\img\\nohienthi.jpg");
                txtMatKhauMoiNL.PasswordChar = '*';
            }
        }
    }
}
