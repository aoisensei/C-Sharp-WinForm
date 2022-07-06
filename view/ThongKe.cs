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
    public partial class ThongKe : Form
    {
        SqlConnection conn = new SqlConnection();
        string sql = "";
        string type = "";
        private string cauLenh = "select Sach.MaSach,Sach.TenSach,BTacGia.MaTacGia,BTacGia.TenTacGia, BTheLoai.MaTheLoai," +
            " TheLoai, NhaXuatBan.MaNXB,NhaXuatBan.TenNXB, NamXuatXu,PhieuMuonTra.MaDG,DocGia.TenDG, TenDN, NgayMuon, NgayPhaiTra, NgayTra" +
            " from Sach INNER JOIN BTheLoai On Sach.MaTheLoai = BTheLoai.MaTheLoai" +
            " INNER JOIN BTacGia On Sach.MaTacGia = BTacGia.MaTacGia " +
            " INNER JOIN NhaXuatBan On Sach.MaNXB = NhaXuatBan.MaNXB " +
            " INNER JOIN PhieuMuonTra On Sach.MaSach = PhieuMuonTra.MaSach" +
            " INNER JOIN DocGia On Sach.MaSach = PhieuMuonTra.MaSach and PhieuMuonTra.MaDG = DocGia.MaDG";
        public ThongKe()
        {
            InitializeComponent();
        }

        

        void layDuLieu(string type)
        {
            if (cbbThongKe.SelectedItem.ToString() == "Tất cả các sách")
            {
                if(type=="")
                    sql = cauLenh;
                else
                    sql = cauLenh + " where "+ type +"";
                DataTable dt = ketNoi.GetData(sql);
                dgDanhSach.DataSource = dt;
            }
            if (cbbThongKe.SelectedItem.ToString() == "Sách đã trả")
            {
                sql = cauLenh + " where PhieuMuonTra.NgayTra is NOT NULL " + type + "";
                DataTable dt = ketNoi.GetData(sql);
                dgDanhSach.DataSource = dt;
            }
            if (cbbThongKe.SelectedItem.ToString() == "Sách chưa trả")
            {
                sql = cauLenh + " where PhieuMuonTra.NgayTra is NULL " + type + "";
                DataTable dt = ketNoi.GetData(sql);
                dgDanhSach.DataSource = dt;
            }
            if (cbbThongKe.SelectedItem.ToString() == "Sách trễ hạn")
            {
                sql = cauLenh + " where NgayPhaiTra < GETDATE() " + type + " and PhieuMuonTra.NgayTra is NULL ";
                DataTable dt = ketNoi.GetData(sql);
                dgDanhSach.DataSource = dt;
            }

        }

        void layNguon()
        {
            layDuLieu(type);
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            conn = ketNoi.connectDB();
            layNguon();
            lblSoLuong.Text = dgDanhSach.Rows.Count.ToString();
        }

        private void cbbThongKe_SelectedValueChanged(object sender, EventArgs e)
        {
            type = "";
            ThongKe_Load(sender, e);
        }

        private void btnXuatEx_Click(object sender, EventArgs e)
        {
            string filePath = "";
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "Excel | *.xlsx";

            if(dialog.ShowDialog() == DialogResult.OK)
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

                    p.Workbook.Properties.Title = "Báo cáo thống kê mượn sách";

                    p.Workbook.Worksheets.Add("Test sheet");

                    ExcelWorksheet ws = p.Workbook.Worksheets[0];

                    ws.Name = "Test sheet";

                    ws.Cells.Style.Font.Size = 11;

                    ws.Cells.Style.Font.Name = "Times New Roman";

                    string[] titleColumnExcel = {"Mã Sách","Tên Sách","Mã Tác Giả","Tên Tác Giả","Mã Thể Loại","Tên Thể Loại",
                                                 "Mã NXB","Tên NXB","Năm Xuất Xứ","Mã độc giả","Tên độc giả","Người lập phiếu","Ngày Mượn","Ngày Phải Trả","Ngày Trả"};

                    var countColumn = titleColumnExcel.Count();

                    ws.Cells[1, 1].Value = "Bảng Thống Kê Mượn Trả Sách";
                    ws.Cells[1, 1, 1, countColumn].Merge = true;
                    ws.Cells[1, 1, 1, countColumn].Style.Font.Bold = true;
                    ws.Cells[1, 1, 1, countColumn].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                    int colIndex = 1;
                    int rowIndex = 2;

                    foreach(var item in titleColumnExcel)
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

                    foreach(DataRow dr in dt.Rows)
                    {
                        colIndex = 1;
                        rowIndex++;

                        ws.Cells[rowIndex, colIndex++].Value = dr["MaSach"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["TenSach"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["MaTacGia"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["TenTacGia"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["MaTheLoai"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["TheLoai"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["MaNXB"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["TenNXB"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = BoDieuKhien.chuyendoiNS(dr["NamXuatXu"].ToString());
                        ws.Cells[rowIndex, colIndex++].Value = dr["MaDG"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["TenDG"].ToString();
                        ws.Cells[rowIndex, colIndex++].Value = dr["TenDN"].ToString();
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

        private void cbbThongKe_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string ngayBD = BoDieuKhien.chuyendoiNS(dtpNgayBD.Value.ToString());
            string ngayKT = BoDieuKhien.chuyendoiNS(dtpNgayKT.Value.ToString());

            if (cbbThongKe.SelectedItem.ToString() == "Tất cả các sách")
            {
                type = " NgayMuon >= Convert(varchar(30), '" + ngayBD + "', 23) and NgayMuon <= Convert(varchar(30), '" + ngayKT + "', 23)";
            }
            else
            {
                type = "and NgayMuon >= Convert(varchar(30), '" + ngayBD + "', 23) and NgayMuon <= Convert(varchar(30), '" + ngayKT + "', 23)";
            }
            ThongKe_Load(sender, e);
        }
    }
}
