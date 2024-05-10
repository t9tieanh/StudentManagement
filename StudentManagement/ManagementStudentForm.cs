using BUL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace StudentManagement
{
    public partial class ManagementStudentForm : Form
    {
        private Student_DTO student = new Student_DTO();
        #region thanh trượt 
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
        private void refreshData()
        {
            try
            {
                dgvStudent.DataSource = Student_BUL.GetStudent();
                dgvStudent.RowTemplate.Height = 40;
                DataGridViewImageColumn pic = (DataGridViewImageColumn)dgvStudent.Columns[7];
                pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
                lblTotal.Text = "Total = " + dgvStudent.RowCount;
            }
            catch { MessageBox.Show("Không lấy được dữ liệu từ Database"); }
        }
        private Gender_DTO sex()
        {
            if (rdNam.Checked) return Gender_DTO.male;
            else if (rdNu.Checked) return Gender_DTO.female;
            else return Gender_DTO.other;
        }
        public ManagementStudentForm()
        {
            InitializeComponent();
            refreshData();
            btnClass.Enabled = false;
        }
        private bool check()
        {
            error.Clear();
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

        private void dgvStudent_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvStudent.CurrentRow.Index;
            txtIdStudent.Text = dgvStudent.Rows[i].Cells[0].Value.ToString().Trim();
            txtFirstNameStudent.Text = dgvStudent.Rows[i].Cells[1].Value.ToString().Trim();
            txtLastNameStudent.Text = dgvStudent.Rows[i].Cells[2].Value.ToString().Trim();
            DtpBirthDay.Value = (DateTime)(dgvStudent.Rows[i].Cells[3].Value);

            if ((int)dgvStudent.Rows[i].Cells[4].Value == 0)
                rdNam.Checked = true;
            else if ((int)dgvStudent.Rows[i].Cells[4].Value == 1)
                rdNu.Checked = true;
            else rdOther.Checked = true;

            txtPhoneNumber.Text = dgvStudent.Rows[i].Cells[5].Value.ToString().Trim();
            txtAddress.Text = dgvStudent.Rows[i].Cells[6].Value.ToString().Trim();

            byte[] pic = (byte[])dgvStudent.Rows[i].Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            pbxPicStudent.Image = Image.FromStream(picture);


            cbDepartMent.Text = dgvStudent.Rows[i].Cells[8].Value.ToString().Trim();
            txtEmail.Text = dgvStudent.Rows[i].Cells[9].Value.ToString().Trim();
        }

        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            lblNotice.Text = "";
            var dt = BUL.Student_BUL.FindStudent("FIRSTNAME", txtFind.Text.Trim());
            if (dt == null)
                lblNotice.Text = "student not found!";
            else
                dgvStudent.DataSource = dt;
        }

        private void btnDownLoad_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = "student_" + txtFirstNameStudent.Text + " " + txtLastNameStudent.Text;
            if (pbxPicStudent.Image == null)
            {
                MessageBox.Show("No image in the picture box", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (svf.ShowDialog() == DialogResult.OK)
            {
                pbxPicStudent.Image.Save(svf.FileName + ("." + ImageFormat.Jpeg.ToString()));
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!check()) return;
            getStudent();
            if (Student_BUL.InsertStudent(student))
                lblNotice.Text = "More successful students !";
            else lblNotice.Text = "Id has already existed !";
        }
        private void resetTextBox()
        {
            txtIdStudent.Text = string.Empty;
            txtFirstNameStudent.Text = string.Empty;
            txtLastNameStudent.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtEmail.Text = string.Empty;
            pbxPicStudent.Image = Properties.Resources._416137715_775449341288653_2240139542177004199_n;
        }
        private void btnToggelMode_CheckedChanged(object sender, EventArgs e)
        {
            resetTextBox();
            btnInsert.Enabled = !btnToggelMode.Checked;
            btnDeleteStudent.Enabled = btnToggelMode.Checked;
            btnUpdate.Enabled = btnToggelMode.Checked;
            btnClass.Enabled = btnToggelMode.Checked;
            txtIdStudent.Enabled = !btnToggelMode.Checked;
        }
        private void getStudent()
        {
            MemoryStream pictureStudent = new MemoryStream();
            pbxPicStudent.Image.Save(pictureStudent, pbxPicStudent.Image.RawFormat);
            student = new Student_DTO(Convert.ToInt32(txtIdStudent.Text.Trim()), txtFirstNameStudent.Text.Trim(), txtLastNameStudent.Text.Trim(), DtpBirthDay.Value, sex(), txtPhoneNumber.Text.Trim(), txtAddress.Text.Trim(), pictureStudent, cbDepartMent.Text, txtEmail.Text);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!check()) return;
            getStudent();
            if (Student_BUL.UpdateStudent(student))
                lblNotice.Text = "Update " + txtIdStudent.Text + " successfully!";
            else
                lblNotice.Text = "Update " + txtIdStudent.Text + " failed!";
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa " + txtIdStudent.Text + " ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            if (BUL.Student_BUL.DeleteStudent(txtIdStudent.Text.Trim()))
            {
                MessageBox.Show("Delete" + txtIdStudent.Text + " successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                lblNotice.Text = "Delete " + txtIdStudent.Text + " failed!";
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void btnClass_Click(object sender, EventArgs e)
        {
            if (txtIdStudent.Text.Trim() == "")
                lblNotice.Text = "You have not selected any students yet !";
            else
            {
                StudentClassForm studentClassForm = new StudentClassForm(new Student_DTO(Convert.ToInt32(txtIdStudent.Text),
                    txtFirstNameStudent.Text,txtLastNameStudent.Text)); ;
                this.Hide();
                studentClassForm.ShowDialog();
                this.Show();
            }
        }
    }
}
