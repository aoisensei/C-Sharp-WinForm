using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QLThuVien
{
    class BoDieuKhien
    {
        public static bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        public static bool checkSDT(string sdt)
        {
            string sql = "select * from TaiKhoan where SDT=" + sdt + "";
            DataTable dt = ketNoi.GetData(sql);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool checkEmail(string email)
        {
            string sql = "select * from TaiKhoan where Email='" + email + "'";
            DataTable dt = ketNoi.GetData(sql);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ThucHienCauLenh(string sql, SqlConnection conn)
        {
            conn = ketNoi.connectDB();
            if (conn.State != ConnectionState.Open) conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close(); 
        }

        public static int OTP()
        {
            Random r = new Random();
            return r.Next(100001,999999);
        }

        public static int SDT(string sdt)
        {
            
            int maOTP = OTP();
            string sodt = "+84" + sdt.Substring(1);
            const string accountSid = "ACa80176dbc859440e713f55ecaf760ff6";
            const string authToken = "3aac8a911480a93395758652b7791e88";

            TwilioClient.Init(accountSid, authToken);

            MessageResource.Create(
                body: "Mã OPT của bạn là : " + maOTP + " ",
                from: new Twilio.Types.PhoneNumber("+16815252795"),
                to: new Twilio.Types.PhoneNumber(sodt)
            );

            //Console.WriteLine(message.Sid);
            MessageBox.Show("Mã OPT đã được gửi đến số điện thoại của bạn, Vui lòng kiểm tra điện thoại!");

            return maOTP;
        }
        
        public static int Email(string ToMail)
        {
            int maOTP = OTP();
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("giangvandat2002@gmail.com","dat211229");

            MailMessage mail = new MailMessage("giangvandat2002@gmail.com",ToMail,"Lấy lại mật khẩu!","Mã OTP của bạn là: "+ maOTP +"");

            client.Send(mail);

            MessageBox.Show("Mã OPT đã được gửi đến Email của bạn, Vui lòng kiểm tra Email!");

            return maOTP;
        }

        public static string chuyendoiNS(string ngay)
        {
            if (ngay == "")
            {
                return "";
            }
            else if (ngay == "NULL")
            {
                return "";
            }
            else
            {
                string[] ngaysinh1 = ngay.Split(" ");
                string[] ngaysinh = ngaysinh1[0].Split("/");
                return ngaysinh[2] + "-" + ngaysinh[1] + "-" + ngaysinh[0];
            }
        }
    }
}
