using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien.view
{
    public partial class Home : Form
    {
        SqlConnection conn = new SqlConnection();
        public string tenDN = "";
        public bool isExit = true;
        public event EventHandler logout;
        string sql = "";

        public Form childForm;

        private void OpenFormChild(Form child)
        {
            if (childForm != null)
            {
                childForm.Close();
            }
            childForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panelBody.Controls.Add(child);
            panelBody.Tag = child;
            child.Show();
        }

        public Home()
        {
            InitializeComponent();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
                Application.ExitThread();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblTaiKhoan.Text = tenDN;
            sql = "select * from TaiKhoan where TenDN = '" + tenDN + "' and ChucVuQL = 'True'";
            DataTable dt = ketNoi.GetData(sql);
            if (dt.Rows.Count > 0)
            {
                mnuQLTaiKhoan.Enabled = true;
            }
            else
            {
                mnuQLTaiKhoan.Enabled = false;
            }
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                logout(this, new EventArgs());
            }
        }

        private void mnuQLTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenFormChild(new QuanLyTaiKhoan());
        }

        private void mnuTaiKhoan_Click(object sender, EventArgs e)
        {
            OpenFormChild(new TaiKhoan(tenDN));
        }

        private void llbHoTro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var url = new ProcessStartInfo("https://www.facebook.com/dat.giang.1447")
            {
                UseShellExecute = true,
                Verb = "open"
            };

            try
            {
                Process.Start(url);
            }
            catch (Win32Exception)
            {
                Process.Start("IExplore.exe", "https://www.facebook.com/dat.giang.1447");
            }
        }

        private void ptbHome_Click(object sender, EventArgs e)
        {
            if(childForm != null)
            {
                childForm.Close();
            }
        }

        private void mnuQLSach_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmQLSach());
        }

        private void mnuQLTacGia_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmTacGia());
        }

        private void mnuQLNXB_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmNXB());
        }

        private void mnuQLTheLoai_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmTL());
        }

        private void mnuQLDocGia_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmDocGia());
        }

        private void mnuSach_Click(object sender, EventArgs e)
        {
            OpenFormChild(new ThongKe());
        }

        private void mnuPhieuMuonTra_Click(object sender, EventArgs e)
        {
            OpenFormChild(new frmPhieuMuonTra(tenDN));
        }

        private void mnuDocGia_Click(object sender, EventArgs e)
        {
            OpenFormChild(new ThongKeDocGia());
        }
    }
}
