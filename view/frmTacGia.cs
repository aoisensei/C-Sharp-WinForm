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
    public partial class frmTacGia : Form
    {
        SqlConnection conn;
        SqlDataAdapter daTacGia, da;
        DataTable dtTacGia, dt;
        string sql = "";
        DataGridViewCellMouseEventArgs vt;
        bool ktThem = true;
        string macu = "";

        public void XoaTrang()
        {
            txtMaTG.Text = "";
            txtTenTG.Text = "";
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
                        txtMaTG.Text = row.Cells[0].Value.ToString();
                        txtTenTG.Text = row.Cells[1].Value.ToString();
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
            txtMaTG.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMaTG.Text == "") return;
            macu = txtMaTG.Text;
            ktThem = false;
            KhoaMo(false);
            txtMaTG.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtMaTG.Text == "") return;
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa tác giả " + txtTenTG.Text + " không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                sql = "Delete from BTacGia Where MaTacGia = N'" + txtMaTG.Text + "'";
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                XoaTrang();
                LayNguonDG();
            }
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtMaTG.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaTG.Focus();
                return;
            }

            if (txtTenTG.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTenTG.Focus();
                return;
            }

            if (ktThem == true)
            {
                if (ktTrungThem(txtMaTG.Text) == true)
                {
                    MessageBox.Show("Nhập trùng mã thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaTG.Focus();
                    return;
                }
            }
            else
            {
                if (ktTrungSua(txtMaTG.Text) == true)
                {
                    MessageBox.Show("Nhập trùng mã sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaTG.Focus();
                    return;
                }
            }

            if (ktThem == true)
                sql = "Insert Into BTacGia(MaTacGia, TenTacGia) values(N'" + txtMaTG.Text + "', N'" + txtTenTG.Text + "')";
            else
                sql = "Update BTacGia set MaTacGia = N'" + txtMaTG.Text + "', TenTacGia = N'" + txtTenTG.Text + "' where MaTacGia=N'" + macu + "'";
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

        public void KhoaMo(bool b)
        {
            dgDanhMuc.Enabled = b;
            txtTenTG.ReadOnly = b;
            txtMaTG.ReadOnly = b;

            cmdThem.Enabled = b;
            cmdSua.Enabled = b;
            cmdXoa.Enabled = b;
            cmdGhi.Enabled = !b;
            cmdKhong.Enabled = !b;
        }

        public void LayNguonDG()
        {
            sql = "Select * from  BTacGia";
            daTacGia = new SqlDataAdapter(sql, conn);
            dtTacGia = new DataTable();
            daTacGia.Fill(dtTacGia);

            dgDanhMuc.DataSource = dtTacGia;

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            sql = "Select * from BTacGia where MaTacGia like '%" + txtTimKiem.Text + "%'";
            dt = ketNoi.GetData(sql);
            dgDanhMuc.DataSource = dt;
        }
        public bool ktTrungSua(string manhap)
        {
            sql = "Select * from BTacGia Where MaTacGia = N'" + manhap + "' and MaTacGia <> N'" + macu + "'";
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
            sql = "Select * from BTacGia Where MaTacGia = N'" + manhap + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public frmTacGia()
        {
            InitializeComponent();
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            conn = ketNoi.connectDB();
            KhoaMo(true);
            LayNguonDG();
        }
    }
}
