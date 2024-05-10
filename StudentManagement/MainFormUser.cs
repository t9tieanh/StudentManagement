using BUL;
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
    public partial class MainFormUser : Form
    {
        private User_DTO myUser;
        private void pnTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void SetUser()
        {
            txtUserFullName.Text = myUser.FullName;
            picUser.Image = (myUser.Picture == null) ? picUser.Image : Image.FromStream(myUser.Picture);
        }
        private void LoadCbGroup()
        {
            cbGroupUpdate.DataSource = BUL.Group_BUL.GetGroup(myUser);
            cbGroupUpdate.DisplayMember = "Name";
            txtIdGroupUpdate.Text = "";
            txtNameGroupUpdate.Text = "";
            cbGroupDelete.DataSource = BUL.Group_BUL.GetGroup(myUser);
            cbGroupDelete.DisplayMember = "Name";
            txtIdGroupDelete.Text = "";
            txtNameGroupDelete.Text = "";
        }
        public MainFormUser(User_DTO myUser)
        {
            InitializeComponent();
            this.myUser = myUser;
            // load dữ liệu cho cb box group 
            LoadCbGroup();
            //
            SetUser();
            txtUserFullName.Enabled = false;
        }
        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (!ErrorChecking.InputCheck.Name(txtNameGroup.Text) || !ErrorChecking.InputCheck.Id(txtGroupId.Text))
            {
                lblNoticeAddGroup.Text = "ID hoặc tên của group không hợp lệ!";
                return;
            }
            var newGroup = new Group_DTO(txtGroupId.Text, txtNameGroup.Text, myUser);
            if (Group_BUL.InsertGroup(newGroup))
            {
                lblNoticeAddGroup.Text = "Thêm Group thành công !";
                LoadCbGroup();
            }
            else
            {
                lblNoticeAddGroup.Text = "Id của group đã tồn tại!, vui lòng chọn id khác";
            }
        }

        private void cbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            var group = (Group_DTO)cbGroupUpdate.SelectedValue;
            txtNameGroupUpdate.Text = group.Name;
            txtIdGroupUpdate.Text = group.GroupId;
        }

        private void btnUpdateGroup_Click(object sender, EventArgs e)
        {
            if (!ErrorChecking.InputCheck.Name(txtNameGroupUpdate.Text) || !ErrorChecking.InputCheck.Id(txtIdGroupUpdate.Text))
            {
                lblNoticeGroupUpdate.Text = "ID hoặc tên của group không hợp lệ!";
                return;
            }
            var myGroup = new Group_DTO(txtIdGroupUpdate.Text, txtNameGroupUpdate.Text, myUser);
            if (Group_BUL.UpdateGroup(myGroup))
            {
                lblNoticeGroupUpdate.Text = "Sửa Group thành công !";
                LoadCbGroup();
            }
            else
            {
                lblNoticeGroupUpdate.Text = "Sửa Group không thành công !";
            }
        }

        private void cbGroupDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            var group = (Group_DTO)cbGroupDelete.SelectedValue;
            txtNameGroupDelete.Text = group.Name;
            txtIdGroupDelete.Text = group.GroupId;
        }

        private void btnDeleteGroup_Click(object sender, EventArgs e)
        {
            var myGroup = new Group_DTO(txtIdGroupDelete.Text, txtNameGroupDelete.Text, myUser);
            if (Group_BUL.DeleteGroup(myGroup))
            {
                lblNoticeGroupDelete.Text = "Xóa Group thành công !";
                LoadCbGroup();
            }
            else
            {
                lblNoticeGroupDelete.Text = "Xóa Group không thành công !";
            }
        }

        private void btnShowFullGroup_Click(object sender, EventArgs e)
        {
            Hide();
            new GroupListForm(myUser).ShowDialog();
            Show();
        }

        private void btnInsertTeacher_Click(object sender, EventArgs e)
        {
            new DetailTeacherForUser(myUser).ShowDialog();
        }

        private void UpdateTeacher_Click(object sender, EventArgs e)
        {
            new DetailTeacherForUser(null, myUser).ShowDialog();
        }

        private void lblEditProfile_Click(object sender, EventArgs e)
        {
            new DentailUserForUser (myUser).ShowDialog();
            this.myUser = BUL.User_BUL.GetUser(myUser.UserId);
            SetUser();
        }
    }
}
