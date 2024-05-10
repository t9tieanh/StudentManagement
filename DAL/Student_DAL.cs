using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Student_DAL
    {
        public static DataTable GetStudent()
        {
            return MyDB.GetDataTable("SELECT * FROM STUDENT");
        }
        public static Student_DTO FindStudent (string value)
        {
            DataTable dt = MyDB.GetDataTable("SELECT * FROM STUDENT WHERE STUDENTID LIKE N'%" + value + "%' ");

            if (dt.Rows.Count > 0)
            {
                int i = 0;
                int studentId = Convert.ToInt32(dt.Rows[i][0]);
                string name = dt.Rows[i][1].ToString();
                string address = dt.Rows[i][2].ToString();
                DateTime birthDate = (DateTime)dt.Rows[i][3];
                Gender_DTO gender = (Gender_DTO)1; // Replace with the appropriate way to get the gender from DataTable
                string field5 = dt.Rows[i][5].ToString();
                string field6 = dt.Rows[i][6].ToString();
                byte[] pic = (byte[])dt.Rows[i][7];
                MemoryStream picture = new MemoryStream(pic);
                string department = dt.Rows[i][8].ToString();
                return new Student_DTO(studentId, name, address, birthDate, gender, field5, field6, picture, department);
            }
            else
            {
                return null;
            }
        }
        public static DataTable FindStudent(string field, string value)
        {
            return MyDB.GetDataTable("SELECT * FROM STUDENT WHERE " + field + " LIKE N'%" + value + "%' ");
        }
        public static bool InsertStudent(Student_DTO newStudent)
        {
            /*int studentId = newStudent.StudentId;
            string firstName = newStudent.FirstName;
            string lastName = newStudent.LastName;
            DateTime birthDay = newStudent.BirthDay;
            Gender_DTO gender = newStudent.Gender;
            string phone = newStudent.Phone;
            string address = newStudent.Address;
            byte[] picture = newStudent.Picture.ToArray();
            string department = newStudent.Department;

            string query = $"INSERT INTO STUDENT VALUES ('{studentId}', '{firstName}', '{lastName}', '{birthDay.ToString("yyyy-MM-dd")}', {(int)gender}, '{phone}', '{address}', '{picture}', '{department}')";
            return MyDB.ExecuteNonQuery(query);
*/
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "INSERT INTO STUDENT VALUES (@STUDENTID, @FIRSTNAME, @LASTNAME, @BIRTHDAY, @GENDER, @PHONE, @ADDRESS , @PICTURE , @DEPARTMENT , @Email)";

            sqlCommand.Parameters.AddWithValue("@STUDENTID", newStudent.StudentId);
            sqlCommand.Parameters.AddWithValue("@FIRSTNAME", newStudent.FirstName);
            sqlCommand.Parameters.AddWithValue("@LASTNAME", newStudent.LastName);
            sqlCommand.Parameters.AddWithValue("@BIRTHDAY", newStudent.BirthDay.ToString("yyyy-MM-dd"));
            sqlCommand.Parameters.AddWithValue("@GENDER", (int)newStudent.Gender);
            sqlCommand.Parameters.AddWithValue("@PHONE", newStudent.Phone);
            sqlCommand.Parameters.AddWithValue("@ADDRESS", newStudent.Address);
            sqlCommand.Parameters.Add("@PICTURE", SqlDbType.Image).Value = newStudent.Picture.ToArray();
            sqlCommand.Parameters.AddWithValue("@DEPARTMENT", newStudent.Department);
            sqlCommand.Parameters.AddWithValue("@Email", newStudent.Email);

            return MyDB.ExecuteNonQuery(sqlCommand);
        }
        public static bool UpdateStudent(Student_DTO newStudent)
        {
            /*int studentId = newStudent.StudentId;
            string firstName = newStudent.FirstName;
            string lastName = newStudent.LastName;
            DateTime birthDay = newStudent.BirthDay;
            Gender_DTO gender = newStudent.Gender;
            string phone = newStudent.Phone;
            string address = newStudent.Address;
            byte[] picture = newStudent.Picture.ToArray();
            string department = newStudent.Department;

            string query =  "UPDATE STUDENT SET " +
                           $"FIRSTNAME = '{firstName}', " +
                           $"LASTNAME = '{lastName}', " +
                           $"BIRTHDAY = '{birthDay}', " +
                           $"GENDER = '{(int)gender}', " +
                           $"PHONE = '{phone}', " +
                           $"ADDRESS = '{address}', " +
                           $"PICTURE = '{picture}', " +
                           $"DEPARTMENT = '{department}' " +
                           $"WHERE STUDENTID = '{studentId}'";*/
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "UPDATE STUDENT SET FIRSTNAME = @FIRSTNAME, LASTNAME = @LASTNAME, BIRTHDAY = @BIRTHDAY, GENDER = @GENDER, PHONE = @PHONE, ADDRESS = @ADDRESS ,PICTURE =  @PICTURE ,DEPARTMENT = @DEPARTMENT, EMAIL = @EMAIL WHERE STUDENTID = @STUDENTID";
            sqlCommand.Parameters.AddWithValue("@STUDENTID", newStudent.StudentId);
            sqlCommand.Parameters.AddWithValue("@FIRSTNAME", newStudent.FirstName);
            sqlCommand.Parameters.AddWithValue("@LASTNAME", newStudent.LastName);
            sqlCommand.Parameters.AddWithValue("@BIRTHDAY", newStudent.BirthDay.ToString("yyyy-MM-dd"));
            sqlCommand.Parameters.AddWithValue("@GENDER", (int)newStudent.Gender);
            sqlCommand.Parameters.AddWithValue("@PHONE", newStudent.Phone);
            sqlCommand.Parameters.AddWithValue("@ADDRESS", newStudent.Address);
            sqlCommand.Parameters.Add("@PICTURE", SqlDbType.Image).Value = newStudent.Picture.ToArray();
            sqlCommand.Parameters.AddWithValue("@DEPARTMENT", newStudent.Department);
            sqlCommand.Parameters.AddWithValue("@EMAIL", newStudent.Email);
            return MyDB.ExecuteNonQuery(sqlCommand);
        }
        public static bool DeleteStudent(string studentId)
        {
            string query = "DELETE FROM CLASSJOIN WHERE STUDENTID = " + studentId;
            if (!MyDB.ExecuteNonQuery(query)) return false;
            query = "DELETE FROM STUDENT WHERE STUDENTID = " + studentId ;
            return MyDB.ExecuteNonQuery(query);
        }
        #region dành cho thống kê 
        public static int StudentScore (string department, int startScore , int endScore)
        {
            string query = "SELECT COUNT (*) " +
                "FROM (SELECT Student.StudentId " +
                        "FROM Student, CLASSJOIN " +
                        $"WHERE Student.StudentId = CLASSJOIN.StudentId AND Student.Department = N'{department}' " +
                        " GROUP BY Student.StudentId " +
                        $" HAVING AVG (Score) BETWEEN {startScore} AND {endScore}) A"; 
            return MyDB.ExecuteScalar(query);
        }
        public static int StudentTotal(string department)
        {
            string query = $"SELECT COUNT (*) FROM STUDENT WHERE Department = N'{department}'";
            return MyDB.ExecuteScalar(query);
        }
        public static int StudentTotalSex(string department, int sex)
        {
            string query = $"SELECT COUNT (*) FROM STUDENT WHERE Department = N'{department}' AND GENDER = '{sex}'";
            return MyDB.ExecuteScalar(query);
        }
        #endregion 
    }
}
