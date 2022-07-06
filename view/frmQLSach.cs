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
    public partial class frmQLSach : Form
    {
        SqlConnection conn;
        SqlDataAdapter daSach, da;
        DataTable dtSach, dt;
        string sql = "";
        DataGridViewCellMouseEventArgs vt;
        bool ktThem = true;
        string macu = "";

        public void KhoaMo(bool b)
        {
            dgDanhMuc.Enabled = b;
            txtMaNXB.ReadOnly = b;
            txtMaSach.ReadOnly = b;
            txtMaTG.ReadOnly = b;
            txtMaTL.ReadOnly = b;
            txtNamXB.ReadOnly = b;
            txtSL.ReadOnly = b;
            txtTenSach.ReadOnly = b;

            cmdThem.Enabled = b;
            cmdSua.Enabled = b;
            cmdXoa.Enabled = b;
            cmdGhi.Enabled = !b;
            cmdKhong.Enabled = !b;
        }

        public void LayNguonDG()
        {
            sql = "Select * from  Sach";
            daSach = new SqlDataAdapter(sql, conn);
            dtSach = new DataTable();
            daSach.Fill(dtSach);

            dgDanhMuc.DataSource = dtSach;

        }
        public void XoaTrang()
        {
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            txtMaTG.Text = "";
            txtMaNXB.Text = "";
            txtMaTL.Text = "";
            txtSL.Text = "";
            txtNamXB.Text = "";
        }
        public bool ktTrungSua(string manhap)
        {
            sql = "Select * from Sach Where MaSach = N'" + manhap + "' and MaSach <> N'" + macu + "'";
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
            sql = "Select * from Sach Where MaSach = N'" + manhap + "'";
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
                        String[] NamXuatBan = row.Cells[5].Value.ToString().Split(' ');
                        txtMaSach.Text = row.Cells[0].Value.ToString();
                        txtTenSach.Text = row.Cells[1].Value.ToString();
                        txtMaTG.Text = row.Cells[2].Value.ToString();
                        txtMaTL.Text = row.Cells[3].Value.ToString();
                        txtMaNXB.Text = row.Cells[4].Value.ToString();
                        txtNamXB.Text = NamXuatBan[0];
                        txtSL.Text = row.Cells[6].Value.ToString();
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
            txtMaSach.Focus();
        }

        private void cmdSua_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "") return;
            macu = txtMaSach.Text;
            ktThem = false;
            KhoaMo(false);
            txtMaSach.Focus();
        }

        private void cmdXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "") return;
            DialogResult kq = MessageBox.Show("Bạn có muốn xóa sách " + txtTenSach.Text + " không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                sql = "Delete from Sach Where MaSach = N'" + txtMaSach.Text + "'";
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                XoaTrang();
                LayNguonDG();
            }
        }

        private void cmdGhi_Click(object sender, EventArgs e)
        {
            if (txtMaSach.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaSach.Focus();
                return;
            }

            if (txtTenSach.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTenSach.Focus();
                return;
            }

            if (txtMaNXB.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaNXB.Focus();
                return;
            }

            if (txtMaTG.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaTG.Focus();
                return;
            }

            if (txtMaTL.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaTL.Focus();
                return;
            }

            if (txtNamXB.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập năm xuất bản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNamXB.Focus();
                return;
            }

            if (txtSL.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSL.Focus();
                return;
            }

            if (ktThem == true)
            {
                if (ktTrungThem(txtMaSach.Text) == true)
                {
                    MessageBox.Show("Nhập trùng mã thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaSach.Focus();
                    return;
                }
            }
            else
            {
                if (ktTrungSua(txtMaSach.Text) == true)
                {
                    MessageBox.Show("Nhập trùng mã sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMaSach.Focus();
                    return;
                }
            }
            //  " + txtMaSach.Text + "
            string[] namxx = txtNamXB.Text.Split("/");
            string namXX = namxx[2] + '-' + namxx[1] + '-' + namxx[0];
          
            if (ktThem == true)
                sql = "Insert Into Sach(MaSach, TenSach, MaTacGia, MaTheLoai, MaNXB, NamXuatXu, SoLuong)" +
                    "values (N'" + txtMaSach.Text + "', N'" + txtTenSach.Text + "', N'" + txtMaTG.Text + "'," +
                    "N'" + txtMaTL.Text + "', N'" + txtMaNXB.Text + "', N'" + namXX + "', N'" + txtSL.Text + "')";
            else
                sql = "Update Sach set MaSach=N'" + txtMaSach.Text + "', TenSach=N'" + txtTenSach.Text + "', MaTacGia=N'" + txtMaTG.Text + "', MaTheLoai=N'" + txtMaTL.Text + "', " +
                    "MaNXB=N'" + txtMaNXB.Text + "', NamXuatXu=N'" + namXX + "', SoLuong=N'" + txtSL.Text + "' Where MaSach=N'" + macu + "'";
              MessageBox.Show(sql);
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

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            sql = "Select * from Sach where MaSach like '%" + txtTimKiem.Text + "%'";
            dt = ketNoi.GetData(sql);
            dgDanhMuc.DataSource = dt;
        }

        public frmQLSach()
        {
            InitializeComponent();
        }

        private void frmQLSach_Load(object sender, EventArgs e)
        {
            conn = ketNoi.connectDB();
            KhoaMo(true);
            LayNguonDG();
        }
    }
}
