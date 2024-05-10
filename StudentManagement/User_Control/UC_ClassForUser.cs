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
    public partial class UC_ClassForUser : UserControl
    {
        Class_DTO myClass;
        private void setClass()
        {
            picTeacher.Image = (myClass.TeacherPicture == null) ? picTeacher.Image : Image.FromStream(myClass.TeacherPicture);
            lblClassId.Text = myClass.ClassID;
            lblSubject.Text = myClass.SubjectName;
            lblYear.Text = myClass.Year.ToString();
        }
        public UC_ClassForUser(Class_DTO myClass)
        {
            InitializeComponent();
            this.myClass = myClass;
            setClass();
        }

        private void btnShowStudent_Click(object sender, EventArgs e)
        {
            new InfomationClassForm (myClass).ShowDialog();
        }
    }
}
