using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class DetailTeacherForUser : Form
    {
        private Teacher_DTO myTeacher;
        private User_DTO myUser;
        private bool CheckInput()
        {
            error.Clear();
            bool wasError = true;
            if (cbGroup.SelectedIndex == -1)
                wasError = false;
            if (!ErrorChecking.InputCheck.Id(txtIdTeacher.Text.Trim()))
            {
                error.SetError(txtIdTeacher, "Subject Id not valid !");
                wasError = false;
            }
            if (!ErrorChecking.InputCheck.Name(txtFirstName.Text.Trim()))
            {
                error.SetError(txtFirstName, "Subject Name not valid !");
                wasError = false;
            }
            if (!ErrorChecking.InputCheck.Name(txtLastName.Text.Trim()))
            {
                error.SetError(txtLastName, "Last Name không hợp lệ");
                wasError = false;
            }
            if (!ErrorChecking.InputCheck.PhoneNumber(txtPhoneNumber.Text.Trim()))
            {
                error.SetError(txtPhoneNumber, "Phone number không hợp lệ");
                wasError = false;
            }
            if (!ErrorChecking.InputCheck.Address(txtAddress.Text.Trim()))
            {
                error.SetError(txtAddress, "Địa chỉ không hợp lệ");
                wasError = false;
            }
            if (!ErrorChecking.InputCheck.UserNPassWord(txtPassword.Text.Trim()) && btnUpdate.Visible == false)
            {
                error.SetError(txtPassword, "PassWord không hợp lệ");
                wasError = false;
            }
            return wasError;
        }
        private void SetTeacher()
        {
            if (myTeacher != null)
            {
                txtIdTeacher.Text = myTeacher.TeacherID;
                txtFirstName.Text = myTeacher.FirstName;
                txtLastName.Text = myTeacher.LastName;
                txtPhoneNumber.Text = myTeacher.PhoneNumber;
                txtAddress.Text = myTeacher.Address;
                pbxTeacher.Image = (myTeacher.Picture == null) ? pbxTeacher.Image : Image.FromStream(myTeacher.Picture);
                txtPassword.Enabled = false;

                if (myTeacher.Group == null) cbGroup.SelectedIndex = -1;
                else cbGroup.Text = myTeacher.Group.Name;
            }
        }
        private void GetTeacher()
        {
            MemoryStream pictureTeacher = new MemoryStream();
            pbxTeacher.Image.Save(pictureTeacher, pbxTeacher.Image.RawFormat);
            myTeacher = new Teacher_DTO(txtIdTeacher.Text, txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text,
                txtAddress.Text, pictureTeacher, (Group_DTO)cbGroup.SelectedValue);
        }
        private void LoadDataCbGroup()
        {
            var DataLst = BUL.Group_BUL.GetGroup(myUser);
            cbGroup.DataSource = DataLst;
            cbGroup.DisplayMember = "Name";
        }
        public DetailTeacherForUser(User_DTO myUser)
        {
            InitializeComponent();
            this.myUser = myUser;
            LoadDataCbGroup();
            //
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
        }
        public DetailTeacherForUser(Teacher_DTO myTeacher, User_DTO myUser)
        {
            InitializeComponent();
            txtIdTeacher.Enabled = false;
            this.myTeacher = myTeacher;
            this.myUser = myUser;
            LoadDataCbGroup();
            SetTeacher();
            //
            btnInsert.Visible = false;
            txtIdTeacher.Enabled = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            lblNotice.Text = "...";
            if (!CheckInput()) return;
            GetTeacher();
            myTeacher.Password = txtPassword.Text;
            if (BUL.Teacher_BUL.InsertTeacher(myTeacher))
            {
                MessageBox.Show("Thêm giáo viên thành công !", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Close();
            }
            lblNotice.Text = "Id của giáo viên đã tồn tại !";
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
                pbxTeacher.ImageLocation = filePath;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblNotice.Text = "...";
            if (!CheckInput()) return;
            GetTeacher();
            if (BUL.Teacher_BUL.UpdateTeacher(myTeacher))
            {
                MessageBox.Show("Cập nhật giáo viên thành công !", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            lblNotice.Text = "Cập nhật giáo viên không thành công !";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblNotice.Text = "...";
            if (!CheckInput()) return;
            GetTeacher();
            if (BUL.Teacher_BUL.DeleteTeacher(myTeacher.TeacherID))
            {
                MessageBox.Show("Xóa giáo viên thành công !", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Close();
            }
            lblNotice.Text = "Xóa giáo viên không thành công !";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var Teacher = BUL.Teacher_BUL.GetTeacher(txtIdSearch.Text);
            if (Teacher == null) 
            {
                lblNotice.Text = "không tìm thấy giáo viên nào thuộc quản lý từ bạn !";
                return; 
            }
            else if (Teacher.Group == null)
            {
                lblNotice.Text = "không tìm thấy giáo viên nào thuộc quản lý từ bạn !";
                return;
            }
            else if (Teacher.Group.User.UserId != myUser.UserId)
            {
                lblNotice.Text = "không tìm thấy giáo viên nào thuộc quản lý từ bạn !";
                return;
            }
            myTeacher = Teacher;
            SetTeacher();
            return;
        }
        #region thanh trượt 
        private void pnTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        #endregion
    }
}
