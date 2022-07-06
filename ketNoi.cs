using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    class ketNoi
    {
        public static SqlConnection connectDB()
        {
            string connString = @"Data Source=DESKTOP-OFMRGFU\SQLEXPRESS;Initial Catalog=QLTM;User ID=sa;Password=dat211229";
            SqlConnection con = new SqlConnection(connString);
            return con;
        }

        public static DataTable GetData(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, connectDB());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
