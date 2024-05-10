using BUL;
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
    public partial class ComfirmEmailForm : Form
    {
        private bool next ; // biến xác định xem form tiếp theo là quên mật khẩu hay là tạo tài khoản 
        private bool isUser;
        private bool isAdmin;
        private bool daGui = false;
        public ComfirmEmailForm(bool next,bool isAdmin,bool isUser)
        {
            InitializeComponent();
            this.next = next;
            this.isUser = isUser;
            this.isAdmin = isAdmin;
        }
        /// di chuyển form 
        /// </summary>

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void pnTab_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            if (next) // điều kiện là form đang sử dụng để tạo tài khoản 
            {
                if ((!BUL.Login_BUL.CheckEmail(txtEmail.Text.Trim()) && isAdmin) || (!BUL.User_BUL.CheckEmail(txtEmail.Text) && isUser))
                {
                    lblNotice.Text = "Email đã tồn tại !. vui lòng chọn email khác !";
                    return;
                }
            }
            else
            {
                if (BUL.Login_BUL.CheckEmail(txtEmail.Text.Trim()))
                {
                    lblNotice.Text = "Email chưa tồn tại !. vui lòng nhập lại !";
                    return;
                }
            }
            if (Login_BUL.SendCodeConfirm(txtEmail.Text.Trim()))
            {
                lblNotice.Text = "Code OTP đã được gửi đi, hãy kiểm tra email của bạn";
                daGui = true;
            }
            else lblNotice.Text = "Có lỗi, Code OTP  chưa được gửi đi !";
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (!daGui)
            {
                lblNotice.Text = "Bạn chưa xác nhận gửi mã OTP !";
                return;
            }
            if (!Login_BUL.ConfirmCode(txtOTP.Text.Trim()))
            {
                lblNotice.Text = "Mã OTP của bạn chưa đúng!";
                return;
            }
            this.Hide();
            if (next) {
                if (isAdmin)
                {
                    SignUpAdminForm signForm = new SignUpAdminForm(txtEmail.Text);
                    signForm.ShowDialog();
                }
                else if (isUser)
                {
                    SignUpUserForm signForm = new SignUpUserForm(txtEmail.Text);
                    signForm.ShowDialog();
                }
            }
            else
            {
                ChangePassWordForm changePassWordFrom = new ChangePassWordForm(txtEmail.Text.Trim());
                changePassWordFrom.ShowDialog();
            }
            this.Close();
        }
    }
}
