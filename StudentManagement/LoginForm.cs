
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms.Design.Behavior;
using System.Data.SqlClient;
using DTO;
using BUL;
using ErrorChecking;

namespace StudentManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        #region di chuyển form và các design khác 
        /// <summary>
        /// di chuyển form 
        /// </summary>

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void iconHide_Click(object sender, EventArgs e)
        {
            iconShow.BringToFront();
            txtPassWord.PasswordChar = '*';
        }

        private void iconShow_Click(object sender, EventArgs e)
        {
            iconHide.BringToFront();
            txtPassWord.PasswordChar = '\0';
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        #endregion
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private bool checkErrorInput()
        {
            if (!InputCheck.UserNPassWord(txtUsers.Text.Trim()))
            {
                errorProvider1.SetError(txtUsers, "User not valid!");
                return false;
            }
            if (!InputCheck.UserNPassWord(txtPassWord.Text.Trim()))
            {
                errorProvider1.SetError(txtPassWord, "PassWord not valid!");
                return false;
            }
            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!checkErrorInput()) { return; }

            if (rdAdmin.Checked)
            {
                Login_DTO login = new Login_DTO(txtUsers.Text, txtPassWord.Text);
                if (!Login_BUL.ProcedToLogin(login))
                {
                    lblNotice.Text = "Invalid UserName or PassWord !";
                }
                else
                {
                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Show();
                }
            }
            else if (rdTeacher.Checked)
            {
                Teacher_DTO teacher = new Teacher_DTO();
                teacher.TeacherID = txtUsers.Text.Trim();
                teacher.Password = txtPassWord.Text;
                teacher = Teacher_BUL.ProcedToLogin(teacher);
                if (teacher == null)
                {
                    lblNotice.Text = "Invalid UserName or PassWord !";
                }
                else
                {
                    MainFormTeacher mainForm = new MainFormTeacher(teacher);
                    this.Hide();
                    mainForm.ShowDialog();
                    this.Show();
                }
            }
            else if (rdUser.Checked)
            {
                User_DTO user = new User_DTO(txtUsers.Text.Trim(),txtPassWord.Text.Trim());
                user = User_BUL.ProcedToLogin(user);
                if (user == null)
                {
                    lblNotice.Text = "Invalid UserName or PassWord !";
                }
                else
                {
                    this.Hide();
                    new MainFormUser (user).ShowDialog();
                    this.Show();
                }
            }
            txtUsers.Text = "";
            txtPassWord.Text = "";
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            if (rdTeacher.Checked)
            {
                lblNotice.Text = "không thể tạo tài khoản teacher !";
                return;
            }
            ComfirmEmailForm signUpForm = new ComfirmEmailForm(true,rdAdmin.Checked,rdUser.Checked);
            this.Hide();
            signUpForm.ShowDialog();
            this.Show();
        }

        private void btnForgetPassWord_Click(object sender, EventArgs e)
        {
            ComfirmEmailForm signUpForm = new ComfirmEmailForm(false,true,true);
            this.Hide();
            signUpForm.ShowDialog();
            this.Show();
        }
    }
}