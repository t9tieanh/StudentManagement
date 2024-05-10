using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class Class_BUL
    {
        public static List<Class_DTO> GetClass()
        {
            return DAL.Class_DAL.GetClass();
        }
        public static DataTable GetDataClass()
        {
            return DAL.Class_DAL.GetDataClass();
        }
        public static bool InsertClass (Class_DTO newClass)
        {
            return DAL.Class_DAL.InsertClass(newClass);
        }
        public static List<Class_DTO> GetClass(string field, string value, string tableName)
        {
            return DAL.Class_DAL.GetClass(field, value, tableName);
        }
        public static bool InsertStudentToClass(string StudentId, Class_DTO myClass)
        {
            return DAL.Class_DAL.InsertStudentToClass (StudentId, myClass);
        }
        public static bool CheckName(string name)
        {
            return DAL.Class_DAL.CheckName (name);
        }
        public static bool UpdateClass(Class_DTO newClass)
        {
            return DAL.Class_DAL.UpdateClass (newClass);
        }
        public static bool DeleteClass(string ClassID)
        {
            return DAL.Class_DAL.DeleteClass (ClassID);
        }
        public static bool CheckJoinClass(string StudentId, Class_DTO myClass)
        {
            return DAL.Class_DAL.CheckJoinClass (StudentId, myClass);
        }
        public static DataTable GetStudent(Class_DTO myClass)
        {
            return DAL.Class_DAL.GetStudent(myClass);
        }
        /// <summary>
        /// dành riêng cho teacher
        /// </summary>
        /// <param name="teacher"></param>
        /// <returns></returns>
        public static List<Class_DTO> GetClass(Teacher_DTO teacher)
        {
            return DAL.Class_DAL.GetClass(teacher);
        }
        public static DataTable GetDataClass(Teacher_DTO teacher)
        {
            return DAL.Class_DAL.GetDataClass(teacher);
        }
        /// <summary>
        /// xóa sinh viên trong lớp 
        /// </summary>
        /// <param name="StudentId"></param>
        /// <param name="myClass"></param>
        /// <returns></returns>
        public static bool DeleteJoinClass(string StudentId, Class_DTO myClass)
        {
            return DAL.Class_DAL.DeleteJoinClass (StudentId, myClass);
        }
        /// <summary>
        /// update cho score classjoin
        /// </summary>
        /// <param name="StudentId"></param>
        /// <param name="myClass"></param>
        /// <param name="score"></param>
        /// <param name="comment"></param>
        /// <returns></returns>
        public static bool UpdateScore(string StudentId, Class_DTO myClass, int score, string comment)
        {
            return Class_DAL.UpdateScore (StudentId, myClass, score, comment);
        }
        /// lấy những class của 1 sinh viên nào đó đăng kí 
        public static DataTable GetClassStudent(string studentID)
        {
            return DAL.Class_DAL.GetClassStudent (studentID);
        }
        public static DataTable GetClassStudentCanRegister(string studentID)
        {
            return DAL.Class_DAL.GetClassStudentCanRegister (studentID);
        }
        public static DataTable ScoreClass(string ClassId)
        {
            return DAL.Class_DAL.ScoreClass(ClassId); 
        }
    }
}
