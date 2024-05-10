using DTO;
using System.Data.SqlClient;

namespace StudentManagement
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //private SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);
            /*var Login = new Login_DTO("Tieanh19", "1", "", true);
            DAL.Login_DAL.InsertLogin(Login);
            DAL.Login_DAL.UpdateStatus(Login);*/
            Application.Run(new LoginForm());
            //Application.Run(new StudentListForm());
            //Application.Run(new MainForm());
            //Application.Run(new AddClassForm());
            //Application.Run(new ManagementStudentForm());
            //Application.Run(new UpdateStudentForm());
            // Application.Run(new AddStudentForm());
            //Application.Run(new SearchStudentForm());
            //Application.Run(new ChangePassWordForm("đ"));
            // Application.Run(new ClassManagementForm());
            //Application.Run(new ManagementCourse());

            // Application.Run(new ComfirmEmailForm());

        }
    }
}