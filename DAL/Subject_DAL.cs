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
    public class Subject_DAL
    {
        public static bool InsertSubject (Subject_DTO newSubject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "INSERT INTO SUBJECT VALUES (@SUBJECTID, @NAME, @DESCRIBE, @SEMESTER, @STATUS)";
            sqlCommand.Parameters.AddWithValue("@SUBJECTID", newSubject.SubjectId);
            sqlCommand.Parameters.AddWithValue("@NAME", newSubject.Name);
            sqlCommand.Parameters.AddWithValue("@DESCRIBE", newSubject.Describe);
            sqlCommand.Parameters.AddWithValue("@SEMESTER", newSubject.Semester);
            sqlCommand.Parameters.AddWithValue("@STATUS",1);
            return MyDB.ExecuteNonQuery(sqlCommand);
        }
        private static List<Subject_DTO> getSubject (DataTable dt)
        {
            List<Subject_DTO> mySubject = new List<Subject_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string SubjectID = dt.Rows[i][0].ToString();
                string Name = dt.Rows[i][1].ToString();
                string Describe = dt.Rows[i][2].ToString();
                int Semester = Convert.ToInt32(dt.Rows[i][3].ToString());
                mySubject.Add(new Subject_DTO(SubjectID, Name, Describe, Semester));
            }
            return mySubject;
        }

        public static List<Subject_DTO> GetSubject ()
        {
            DataTable dt = MyDB.GetDataTable("SELECT * FROM SUBJECT WHERE STATUS = 1 ");
            return getSubject(dt);
        }
        public static List<Subject_DTO> GetSubject (int Semester)
        {
            DataTable dt = MyDB.GetDataTable($"SELECT * FROM SUBJECT WHERE SEMESTER = '{Semester}'" + " AND STATUS = 1");
            return getSubject (dt);
        }
        public static DataTable GetDataSubject ()
        {
            DataTable dt = MyDB.GetDataTable($"SELECT SubjectID, Name, Describe, Semester FROM SUBJECT WHERE STATUS = 1");
            return dt;
        }
        public static bool UpdateSubject(Subject_DTO newSubject)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "UPDATE SUBJECT SET NAME = @NAME, DESCRIBE = @DESCRIBE, SEMESTER = @SEMESTER WHERE SUBJECTID = @SUBJECTID";
            sqlCommand.Parameters.AddWithValue("@SUBJECTID", newSubject.SubjectId);
            sqlCommand.Parameters.AddWithValue("@NAME", newSubject.Name);
            sqlCommand.Parameters.AddWithValue("@DESCRIBE", newSubject.Describe);
            sqlCommand.Parameters.AddWithValue("@SEMESTER", newSubject.Semester);
            return MyDB.ExecuteNonQuery(sqlCommand);
        }

        public static bool DeleteSubject(string subjectId)
        {
            string query = "UPDATE SUBJECT SET STATUS = 0 WHERE SUBJECTID = " + subjectId;
            return MyDB.ExecuteNonQuery(query);
        }
        public static bool checkName (string name)
        {
            string query = $"SELECT COUNT(*) FROM SUBJECT WHERE NAME = N'{name}' AND STATUS = 1 ";

            int count = MyDB.ExecuteScalar(query); // user đã tồn tại
            if (count > 0) return false;
            return true;
        }
    }
}
