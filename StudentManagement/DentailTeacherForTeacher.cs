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
    public partial class DentailTeacherForTeacher : Form
    {
        private Teacher_DTO myTeacher;
        private void GetTeacher()
        {
            MemoryStream pictureTeacher = new MemoryStream();
            pbxTeacher.Image.Save(pictureTeacher, pbxTeacher.Image.RawFormat);
            myTeacher = new Teacher_DTO(txtIdTeacher.Text, txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text,
                txtAddress.Text, pictureTeacher, myTeacher.Group);
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
            }
        }
        private bool CheckInput()
        {
            error.Clear();
            bool wasError = true;
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
            return wasError;
        }
        public DentailTeacherForTeacher(Teacher_DTO myTeacher)
        {
            InitializeComponent();
            this.myTeacher = myTeacher;
            txtIdTeacher.Enabled = false;
            SetTeacher();
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

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassWordForm changePassWord = new ChangePassWordForm(myTeacher);
            this.Hide();
            changePassWord.ShowDialog();
            this.Show();
        }
    }
}
