using BUL;
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
    public partial class DentailSubjectForm : Form
    {
        private Subject_DTO mySubject;
        private bool check()
        {
            bool wasError = true;
            if (!ErrorChecking.InputCheck.Id(txtSubjectID.Text.Trim()))
            {
                error.SetError(txtSubjectID, "Subject Id not valid !");
                wasError = false;
            }
            if (!ErrorChecking.InputCheck.Name(txtSubjectName.Text.Trim()))
            {
                error.SetError(txtSubjectName, "Subject Name not valid !");
                wasError = false;
            }
            if (!ErrorChecking.InputCheck.IsDescribe(txtSubjecDescribe.Text.Trim()))
            {
                error.SetError(txtSubjecDescribe, "Last Name không hợp lệ");
                wasError = false;
            }
            return wasError;
        }
        private void setSubject()
        {
            txtSubjectName.Text = mySubject.Name;
            txtSubjectID.Text = mySubject.SubjectId;
            txtSubjecDescribe.Text = mySubject.Describe;
            cbSemeter.Text = mySubject.Semester.ToString();
        }
        private void getSubject()
        {
            mySubject = new Subject_DTO(txtSubjectID.Text, txtSubjectName.Text, txtSubjecDescribe.Text, Convert.ToInt32(cbSemeter.Text));
        }
        public DentailSubjectForm(Subject_DTO newSubject)
        {
            InitializeComponent();
            this.mySubject = newSubject;
            setSubject();
            btnInsert.Visible = false;
            txtSubjectID.ReadOnly = true;
        }
        public DentailSubjectForm()
        {
            InitializeComponent();
            btnUpdate.Visible = false;
            btnDeleteStudent.Visible = false;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!check()) return;
            getSubject();
            if (Subject_BUL.UpdateSubject(mySubject))
                lblNotice.Text = "Update " + mySubject.ToString() + " successfully!";
            else
                lblNotice.Text = "Update  " + txtSubjectID.Text + " failed !";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!check()) return;
            getSubject();
            if (!Subject_BUL.checkName(mySubject.Name.Trim())) {
                lblNotice.Text = "The subject name already exists, please choose another name!";
                return;
            }
            if (Subject_BUL.InsertSubject(mySubject))
            {
                MessageBox.Show("Insert " + mySubject.Name + " successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                lblNotice.Text = "ID Subject  " + txtSubjectID.Text + " already exists !";
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            getSubject();
            DialogResult result = MessageBox.Show("Xác nhận xóa " + mySubject.ToString() + " ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            if (BUL.Subject_BUL.DeleteSubject(mySubject.SubjectId))
            {
                MessageBox.Show("Delete" + mySubject.ToString() + " successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                lblNotice.Text = "Delete " + mySubject.ToString() + " failed!";
        }
    }
}
