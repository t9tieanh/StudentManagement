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
    public partial class GroupListForm : Form
    {
        private User_DTO myUser;
        private Teacher_DTO teacherSelected;
        #region thanh trượt
        private void pnTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        #endregion
        private void SetUser()
        {
            txtUserFullName.Text = myUser.FullName;
            picUser.Image = (myUser.Picture == null) ? picUser.Image : Image.FromStream(myUser.Picture);
        }
        public void LoadInfoTeacher(Teacher_DTO myTeacher)
        {
            teacherSelected = myTeacher;
            txtIdTeacher.Text = myTeacher.TeacherID;
            txtFirstName.Text = myTeacher.FirstName;
            txtLastName.Text = myTeacher.LastName;
            txtPhoneNumber.Text = myTeacher.PhoneNumber;
            txtGroup.Text = myTeacher.Group.Name;
            txtAddress.Text = myTeacher.Address;
            picTeacher.Image = (myTeacher.Picture == null) ? picTeacher.Image = picTeacher.Image : Image.FromStream(myTeacher.Picture);
        }
        public void LoadListTeacher(Group_DTO myGroup)
        {
            flPnTeacher.Controls.Clear();
            var myTeacherLst = BUL.Teacher_BUL.GetTeacher(myGroup);
            foreach (var teacher in myTeacherLst)
            {
                flPnTeacher.Controls.Add(new User_Control.UC_TeacherForUser(teacher, this));
            }
        }
        private void LoadMyGroup()
        {
            flPnGroup.Controls.Clear();
            var myGroupLst = BUL.Group_BUL.GetGroup(myUser);
            foreach (var group in myGroupLst)
            {
                flPnGroup.Controls.Add(new User_Control.UC_Group(group, this));
            }
        }
        public GroupListForm(User_DTO myUser)
        {
            InitializeComponent();
            this.myUser = myUser;
            SetUser();
            LoadMyGroup();
            txtUserFullName.Enabled = false;
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (teacherSelected != null)
                new ClassTeacherFromUserForm(teacherSelected).ShowDialog();
        }

        private void btnUpdateThisTeacher_Click(object sender, EventArgs e)
        {
            if (teacherSelected != null)
                new DetailTeacherForUser(teacherSelected,myUser).ShowDialog();
        }
    }
}
