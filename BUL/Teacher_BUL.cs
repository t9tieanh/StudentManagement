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
    public class Teacher_BUL
    {
        public static List<Teacher_DTO> GetTeacher()
        {
            return DAL.Teacher_DAL.GetTeacher();
        }
        public static List<Teacher_DTO> GetTeacher(string field , string value)
        {
            return DAL.Teacher_DAL.GetTeacher(field,value);
        }
        public static bool InsertTeacher (Teacher_DTO newTeacher)
        {
            return DAL.Teacher_DAL.InsertTeacher(newTeacher);
        }
        public static DataTable GetDataTeacher()
        {
            return DAL.Teacher_DAL.GetDataTeacher();
        }
        public static bool DeleteTeacher (string subjectId)
        {
            return DAL.Teacher_DAL.DeleteTeacher(subjectId);
        }
        public static bool UpdateTeacher(Teacher_DTO newTeacher)
        {
            return DAL.Teacher_DAL.UpdateTeacher (newTeacher);
        }
        public static bool ChangePassword(Teacher_DTO newTeacher)
        {
            return DAL.Teacher_DAL.ChangePassword (newTeacher);
        }
        public static Teacher_DTO ProcedToLogin(Teacher_DTO teacher)
        {
            return Teacher_DAL.ProcedToLogin(teacher);
        }
        public static List<Teacher_DTO> GetTeacher(Group_DTO myGroup)
        {
            return Teacher_DAL.GetTeacher(myGroup);
        }
        public static Teacher_DTO GetTeacher(string idTeacher)
        {
            return Teacher_DAL.GetTeacher (idTeacher);
        }
    }
}
