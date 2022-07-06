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
    public partial class frmTL : Form
    {
        SqlConnection conn;
        SqlDataAdapter daTheLoai, da;
        DataTable dtTheLoai, dt;
        string sql = "";
        DataGridViewCellMouseEventArgs vt;
        bool ktThem = true;
        string macu = "";

        public void XoaTrang()
        {
            txtMaTL.Text = "";
            txtTenTL.Text = "";
        }

        public void KhoaMo(bool b)
        {
            dgDanhMuc.Enabled = b;
            txtTenTL.ReadOnly = b;
            txtMaTL.ReadOnly = b;

            cmdThem.Enabled = b;
            cmdSua.Enabled = b;
            cmdXoa.Enabled = b;
            cmdGhi.Enabled = !b;
            cmdKhong.Enabled = !b;
        }

        public void LayNguonDG()
        {
            sql = "Select * from  BTheLoai";
            daTheLoai = new SqlDataAdapter(sql, conn);
            dtTheLoai = new DataTable();
            daTheLoai.Fill(dtTheLoai);

            dgDanhMuc.DataSource = dtTheLoai;
        }
        public bool ktTrungSua(string manhap)
        {
            sql = "Select * from BTheLoai Where MaTheLoai = N'" + manhap + "' and MaTheLoai <> N'" + macu + "'";
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
            sql = "Select * from BTheLoai Where MaTheLoai = N'" + manhap + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            XoaTrang();
            ktThem = true;
            KhoaMo(false);
            txtMaTL.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMaTL.Text == "") return;
            macu = txtMaTL.Text;
            ktThem = false;
            KhoaMo(false);
            txtMaTL.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtMaTL.Text == "") return;
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa sách thể loại " + txtTenTL.Text + " không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                sql = "Delete from BTheLoai Where MaTheLoai = N'" + txtMaTL.Text + "'";
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                XoaTrang();
                LayNguonDG();
            }
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtMaTL.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaTL.Focus();
                return;
            }

            if (txtTenTL.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTenTL.Focus();
                return;
            }

            if (ktThem == true)
            {
                if (ktTrungThem(txtMaTL.Text) == true)
                {
                    MessageBox.Show("Nhập trùng mã thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaTL.Focus();
                    return;
                }
            }
            else
            {
                if (ktTrungSua(txtMaTL.Text) == true)
                {
                    MessageBox.Show("Nhập trùng mã sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaTL.Focus();
                    return;
                }
            }

            if (ktThem == true)
                sql = "Insert Into BTheLoai(MaTheLoai, TheLoai) values(N'" + txtMaTL.Text + "', N'" + txtTenTL.Text + "')";
            else
                sql = "Update BTheLoai set MaTheLoai = N'" + txtMaTL.Text + "', TheLoai = N'" + txtTenTL.Text + "' where MaTheLoai=N'" + macu + "'";
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
                        txtMaTL.Text = row.Cells[0].Value.ToString();
                        txtTenTL.Text = row.Cells[1].Value.ToString();
                    }
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi" + ev.Message, "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            sql = "Select * from BTheLoai where MaTheLoai like '%" + txtTimKiem.Text + "%'";
            dt = ketNoi.GetData(sql);
            dgDanhMuc.DataSource = dt;
        }

        public frmTL()
        {
            InitializeComponent();
        }

        private void frmTL_Load(object sender, EventArgs e)
        {
            conn = ketNoi.connectDB();
            KhoaMo(true);
            LayNguonDG();
        }
    }
}
