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
using BUL;
using DTO;
namespace StudentManagement
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private Gender_DTO sex()
        {
            if (rdNam.Checked) return Gender_DTO.male;
            else if (rdNu.Checked) return Gender_DTO.female;
            else return Gender_DTO.other;
        }
        private bool check()
        {
            bool wasError = true;
            if (!ErrorChecking.InputCheck.Id (txtIdStudent.Text.Trim()))
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
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

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!check()) return;
            MemoryStream pictureStudent = new MemoryStream();
            pbxPicStudent.Image.Save(pictureStudent, pbxPicStudent.Image.RawFormat);
            Student_DTO newStudent = new Student_DTO(Convert.ToInt32(txtIdStudent.Text.Trim()), txtFirstNameStudent.Text.Trim(), txtLastNameStudent.Text.Trim(), DtpBirthDay.Value, sex(), txtPhoneNumber.Text.Trim(), txtAddress.Text.Trim(), pictureStudent, cbDepartMent.Text,txtEmail.Text);
            if (Student_BUL.InsertStudent(newStudent))
                lblNotice.Text = "More successful students !";
            else lblNotice.Text = "Id has already existed !";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
