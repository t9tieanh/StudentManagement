using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class ChangePassWordForm : Form
    {
        private string email;
        private Teacher_DTO teacher_DTO;
        private User_DTO user;
        bool flag = true;
        public ChangePassWordForm(string email)
        {
            InitializeComponent();
            this.email = email;
        }
        public ChangePassWordForm(Teacher_DTO teacher)
        {
            InitializeComponent();
            this.teacher_DTO = teacher;
            flag = false;
        }
        public ChangePassWordForm (User_DTO myUser)
        {
            InitializeComponent();
            this.user = myUser;
            flag = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void btnChangePassWord_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassWord.Text != txtPassWord.Text)
            {
                lblNotice.Text = "PassWord không trùng khớp !";
                return;
            }
            if (flag)
            {
                DTO.Login_DTO login = new DTO.Login_DTO("", txtPassWord.Text, email);
                if (!BUL.Login_BUL.UpdateLogin(login))
                {
                    lblNotice.Text = "Cập nhật chưa thành công !,vui lòng thử lại";
                    return;
                }
            }
            else
            {
                if (teacher_DTO != null)
                {
                    teacher_DTO.Password = txtPassWord.Text;
                    if (!BUL.Teacher_BUL.ChangePassword(teacher_DTO))
                    {
                        lblNotice.Text = "Cập nhật chưa thành công !,vui lòng thử lại";
                        return;
                    }
                }
                else if (user != null )
                {
                    user.Password = txtPassWord.Text;
                    if (!BUL.User_BUL.ChangePassword(user))
                    {
                        lblNotice.Text = "Cập nhật chưa thành công !,vui lòng thử lại";
                        return;
                    }
                }
            }
            MessageBox.Show("Account successfully updated!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
            txtConfirmPassWord.PasswordChar = '*';
        }

        private void pnTab_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
    }
}
