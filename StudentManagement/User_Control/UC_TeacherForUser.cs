using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement.User_Control
{
    public partial class UC_TeacherForUser : UserControl
    {
        private Teacher_DTO myTeacher;
        private GroupListForm GroupListForm;
        private void SetTeacher()
        {
            lblNameTeacher.Text = myTeacher.FirstName + " " + myTeacher.LastName;
            picTeacher.Image = (myTeacher.Picture == null) ? picTeacher.Image : Image.FromStream(myTeacher.Picture);
            lblTeacherId.Text = myTeacher.TeacherID;
            lblPhoneNumber.Text = myTeacher.PhoneNumber;
        }
        public UC_TeacherForUser(Teacher_DTO myTeacher, GroupListForm groupListForm)
        {
            InitializeComponent();
            this.myTeacher = myTeacher;
            GroupListForm = groupListForm;
            SetTeacher();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            GroupListForm.LoadInfoTeacher(myTeacher);
        }
    }
}
