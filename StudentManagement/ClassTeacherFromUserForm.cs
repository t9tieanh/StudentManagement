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
    public partial class ClassTeacherFromUserForm : Form
    {
        private Teacher_DTO myTeacher;
        private void SetTeacher()
        {
            lblNameTeacher.Text = myTeacher.FirstName + " " + myTeacher.LastName;
            lblTeacher.Text = lblNameTeacher.Text;
            picTeacher.Image = (myTeacher.Picture == null) ? picTeacher.Image : Image.FromStream(myTeacher.Picture);
            lblTeacherId.Text = myTeacher.TeacherID;
            lblPhoneNumber.Text = myTeacher.PhoneNumber;
        }
        private void LoadClass()
        {
            flpnClass.Controls.Clear();
            var lstClass = BUL.Class_BUL.GetClass(myTeacher);
            if (lstClass.Count == 0)
            {
                lblNotice.Text = "giáo viên này chưa được admin giao bất cứ lớp nào !";
                return;
            }
            foreach (var myclass in lstClass)
            {
                flpnClass.Controls.Add(new User_Control.UC_ClassForUser(myclass));
            }
        }
        public ClassTeacherFromUserForm(Teacher_DTO myTeacher)
        {
            InitializeComponent();
            this.myTeacher = myTeacher;
            SetTeacher();
            LoadClass();
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
    }
}
