using DTO;
using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class StaticStudentForm : Form
    {
        private int totalStudent;
        // đánh giá chi tiết 
        private double totalBestStudent;
        private double totalGoodStudent;
        private double totalMediumStudent;
        private double totalWeakStudent;
        // tổng số nam nữ 
        private double totalMale;
        private double totalFemale;
        private double totalOther;
        #region di chuyển form 
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
        private void ReloadData()
        {
            totalGoodStudent = BUL.Student_BUL.StudentScore(cbDepartment.Text, 7, 8);
            totalBestStudent = BUL.Student_BUL.StudentScore(cbDepartment.Text, 8, 10);
            totalMediumStudent = BUL.Student_BUL.StudentScore(cbDepartment.Text, 5, 7);
            totalWeakStudent = BUL.Student_BUL.StudentScore(cbDepartment.Text, 0, 5);

            totalStudent = BUL.Student_BUL.StudentTotal(cbDepartment.Text);
            totalFemale = BUL.Student_BUL.StudentTotalSex(cbDepartment.Text, (int)Gender_DTO.female);
            totalMale = BUL.Student_BUL.StudentTotalSex(cbDepartment.Text, (int)Gender_DTO.male);
            totalOther = totalStudent - totalFemale - totalMale;
            //set các panel
            lblTotalBestStudent.Text = totalBestStudent.ToString();
            lblTotalWeekStudent.Text = totalWeakStudent.ToString();
            //tính biểu đồ thống kê nam nữ 
            lblTotalStudent.Text = totalStudent.ToString();
            lblTotalFemale.Text = totalFemale.ToString();
            lblTotalMale.Text = totalMale.ToString();
            lblTotalOther.Text = totalOther.ToString();
            if (totalStudent != 0)
            {
                ProcessFemale.Value = (int)((totalFemale * 100) / totalStudent);
                ProcessMale.Value = (int)(totalMale * 100) / totalStudent;
                ProcessOther.Value = 100 - ProcessMale.Value - ProcessFemale.Value;
            }
            // tính biểu đồ thống kê score 
            double totalScoreStudent = totalGoodStudent + totalBestStudent + totalMediumStudent + totalWeakStudent;
            if (totalScoreStudent != 0)
            {
                processBest.Value = (int)((totalBestStudent * 100) / totalScoreStudent);
                lblBestValue.Text = processBest.Value + "%";
                processGood.Value = (int)((totalGoodStudent * 100) / totalScoreStudent);
                lblGoodValue.Text = processGood.Value + "%";
                processMedium.Value = (int)((totalMediumStudent * 100) / totalScoreStudent);
                lblMediumValue.Text = processMedium.Value + "%";
                processWeek.Value = 100 - processBest.Value - processGood.Value - processMedium.Value;
                lblWeekValue.Text = processWeek.Value + "%";
            }
        }
        public StaticStudentForm()
        {
            InitializeComponent();
            ReloadData();
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadData();
        }
    }
}
