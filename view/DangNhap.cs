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
    public partial class DangNhap : Form
    {
        SqlConnection conn;
        DataTable dt;
        string sql = "";
        bool show = false;

        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            conn = ketNoi.connectDB();
            txtPassWord.PasswordChar = '*';
            ptbShow.Image = Image.FromFile("E:\\C#\\img\\nohienthi.jpg");
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassWord.Focus();
            }
        }

        private void txtTaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

        private void txtPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" && txtPassWord.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
                return;
            }

            if (txtTaiKhoan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
                return;
            }

            if (txtPassWord.Text == "")
            {
                txtPassWord.Focus();
                MessageBox.Show("Vui lòng nhập tên mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                sql = "select * from TaiKhoan where TenDN = N'" + txtTaiKhoan.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS and PassWord = N'" + 
                        txtPassWord.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS";
                dt = ketNoi.GetData(sql);   
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi xay ra la: " + ex);
            }
            finally
            {
                conn.Close();
            }

            if (dt.Rows.Count > 0)
            {
                Home home = new Home();
                home.tenDN = txtTaiKhoan.Text;
                this.Hide();
                home.Show();
                home.logout += Home_logout;
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Home_logout(object sender, EventArgs e)
        {
            (sender as Home).isExit = false;
            (sender as Home).Close();
            this.Show();
            txtPassWord.Text = "";
        }

        private void DangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true; 
            }
        }

        private void btnQuenMk_Click(object sender, EventArgs e)
        {
            QuenMatKhau qmk = new QuenMatKhau();
            qmk.ShowDialog();
        }

        private void ptbShow_Click(object sender, EventArgs e)
        {
            show = !show;
            if (show)
            {
                txtPassWord.PasswordChar = '\0';
                ptbShow.Image = Image.FromFile("E:\\C#\\img\\showmk.png");
            }
            else
            {
                txtPassWord.PasswordChar = '*';
                ptbShow.Image = Image.FromFile("E:\\C#\\img\\nohienthi.jpg");
            }
        }
    }
}
