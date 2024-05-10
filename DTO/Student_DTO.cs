using System.Data;
using System.Reflection;

namespace DTO
{
    public class Student_DTO
    {
        private int studentId ;
        private string firstName = "";
        private string lastName = "";
        private DateTime birthDay ;
        private Gender_DTO gender;
        private string phone = "";
        private string address = "";
        private MemoryStream picture;
        private string department = "";
        private string email = ""; 
        public Student_DTO()
        {
        }
        public Student_DTO (int studentId, string firstName, string lastName)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
        }

        public Student_DTO(int studentId, string firstName, string lastName, DateTime birthDay, Gender_DTO gender, string phone, string address, MemoryStream picture, string department)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Gender = gender;
            Phone = phone;
            Address = address;
            Picture = picture;
            Department = department;
        }

        public Student_DTO(int studentId, string firstName, string lastName, DateTime birthDay, Gender_DTO gender, string phone, string address, MemoryStream picture, string department, string email)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Gender = gender;
            Phone = phone;
            Address = address;
            Picture = picture;
            Department = department;
            Email = email;
        }

        public Student_DTO(int studentId, string firstName, string lastName, DateTime birthDay, Gender_DTO gender, string phone, string address)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Gender = gender;
            Phone = phone;
            Address = address;
            //Picture = picture;
        }

        public Student_DTO(int studentId, string firstName, string lastName, DateTime birthDay, string email, MemoryStream picture,string address, string phone)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            BirthDay = birthDay;
            Email = email;
            Picture = picture  ;
            Address = address;
            Phone = phone;
        }

        public int StudentId { get => studentId; set => studentId = value; }
        public string FirstName { get => firstName; set => firstName = value.Trim(); }
        public string LastName { get => lastName; set => lastName = value.Trim(); }
        public DateTime BirthDay { get => birthDay; set => birthDay = value; }
        public Gender_DTO Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value.Trim(); }
        public string Address { get => address; set => address = value.Trim(); }
        public MemoryStream Picture { get => picture; set => picture = value; }
        public string Department { get => department; set => department = value.Trim(); }
        public string Email { get => email; set => email = value.Trim(); }

        public override string? ToString()
        {
            return this.firstName + this.lastName;
        }
    }
}