using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien.view
{
    public partial class ThongKeDocGia : Form
    {
        SqlConnection conn = new SqlConnection();
        string sql = "";
        private string caulenh = "select Sach.MaSach, Sach.TenSach, PhieuMuonTra.MaPhieuMT, TaiKhoan.HoTen, PhieuMuonTra.TinhTrang, " +
                        " PhieuMuonTra.NgayMuon, PhieuMuonTra.NgayPhaiTra, PhieuMuonTra.NgayTra from PhieuMuonTra " +
                        " inner join Sach on Sach.MaSach = PhieuMuonTra.MaSach" +
                        " inner join TaiKhoan on TaiKhoan.TenDN = PhieuMuonTra.TenDN";

        public ThongKeDocGia()
        {
            InitializeComponent();
        }

        void layNguonDL()
        {
            sql = "select DISTINCT DocGia.MaDG from DocGia inner join PhieuMuonTra on PhieuMuonTra.MaDG = DocGia.MaDG ";
            DataTable dt = ketNoi.GetData(sql);
            List<string> listDG = new List<string>();
            listDG.Add("------");
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                listDG.Add(dt.Rows[i][0].ToString());
            }
            cbbTuyChon.DataSource = listDG;
        }

        void getDL(string type)
        {
            if (cbbTuyChon.SelectedItem.ToString() != "------")
            {
                if (type == "")
                    sql = caulenh + " where PhieuMuonTra.MaDG = '" + cbbTuyChon.SelectedItem.ToString() + "'";
                else if (type == "datra")
                {
                    sql = caulenh + " where PhieuMuonTra.MaDG = '" + cbbTuyChon.SelectedItem.ToString() + "'" +
                        " and PhieuMuonTra.NgayTra is NOT NULL";
                }
                else if(type == "chuatra")
                {
                    sql = caulenh + " where PhieuMuonTra.MaDG = '" + cbbTuyChon.SelectedItem.ToString() + "'" +
                        " and PhieuMuonTra.NgayTra is NULL";
                }
                else
                {
                    sql = caulenh + " where PhieuMuonTra.MaDG = '" + cbbTuyChon.SelectedItem.ToString() + "'" +
                        " and PhieuMuonTra.NgayTra is NULL and PhieuMuonTra.NgayPhaiTra < GetDate()";
                }

            }

            else
            {
                if (type == "")
                {
                    sql = caulenh;
                }
                else if(type == "datra")
                {
                    sql = caulenh + " and PhieuMuonTra.NgayTra is NOT NULL";
                }
                else if(type == "chuatra")
                {
                    sql = caulenh + " and PhieuMuonTra.NgayTra is NULL";
                }
                else
                {
                    sql = caulenh +" and PhieuMuonTra.NgayTra is NULL and PhieuMuonTra.NgayPhaiTra < GetDate() ";
                }
            }
                
             DataTable dta = ketNoi.GetData(sql);
             dgDanhSach.DataSource = dta;
             lblSoLuong.Text = dgDanhSach.Rows.Count.ToString();
        }

        void getThongTinDG()
        {
            string docgia = "select DocGia.MaDG, DocGia.TenDG from DocGia where MaDG = '" + cbbTuyChon.SelectedItem.ToString() + "' ";
            DataTable dt = new DataTable();
            dt = ketNoi.GetData(docgia);
            if (dt.Rows.Count > 0) 
            {
                lblMaDG.Text = dt.Rows[0][0].ToString();
                lblTenDG.Text = dt.Rows[0][1].ToString();
            }
            else
            {
                lblMaDG.Text = "";
                lblTenDG.Text = "";
            }
        }

        private void ThongKeDocGia_Shown(object sender, EventArgs e)
        {
            layNguonDL();
            getDL("");
        }

        private void ThongKeDocGia_Load(object sender, EventArgs e)
        {
            conn = ketNoi.connectDB(); 
        }

        private void cbbTuyChon_SelectedValueChanged(object sender, EventArgs e)
        {
            ThongKeDocGia_Load(sender, e); 
            getDL("");
            getThongTinDG();
            //lblSoLuong.Text = dgDanhSach.Rows.Count.ToString();
        }

        private void cbbTuyChon_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            ThongKeDocGia_Load(sender, e);
            getDL("");
        }

        private void btnDaTra_Click(object sender, EventArgs e)
        {
            ThongKeDocGia_Load(sender, e);
            getDL("datra");
        }

        private void btnTreHan_Click(object sender, EventArgs e)
        {
            ThongKeDocGia_Load(sender, e);
            getDL("trehan");
        }

        private void btnChuaTra_Click(object sender, EventArgs e)
        {
            ThongKeDocGia_Load(sender, e);
            getDL("chuatra");
        }

        private void btnXuatEX_Click(object sender, EventArgs e)
        {
            string filePath = "";
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "Excel | *.xlsx";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
            }

            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn không hợp lệ");
                return;
            }

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            try
            {
                using (ExcelPackage p = new ExcelPackage())
                {
                    p.Workbook.Properties.Author = "Giang Van Dat";

                    p.Workbook.Properties.Title = "Báo cáo thống kê sách mượn của độc giả";

                    p.Workbook.Worksheets.Add("Test sheet");

                    ExcelWorksheet ws = p.Workbook.Worksheets[0];

                    ws.Name = "Test sheet";

                    ws.Cells.Style.Font.Size = 11;

                    ws.Cells.Style.Font.Name = "Times New Roman";

                    string[] titleColumnExcel = {"Mã Sách","Tên Sách","Mã Phiếu Mượn Trả","Người lập phiếu","Tình trạng","Ngày Mượn","Ngày Phải Trả","Ngày Trả"};

                    var countColumn = titleColumnExcel.Count();

                    ws.Cells[1, 1].Value = "Báo cáo thống kê sách mượn của độc giả";
                    ws.Cells[1, 1, 1, countColumn].Merge = true;
                    ws.Cells[1, 1, 1, countColumn].Style.Font.Bold = true;
                    ws.Cells[1, 1, 1, countColumn].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    int colIndex = 1;
                    int rowIndex = 2;

                    foreach (var item in titleColumnExcel)
                    {
                        var cell = ws.Cells[rowIndex, colIndex];

                        var fill = cell.Style.Fill;
                        fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);

                        var border = cell.Style.Border;
                        border.Bottom.Style = border.Left.Style = border.Right.Style = border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

                        cell.Value = item;
                        ws.Cells[rowIndex, colIndex].AutoFitColumns();
                        colIndex++;
                    }

                    DataTable dt = ketNoi.GetData(sql);

                    foreach (DataRow dr in dt.Rows)
                    {
                        colIndex = 1;
                        rowIndex++;

                        ws.Cells[rowIndex, colIndex++].Value = dr["MaSach"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["TenSach"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["MaPhieuMT"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["HoTen"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["TinhTrang"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = BoDieuKhien.chuyendoiNS(dr["NgayMuon"].ToString());
                        ws.Cells[rowIndex, colIndex++].Value = BoDieuKhien.chuyendoiNS(dr["NgayPhaiTra"].ToString());
                        ws.Cells[rowIndex, colIndex++].Value = BoDieuKhien.chuyendoiNS(dr["NgayTra"].ToString());
                    }

                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.ToString());
            }
        }
    }
}
