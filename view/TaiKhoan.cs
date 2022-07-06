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
using System.Text.RegularExpressions;

namespace QLThuVien.view
{
    public partial class TaiKhoan : Form
    {
        SqlConnection conn = new SqlConnection();
        string sql = "";
        private string tenDN;

        public TaiKhoan()
        {
            InitializeComponent();
        }

        public TaiKhoan(string tenDN)
        {
            InitializeComponent();
            this.tenDN = tenDN;
        }

        public Form childForm;
        private void OpenForm(Form child)
        {
            if (childForm != null)
            {
                childForm.Close();
            }
            childForm = child;
            childForm.Show();
        }

        private void xoatrang()
        {
            lblTaiKhoan.Text = "";
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            dtpNgaySinh.Value = new DateTime(2022, 1, 1);
            chkChonNgayThang.Checked = false;
            optNam.Checked = false;
            optNu.Checked = false;
        }

        private void layNguon()

        {
            xoatrang();
            sql = "select * from TaiKhoan where TenDN = '" + tenDN + "'";
            if (conn.State != ConnectionState.Open) conn.Open();
            DataTable dt = ketNoi.GetData(sql);
            lblTaiKhoan.Text = tenDN;
            string[] ngaysinh1 = dt.Rows[0][6].ToString().Split(" ");
            string[] ngaysinh = ngaysinh1[0].Split("/");

            txtHoTen.Text = dt.Rows[0][3].ToString();
            txtEmail.Text = dt.Rows[0][4].ToString();
            txtSDT.Text = dt.Rows[0][5].ToString();

            if (dt.Rows[0][6].ToString() != "")
            {
                chkChonNgayThang.Checked = true;
                dtpNgaySinh.Value = new DateTime(int.Parse(ngaysinh[2]), int.Parse(ngaysinh[1]), int.Parse(ngaysinh[0]));
            }

            if (dt.Rows[0][7].ToString() == "False")
            {
                optNam.Checked = false;
                optNu.Checked = true;
            }
            else if (dt.Rows[0][7].ToString() == "True")
            {
                optNu.Checked = false;
                optNam.Checked = true;
            }
            else
            {
                optNu.Checked = false;
                optNam.Checked = false;
            }
        }

        private void KhoaMo(bool check)
        {
            txtHoTen.Enabled = check;
            txtSDT.Enabled = check;
            txtEmail.Enabled = check;
            dtpNgaySinh.Enabled = check;
            chkChonNgayThang.Enabled = check;
            optNam.Enabled = check;
            optNu.Enabled = check;

            btnSuaTT.Enabled = !check;
            btnLuuTT.Enabled = check;
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            conn = ketNoi.connectDB();
            KhoaMo(false);
            layNguon();
        }

        private void btnSuaTT_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có thực sự muốn sửa thông tin các nhân hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dl == DialogResult.Yes)
                KhoaMo(true);
            else
                return;
        }

        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            string checkGT;
            if (optNam.Checked == false && optNu.Checked == false)
            {
                checkGT = "NULL";
            }
            else
            {
                checkGT = optNam.Checked ? "'True'" : "'False'";
            }

            DateTime data = dtpNgaySinh.Value;
            string ngaysinh = chkChonNgayThang.Checked ?
                                "N'" + data.Year.ToString() + "-" + data.Month.ToString() + "-" + data.Day.ToString() + "'" : "NULL";
            string sdt = txtSDT.Text.Length > 0 ? "N'" + txtSDT.Text + "'" : "NULL";

            sql = "update TaiKhoan set HoTen = N'" + txtHoTen.Text + "',Email = N'" + txtEmail.Text + "',SDT = " + sdt
                    + ", NgaySinh = " + ngaysinh + ",GioiTinh = " + checkGT + " where TenDN = '" + tenDN + "' ";
            BoDieuKhien.ThucHienCauLenh(sql, conn);
            KhoaMo(false);
            MessageBox.Show("Lưu thông tin thành công!", "Thông báo", MessageBoxButtons.OK);
        }

        private void txtHoTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        private void txtHoTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSDT.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (BoDieuKhien.isEmail(txtEmail.Text))
            {
                return;
            }
            else
            {
                MessageBox.Show("Email không hợp lệ! Vui lòng nhập lạii", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            OpenForm(new DoiMatKhau(tenDN));
        }
    }
}
