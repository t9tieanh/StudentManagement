using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Subject_DTO
    {
        private string subjectId;
        private string name;
        private string describe;
        private int semester; // học kì 

        public Subject_DTO(string subjectId, string name, string describe)
        {
            SubjectId = subjectId;
            Name = name;
            Describe = describe;
        }
        public Subject_DTO(string subjectId, string name)
        {
            SubjectId = subjectId;
            Name = name;
        }
        public Subject_DTO(string subjectId, string name, string describe, int Semester)
        {
            SubjectId = subjectId;
            Name = name;
            Describe = describe;
            this.Semester = Semester;
        }
        public Subject_DTO() { }

        public string SubjectId { get => subjectId; set => subjectId = value.Trim(); }
        public string Name { get => name; set => name = value.Trim(); }
        public string Describe { get => describe; set => describe = value.Trim(); }
        public int Semester { get => semester; set => semester = value; }

        public override string? ToString()
        {
            return subjectId + " " + Name ;
        }
    }
}
