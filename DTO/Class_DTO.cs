using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Class_DTO
    {
        private string classID;
        private string className;
        private string teacherName;
        private string subjectName;
        private int year;
        private MemoryStream teacherPicture;
        private string teacherId;
        private string subjectId;

        public Class_DTO (string classID, string className, MemoryStream teacherPicture, int year, string teacherName, string subjectName, string teacherID, string subjectID)
        {
            ClassID = classID.Trim();
            ClassName = className.Trim();
            TeacherPicture = teacherPicture;
            Year = year;
            TeacherName = teacherName.Trim();
            SubjectName = subjectName.Trim();
            TeacherId = teacherID.Trim();
            SubjectId = subjectID.Trim();
        }
        public Class_DTO (string classID, string className, int year, string teacherID, string subjectID)
        {
            ClassID = classID.Trim();
            ClassName = className.Trim();
            Year = year;
            TeacherId = teacherID.Trim(); 
            SubjectId = subjectID.Trim();
        }

        public Class_DTO(string classID)
        {
            ClassID = classID;
        }

        public string ClassID { get => classID; set => classID = value.Trim(); }
        public string ClassName { get => className; set => className = value.Trim(); }
        public MemoryStream TeacherPicture { get => teacherPicture; set => teacherPicture = value; }
        public string TeacherName { get => teacherName; set => teacherName = value.Trim(); }
        public string SubjectName { get => subjectName; set => subjectName = value.Trim(); }
        public int Year { get => year; set => year = value; }
        public string TeacherId { get => teacherId; set => teacherId = value.Trim(); }
        public string SubjectId { get => subjectId; set => subjectId = value.Trim(); }

        public override string? ToString()
        {
            return ClassName + " ";
        }
    }
}
