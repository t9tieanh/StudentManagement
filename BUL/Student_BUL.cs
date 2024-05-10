using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace BUL
{
    public class Student_BUL
    {
        public static DataTable GetStudent()
        {
            return Student_DAL.GetStudent();
        }
        public static Student_DTO FindStudent(string ID)
        {
            return Student_DAL.FindStudent(ID);
        }
        public static bool InsertStudent(Student_DTO newStudent)
        {
            return Student_DAL.InsertStudent(newStudent);
        }
        public static bool UpdateStudent(Student_DTO newStudent)
        {
            return Student_DAL.UpdateStudent(newStudent);
        }
        public static bool DeleteStudent(string studentId)
        {
            return Student_DAL.DeleteStudent(studentId);
        }
        public static DataTable FindStudent(string field, string value)
        {
            return Student_DAL.FindStudent(field,value) ;
        }
        public static int StudentScore (string department, int StartScore, int EndScore)
        {
            return Student_DAL.StudentScore(department,StartScore,EndScore);
        }
        public static int StudentTotal(string department)
        {
            return DAL.Student_DAL.StudentTotal(department);
        }
        public static int StudentTotalSex(string department, int sex)
        {
            return DAL.Student_DAL.StudentTotalSex(department,sex);
        }
    }
}
