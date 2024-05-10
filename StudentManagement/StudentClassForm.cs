using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class StudentClassForm : Form
    {
        private Student_DTO myStudent;
        private void getMyClass()
        {
            lblNameStudent.Text = myStudent.FirstName + " " + myStudent.LastName;
            try
            {
                dgvClass.DataSource = BUL.Class_BUL.GetClassStudent(myStudent.StudentId.ToString());
                dgvClassCanRegistration.DataSource = BUL.Class_BUL.GetClassStudentCanRegister(myStudent.StudentId.ToString());
            }
            catch
            {
                MessageBox.Show("Không thể lấy dữ liệu từ database !");
            }
        }
        public StudentClassForm()
        {
            InitializeComponent();
        }
        public StudentClassForm(Student_DTO myStudent)
        {
            InitializeComponent();
            this.myStudent = myStudent;
            getMyClass();
            //
            txtClassId.Enabled = false;
            txtClassName.Enabled = false;
            txtNameSubject.Enabled = false;
            txtNameTeacher.Enabled = false;
            txtYear.Enabled = false; 
            //
        }

        private void dgvClassCanRegistration_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvClassCanRegistration.CurrentRow.Index;
            txtClassId.Text = dgvClassCanRegistration.Rows[i].Cells[0].Value.ToString().Trim();
            txtClassName.Text = dgvClassCanRegistration.Rows[i].Cells[1].Value.ToString().Trim();
            txtNameSubject.Text = dgvClassCanRegistration.Rows[i].Cells[2].Value.ToString().Trim();
            txtNameTeacher.Text = dgvClassCanRegistration.Rows[i].Cells[3].Value.ToString().Trim() + " " +
                dgvClassCanRegistration.Rows[i].Cells[4].Value.ToString().Trim();
            txtYear.Text = dgvClassCanRegistration.Rows[i].Cells[5].Value.ToString().Trim();
        }

        private void btnRegisterClass_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm more student "+myStudent.ToString()+" in class " + txtClassId.Text +" - "+ txtClassName.Text+" ?", "Comfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            if (BUL.Class_BUL.InsertStudentToClass(myStudent.StudentId.ToString(), new Class_DTO(txtClassId.Text)))
            {
                lblNotice.Text = $"Add students {myStudent.ToString()} to class {txtClassId.Text + " - " + txtClassName.Text} successfully!";
                getMyClass();
            }
            else
                lblNotice.Text = $"Add students {myStudent.ToString()} to class {txtClassId.Text + " - " + txtClassName.Text} failed!";
        }
    }
}
