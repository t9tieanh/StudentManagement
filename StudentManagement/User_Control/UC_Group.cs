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
    public partial class UC_Group : UserControl
    {
        private Group_DTO myGroup;
        private GroupListForm myGroupListForm;
        private void SetGroup()
        {
            txtNameGroup.Text = myGroup.Name;
            txtIdGroup.Text = myGroup.GroupId;
            txtIdUser.Text = myGroup.User.UserId;
        }
        public UC_Group()
        {
            InitializeComponent();
        }
        public UC_Group(Group_DTO myGroup, GroupListForm myGroupListForm)
        {
            InitializeComponent();
            this.myGroup = myGroup;
            SetGroup();
            this.myGroupListForm = myGroupListForm;
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            myGroupListForm.LoadListTeacher (myGroup);
        }
    }
}
