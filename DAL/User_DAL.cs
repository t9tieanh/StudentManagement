using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class User_DAL
    {
        private static List<User_DTO> GetUser (DataTable dt)
        {
            List<User_DTO> myUser = new List<User_DTO>();
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string UserID = dt.Rows[i][0].ToString();
                    string FullName = dt.Rows[i][1].ToString();
                    string UserName = dt.Rows[i][2].ToString();
                    string Password = dt.Rows[i][3].ToString();
                    byte[] pic = (byte[])dt.Rows[i][4];
                    MemoryStream picture = new MemoryStream(pic);
                    string Email = dt.Rows[i][5].ToString();
                    bool status = Convert.ToBoolean(dt.Rows[i][6].ToString());

                    myUser.Add(new User_DTO(UserID, FullName, UserName, Password, picture, Email, status));
                }
            }
            return myUser;
        }
        public static User_DTO GetUser(string idUser)
        {
            DataTable dt = MyDB.GetDataTable($"SELECT * FROM [USER] WHERE USERID = '{idUser}'");
            return GetUser(dt)[0];
        }
        public static List<User_DTO> GetUser()
        {
            DataTable dt = MyDB.GetDataTable($"SELECT * FROM [USER]");
            return GetUser(dt);
        }
        public static bool InsertUser (User_DTO newUser)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "INSERT INTO [USER] VALUES (@USERID, @FULLNAME, @USERNAME, @PASSWORD, @PICTURE, @EMAIL, @STATUS)";
            sqlCommand.Parameters.AddWithValue("@USERID", newUser.UserId);
            sqlCommand.Parameters.AddWithValue("@FULLNAME", newUser.FullName);
            sqlCommand.Parameters.AddWithValue("@USERNAME", newUser.UserName);
            sqlCommand.Parameters.AddWithValue("@PASSWORD", newUser.Password);
            sqlCommand.Parameters.Add("@PICTURE", SqlDbType.Image).Value = newUser.Picture.ToArray();
            sqlCommand.Parameters.AddWithValue("@EMAIL", newUser.Email);
            sqlCommand.Parameters.AddWithValue("@STATUS", 0);
            return MyDB.ExecuteNonQuery(sqlCommand);
        }
        public static bool UpdateStatus (User_DTO myUser)
        {
            string querry = $"UPDATE [USER] SET STATUS = '{myUser.Status}' WHERE USERID = '{myUser.UserId}'";
            return MyDB.ExecuteNonQuery(querry);
        }
        public static bool ChangePassword (User_DTO myUser)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "UPDATE [USER] SET PASSWORD = @PASSWORD WHERE USERID = @USERID";
            sqlCommand.Parameters.AddWithValue("@PASSWORD", myUser.Password);
            sqlCommand.Parameters.AddWithValue("@USERID", myUser.UserId);
            return MyDB.ExecuteNonQuery(sqlCommand);
        }
        public static bool UpdateUser (User_DTO myUser)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = $"UPDATE [USER] SET FULLNAME = @FULLNAME, PICTURE = @PICTURE, EMAIL = @EMAIL WHERE USERID = @USERID";
            sqlCommand.Parameters.AddWithValue("@USERID", myUser.UserId);
            sqlCommand.Parameters.AddWithValue("@FULLNAME", myUser.FullName);
            sqlCommand.Parameters.Add("@PICTURE", SqlDbType.Image).Value = myUser.Picture.ToArray();
            sqlCommand.Parameters.AddWithValue("@EMAIL", myUser.Email);
            return MyDB.ExecuteNonQuery(sqlCommand);
        }
        public static bool CheckEmail(string email)
        {
            string query = $"SELECT COUNT(*) FROM [USER] WHERE EMAIL = '{email}' ";

            int count = MyDB.ExecuteScalar(query);
            if (count > 0) return false; // email đã tồn tại
            return true;
        }
        public static User_DTO ProcedToLogin (DTO.User_DTO user)
        {
            string userName = user.UserName;
            string password = user.Password;

            string query = $"SELECT * FROM [USER] WHERE USERNAME = N'{userName}' AND PASSWORD = N'{password}' AND STATUS = 1";

            var userLst = GetUser(MyDB.GetDataTable(query));
            if (userLst.Count > 0)
            {
                return userLst.First();
            }
            return null;
        }
    }
}
