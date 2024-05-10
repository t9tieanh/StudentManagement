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
using BUL;
using System.Runtime.InteropServices;
using ErrorChecking;

namespace StudentManagement
{
    public partial class SignUpAdminForm : Form
    {
        private string email; 
        public SignUpAdminForm(string email)
        {
            InitializeComponent();
            this.email = email;
        }
        /// <summary>
        /// điều khiển tab form
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void pnTab_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool check()
        {
            if (!InputCheck.UserNPassWord(txtUsers.Text.Trim()))
            {
                error.SetError(txtUsers, "User not valid!");
                return false;
            }
            if (!InputCheck.UserNPassWord(txtPassWord.Text.Trim()))
            {
                error.SetError(txtPassWord, "PassWord not valid!");
                return false;
            }
            return true;
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!check()) return;
            if (txtConfirmPassWord.Text.Trim() != txtConfirmPassWord.Text.Trim())
            {
                lblNotice.Text = "PassWord Không trùng khớp!";
                return;
            }
            Login_DTO newLogin = new Login_DTO(txtUsers.Text.Trim(), txtPassWord.Text.Trim() , email);
            if (Login_BUL.InsertLogin(newLogin))
            {
                MessageBox.Show("Account successfully created!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                lblNotice.Text = "UserName đã tồn tại! , Xin vui lòng chọn UserName khác!";
            }
        }

        private void iconShow_Click(object sender, EventArgs e)
        {
            iconHide.BringToFront();
            txtPassWord.PasswordChar = '\0';
        }
        private void iconHide_Click_1(object sender, EventArgs e)
        {
            iconShow.BringToFront();
            txtPassWord.PasswordChar = '*';
        }

        private void iconShow1_Click(object sender, EventArgs e)
        {
            iconHide1.BringToFront();
            txtConfirmPassWord.PasswordChar = '\0';
        }

        private void iconHide1_Click(object sender, EventArgs e)
        {
            iconShow1.BringToFront();
            txtConfirmPassWord.PasswordChar = '*';
        }
    }
}
