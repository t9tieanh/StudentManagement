using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class AddClassForm : Form
    {
        // check lỗi input 
        private bool checkInput ()
        {
            error.Clear();
            bool wasError = true;
            if (!ErrorChecking.InputCheck.Id(txtClassID.Text.Trim()))
            {
                error.SetError(txtClassID, "Id của lớp không hợp lệ !");
                wasError = false;
            }
            if (!ErrorChecking.InputCheck.Name(txtClassName.Text.Trim()))
            {
                error.SetError(txtAddress, "Tên lớp không hợp lệ !");
                wasError = false;
            }
            if (!ErrorChecking.InputCheck.IsInt(txtYear.Text.Trim()))
            {
                error.SetError(txtYear, "Năm không hợp lệ");
                wasError = false;
            }
            return wasError;
        }
        public AddClassForm()
        {
            InitializeComponent();
            GetSubject();
            GetTeacher();
            rdStep1.Checked = true;
        }
        private void GetSubject()
        {
            try
            {
                dgvSubject.DataSource = BUL.Subject_BUL.GetDataSubject();
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu");
            }
        }
        private void GetTeacher()
        {
            try
            {
                dgvTeacher.DataSource = BUL.Teacher_BUL.GetDataTeacher();
                DataGridViewImageColumn pic = (DataGridViewImageColumn)dgvTeacher.Columns[5];
                pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            catch
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu");
            }
        }

        private void dgvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvSubject.CurrentRow.Index;
            txtSubjectID.Text = dgvSubject.Rows[i].Cells[0].Value.ToString().Trim();
            txtSubjectName.Text = dgvSubject.Rows[i].Cells[1].Value.ToString().Trim();
            cbSemeter.Text = dgvSubject.Rows[i].Cells[3].Value.ToString().Trim();

            txtSubject.Text = txtSubjectName.Text;

        }

        private void dgvTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvTeacher.CurrentRow.Index;
            txtIdTeacher.Text = dgvTeacher.Rows[i].Cells[0].Value.ToString().Trim();
            txtName.Text = dgvTeacher.Rows[i].Cells[1].Value.ToString().Trim() + " " + dgvTeacher.Rows[i].Cells[2].Value.ToString().Trim();
            txtPhoneNumber.Text = dgvTeacher.Rows[i].Cells[3].Value.ToString().Trim();
            txtAddress.Text = dgvTeacher.Rows[i].Cells[4].Value.ToString().Trim();

            byte[] pic = (byte[])dgvTeacher.CurrentRow.Cells[5].Value;
            MemoryStream picture = new MemoryStream(pic);
            pbxTeacher.Image = Image.FromStream(picture);

            txtTeacher.Text = txtName.Text;
        }

        private void rdStep1_CheckedChanged(object sender, EventArgs e)
        {
            lblStep1.BackColor = (rdStep1.Checked) ? Color.DodgerBlue : Color.Transparent;
            pnSelectSubject.Visible = rdStep1.Checked;
            pnTeacher.Visible = !rdStep1.Checked;
            pnInfomation.Visible = !rdStep1.Checked;
        }

        private void rdStep2_CheckedChanged(object sender, EventArgs e)
        {
            lblStep2.BackColor = (rdStep2.Checked) ? Color.DodgerBlue : Color.Transparent;
            pnSelectSubject.Visible = !rdStep2.Checked;
            pnTeacher.Visible = rdStep2.Checked;
            pnInfomation.Visible = !rdStep2.Checked;
        }

        private void rdStep3_CheckedChanged(object sender, EventArgs e)
        {
            lblStep3.BackColor = (rdStep3.Checked) ? Color.DodgerBlue : Color.Transparent;
            pnSelectSubject.Visible = !rdStep3.Checked;
            pnTeacher.Visible = !rdStep3.Checked;
            pnInfomation.Visible = rdStep3.Checked;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rdStep1.Checked) { rdStep2.Checked = true; }
            else if (rdStep2.Checked) { rdStep3.Checked = true; }
            else { rdStep1.Checked = true; }
        }

        private void btnCreateClass_Click(object sender, EventArgs e)
        {
            if (!checkInput()) return;
            if (!BUL.Class_BUL.CheckName(txtClassName.Text.Trim())) 
            {
                lblNotice.Text = "class name already exists, please choose another name!";
                return; 
            }
            DTO.Class_DTO newClass = new Class_DTO (txtClassID.Text,txtClassName.Text,Convert.ToInt32(txtYear.Text)
                ,txtIdTeacher.Text,txtSubjectID.Text);
            if (BUL.Class_BUL.InsertClass(newClass)) 
            {
                MessageBox.Show("Insert Thành công !");
                this.Close();
            }
            else
                lblNotice.Text = "ID class already exists, please choose another id";
        }
    }
}
