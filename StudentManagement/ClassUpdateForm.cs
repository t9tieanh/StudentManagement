using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace StudentManagement
{
    public partial class ClassUpdateForm : Form
    {
        private Class_DTO myClass;
        private void GetmyClass()
        {
            myClass = new Class_DTO(txtClassID.Text, txtClassName.Text,
                Convert.ToInt32(txtYear.Text), txtIdTeacher.Text, txtSubjectID.Text);
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
        #region các hàm get (lấy dữ liệu từ database  )
        private void GetStudent()
        {
            dgvStudent.DataSource = BUL.Student_BUL.GetStudent();
            DataGridViewImageColumn pic = (DataGridViewImageColumn)dgvStudent.Columns[7];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        private void GetStudent(string field, string value)
        {
            dgvStudent.DataSource = BUL.Student_BUL.FindStudent(field, value);
            DataGridViewImageColumn pic = (DataGridViewImageColumn)dgvStudent.Columns[7];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
        /// <summary>
        /// hàm get cho delete
        /// </summary>
        private void GetDeleteStudent()
        {
            try
            {
                dgvDeleteStudent.DataSource = BUL.Class_BUL.GetStudent(myClass);
                DataGridViewImageColumn pic = (DataGridViewImageColumn)dgvDeleteStudent.Columns[3];
                pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            catch
            {
                MessageBox.Show("Lỗi không lấy được dữ liệu!", "Notice");
            }
        }
        /// <summary>
        /// hàm get student cho score
        /// </summary>
        private void GetScoreStudent()
        {
            try
            {
                dgvScoreStudent.DataSource = BUL.Class_BUL.GetStudent(myClass);
                DataGridViewImageColumn pic = (DataGridViewImageColumn)dgvScoreStudent.Columns[3];
                pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
                /*DataGridViewColumn scoreColumn = dgvScoreStudent.Columns[4];
                DataGridViewColumn commentColumn = dgvScoreStudent.Columns[5];

                // Đặt ReadOnly = false cho cả hai cột
                scoreColumn.ReadOnly = true;
                commentColumn.ReadOnly = true;*/
                DataGridViewColumn columnId = dgvScoreStudent.Columns[0];
                DataGridViewColumn columnFn = dgvScoreStudent.Columns[1];
                DataGridViewColumn columnLn = dgvScoreStudent.Columns[2];
                DataGridViewColumn columnb = dgvScoreStudent.Columns[3];


                // Đặt ReadOnly = false cho cả hai cột
                columnId.ReadOnly = true;
                columnFn.ReadOnly = true;
                columnLn.ReadOnly = true;
                columnb.ReadOnly = true;
            }
            catch
            {
                MessageBox.Show("Lỗi không lấy được dữ liệu!", "Notice");
            }
        }
        #endregion
        private void SetMyClass()
        {
            txtIdTeacher.Text = myClass.TeacherId;
            txtTeacher.Text = myClass.TeacherName;
            txtName.Text = myClass.TeacherName;
            txtSubjectID.Text = myClass.SubjectId;
            txtSubjectName.Text = myClass.SubjectName;
            txtSubject.Text = myClass.SubjectName;
            txtClassID.Text = myClass.ClassID;
            txtClassName.Text = myClass.ClassName;
            txtYear.Text = myClass.Year + " ";
            pbxTeacher.Image = Image.FromStream(myClass.TeacherPicture);
            pbxTeacherpic.Image = pbxTeacher.Image;

        }
        public ClassUpdateForm(Class_DTO myClass, bool isAdmin)
        {
            InitializeComponent();
            this.myClass = myClass;
            GetSubject();
            GetTeacher();
            GetStudent();
            GetDeleteStudent();
            GetScoreStudent();
            //this.myClass = myClass;
            rdStep3.Checked = true;
            SetMyClass();
            // ẩn các control khi sử dụng form với tư các teacher (teacher không được thay đổi thông tin của lớp )
            rdStep1.Enabled = isAdmin;
            rdStep2.Enabled = isAdmin;
            rdStep3.Enabled = isAdmin;
            btnDelete.Enabled = isAdmin;
            btnUpdate.Enabled = isAdmin;
            btnNext.Enabled = isAdmin;
            //
            LoadDataScore();
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rdStep1.Checked) { rdStep2.Checked = true; }
            else if (rdStep2.Checked) { rdStep3.Checked = true; }
            else { rdStep1.Checked = true; }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            GetmyClass();
            if (BUL.Class_BUL.UpdateClass(myClass))
                lblNotice.Text = "Update " + myClass.ToString() + "successfully!";
            else lblNotice.Text = "Update " + myClass.ToString() + "failed!";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa " + txtClassID.Text + " ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            if (BUL.Class_BUL.DeleteClass(txtClassID.Text))
            {
                MessageBox.Show("Delete " + txtClassID.Text + " successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else lblNotice.Text = "Deltete " + txtClassID.Text + "failed!";
        }

        //---------------------
        private void btnSelect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow selectedRow in dgvStudent.SelectedRows)
            {
                DataGridViewRow newRow = selectedRow.Clone() as DataGridViewRow;
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    newRow.Cells[cell.ColumnIndex].Value = cell.Value;
                }
                dgvSelectStudent.Rows.Add(newRow);
            }
        }

        private void txtSearchClass_TextChanged(object sender, EventArgs e)
        {
            GetStudent(cbStudent.Text.Trim(), txtSearchStudent.Text.Trim());
        }
        private void btnInsertStudent_Click(object sender, EventArgs e)
        {
            string failed = "";
            string success = "";
            foreach (DataGridViewRow row in dgvSelectStudent.Rows)
            {
                if (!BUL.Class_BUL.CheckJoinClass(row.Cells[0].Value.ToString(), myClass))
                {
                    failed += row.Cells[0].Value.ToString().Trim() + " - " + row.Cells[1].Value.ToString().Trim() + " " + row.Cells[2].Value.ToString().Trim() + ", ";
                    continue;
                }
                if (!BUL.Class_BUL.InsertStudentToClass(row.Cells[0].Value.ToString(), myClass))
                    failed += row.Cells[0].Value.ToString().Trim() + " - " + row.Cells[1].Value.ToString().Trim() + " " + row.Cells[2].Value.ToString().Trim() + ", ";
                else
                    success += row.Cells[0].Value.ToString().Trim() + " - " + row.Cells[1].Value.ToString().Trim() + " " + row.Cells[2].Value.ToString().Trim() + ", ";
            }
            MessageBox.Show("List of students added to class " + myClass.ToString() + " : \n" + success + "\n\nList of additional failed students : \n" + failed
                , "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvSelectStudent.Rows.Clear();
        }

        private void dgvDeleteStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvDeleteStudent.CurrentRow.Index;
            lblStudentID.Text = dgvDeleteStudent.Rows[i].Cells[0].Value.ToString().Trim();
            lblFirstName.Text = dgvDeleteStudent.Rows[i].Cells[1].Value.ToString().Trim();
            lblLastName.Text = dgvDeleteStudent.Rows[i].Cells[2].Value.ToString().Trim();
            lblScore.Text = dgvDeleteStudent.Rows[i].Cells[4].Value.ToString().Trim();
            lblComment.Text = dgvDeleteStudent.Rows[i].Cells[5].Value.ToString().Trim();

            byte[] pic = (byte[])dgvDeleteStudent.CurrentRow.Cells[3].Value;
            MemoryStream picture = new MemoryStream(pic);
            pbxPicStudent.Image = Image.FromStream(picture);
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận xóa " + lblFirstName.Text + " ra khỏi lớp học ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            if (BUL.Class_BUL.DeleteJoinClass(lblStudentID.Text.Trim(), myClass))
            {
                MessageBox.Show("Delete " + lblFirstName.Text + " successfully!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataScore();
            }
            else MessageBox.Show("Delete " + lblFirstName.Text + " failed!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRefeshClass_Click(object sender, EventArgs e)
        {
            GetDeleteStudent();
        }

        private void btnUpdateStore_Click(object sender, EventArgs e)
        {
            /*string failed = "";
            string success = "";
            foreach (DataGridViewRow row in dgvScoreStudent.Rows)
            {
                int scoreStudent;
                try
                {
                    scoreStudent = Convert.ToInt32(row.Cells[4].Value.ToString());
                    if (scoreStudent < 0 || scoreStudent > 10)
                    {
                        failed += row.Cells[0].Value.ToString().Trim() + " - " + row.Cells[1].Value.ToString().Trim() + " "+row.Cells[2].Value.ToString().Trim() + " Do nhập điểm không hợp lệ !\n";
                        continue;
                    }
                }
                catch {
                    failed += row.Cells[0].Value.ToString().Trim() + " - " + row.Cells[1].Value.ToString().Trim() +" "+ row.Cells[2].Value.ToString().Trim() + " Do nhập điểm không hợp lệ !\n";
                    continue;
                }
                if (!BUL.Class_BUL.UpdateScore(row.Cells[0].Value.ToString(), myClass, scoreStudent, row.Cells[5].Value.ToString()))
                    failed += row.Cells[0].Value.ToString().Trim() + " - " + row.Cells[1].Value.ToString().Trim() + " " + row.Cells[2].Value.ToString().Trim() + " do lỗi từ hệ thống! \n";
                else
                    success += row.Cells[0].Value.ToString().Trim() + " - " + row.Cells[1].Value.ToString().Trim() + " " + row.Cells[2].Value.ToString().Trim() + "\n ";
            }
            MessageBox.Show("List of students updated score to class " + myClass.ToString() + " : \n" + success + "\n\nList of update score failed students : \n" + failed
                , "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            string failed = "";
            string success = "";

            // Lấy DataTable từ DataGridView's DataSource
            DataTable originalDataTable = (DataTable)dgvScoreStudent.DataSource;

            // Lấy các thay đổi từ DataTable
            DataTable changesDataTable = originalDataTable.GetChanges();

            if (changesDataTable != null)
            {
                foreach (DataRow row in changesDataTable.Rows)
                {
                    int scoreStudent;
                    try
                    {
                        scoreStudent = Convert.ToInt32(row[4]);
                        if (scoreStudent < 0 || scoreStudent > 10)
                        {
                            failed += row[0].ToString().Trim() + " - " + row[1].ToString().Trim() + " " + row[2].ToString().Trim() + " Do nhập điểm không hợp lệ !\n";
                            continue;
                        }
                    }
                    catch
                    {
                        failed += row[0].ToString().Trim() + " - " + row[1].ToString().Trim() + " " + row[2].ToString().Trim() + " Do nhập điểm không hợp lệ !\n";
                        continue;
                    }
                    if (!BUL.Class_BUL.UpdateScore(row[0].ToString(), myClass, scoreStudent, row[5].ToString()))
                        failed += row[0].ToString().Trim() + " - " + row[1].ToString().Trim() + " " + row[2].ToString().Trim() + " do lỗi từ hệ thống! \n";
                    else
                        success += row[0].ToString().Trim() + " - " + row[1].ToString().Trim() + " " + row[2].ToString().Trim() + "\n ";
                }
            }

            // Hiển thị kết quả
            MessageBox.Show("List of students updated score to class " + myClass.ToString() + " : \n" + success + "\n\nList of update score failed students : \n" + failed
                , "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataScore();
        }

        private void btnRfscore_Click(object sender, EventArgs e)
        {
            GetScoreStudent();
        }
        // code cho phần Raking chart 
        private DataTable dataTableScore;
        private int countWeekStudent = 0;
        private int countGoodStudent = 0;
        private int countMediumStudent = 0;
        private int countBestStudent = 0;
        private void analysisData(DataTable dt)
        {
            if (dt.Rows.Count == 0) return;
            int sum = 0;
            foreach (DataRow row in dt.Rows)
            {
                int score = Convert.ToInt32(row[0]);
                if (score < 5)
                    countWeekStudent += 1;
                else if (score < 7)
                    countMediumStudent += 1;
                else if (score < 8)
                    countGoodStudent += 1;
                else
                    countBestStudent += 1;
                sum += score;
            }
            lblTotalStudentScored.Text = dt.Rows.Count.ToString();
            lblTotalBestStudent.Text = countBestStudent.ToString();
            lblTotalWeekStudent.Text = countWeekStudent.ToString();
            lblAvgScore.Text = (sum / ((dt.Rows.Count) * 1.0)).ToString();

            processWeek.Value = (int)(((countWeekStudent * 1.0) / (dt.Rows.Count)) * 100);
            processMedium.Value = (int)(((countMediumStudent * 1.0) / (dt.Rows.Count))) * 100;
            processGood.Value = (int)(((countGoodStudent * 1.0) / (dt.Rows.Count)) * 100);
            processBest.Value = 100 - processWeek.Value - processMedium.Value - processGood.Value;

            lblBestValue.Text = processBest.Value.ToString() + "%";
            lblMediumValue.Text = processMedium.Value.ToString() + "%";
            lblGoodValue.Text = processGood.Value.ToString() + "%";
            lblWeekValue.Text = processWeek.Value.ToString() + "%";
        }
        private void LoadDataScore()
        {
            dataTableScore = BUL.Class_BUL.ScoreClass(myClass.ClassID);
            if (dataTableScore == null) return;
            analysisData(dataTableScore);
        }

        private void btnRefeshDataChart_Click(object sender, EventArgs e)
        {
            LoadDataScore();
        }
    }
}
