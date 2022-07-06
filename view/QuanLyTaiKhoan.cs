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
    public partial class QuanLyTaiKhoan : Form
    {
        SqlConnection conn = new SqlConnection();
        DataTable dt = new DataTable();
        DataGridViewCellMouseEventArgs vitri;
        string sql = "";
        bool ktthem = true;
        string tencu = "";
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        void layNguonDL()
        {
            khoaMo(false);
            sql = "select * from TaiKhoan";
            dt = ketNoi.GetData(sql);

            dgListTaiKhoan.DataSource = dt;
        }

        private void khoaMo(bool check)
        {
            btnThemTK.Enabled = !check;
            btnSuaTK.Enabled = !check;
            btnXoaTK.Enabled = !check;
            btnGhi.Enabled = check;
            btnKhong.Enabled = check;

            dgListTaiKhoan.Enabled = !check;
            txtTenDN.ReadOnly = !check;
            txtPassWord.ReadOnly = !check;
            txtHoTen.ReadOnly = !check;
            txtSDT.ReadOnly = !check;
            txtEmail.ReadOnly = !check;
            optNam.Enabled = check;
            optNu.Enabled = check;
            dtpNgaySinh.Enabled = check;
            chkChonNgayThang.Enabled = check;
        }
        bool TaiKhoanThem()
        {
            if (txtTenDN.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDN.Focus();
                return false;
            }

            if (txtPassWord.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassWord.Focus();
                return false;
            }

            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            return true;
        }

        string ktraQly()
        {
            string ktQly = "select ChucVuQL from TaiKhoan where TenDN = '" + tencu + "'";
            DataTable dta = ketNoi.GetData(ktQly);
            return dta.Rows[0][0].ToString();
        }

        void truyVanThemSua(bool check)
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

            if (check)
                sql = "insert into TaiKhoan(TenDN,PassWord,ChucVuQL,HoTen,Email,SDT,NgaySinh,GioiTinh) values(N'"
                    + txtTenDN.Text + "',N'" + txtPassWord.Text + "','False',N'" + txtHoTen.Text + "',N'" +
                    txtEmail.Text + "'," + sdt + "," + ngaysinh + "," + checkGT + ")";
            else
            {
                string ktraQL = ktraQly();
                if (ktraQL == "True")
                {
                    sql = "update TaiKhoan set TenDN = N'" + txtTenDN.Text + "', PassWord = N'" + txtPassWord.Text + "', ChucVuQL = 'True',HoTen = N'" + txtHoTen.Text +
                   "',Email = N'" + txtEmail.Text + "',SDT = " + sdt + ", NgaySinh = " + ngaysinh + ",GioiTinh = " + checkGT + " where TenDN = '" + tencu + "' ";
                }
                else
                {
                    sql = "update TaiKhoan set TenDN = N'" + txtTenDN.Text + "', PassWord = N'" + txtPassWord.Text + "', ChucVuQL = 'False',HoTen = N'" + txtHoTen.Text +
                        "',Email = N'" + txtEmail.Text + "',SDT = " + sdt + ", NgaySinh = " + ngaysinh + ",GioiTinh = " + checkGT + " where TenDN = '" + tencu + "' ";
                }
            }
            BoDieuKhien.ThucHienCauLenh(sql, conn);

            if (check)
            {
                XoaTrang();
                MessageBox.Show("Thêm tài khoản thành công!");
            }
            else
                MessageBox.Show("Sửa tài khoản thành công!");
        }

        private void XoaTrang()
        {
            txtTenDN.Text = "";
            txtPassWord.Text = "";
            txtHoTen.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            dtpNgaySinh.Value = new DateTime(2022, 1, 1);
            chkChonNgayThang.Checked = false;
            optNam.Checked = false;
            optNu.Checked = false;
        }

        public static bool isTKMK(string input)
        {
            return Regex.IsMatch(input, "^[a-zA-Z0-9]");
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            conn = ketNoi.connectDB();
            layNguonDL();
        }

        private void dgListTaiKhoan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgListTaiKhoan.RowCount > 0)
                {
                    if (e.RowIndex >= 0)
                    {
                        XoaTrang();
                        vitri = e;
                        DataGridViewRow row = dgListTaiKhoan.Rows[e.RowIndex];
                        string[] ngaysinh1 = row.Cells[6].Value.ToString().Split(" ");
                        string[] ngaysinh = ngaysinh1[0].Split("/");
                        txtTenDN.Text = row.Cells[0].Value.ToString();
                        txtPassWord.Text = row.Cells[1].Value.ToString();
                        txtHoTen.Text = row.Cells[3].Value.ToString();
                        txtEmail.Text = row.Cells[4].Value.ToString();
                        txtSDT.Text = row.Cells[5].Value.ToString();

                        if (row.Cells[6].Value.ToString() != "")
                        {
                            chkChonNgayThang.Checked = true;
                            dtpNgaySinh.Value = new DateTime(int.Parse(ngaysinh[2]), int.Parse(ngaysinh[1]), int.Parse(ngaysinh[0]));
                        }
                        else
                        {
                            chkChonNgayThang.Checked = false;
                        }

                        if (row.Cells[7].Value.ToString() == "True")
                        {
                            optNu.Checked = false;
                            optNam.Checked = true;
                        }
                        else if (row.Cells[7].Value.ToString() == "False")
                        {
                            optNu.Checked = true;
                            optNam.Checked = false;
                        }
                        else
                        {
                            optNam.Checked = false;
                            optNu.Checked = false;
                        }
                    }
                }
            }
            catch (Exception ev)
            {
                //MessageBox.Show("Error: " + ev + "","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtTenDN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassWord.Focus();
            }
        }

        private void txtTenDN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        private void txtTenDN_Leave(object sender, EventArgs e)
        {
            if (txtTenDN.Text.Length < 6 && txtTenDN.Text.Length > 0)
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập >= 6 ký tự", "Erorr", MessageBoxButtons.OK);
                txtTenDN.Focus();
            }
            sql = "select * from TaiKhoan where TenDN = '" + txtTenDN.Text + "'";
            DataTable dt = ketNoi.GetData(sql);
            if (dt.Rows.Count > 0 && ktthem)
            {
                MessageBox.Show("Tên đăng nhập này đã tồn tại!", "Erorr", MessageBoxButtons.OK);
                txtTenDN.Text = "";
                txtTenDN.Focus();
            }
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

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtHoTen.Focus();
            }
        }

        private void txtPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }

        private void txtPassWord_Leave(object sender, EventArgs e)
        {
            if (txtPassWord.Text.Length < 6 && txtPassWord.Text.Length > 0)
            {
                MessageBox.Show("Vui lòng nhập password >= 6 ký tự", "Erorr", MessageBoxButtons.OK);
                txtPassWord.Focus();
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
            if (txtEmail.Text != "")
            {
                if (BoDieuKhien.checkEmail(txtEmail.Text))
                {
                    MessageBox.Show("Email đã đăng ký! Vui lòng nhập lại email khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Text = "";
                    txtEmail.Focus();
                    return;
                }

                if (BoDieuKhien.isEmail(txtEmail.Text))
                {
                    return;
                }
                else
                {
                    MessageBox.Show("Email không hợp lệ! Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                }
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text != "")
            {
                if (BoDieuKhien.checkSDT(txtSDT.Text))
                {
                    MessageBox.Show("Số điện thoại này đã đăng ký! Vui lòng nhập lại số điện thoại khác khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSDT.Text = "";
                    txtSDT.Focus();
                    return;
                }
            }
        }

        private void btnThemTK_Click(object sender, EventArgs e)
        {
            XoaTrang();
            vitri = null;
            ktthem = true;
            khoaMo(true);
            txtTenDN.Focus();
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            if (vitri == null)
                MessageBox.Show("Vui lòng chọn trường dữ liệu bạn muốn sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                tencu = txtTenDN.Text;
                ktthem = false;
                khoaMo(true);
                txtTenDN.Focus();
            }
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            if (vitri == null)
                MessageBox.Show("Vui lòng chọn trường dữ liệu bạn muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DialogResult kq = MessageBox.Show("Ban muon xoa tai khoan " + txtTenDN.Text + " khong ", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    sql = "delete from TaiKhoan where TenDN = N'" + txtTenDN.Text + "' ";
                    BoDieuKhien.ThucHienCauLenh(sql, conn);
                    XoaTrang();
                    layNguonDL();
                    vitri = null;
                }
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (ktthem)
            {
                bool ktra = TaiKhoanThem();
                if (ktra)
                    truyVanThemSua(true);
                else
                    return;
            }
            else
            {
                truyVanThemSua(false);
            }
            layNguonDL();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            if (ktthem)
            {
                khoaMo(false);
                XoaTrang();
            }
            if (ktthem == false)
            {
                try
                {
                    khoaMo(false);
                    dgListTaiKhoan_CellMouseClick(sender, vitri);
                }
                catch (Exception ev)
                {
                    MessageBox.Show("" + ev + "");
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            khoaMo(false);
            sql = "select * from TaiKhoan where TenDN LIKE '%" + txtTimKiem.Text + "%'";
            DataTable dt = ketNoi.GetData(sql);

            dgListTaiKhoan.DataSource = dt;
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                e.Handled = true;
            }
        }
    }
}
