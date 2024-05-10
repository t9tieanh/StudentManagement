using DAL;
using DTO;
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

namespace StudentManagement
{
    public partial class MainFormTeacher : Form
    {
        private Teacher_DTO teacher = new Teacher_DTO();
        private void SetTeacher()
        {
            txtNameTeacher.Text = teacher.FirstName + " " + teacher.LastName;
            picTeacher.Image = (teacher.Picture == null) ? picTeacher.Image : Image.FromStream(teacher.Picture);
        }
        public MainFormTeacher(Teacher_DTO teacher)
        {
            InitializeComponent();
            this.teacher = teacher;
            SetTeacher();
            GetMyClass();
        }

        private void GetMyClass()
        {
            pnflClassList.Controls.Clear();
            var MyClass = BUL.Class_BUL.GetClass(teacher);
            lblTotalClass.Text = MyClass.Count.ToString();
            foreach (Class_DTO cl in MyClass)
                pnflClassList.Controls.Add(new User_Control.UC_Class(cl, false));
        }

        #region di chuyển tab form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void pnTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private void btnRefeshClass_Click(object sender, EventArgs e)
        {
            GetMyClass();
            teacher = BUL.Teacher_BUL.GetTeacher(teacher.TeacherID);
            SetTeacher();
        }

        private void btnPrintClass_Click(object sender, EventArgs e)
        {
            var classPrint = new PrintClassForm(teacher);
            this.Hide();
            classPrint.ShowDialog();
            this.Show();
        }

        private void lblEditProfile_Click(object sender, EventArgs e)
        {
            var UpdateProfile = new DentailTeacherForTeacher (teacher);
            UpdateProfile.ShowDialog();
        }
    }
}
