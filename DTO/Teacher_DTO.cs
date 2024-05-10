using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Teacher_DTO
    {
        private string teacherID;
        private string firstName; 
        private string lastName;
        private string phoneNumber;
        private string address;
        private MemoryStream picture;
        private string password;
        private Group_DTO group;

        public Teacher_DTO(string teacherID, string Name)
        {
            TeacherID = teacherID.Trim();
            FirstName = Name.Trim();
        }
        public Teacher_DTO() { }

        public Teacher_DTO(string teacherID, string firstName, string lastName, string phoneNumber, string address, MemoryStream picture, Group_DTO group)
        {
            TeacherID = teacherID;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Address = address;
            Picture = picture ;
            Group = group;
        }
        public Teacher_DTO(string teacherID, string firstName, string lastName, string phoneNumber, string address, MemoryStream picture, string password)
        {
            TeacherID = teacherID;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Address = address;
            Picture = picture;
            //
            Password = password;
        }
        public Teacher_DTO(string teacherID, string firstName, string lastName, string phoneNumber, string address, MemoryStream picture, string password,Group_DTO group)
        {
            TeacherID = teacherID;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Address = address;
            Picture = picture;
            //
            Password = password;
            Group = group;
        }

        public string TeacherID { get => teacherID; set => teacherID = value.Trim(); }
        public string FirstName { get => firstName; set => firstName = value.Trim(); }
        public string LastName { get => lastName; set => lastName = value.Trim(); }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value.Trim(); }
        public string Address { get => address; set => address = value.Trim(); }
        public MemoryStream Picture { get => picture; set => picture = value; }
        public string Password { get => password; 
            set {
                Login_DTO login = new Login_DTO(value);
                password = login.Password; 
            }
        }

        public Group_DTO Group { get => group; set => group = value; }

        public override string? ToString()
        {
            return firstName + " " +lastName;
        }
    }
}
