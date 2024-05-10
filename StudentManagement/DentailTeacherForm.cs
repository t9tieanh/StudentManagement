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
    public partial class DentailTeacherForm : Form
    {
        DTO.Teacher_DTO myTeacher;
        // check input 
        private bool checkInput()
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
            if (!ErrorChecking.InputCheck.UserNPassWord(txtPassword.Text.Trim()) && txtPassword.Visible)
            {
                error.SetError(txtPassword, "PassWord không hợp lệ");
                wasError = false;
            }
            return wasError;
        }
        private void setTeacher()
        {
            txtFirstName.Text = myTeacher.FirstName;
            txtLastName.Text = myTeacher.LastName;
            txtIdTeacher.Text = myTeacher.TeacherID;
            txtPhoneNumber.Text = myTeacher.PhoneNumber;
            txtAddress.Text = myTeacher.Address;
            pbxTeacher.Image = Image.FromStream(myTeacher.Picture);
            if (myTeacher.Group == null) cbGroup.SelectedIndex = -1;
            else cbGroup.Text = myTeacher.Group.Name;
        }
        private void getTeacher()
        {
            MemoryStream pictureTeacher = new MemoryStream();
            pbxTeacher.Image.Save(pictureTeacher, pbxTeacher.Image.RawFormat);
            if (cbGroup.SelectedIndex == -1) {
                myTeacher = new Teacher_DTO(txtIdTeacher.Text, txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text, txtAddress.Text, pictureTeacher, txtPassword.Text);
            }
            else
                myTeacher = new Teacher_DTO(txtIdTeacher.Text, txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text, txtAddress.Text, pictureTeacher, txtPassword.Text,(Group_DTO)cbGroup.SelectedValue);
        }
        public DentailTeacherForm(Teacher_DTO teacher)
        {
            InitializeComponent();
            cbGroup.DataSource = BUL.Group_BUL.GetGroup();
            cbGroup.DisplayMember = "Name";
            myTeacher = teacher;
            setTeacher();
            btnInsert.Visible = false;
            txtIdTeacher.ReadOnly = true;
            // btnImportPic.Visible = false;
            txtPassword.Visible = false;
            lblTtPassword.Visible = false;
        }
        public DentailTeacherForm()
        {
            InitializeComponent();
            cbGroup.DataSource = BUL.Group_BUL.GetGroup();
            cbGroup.DisplayMember = "Name";
            // setTeacher();
            btnUpdate.Visible = false;
            btnDelete.Visible = false;
            btnChangePassWord.Visible = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!checkInput()) return;
            getTeacher();
            if (BUL.Teacher_BUL.InsertTeacher(myTeacher))
            {
                lblNotice.Text = "Insert " + myTeacher.ToString() + " successfully!";
            }
            else
            {
                lblNotice.Text = "ID Subject  " + txtIdTeacher.Text + " already exists !";
            }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa " + txtIdTeacher.Text + " ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            getTeacher();
            if (BUL.Teacher_BUL.DeleteTeacher(txtIdTeacher.Text.Trim()))
            {
                MessageBox.Show("Delete" + myTeacher.ToString() + " successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                lblNotice.Text = "Delete " + myTeacher.ToString() + " failed! ";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!checkInput()) return;
            getTeacher();
            if (BUL.Teacher_BUL.UpdateTeacher(myTeacher))
                lblNotice.Text = "Update " + myTeacher.ToString() + " successfully!";
            else
                lblNotice.Text = "Update " + myTeacher.ToString() + " failed!";
        }

        private void btnChangePassWord_Click(object sender, EventArgs e)
        {
            ChangePassWordForm changePassWord = new ChangePassWordForm(myTeacher);
            this.Hide();
            changePassWord.ShowDialog();    
            this.Show ();
        }
    }
}
