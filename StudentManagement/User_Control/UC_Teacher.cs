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
using System.Xml.Linq;

namespace StudentManagement.User_Control
{
    public partial class UC_Teacher : UserControl
    {
        private Teacher_DTO myTeacher;
        public UC_Teacher(Teacher_DTO teacher)
        {
            InitializeComponent();
            myTeacher = teacher;
            setData();
        }
        private void setData()
        {
            lblNameTeacher.Text = myTeacher.FirstName + " " + myTeacher.LastName;
            lblDescebri.Text = myTeacher.PhoneNumber + " / " + myTeacher.Address;
            pbxTeacher.Image = Image.FromStream(myTeacher.Picture);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DentailTeacherForm UpdateTeacher = new DentailTeacherForm(myTeacher);
            UpdateTeacher.ShowDialog();
        }
    }
}
