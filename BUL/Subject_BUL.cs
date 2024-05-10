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
    public class Subject_BUL
    {
        public static bool InsertSubject (Subject_DTO newSubject)
        {
            return DAL.Subject_DAL.InsertSubject (newSubject);
        }
        public static List<Subject_DTO> GetSubject()
        {
            return DAL.Subject_DAL.GetSubject();
        }
        public static bool UpdateSubject(Subject_DTO newSubject)
        {
            return DAL.Subject_DAL.UpdateSubject (newSubject);
        }
        public static bool DeleteSubject(string subjectId)
        {
            return Subject_DAL.DeleteSubject(subjectId);
        }
        public static List<Subject_DTO> GetSubject(int Semester)
        {
            return Subject_DAL.GetSubject (Semester);
        }
        public static DataTable GetDataSubject()
        {
            return Subject_DAL.GetDataSubject();
        }
        public static bool checkName(string name)
        {
            return Subject_DAL.checkName(name);
        }
    }
}
