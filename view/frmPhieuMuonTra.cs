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
    public partial class frmPhieuMuonTra : Form
    {
        SqlConnection conn;
        DataTable dtPhieu, dtChiTiet;
        bool ktThem = true;
        string sql, macu = " ";
        string tenTK;
        private DataGridViewCellMouseEventArgs vt;
        private DataGridViewCellMouseEventArgs vt2;

        public void XoaTrang1()
        {
            txtMaPhieu.Text = "";
            cbbMaSach.SelectedItem = "MS1";
            cbbSMaDG.SelectedItem = "MDG1";
        }

        public void KhoaMo1(bool b)
        {
            ds1.Enabled = b;
            cmdthem.Enabled = b; cmdsua.Enabled = b; cmdxoa.Enabled = b;
            cbbMaSach.Enabled = !b;
            cbbSMaDG.Enabled = !b;
            cmdghi.Enabled = !b; cmdkhong.Enabled = !b;

        }
        public void LayNguon1()
        {
            sql = "Select MaPhieuMT, MaDG, MaSach, TaiKhoan.HoTen from PhieuMuonTra INNER JOIN TaiKhoan on TaiKhoan.TenDN = PhieuMuonTra.TenDN";
            dtPhieu = ketNoi.GetData(sql);
            ds1.DataSource = dtPhieu;
        }

        void layNguonDLCBB()
        {
            sql = "select DISTINCT DocGia.MaDG from DocGia inner join PhieuMuonTra on PhieuMuonTra.MaDG = DocGia.MaDG ";
            DataTable dt = ketNoi.GetData(sql);
            List<string> listMP = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listMP.Add(dt.Rows[i][0].ToString());
            }
            cbbSMaDG.DataSource = listMP;
            sql = "select DISTINCT Sach.MaSach from Sach inner join PhieuMuonTra on PhieuMuonTra.MaSach = Sach.MaSach ";
            DataTable dtt = ketNoi.GetData(sql);
            List<string> listDG = new List<string>();
            for (int i = 0; i < dtt.Rows.Count; i++)
            {
                listDG.Add(dtt.Rows[i][0].ToString());
            }
            cbbMaSach.DataSource = listDG;
        }

        private string layMaMoi()
        {
            sql = "select MaPhieuMT from PhieuMuonTra ";
            DataTable dt = ketNoi.GetData(sql);
            string laymacu = dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(1);
            return (Convert.ToInt32(laymacu) + 1).ToString();
        }

        public void KhoaMo2()
        {
            ds2.Enabled = true;
            txtMaPhieu2.Enabled = false;
            txtMaSach.Enabled = false;
            ngaymuon.Enabled = false;
            ngayhen.Enabled = false;
        }
        public void LayNguon2()
        {
            sql = "Select MaPhieuMT, MaSach, NgayMuon, NgayPhaiTra from PhieuMuonTra where NgayTra is NULL";
            dtChiTiet = ketNoi.GetData(sql);
            ds2.DataSource = dtChiTiet;
        }
        public void XoaTrang2()
        {
            txtMaPhieu2.Text = ""; txtMaSach.Text = ""; ngaymuon.Text = "";
            ngayhen.Text = "";
        }

        public bool SoSachMuon()
        {
            sql = "select MaSach from PhieuMuonTra where MaSach = '" + cbbMaSach.SelectedItem.ToString() + "'";
            DataTable dt = ketNoi.GetData(sql);
            sql = "select SoLuong from Sach where MaSach = '" + cbbMaSach.SelectedItem.ToString() + "'";
            DataTable dtSL = ketNoi.GetData(sql);

            if (Convert.ToInt32(dt.Rows.Count) < Convert.ToInt32(dtSL.Rows[0][0].ToString()))
            {
                return true;
            }
            else
                return false;
        }
        public frmPhieuMuonTra()
        {
            InitializeComponent();
        }

        public frmPhieuMuonTra(string tenTk)
        {
            this.tenTK = tenTk;
            InitializeComponent();
        }

        private void frmPhieuMuonTra_Load(object sender, EventArgs e)
        {
            conn = ketNoi.connectDB();
            KhoaMo1(true);
            LayNguon1();
            KhoaMo2();
            LayNguon2();
        }

        private void cmdthem_Click(object sender, EventArgs e)
        {
            KhoaMo1(false);
            ktThem = true;
        }

        private void cmdsua_Click(object sender, EventArgs e)
        {
            if (vt != null)
            {
                KhoaMo1(false);
                ktThem = false;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn trường dữ liệu để sửa!");
            }
            
        }

        private void cmdghi_Click(object sender, EventArgs e)
        {

            if (ktThem == true)
            {
                if(SoSachMuon() == true)
                {
                    sql = " insert into PhieuMuonTra(MaPhieuMT,MaDG,TenDN,MaSach,NgayMuon,NgayPhaiTra) values(N'M" + layMaMoi()
                        + "',N'" + cbbSMaDG.SelectedItem.ToString() + "',N'" + tenTK + "',N'" + cbbMaSach.SelectedItem.ToString() + "',GETDATE(),GETDATE()+7)";
                }
                else
                {
                    MessageBox.Show("Đã hết sách này trong kho!", "Thông báo");
                   txtMaSach.Focus();
                   return;
                }
            }
            else
                sql = "update PhieuMuonTra set MaDG=N'" + cbbSMaDG.SelectedItem.ToString() + "', MaSach=N'" + 
                    cbbMaSach.SelectedItem.ToString() + "' where MaPhieuMT=N'" + txtMaPhieu.Text + "'";

            BoDieuKhien.ThucHienCauLenh(sql, conn);

            KhoaMo1(true);
            LayNguon1();
            LayNguon2();
        }

        private void cmdkhong_Click(object sender, EventArgs e)
        {
            try
            {
                KhoaMo1(true);
                if(vt != null)
                    ds1_CellMouseClick(sender, vt);
            }
            catch (Exception ex) { }
        }

        private void cmdxoa_Click(object sender, EventArgs e)
        {
            macu = txtMaPhieu.Text;
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "delete from PhieuMuonTra where MaPhieuMT = N'" + macu + "'";
                BoDieuKhien.ThucHienCauLenh(sql, conn);
                XoaTrang1();
                LayNguon1();
                LayNguon2();
                XoaTrang1();
            }
        }


        private void ds1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (ds1.RowCount > 0)
                {
                    if (e.RowIndex >= 0)
                    {
                        vt = e;
                        DataGridViewRow row = ds1.Rows[e.RowIndex];
                        txtMaPhieu.Text = row.Cells[0].Value.ToString();
                        cbbSMaDG.SelectedItem = row.Cells[1].Value.ToString();
                        cbbMaSach.SelectedItem = row.Cells[2].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi" + ex);
            }
        }

        private void ds2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (ds2.RowCount > 0)
                {
                    if (e.RowIndex >= 0)
                    {
                        vt2 = e;
                        DataGridViewRow row = ds2.Rows[e.RowIndex];
                        txtMaPhieu2.Text = row.Cells[0].Value.ToString();
                        txtMaSach.Text = row.Cells[1].Value.ToString();
                        ngaymuon.Text = row.Cells[2].Value.ToString();
                        ngayhen.Text = row.Cells[3].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi" + ex);
            }
        }

        private void frmPhieuMuonTra_Shown(object sender, EventArgs e)
        {
            layNguonDLCBB();
        }

        private void txtNgayGiaHan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void cmdsua1_Click(object sender, EventArgs e)
        {
            if (vt2 != null)
            {
                if (txtNgayGiaHan.Text == "") MessageBox.Show("Bạn chưa nhập số ngày gia hạn thêm!", "Thông báo");
                else
                {
                    DialogResult dl = MessageBox.Show("Bạn thực sự muốn gia hạn thêm hay không!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dl == DialogResult.Yes)
                    {
                        sql = "update PhieuMuonTra set NgayPhaiTra = DATEADD(day," + txtNgayGiaHan.Text + ",NgayPhaiTra) where MaPhieuMT='" + txtMaPhieu2.Text + "'";
                        BoDieuKhien.ThucHienCauLenh(sql, conn);
                        LayNguon1();
                        LayNguon2();
                        MessageBox.Show("Gia hạn sach có mã " + txtMaPhieu2.Text + " thành công");
                    }
                    else
                        return;

                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn trường dữ liệu để sửa!");
                return;
            }
            
        }

        private void cmdxoa1_Click(object sender, EventArgs e)
        {
            macu = txtMaPhieu2.Text;
            if (MessageBox.Show("Bạn có muốn đánh dấu đã trả sách?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "update PhieuMuonTra set NgayTra = GETDATE(), TinhTrang = N'" + cbbTinhTrang.SelectedItem.ToString() + "' where MaPhieuMT = N'" + macu + "'";
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                LayNguon2();
                XoaTrang2();
            }
        }

    }
}
