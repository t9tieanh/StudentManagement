using BUL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StudentManagement
{
    public partial class SignUpUserForm : Form
    {
        private User_DTO myUser = new User_DTO ();
        public SignUpUserForm()
        {
            InitializeComponent();
        }
        public SignUpUserForm(string email)
        {
            InitializeComponent();
            myUser.Email = email;
            txtEmail.Text = email;
        }

        private void iconShow_Click(object sender, EventArgs e)
        {
            iconHide.BringToFront();
            txtPassWord.PasswordChar = '\0';
        }

        private void iconShow1_Click(object sender, EventArgs e)
        {
            iconHide1.BringToFront();
            txtConfirmPassWord.PasswordChar = '\0';
        }

        private void iconHide_Click(object sender, EventArgs e)
        {
            iconShow.BringToFront();
            txtPassWord.PasswordChar = '*';
        }
        private void iconHide1_Click(object sender, EventArgs e)
        {
            iconShow1.BringToFront();
            txtPassWord.PasswordChar = '*';
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
        private void GetUser ()
        {
            myUser.UserId = txtUserId.Text;
            myUser.FullName = txtFullName.Text;
            myUser.Email = txtEmail.Text;
            myUser.UserName = txtUserName.Text;
            myUser.Password = txtPassWord.Text;
            myUser.Status = false;
            picUser.Image.Save(myUser.Picture, picUser.Image.RawFormat);
        }
        private bool check()
        {
            error.Clear();
            bool wasError = true;
            if (!ErrorChecking.InputCheck.Id(txtUserId.Text))
            {
                error.SetError(txtUserId, "User Id not valid !");
                wasError = false;
            }
            if (!ErrorChecking.InputCheck.Name(txtFullName.Text.Trim()))
            {
                error.SetError(txtFullName, "Name not valid !");
                wasError = false;
            }
            if (!ErrorChecking.InputCheck.UserNPassWord(txtUserName.Text.Trim()))
            {
                error.SetError(txtUserName, "UserName not valid");
                wasError = false;
            }
            if (!ErrorChecking.InputCheck.UserNPassWord(txtPassWord.Text.Trim()))
            {
                error.SetError(txtPassWord, "Password not valid");
                wasError = false;
            }
            return wasError;
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!check()) return;
            if (txtConfirmPassWord.Text.Trim() != txtConfirmPassWord.Text.Trim())
            {
                lblNotice.Text = "PassWord Không trùng khớp!";
                return;
            }
            GetUser();
            if (BUL.User_BUL.InsertUser(myUser))
            {
                MessageBox.Show("Account successfully created!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                lblNotice.Text = "UserName đã tồn tại! , Xin vui lòng chọn UserName khác!";
            }
        }
    }
}
