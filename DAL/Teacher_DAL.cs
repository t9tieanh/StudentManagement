using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DAL
{
    public class Teacher_DAL
    {
        public static bool InsertTeacher(Teacher_DTO newTeacher)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "INSERT INTO TEACHER VALUES (@TEACHERID, @FIRSTNAME, @LASTNAME, @PHONE, @ADDRESS, @PICTURE, @STATUS, @PASSWORD, @GROUPID)";
            sqlCommand.Parameters.AddWithValue("@TEACHERID", newTeacher.TeacherID);
            sqlCommand.Parameters.AddWithValue("@FIRSTNAME", newTeacher.FirstName);
            sqlCommand.Parameters.AddWithValue("@LASTNAME", newTeacher.LastName);
            sqlCommand.Parameters.AddWithValue("@PHONE", newTeacher.PhoneNumber);
            sqlCommand.Parameters.AddWithValue("@ADDRESS", newTeacher.Address);
            sqlCommand.Parameters.AddWithValue("@STATUS", 1);
            sqlCommand.Parameters.AddWithValue("@PASSWORD", newTeacher.Password);
            if (newTeacher.Group != null)
                sqlCommand.Parameters.AddWithValue("@GROUPID", newTeacher.Group.GroupId);
            else
                sqlCommand.Parameters.AddWithValue("@GROUPID", DBNull.Value);
            sqlCommand.Parameters.Add("@PICTURE", SqlDbType.Image).Value = newTeacher.Picture.ToArray();
            return MyDB.ExecuteNonQuery(sqlCommand);
        }

        private static List<Teacher_DTO> GetTeacher(DataTable dt)
        {
            List<Teacher_DTO> myTeacher = new List<Teacher_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string StudentID = dt.Rows[i][0].ToString();
                string FirstName = dt.Rows[i][1].ToString();
                string LastName = dt.Rows[i][2].ToString();
                string Phone = dt.Rows[i][3].ToString();
                string Address = dt.Rows[i][4].ToString();
                byte[] pic = (byte[])dt.Rows[i][5];
                MemoryStream picture = new MemoryStream(pic);

                string idGroup = dt.Rows[i][8].ToString();
                Group_DTO myGroup = null;
                if (idGroup.Trim() != "")
                    myGroup = Group_DAL.GetGroup(idGroup);

                myTeacher.Add(new Teacher_DTO(StudentID, FirstName, LastName, Phone, Address, picture,myGroup));
            }
            return myTeacher;
        }
        public static List<Teacher_DTO> GetTeacher()
        {
            DataTable dt = MyDB.GetDataTable("SELECT * FROM TEACHER WHERE STATUS = 1 ");
            return GetTeacher (dt);
        }
        public static Teacher_DTO GetTeacher (string idTeacher)
        {
            DataTable dt = MyDB.GetDataTable($"SELECT * FROM TEACHER WHERE TEACHERID = '{idTeacher}' AND  STATUS = 1 ");
            if (dt.Rows.Count == 0) 
                return null;
            return GetTeacher(dt)[0];
        }
        public static List <Teacher_DTO> GetTeacher (Group_DTO myGroup)
        {
            DataTable dt = MyDB.GetDataTable($"SELECT * FROM TEACHER WHERE GROUPID = '{myGroup.GroupId}'");
            return GetTeacher(dt);
        }
        public static DataTable GetDataTeacher()
        {
            return MyDB.GetDataTable("SELECT TeacherID, FirstName, LastName, Phone, Address, Picture FROM TEACHER WHERE STATUS = 1 ");
        }

        public static List<Teacher_DTO> GetTeacher(string field, string value)
        {
            DataTable dt = MyDB.GetDataTable($"SELECT * FROM TEACHER WHERE {field} LIKE '%{value}%' AND STATUS = 1");
            return GetTeacher(dt);
        }
        public static bool UpdateTeacher(Teacher_DTO newTeacher)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "UPDATE TEACHER SET FIRSTNAME = @FIRSTNAME, LASTNAME = @LASTNAME, PHONE = @PHONE, ADDRESS = @ADDRESS, PICTURE = @PICTURE, GROUPID = @GROUPID WHERE TEACHERID = @TEACHERID";
            sqlCommand.Parameters.AddWithValue("@FIRSTNAME", newTeacher.FirstName);
            sqlCommand.Parameters.AddWithValue("@LASTNAME", newTeacher.LastName);
            sqlCommand.Parameters.AddWithValue("@PHONE", newTeacher.PhoneNumber);
            sqlCommand.Parameters.AddWithValue("@ADDRESS", newTeacher.Address);
            sqlCommand.Parameters.AddWithValue("@TEACHERID", newTeacher.TeacherID);
            if (newTeacher.Group != null)
                sqlCommand.Parameters.AddWithValue("@GROUPID", newTeacher.Group.GroupId);
            else
                sqlCommand.Parameters.AddWithValue("@GROUPID", DBNull.Value);
            sqlCommand.Parameters.Add("@PICTURE", SqlDbType.Image).Value = newTeacher.Picture.ToArray();
            return MyDB.ExecuteNonQuery(sqlCommand);
        }

        public static bool ChangePassword(Teacher_DTO newTeacher)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "UPDATE TEACHER SET PASSWORD = @PASSWORD WHERE TEACHERID = @TEACHERID";
            sqlCommand.Parameters.AddWithValue("@PASSWORD", newTeacher.Password);
            sqlCommand.Parameters.AddWithValue("@TEACHERID", newTeacher.TeacherID);
            return MyDB.ExecuteNonQuery(sqlCommand);
        }

        public static bool DeleteTeacher(string subjectId)
        {
            string query = "UPDATE TEACHER SET STATUS = 0 WHERE TEACHERID = " + subjectId;
            return MyDB.ExecuteNonQuery(query);
        }

        /// <summary>
        /// đăng nhập 
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public static Teacher_DTO ProcedToLogin (Teacher_DTO teacher)
        {
            string userName = teacher.TeacherID;
            string password = teacher.Password;
            DataTable dt = MyDB.GetDataTable($"SELECT * FROM TEACHER WHERE TEACHERID = '{userName}' AND PASSWORD = '{password}'");
            var teachers = GetTeacher(dt);
            if (teachers.Count > 0)
            {
                return teachers.First();
            }
            return null;
        }
        public static bool SetNullGroupTeacher (Group_DTO group)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "UPDATE TEACHER SET GROUPID = @VALUE WHERE GROUPID = @GROUPID";
            sqlCommand.Parameters.AddWithValue("@VALUE", DBNull.Value);
            sqlCommand.Parameters.AddWithValue("@GROUPID", group.GroupId);
            return MyDB.ExecuteNonQuery(sqlCommand);
        }
    }
}
