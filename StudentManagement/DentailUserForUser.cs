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

namespace StudentManagement
{
    public partial class DentailUserForUser : Form
    {
        private User_DTO myUser;
        private void SetMyUser()
        {
            txtUserId.Text = myUser.UserId;
            txtFullName.Text = myUser.FullName;
            txtEmail.Text = myUser.Email;
            picUser.Image = myUser.Picture == null ? picUser.Image : Image.FromStream(myUser.Picture);
        }
        private void GetMyUser()
        {
            myUser.UserId = txtUserId.Text;
            myUser.FullName = txtFullName.Text;
            myUser.Email = txtEmail.Text;
            MemoryStream pictureUser = new MemoryStream();
            picUser.Image.Save(pictureUser, picUser.Image.RawFormat);
            myUser.Picture = pictureUser;
        }
        public DentailUserForUser(User_DTO myUser)
        {
            InitializeComponent();
            this.myUser = myUser;
            txtUserId.Enabled = false;
            SetMyUser();
        }

        private void btnImportPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn file PNG";

            // Thiết lập bộ lọc để chỉ hiển thị file PNG
            openFileDialog.Filter = "PNG Files|*.png";

            // Thiết lập loại file mặc định
            openFileDialog.DefaultExt = "png";

            // Cho phép chọn nhiều file
            openFileDialog.Multiselect = false;
            DialogResult result = openFileDialog.ShowDialog(); // chọn chỗ lưu
            if (result == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                picUser.ImageLocation = filePath;
            }
        }
        private bool check()
        {
            error.Clear();
            bool wasError = true;
            if (!ErrorChecking.InputCheck.Name(txtFullName.Text.Trim()))
            {
                error.SetError(txtFullName, "Name not valid !");
                wasError = false;
            }
            return wasError;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!check()) return;
            GetMyUser();
            if (BUL.User_BUL.UpdateUser(myUser))
            {
                lblNotice.Text = "Update thành công !";
            }
            else
            {
                lblNotice.Text = "(lỗi hệ thống) Cập nhật không thành công!";
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassWordForm changePassWord = new ChangePassWordForm(myUser);
            this.Hide();
            changePassWord.ShowDialog();
            this.Show();
        }
    }
}
