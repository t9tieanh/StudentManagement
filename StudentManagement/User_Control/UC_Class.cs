using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.User_Control
{
    public partial class UC_Class : UserControl
    {
        Class_DTO myClass;
        bool check = true; // nếu sử dụng usercontrol này với tư cách là teacher -> check = false
        private void setClass()
        {
            pbxTeacher.Image = Image.FromStream(myClass.TeacherPicture);
            lblYear.Text = myClass.Year.ToString();
            lblTeacherName.Text = myClass.TeacherName;
            lblNameSubject.Text = myClass.SubjectName;
            lblClassName.Text = myClass.ClassName;
        }
        public UC_Class(Class_DTO myclass)
        {
            InitializeComponent();
            this.myClass = myclass;
            setClass();
        }
        public UC_Class (Class_DTO myclass , bool check)
        {
            InitializeComponent();
            this.myClass = myclass;
            setClass();
            this.check = false;
        }

        public UC_Class()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var UpdateForm = new ClassUpdateForm(myClass,check);
            UpdateForm.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var PrintForm = new InfomationClassForm (myClass);
            PrintForm.ShowDialog();
        }
    }
}
