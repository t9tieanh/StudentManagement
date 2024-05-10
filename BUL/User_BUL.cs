using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class User_BUL
    {
        public static User_DTO GetUser(string idUser)
        {
            return User_DAL.GetUser(idUser);
        }
        public static List<User_DTO> GetUser()
        {
            return User_DAL.GetUser();
        }
        public static bool InsertUser(User_DTO newUser)
        {
            return User_DAL.InsertUser(newUser);
        }
        public static bool CheckEmail(string email)
        {
            return User_DAL.CheckEmail(email);
        }
        public static User_DTO ProcedToLogin(User_DTO user)
        {
            return User_DAL.ProcedToLogin(user);
        }
        public static bool UpdateStatus(User_DTO myUser)
        {
            return User_DAL.UpdateStatus(myUser);
        }
        public static bool UpdateUser(User_DTO myUser)
        {
            return DAL.User_DAL.UpdateUser(myUser); 
        }
        public static bool ChangePassword(User_DTO myUser)
        {
            return User_DAL.ChangePassword(myUser);
        }
    }
}
