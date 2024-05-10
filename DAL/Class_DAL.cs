using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAL
{
    public class Class_DAL
    {
        /// <summary>
        /// dành cho teacher
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public static List<Class_DTO> GetClass(Teacher_DTO teacher)
        {
            DataTable dt;
            string querry =
                "SELECT Class.ClassID, Class.ClassName, Teacher.TeacherID , Teacher.FirstName , Teacher.LastName,[Subject].SubjectID, [Subject].Name, Teacher.Picture, Class.Year " +
                "FROM Class,[Subject],Teacher  " +
                "WHERE Class.SubjectID = [Subject].SubjectID AND Class.TeacherID = Teacher.TeacherID AND Class.Status = 1" +
                " AND " +  "TEACHER.TEACHERID = N'" + teacher.TeacherID + "'";
            dt = MyDB.GetDataTable(querry);
            return GetClass(dt);
        }
        public static DataTable GetDataClass(Teacher_DTO teacher)
        {
            return MyDB.GetDataTable("SELECT Class.ClassID, Class.ClassName, Teacher.FirstName AS 'FNTeacher' , Teacher.LastName AS 'LNTeacher', [Subject].Name, Teacher.Picture, Class.Year " +
                "FROM Class,[Subject],Teacher  " +
                $"WHERE Class.SubjectID = [Subject].SubjectID AND Class.TeacherID = Teacher.TeacherID AND Class.Status = 1 AND Class.TeacherID = '{teacher.TeacherID}'");
        }
        public static List<Class_DTO> GetClass(string field, string value, string tableName)
        {
            DataTable dt;
            string querry =
                "SELECT Class.ClassID, Class.ClassName, Teacher.TeacherID , Teacher.FirstName , Teacher.LastName,[Subject].SubjectID, [Subject].Name, Teacher.Picture, Class.Year " +
                "FROM Class,[Subject],Teacher  " +
                "WHERE Class.SubjectID = [Subject].SubjectID AND Class.TeacherID = Teacher.TeacherID AND Class.Status = 1" +
                " AND " + tableName +"."+field + " LIKE N'%" + value + "%'";
            dt = MyDB.GetDataTable(querry);
            return GetClass (dt);
        }
        private static List<Class_DTO> GetClass(DataTable dt)
        {
            List<Class_DTO> myClass = new List<Class_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string classID = dt.Rows[i][0].ToString();
                string className = dt.Rows[i][1].ToString();

                string teacherID = dt.Rows[i][2].ToString();
                string teacherName = dt.Rows[i][3].ToString();
                teacherName += " " + dt.Rows[i][4].ToString();

                string subjectID = dt.Rows[i][5].ToString();
                string subjectName = dt.Rows[i][6].ToString();

                byte[] pic = (byte[])dt.Rows[i][7];
                MemoryStream picture = new MemoryStream(pic);

                int year = Convert.ToInt32(dt.Rows[i][8].ToString());

                myClass.Add(new Class_DTO(classID, className, picture, year, teacherName, subjectName, teacherID, subjectID));
            }
            return myClass;
        }
        public static List<Class_DTO> GetClass ()
        {
            DataTable dt = MyDB.GetDataTable("SELECT Class.ClassID, Class.ClassName, Teacher.TeacherID , Teacher.FirstName , Teacher.LastName,[Subject].SubjectID, [Subject].Name, Teacher.Picture, Class.Year " +
                "FROM Class,[Subject],Teacher  " +
                "WHERE Class.SubjectID = [Subject].SubjectID AND Class.TeacherID = Teacher.TeacherID AND Class.Status = 1");
            return GetClass(dt);
        }
        public static DataTable GetDataClass()
        {
            return ( MyDB.GetDataTable("SELECT Class.ClassID, Class.ClassName, Teacher.FirstName AS 'FNTeacher' , Teacher.LastName AS 'LNTeacher', [Subject].Name, Teacher.Picture, Class.Year " +
                "FROM Class,[Subject],Teacher  " +
                "WHERE Class.SubjectID = [Subject].SubjectID AND Class.TeacherID = Teacher.TeacherID AND Class.Status = 1"));
        }
        public static bool InsertClass (Class_DTO newClass)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "INSERT INTO CLASS VALUES (@CLASSID, @CLASSNAME, @TEACHERID, @SUBJECTID, @YEAR, @STATUS)";
            sqlCommand.Parameters.AddWithValue("@CLASSID", newClass.ClassID);
            sqlCommand.Parameters.AddWithValue("@CLASSNAME", newClass.ClassName);
            sqlCommand.Parameters.AddWithValue("@TEACHERID", newClass.TeacherId);
            sqlCommand.Parameters.AddWithValue("@SUBJECTID", newClass.SubjectId);
            sqlCommand.Parameters.AddWithValue("@YEAR", newClass.Year);
            sqlCommand.Parameters.AddWithValue("@STATUS", 1);

            return MyDB.ExecuteNonQuery(sqlCommand);
        }
        public static bool UpdateClass (Class_DTO newClass)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "UPDATE CLASS SET CLASSNAME = @CLASSNAME, TEACHERID = @TEACHERID, SUBJECTID = @SUBJECTID, YEAR = @YEAR WHERE CLASSID = @CLASSID";
            sqlCommand.Parameters.AddWithValue("@CLASSID", newClass.ClassID); ;
            sqlCommand.Parameters.AddWithValue("@CLASSNAME", newClass.ClassName);
            sqlCommand.Parameters.AddWithValue("@TEACHERID", newClass.TeacherId);
            sqlCommand.Parameters.AddWithValue("@SUBJECTID", newClass.SubjectId);
            sqlCommand.Parameters.AddWithValue("@YEAR", newClass.Year.ToString());
            return MyDB.ExecuteNonQuery(sqlCommand);
        }
        public static bool DeleteClass (string ClassID)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "UPDATE CLASS SET STATUS = 0 WHERE ClassID = @CLASSID";
            sqlCommand.Parameters.AddWithValue("@CLASSID", ClassID); ;
            return MyDB.ExecuteNonQuery(sqlCommand);
        }
        public static bool InsertStudentToClass (string StudentId, Class_DTO myClass)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "INSERT INTO CLASSJOIN VALUES (@STUDENTID, @CLASSID, NULL , NULL)";
            sqlCommand.Parameters.AddWithValue("@CLASSID", myClass.ClassID);
            sqlCommand.Parameters.AddWithValue("@STUDENTID", StudentId);
            return MyDB.ExecuteNonQuery(sqlCommand);
        }
        public static bool CheckName (string name)
        {
            string query = $"SELECT COUNT(*) FROM CLASS WHERE CLASSNAME = N'{name}' AND STATUS = 1 ";

            int count = MyDB.ExecuteScalar(query); // user đã tồn tại
            if (count > 0) return false; // FALSE -> đã tồn tại 
            return true;
        }
        public static bool CheckJoinClass (string StudentId, Class_DTO myClass)
        {
            string query = $"SELECT COUNT(*) FROM CLASSJOIN WHERE StudentId = N'{StudentId}' AND CLASSID = '"+myClass.ClassID+ "'";
            int count = MyDB.ExecuteScalar(query); // user đã tồn tại
            if (count > 0) return false; // FALSE -> đã tồn tại 
            return true;
        }
        public static DataTable GetStudent (Class_DTO myClass)
        {
            return MyDB.GetDataTable("SELECT Student.StudentId, FirstName, LastName, Picture, Score, Comment FROM Student, CLASSJOIN WHERE ClassId = '"+myClass.ClassID+"' AND Student.StudentId = CLASSJOIN.StudentId");
        }
        public static bool DeleteJoinClass(string StudentId, Class_DTO myClass)
        {
            string query = $"DELETE FROM CLASSJOIN WHERE STUDENTID = '{StudentId}' AND CLASSID = '{myClass.ClassID}'";
            return MyDB.ExecuteNonQuery(query);
        }
        
        /// <summary>
        /// update score cho class join
        /// </summary>
        /// <param name="StudentId"></param>
        /// <param name="myClass"></param>
        /// <param name="score"></param>
        /// <param name="comment"></param>
        /// <returns></returns>
        public static bool UpdateScore (string StudentId,Class_DTO myClass, int score, string comment)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.CommandText = "UPDATE CLASSJOIN SET SCORE = @SCORE, COMMENT = @COMMENT WHERE STUDENTID = @STUDENTID AND CLASSID = @CLASSID";
                sqlCommand.Parameters.AddWithValue("@CLASSID", myClass.ClassID);
                sqlCommand.Parameters.AddWithValue("@STUDENTID", StudentId);
                sqlCommand.Parameters.AddWithValue("@SCORE", score);
                sqlCommand.Parameters.AddWithValue("@COMMENT", comment);
                return MyDB.ExecuteNonQuery(sqlCommand);
            }
            catch { return false; }
        }
        /// lấy những class của 1 sinh viên nào đó đăng kí 
        public static DataTable GetClassStudent (string studentID)
        {
            string querry = "SELECT Class.ClassID, Class.ClassName, Subject.Name, Teacher.FirstName, Teacher.LastName, Class.Year  " +
                "FROM STUDENT, CLASSJOIN ,Class ,Subject,Teacher " +
                "WHERE STUDENT.STUDENTID = CLASSJOIN.STUDENTID AND CLASSJOIN.ClassId = Class.ClassID " +
                "AND Class.SubjectID = Subject.SubjectID AND CLASS.TeacherID = Teacher.TeacherID " +
                $"AND Student.StudentId = N'{studentID}'";
            return (MyDB.GetDataTable(querry));
        }
        public static DataTable GetClassStudentCanRegister (string studentID)
        {
            string querry = "SELECT Class.ClassID, Class.ClassName, Subject.Name, Teacher.FirstName, Teacher.LastName, Class.Year  " +
                " FROM Class,Subject,Teacher " +
                "WHERE ClassID != ALL " +
                "(SELECT CLASSJOIN.ClassId " +
                "FROM CLASSJOIN " +
                $"WHERE CLASSJOIN.StudentId = '{studentID}') AND Class.Status = 1 AND CLASS.SUBJECTID = SUBJECT.SUBJECTID AND CLASS.TEACHERID = TEACHER.TEACHERID";
            return (MyDB.GetDataTable(querry));
        }
        // code cho phần thống kê (lấy điểm của mỗi lớp)
        public static DataTable ScoreClass (string ClassId)
        {
            string query = "SELECT CLASSJOIN.Score " +
                "FROM CLASSJOIN " +
                $"WHERE ClassId = '{ClassId}' AND CLASSJOIN.Score IS NOT NULL ";
            return MyDB.GetDataTable(query);
        }
    }
}
