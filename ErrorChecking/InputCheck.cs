using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ErrorChecking
{
    public class InputCheck
    {
        /// <summary>
        /// check phoneNumber
        /// </summary>
        /// <param name="phoneNumber"></param>
        /// <returns></returns>
        public static bool PhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Trim().Length > 12 || phoneNumber.Trim() == "")
                return false;
            return phoneNumber.Trim().All(char.IsDigit);
        }
        /// <summary>
        /// check name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool Name(string name)
        {
            if (name.Length > 100 || name.Trim() == "") return false;
            return true;
        }

        /// <summary>
        /// check chuỗi account và Id
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool Id(string input)
        {
            if (input.Trim().Length > 10 || input.Trim() == "") return false;
            Regex regex = new Regex("^[0-9]+$");
            return regex.IsMatch(input.Trim());
        }
        /// <summary>
        /// check chuỗi password
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool UserNPassWord(string input)
        {
            if (input.Length > 20 || input.Trim() == "") return false;
            Regex regex = new Regex("^[a-zA-Z0-9]+$");
            return regex.IsMatch(input.Trim());
        }

        /// <summary>
        /// check chuỗi Int có phải kiểu số nguyên dương hay không
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsInt(string input)
        {
            if (!int.TryParse(input, out _)) return false;
            return Convert.ToInt32(input) > 0;
        }

        /// <summary>
        /// Check address
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static bool Address (string address)
        {
            return  address.Trim().Length < 100;
        }

        public static bool IsDescribe(string input)
        {
            return input.Length < 500;
        }
    }
}
