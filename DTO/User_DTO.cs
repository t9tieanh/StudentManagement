using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User_DTO
    {
        private string userId;
        private string fullName;
        private string userName;
        private string passWord;
        private MemoryStream picture = new MemoryStream ();
        private string email;
        private bool status;

        public User_DTO(string userId, string fullName, string userName, string passWord, MemoryStream picture, string email, bool bit)
        {
            UserId = userId;
            FullName = fullName;
            UserName = userName;
            Password = passWord;
            Picture = picture;
            Email = email;
            Status = bit;
        }
        public User_DTO ()
        {
        }
        public User_DTO(string userName, string passWord)
        {
            UserName = userName;
            Password = passWord;
        }
        public string UserId { get => userId; set => userId = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password
        {
            get => this.passWord;
            set
            {
                Login_DTO login = new Login_DTO(value);
                this.passWord = login.Password;
            }
        }
        public MemoryStream Picture { get => picture; set => picture = value; }
        public string Email { get => email; set => email = value; }
        public bool Status { get => status; set => status = value; }

        public override string? ToString()
        {
            return UserName + " - " + fullName;
        }
    }
}
