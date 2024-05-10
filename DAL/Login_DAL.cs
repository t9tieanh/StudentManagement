using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using System.Runtime.CompilerServices;
using System.Data.SqlClient;
using System.Data;
using DTO;

namespace DAL
{
    public class Login_DAL
    {
        private static int codeOTP;

        public static bool ProcedToLogin(DTO.Login_DTO login)
        {
            string userName = login.UserName;
            string password = login.Password;

            string query = $"SELECT COUNT(*) FROM LOGIN WHERE USERNAME = N'{userName}' AND PASSWORD = N'{password}' AND STATUS = 1";

            int count = MyDB.ExecuteScalar (query);
            if (count > 0) return true;
            return false;
        }

        public static bool InsertLogin(DTO.Login_DTO login)
        {
            string userName = login.UserName;
            string password = login.Password;
            string email  = login.Email;
            string query = $"INSERT INTO LOGIN VALUES ('{userName}', '{password}', '{email}' ,0)";
            return MyDB.ExecuteNonQuery (query);
        }
        public static bool UpdateLogin (DTO.Login_DTO login)
        {
            string password = login.Password;
            string email = login.Email;
            string querry = $"UPDATE LOGIN SET PASSWORD = '{password}' WHERE EMAIL = '{email}'";
            return MyDB.ExecuteNonQuery(querry);
        }
        #region xác nhận email
        public static bool SendCodeConfirm (string email)
        {
            try
            {
                codeOTP = new Random().Next(100000, 999999);
                string pass = "eyrbwcujqkfethzh";

                MailMessage message = new MailMessage();
                message.To.Add(email);
                message.From = new MailAddress("ptienanh19@gmail.com");
                message.Subject = "XÁC NHẬN EMAIL ĐĂNG KÍ TÀI KHOẢN SPKT (TEST)";
                message.Body = "OTP CỦA BẠN LÀ : " + codeOTP;

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("ptienanh19@gmail.com", pass)
                };
                smtp.Send(message);
                return true;
            }
            catch
            {
                return false; // gửi không thành công
            }
        }
        public static bool ConFirmCode (string code)
        {
            return (code == codeOTP + "");
        }
        #endregion 
        #region check email và user đã tồn tại hay chưa
        public static bool CheckUser (string userName)
        {
            string query = $"SELECT COUNT(*) FROM LOGIN WHERE USERNAME = '{userName}' ";

            int count = MyDB.ExecuteScalar(query); // user đã tồn tại
            if (count > 0) return false;
            return true;
        }
        public static bool checkEmail (string email)
        {
            string query = $"SELECT COUNT(*) FROM LOGIN WHERE EMAIL = '{email}' ";

            int count = MyDB.ExecuteScalar(query);
            if (count > 0) return false; // email đã tồn tại
            return true;
        }
        #endregion
        public static bool UpdateStatus (DTO.Login_DTO login)
        {
            string email = login.Email;
            string querry = $"UPDATE LOGIN SET STATUS = '{login.Status}' WHERE EMAIL = '{email}'";
            return MyDB.ExecuteNonQuery(querry);
        }
        public static List<Login_DTO> GetLogin()
        {
            List<Login_DTO> myLogin = new List<Login_DTO>();
            DataTable dt = MyDB.GetDataTable("SELECT * FROM [LOGIN] ");
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string userName = dt.Rows[i][0].ToString();
                    string passWord = dt.Rows[i][1].ToString();
                    string email = dt.Rows[i][2].ToString();
                   // byte byteStatus = (byte)dt.Rows[i][3];
                    bool status = Convert.ToBoolean(dt.Rows[i][3]);
                    myLogin.Add(new Login_DTO(userName, passWord, email,status));
                }
                return myLogin;
            }
            return null;
        }
        public static bool DeleteLogin (string UserName)
        {
            string query = "DELETE FROM [LOGIN] WHERE USERNAME = '" + UserName +"'";
            return MyDB.ExecuteNonQuery(query);
        }
    }
}
