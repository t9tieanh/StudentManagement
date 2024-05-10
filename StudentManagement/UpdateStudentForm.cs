using System.Runtime.InteropServices;
using BUL;
using DTO;
namespace StudentManagement
{
    public partial class UpdateStudentForm : Form
    {
        private Student_DTO student = new Student_DTO();
        private bool check()
        {
            bool wasError = true;
            if (!ErrorChecking.InputCheck.Id(txtIdStudent.Text.Trim()))
            {
                error.SetError(txtIdStudent, "Id không hợp lệ");
                wasError = false;
            }
            if (!ErrorChecking.InputCheck.Name(txtFirstNameStudent.Text.Trim()))
            {
                error.SetError(txtFirstNameStudent, "First Name không hợp lệ");
                wasError = false;
            }
            if (!ErrorChecking.InputCheck.Name(txtLastNameStudent.Text.Trim()))
            {
                error.SetError(txtLastNameStudent, "Last Name không hợp lệ");
                wasError = false;
            }
            if (!ErrorChecking.InputCheck.Address(txtAddress.Text.Trim()))
            {
                error.SetError(txtAddress, "Địa chỉ không hợp lệ");
                wasError = false;
            }
            if (!ErrorChecking.InputCheck.PhoneNumber(txtPhoneNumber.Text.Trim()))
            {
                error.SetError(txtPhoneNumber, "Sđt không hợp lệ");
                wasError = false;
            }
            return wasError;
        }
        private void SetStudent()
        {
            txtIdStudent.Text = student.StudentId.ToString();
            txtFirstNameStudent.Text = student.FirstName.ToString();
            txtLastNameStudent.Text = student.LastName.ToString();
            txtPhoneNumber.Text = student.Phone.ToString();
            txtAddress.Text = student.Address.ToString();

            DtpBirthDay.Value = student.BirthDay;
            if ((int)student.Gender == 0)
                rdNam.Checked = true;
            else if ((int)student.Gender == 1)
                rdNu.Checked = true;
            else rdOther.Checked = true;

            if (student.Picture != null)
                pbxPicStudent.Image = Image.FromStream(student.Picture);
            cbDepartMent.Text = student.Department;
            txtEmail.Text = student.Email;
        }
        private Gender_DTO sex()
        {
            if (rdNam.Checked) return Gender_DTO.male;
            else if (rdNu.Checked) return Gender_DTO.female;
            else return Gender_DTO.other;
        }
        private void getStudent()
        {
            MemoryStream pictureStudent = new MemoryStream();
            pbxPicStudent.Image.Save(pictureStudent, pbxPicStudent.Image.RawFormat);
            student = new Student_DTO(Convert.ToInt32(txtIdStudent.Text.Trim()), txtFirstNameStudent.Text.Trim(), txtLastNameStudent.Text.Trim(), DtpBirthDay.Value, sex(), txtPhoneNumber.Text.Trim(), txtAddress.Text.Trim(), pictureStudent, cbDepartMent.Text, txtEmail.Text);
        }
        public UpdateStudentForm()
        {
            InitializeComponent();
        }

        public UpdateStudentForm(Student_DTO student)
        {
            InitializeComponent();
            this.student = student;
            SetStudent();
            txtIdStudent.Enabled = false;
        }
        #region
        /// <summary>
        /// thanh trượt panel
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
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            Student_DTO newstudent = Student_BUL.FindStudent(txtFindID.Text.Trim());
            if (newstudent != null)
            {
                student = newstudent;
                lblNotice.Text = student.ToString() + " students were found!";
                SetStudent();
            }
            else lblNotice.Text = "ID does not exist";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!check()) return;
            getStudent();
            if (Student_BUL.UpdateStudent(student))
            {
                lblNotice.Text = "Update " + txtIdStudent.Text + " successfully!";
            }
            else
            {
                lblNotice.Text = "Update " + txtIdStudent.Text + " failed!";
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
                pbxPicStudent.ImageLocation = filePath;
            }
        }

        private void btnDeleteStudent_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa " + txtIdStudent.Text + " ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            if (BUL.Student_BUL.DeleteStudent(txtIdStudent.Text.Trim()))
            {
                MessageBox.Show("Delete" + txtIdStudent.Text + " successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                lblNotice.Text = "Delete " + txtIdStudent.Text + " failed!";
            }
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            if (txtIdStudent.Text.Trim() == "")
                lblNotice.Text = "You have not selected any students yet !";
            else
            {
                StudentClassForm studentClassForm = new StudentClassForm(new Student_DTO(Convert.ToInt32(txtIdStudent.Text),
                    txtFirstNameStudent.Text, txtLastNameStudent.Text)); ;
                this.Hide();
                studentClassForm.ShowDialog();
                this.Show();
            }
        }
    }
}
