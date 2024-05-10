using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class Login_BUL
    {
        public static bool ProcedToLogin(DTO.Login_DTO login)
        {
            return Login_DAL.ProcedToLogin(login);
        }

        public static bool InsertLogin(DTO.Login_DTO login)
        {
            return Login_DAL.InsertLogin(login);     
        }
        public static bool SendCodeConfirm (string email)
        {
            return Login_DAL.SendCodeConfirm(email);
        }
        public static bool ConfirmCode (string code)
        {
            return Login_DAL.ConFirmCode(code);
        }
        public static bool CheckEmail (string email)
        {
            return Login_DAL.checkEmail(email);
        }
        public static bool CheckUser (string user)
        {
            return Login_DAL.CheckUser(user);
        }
        public static bool UpdateLogin (DTO.Login_DTO login)
        {
            return Login_DAL.UpdateLogin(login);
        }
        public static bool UpdateStatus(DTO.Login_DTO login)
        {
            return DAL.Login_DAL.UpdateStatus(login);
        }
        public static List<Login_DTO> GetLogin()
        {
            return DAL.Login_DAL.GetLogin();
        }
        public static bool DeleteLogin(string UserName)
        {
            return DAL.Login_DAL.DeleteLogin(UserName);
        }
    }
}
