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
    public partial class frmDocGia : Form
    {
        SqlConnection conn;
        SqlDataAdapter daDocGia, da;
        DataTable dtDocGia, dt;
        string sql = "";
        DataGridViewCellMouseEventArgs vt;
        bool ktThem = true;
        string macu = "";

        public void KhoaMo(bool b)
        {
            dgDanhMuc.Enabled = b;
            txtMaDG.ReadOnly = b;
            txtTenDG.ReadOnly = b;
            txtNS.ReadOnly = b;
            txtSDT.ReadOnly = b;
            txtGT.ReadOnly = b;
            txtDC.ReadOnly = b;

            cmdThem.Enabled = b;
            cmdSua.Enabled = b;
            cmdXoa.Enabled = b;
            cmdGhi.Enabled = !b;
            cmdKhong.Enabled = !b;
        }

        public void LayNguonDG()
        {
            sql = "Select * from  DocGia";
            daDocGia = new SqlDataAdapter(sql, conn);
            dtDocGia = new DataTable();
            daDocGia.Fill(dtDocGia);

            dgDanhMuc.DataSource = dtDocGia;

        }

        public void XoaTrang()
        {
            txtMaDG.Text = "";
            txtTenDG.Text = "";
            txtNS.Text = "";
            txtSDT.Text = "";
            txtGT.Text = "";
            txtDC.Text = "";
        }

        public bool ktTrungSua(string manhap)
        {
            sql = "Select * from DocGia Where MaDG = N'" + manhap + "' and MaDG <> N'" + macu + "'";
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
            sql = "Select * from DocGia Where MaDG = N'" + manhap + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
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
                        String[] NgaySinh = row.Cells[2].Value.ToString().Split(' ');
                        txtMaDG.Text = row.Cells[0].Value.ToString();
                        txtTenDG.Text = row.Cells[1].Value.ToString();
                        txtNS.Text = NgaySinh[0];
                        txtSDT.Text = row.Cells[3].Value.ToString();
                        txtGT.Text = row.Cells[4].Value.ToString();
                        txtDC.Text = row.Cells[5].Value.ToString();
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
            txtMaDG.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMaDG.Text == "") return;
            macu = txtMaDG.Text;
            ktThem = false;
            KhoaMo(false);
            txtMaDG.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDG.Text == "") return;
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa độc giả " + txtTenDG.Text + " không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                sql = "Delete from DocGia Where MaDG = N'" + txtMaDG.Text + "'";
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                XoaTrang();
                LayNguonDG();
            }
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtMaDG.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaDG.Focus();
                return;
            }

            if (txtTenDG.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTenDG.Focus();
                return;
            }

            if (txtNS.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNS.Focus();
                return;
            }

            if (txtSDT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSDT.Focus();
                return;
            }

            if (txtGT.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtGT.Focus();
                return;
            }

            if (txtDC.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDC.Focus();
                return;
            }

            if (ktThem == true)
            {
                if (ktTrungThem(txtMaDG.Text) == true)
                {
                    MessageBox.Show("Nhập trùng mã thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaDG.Focus();
                    return;
                }
            }
            else
            {
                if (ktTrungSua(txtMaDG.Text) == true)
                {
                    MessageBox.Show("Nhập trùng mã sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaDG.Focus();
                    return;
                }
            }

            string[] namxx = txtNS.Text.Split("/");
            string namXX = namxx[2] + '-' + namxx[1] + '-' + namxx[0];
            if (ktThem == true)
                sql = "Insert Into DocGia(MaDG, TenDG, NgaySinh, SDT, GioiTinh, DiaChi)" +
                    "values (N'" + txtMaDG.Text + "', N'" + txtTenDG.Text + "', N'" + namXX + "'," +
                    "N'" + txtSDT.Text + "', N'" + txtGT.Text + "', N'" + txtDC.Text + "')";
            else
                sql = "Update DocGia set MaDG=N'" + txtMaDG.Text + "', TenDG=N'" + txtTenDG.Text + "', NgaySinh=N'" + namXX + "', SDT=N'" + txtSDT.Text + "', " +
                    "GioiTinh=N'" + txtGT.Text + "', DiaChi=N'" + txtDC.Text + "' Where MaDG=N'" + macu + "'";
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
            sql = "Select * from DocGia where MaDG like '%" + txtTimKiem.Text + "%'";
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

        public frmDocGia()
        {
            InitializeComponent();
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            conn = ketNoi.connectDB();
            KhoaMo(true);
            LayNguonDG();
        }
    }
}
