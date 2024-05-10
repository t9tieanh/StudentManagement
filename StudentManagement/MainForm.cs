using DTO;
using StudentManagement.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            GetMySubject();
            GetMyTeacher();
            GetLogin();
            GetClass();
        }
        #region hàm get 
        #region Getsubject 
        private void GetSubject(List<Subject_DTO> mySubject)
        {
            flowPanelSubject.Controls.Clear();
            lblTotalSubject.Text = mySubject.Count.ToString();
            foreach (Subject_DTO subject in mySubject)
                flowPanelSubject.Controls.Add(new User_Control.UC_Subject(subject));
        }
        private void GetMySubject()
        {
            List<Subject_DTO> mySubject = BUL.Subject_BUL.GetSubject();
            GetSubject(mySubject);

        }
        private void GetMySubject(int Semester)
        {
            List<Subject_DTO> mySubject = BUL.Subject_BUL.GetSubject(Semester);
            GetSubject(mySubject);
        }
        #endregion
        #region Getteacher
        private void GetTeacher(List<Teacher_DTO> myTeacher)
        {
            pnFlowTeacher.Controls.Clear();
            lblTotalTeacher.Text = myTeacher.Count.ToString();
            foreach (var teacher in myTeacher)
                pnFlowTeacher.Controls.Add(new User_Control.UC_Teacher(teacher));
        }
        private void GetMyTeacher()
        {
            List<Teacher_DTO> myTeacher = BUL.Teacher_BUL.GetTeacher();
            GetTeacher(myTeacher);
        }
        private void GetMyTeacher(string field, string value)
        {
            List<Teacher_DTO> myTeacher = BUL.Teacher_BUL.GetTeacher(field, value);
            GetTeacher(myTeacher);
        }
        #endregion
        #region GetLogin
        private void GetLogin()
        {
            pnFlowAdmin.Controls.Clear();
            List<Login_DTO> myLogin = BUL.Login_BUL.GetLogin();
            List<User_DTO> myUser = BUL.User_BUL.GetUser();
            foreach (var login in myLogin)
            {
                pnFlowAdmin.Controls.Add(new User_Control.UC_Account(login));
            }
            foreach (var user in myUser)
            {
                pnFlowAdmin.Controls.Add(new User_Control.UC_Account(user));
            }
        }
        #endregion
        #region GetClass
        private void GetClass(List<Class_DTO> ClassList)
        {
            pnflClassList.Controls.Clear();
            lblTotalClass.Text = ClassList.Count.ToString();
            foreach (Class_DTO myclass in ClassList)
                pnflClassList.Controls.Add(new User_Control.UC_Class(myclass));
        }
        private void GetClass()
        {
            List<Class_DTO> ClassList = BUL.Class_BUL.GetClass();
            GetClass(ClassList);
        }
        private void GetSearchMyClass()
        {
            /*TeacherName
            SubjectName
            ClassID
            ClassName*/
            List<Class_DTO> ClassList = new List<Class_DTO>();
            if (cbClass.SelectedIndex == 0)
                ClassList = BUL.Class_BUL.GetClass("FirstName", txtSearchClass.Text, "TEACHER");
            else if (cbClass.SelectedIndex == 1)
                ClassList = BUL.Class_BUL.GetClass("Name", txtSearchClass.Text.Trim(), "SUBJECT");
            else
                ClassList = BUL.Class_BUL.GetClass(cbClass.Text, txtSearchClass.Text.Trim(), "CLASS");
            GetClass(ClassList);
        }
        #endregion
        #endregion
        #region Di chuyển tab 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void pnTab_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void btnEditRemove_Click(object sender, EventArgs e)
        {
            var studentUpdate = new UpdateStudentForm();
            this.Hide();
            studentUpdate.ShowDialog();
            this.Show();
        }
        private void btnInsertTeacher_Click(object sender, EventArgs e)
        {
            DentailTeacherForm UpdateTeacher = new DentailTeacherForm();
            UpdateTeacher.ShowDialog();
        }

        private void btnInsertSubject_Click_1(object sender, EventArgs e)
        {
            DentailSubjectForm UpdateSubject = new DentailSubjectForm();
            UpdateSubject.ShowDialog();
        }
        private void btnListStudent_Click(object sender, EventArgs e)
        {
            var studentList = new StudentListForm();
            this.Hide();
            studentList.ShowDialog();
            this.Show();
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            var studentUpdate = new UpdateStudentForm();
            this.Hide();
            studentUpdate.ShowDialog();
            this.Show();
        }

        private void btnManagementStudent_Click(object sender, EventArgs e)
        {
            var studentManagement = new ManagementStudentForm();
            this.Hide();
            studentManagement.ShowDialog();
            this.Show();
        }

        private void btnInsertStudent_Click_1(object sender, EventArgs e)
        {
            AddStudentForm addStudent = new AddStudentForm();
            this.Hide();
            addStudent.ShowDialog();
            this.Show();
        }
        #region hiện thông báo
        private bool tick = false;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (tick) pbxNotice.Image = Properties.Resources.ao_thun_dong_phuc_at295_1__1_;
            else
                pbxNotice.Image = Properties.Resources.dong_phuc_the_duc_su_pham_ky_thuat;

            tick = !tick;
        }
        #endregion 

        private void btnRefeshSubject_Click_1(object sender, EventArgs e)
        {
            GetMySubject();
        }

        private void btnRefeshAdmin_Click(object sender, EventArgs e)
        {
            GetLogin();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            var studenFind = new SearchStudentForm();
            this.Hide();
            studenFind.ShowDialog();
            this.Show();
        }

        private void cbSemester_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            GetMySubject(Convert.ToInt32(cbSemester.Text));
        }

        private void btnRefeshTeacher_Click(object sender, EventArgs e)
        {
            GetMyTeacher();
        }

        private void btnRefeshClass_Click(object sender, EventArgs e)
        {
            GetClass();
        }

        private void txtSearchValue_TextChanged(object sender, EventArgs e)
        {
            GetMyTeacher(cbSearch.Text, txtSearchValue.Text);
        }

        private void btnInsertClass_Click(object sender, EventArgs e)
        {
            var addClassForm = new AddClassForm();
            addClassForm.ShowDialog();
        }

        private void txtSearchClass_TextChanged(object sender, EventArgs e)
        {
            GetSearchMyClass();
        }

        private void btnEditClass_Click(object sender, EventArgs e)
        {
            var classPrint = new PrintClassForm();
            this.Hide();
            classPrint.ShowDialog();
            this.Show();
        }

        private void btnPrintStudent_Click(object sender, EventArgs e)
        {
            var studentPrint = new PrintStudentForm();
            this.Hide();
            studentPrint.ShowDialog();
            this.Show();
        }

        private void btnStaticForm_Click(object sender, EventArgs e)
        {
            var StaticStudentForm = new StaticStudentForm();
            this.Hide();
            StaticStudentForm.ShowDialog();
            this.Show();
        }
    }
}
