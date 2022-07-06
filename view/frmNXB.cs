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
    public partial class frmNXB : Form
    {
        SqlConnection conn;
        SqlDataAdapter daNXB, da;
        DataTable dtNXB, dt;
        string sql = "";
        DataGridViewCellMouseEventArgs vt;
        bool ktThem = true;
        string macu = "";

        public void KhoaMo(bool b)
        {
            dgDanhMuc.Enabled = b;
            txtTenNXB.ReadOnly = b;
            txtMaNXB.ReadOnly = b;
            txtDiaChi.ReadOnly = b;
            txtEmail.ReadOnly = b;
            txtSDT.ReadOnly = b;

            cmdThem.Enabled = b;
            cmdSua.Enabled = b;
            cmdXoa.Enabled = b;
            cmdGhi.Enabled = !b;
            cmdKhong.Enabled = !b;
        }

        public void LayNguonDG()
        {
            sql = "Select * from  NhaXuatBan";
            daNXB = new SqlDataAdapter(sql, conn);
            dtNXB = new DataTable();
            daNXB.Fill(dtNXB);

            dgDanhMuc.DataSource = dtNXB;

        }

        public void XoaTrang()
        {
            txtMaNXB.Text = "";
            txtTenNXB.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
        }

        private void dgDanhMuc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgDanhMuc.RowCount > 0)
                {
                    if (e.RowIndex >= 0)
                    {
                        vt = e;
                        DataGridViewRow row = dgDanhMuc.Rows[e.RowIndex];
                        txtMaNXB.Text = row.Cells[0].Value.ToString();
                        txtTenNXB.Text = row.Cells[1].Value.ToString();
                        txtDiaChi.Text = row.Cells[2].Value.ToString();
                        txtSDT.Text = row.Cells[3].Value.ToString();
                        txtEmail.Text = row.Cells[4].Value.ToString();
                    }
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi" + ev.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            XoaTrang();
            ktThem = true;
            KhoaMo(false);
            txtMaNXB.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMaNXB.Text == "") return;
            macu = txtMaNXB.Text;
            ktThem = false;
            KhoaMo(false);
            txtMaNXB.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNXB.Text == "") return;
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa nhà xuất bản " + txtTenNXB.Text + " không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                sql = "Delete from NhaXuatBan Where MaNXB = N'" + txtMaNXB.Text + "'";
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                XoaTrang();
                LayNguonDG();
            }
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtMaNXB.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaNXB.Focus();
                return;
            }

            if (txtTenNXB.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTenNXB.Focus();
                return;
            }

            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDiaChi.Focus();
                return;
            }

            if (txtSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSDT.Focus();
                return;
            }

            if (txtEmail.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEmail.Focus();
                return;
            }

            if (ktThem == true)
            {
                if (ktTrungThem(txtMaNXB.Text) == true)
                {
                    MessageBox.Show("Nhập trùng mã thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaNXB.Focus();
                    return;
                }
            }
            else
            {
                if (ktTrungSua(txtMaNXB.Text) == true)
                {
                    MessageBox.Show("Nhập trùng mã sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaNXB.Focus();
                    return;
                }
            }

            if (ktThem == true)
                sql = "Insert Into NhaXuatBan(MaNXB, TenNXB, DiaChi, SDT, Email) values(N'" + txtMaNXB.Text + "', N'" + txtTenNXB.Text + "', N'" + txtDiaChi.Text + "'," +
                    "N'" + txtSDT.Text + "', N'" + txtEmail.Text + "')";
            else
                sql = "Update NhaXuatBan set MaNXB = N'" + txtMaNXB.Text + "', TenNXB = N'" + txtTenNXB.Text + "', DiaChi = N'" + txtDiaChi.Text +
                    "', SDT = N'" + txtSDT.Text + "', Email = N'" + txtEmail.Text + "' where MaNXB=N'" + macu + "'";
            if (conn.State != ConnectionState.Open) conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            KhoaMo(true);
            LayNguonDG();
        }

        private void cmdKhong_Click(object sender, EventArgs e)
        {
            try
            {
                KhoaMo(true);
                if(vt!=null)
                    dgDanhMuc_CellMouseClick(sender, vt);
            }
            catch (Exception ev) { }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            sql = "Select * from NhaXuatBan where MaNXB like '%" + txtTimKiem.Text + "%'";
            dt = ketNoi.GetData(sql);
            dgDanhMuc.DataSource = dt;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        public frmNXB()
        {
            InitializeComponent();
        }

        private void frmNXB_Load(object sender, EventArgs e)
        {
            conn = ketNoi.connectDB();
            KhoaMo(true);
            LayNguonDG();
        }
        public bool ktTrungSua(string manhap)
        {
            sql = "Select * from NhaXuatBan Where MaNXB = N'" + manhap + "' and MaNXB <> N'" + macu + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool ktTrungThem(string manhap)
        {
            sql = "Select * from NhaXuatBan Where MaNXB = N'" + manhap + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
