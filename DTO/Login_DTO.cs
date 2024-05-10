using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Login_DTO
    {
        private string userName; 
        private string password;
        private string email;
        private bool status;
        public Login_DTO(string password)
        {
            Password = password;
        }
        public Login_DTO(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
        public Login_DTO(string userName, string password,string email)
        {
            UserName = userName;
            Password = password;   
            Email = email;
        }
        public Login_DTO(string userName, string password, string email, bool status)
        {
            UserName = userName;
            Password = password;   
            Email = email;
            Status = status;
        }

        public string UserName { get => userName; set => userName = value; }
        public string Password
        {
            get => password;
            set
            {
                password = "";
                byte[] temp = ASCIIEncoding.ASCII.GetBytes(value);
                byte[] hasdata = new MD5CryptoServiceProvider().ComputeHash(temp);
                foreach (byte b in hasdata)
                {
                    this.password += b;
                }
            }
        }
        public string Email { get => email; set => email = value.Trim(); }
        public bool Status { get => status; set => status = value; }
    }
}
