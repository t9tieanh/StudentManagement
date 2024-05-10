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
    public partial class UC_Account : UserControl
    {
        private Login_DTO myLogin;
        private User_DTO myUser;
        private void setData()
        {
            if (myLogin != null)
            {
                lblAccount.Text = myLogin.UserName;
                lblEmail.Text = myLogin.Email;
                btnAllow.Visible = myLogin.Status;
                btnUnAllow.Visible = !myLogin.Status;
            }
            else if (myUser != null)
            {
                lblAccount.Text = myUser.UserName;
                lblEmail.Text = myUser.Email;   
                btnAllow.Visible = myUser.Status;
                btnUnAllow.Visible = !myUser.Status;
                picAccount.Image = (myUser.Picture == null) ? picAccount.Image : Image.FromStream(myUser.Picture);
            }
        }
        public UC_Account(Login_DTO myLogin)
        {
            InitializeComponent();
            this.myLogin = myLogin;
            setData();
        }
        /// <summary>
        ///  dùng với user
        /// </summary>
        /// <param name="myUser"></param>
        public UC_Account(User_DTO myUser)
        {
            InitializeComponent();
            this.myUser = myUser;
            btnDelete.Visible= false;
            lblTitleDelete.Visible = false; 
            setData();
        }

        private void btnUnAllow_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (myLogin != null)
            {
                result = MessageBox.Show("Xác nhận cấp quyền cho tài khoản " + myLogin.UserName, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
                myLogin.Status = true;
                BUL.Login_BUL.UpdateStatus(myLogin);
                btnAllow.Visible = true;
                btnUnAllow.Visible = false;
            }
            else if (myUser != null)
            {
                result = MessageBox.Show("Xác nhận cấp quyền cho tài khoản " + myUser.UserName, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
                myUser.Status = true;
                BUL.User_BUL.UpdateStatus(myUser);  
                btnAllow.Visible = true;
                btnUnAllow.Visible = false;
            }
        }
        private void btnAllow_Click(object sender, EventArgs e)
        {
            DialogResult result;
            if (myLogin != null)
            {
                result = MessageBox.Show("Xác nhận hủy cấp quyền cho tài khoản " + myLogin.UserName, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
                myLogin.Status = false;
                BUL.Login_BUL.UpdateStatus(myLogin);
                btnUnAllow.Visible = true;
                btnAllow.Visible = false;
            }
            else if (myUser != null)
            {
                result = MessageBox.Show("Xác nhận hủy cấp quyền cho tài khoản " + myUser.ToString(), "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;
                myUser.Status = false;
                BUL.User_BUL.UpdateStatus(myUser);
                btnUnAllow.Visible = true;
                btnAllow.Visible = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa tài khoản " + myLogin.UserName, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            if (BUL.Login_BUL.DeleteLogin(myLogin.UserName))
                MessageBox.Show("Xóa thành công Account " + myLogin.UserName, "Notice");
            else
                MessageBox.Show("Xóa Account " + myLogin.UserName + " thất bại", "Notice");
        }
    }
}
