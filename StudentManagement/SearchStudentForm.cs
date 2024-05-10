using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUL;
using DTO;
namespace StudentManagement
{
    public partial class SearchStudentForm : Form
    {
        public SearchStudentForm()
        {
            InitializeComponent();
        }
        #region di chuyển form 
        /// <summary>
        /// điều khiển tab form
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
        /// check user lựa chọn field tìm kiếm
        /// </summary>
        /// <returns></returns>

        private string Check()
        {
            if (chkId.Checked) return "STUDENTID";
            else if (chkFname.Checked) return "FIRSTNAME";
            else return "PHONE";
        }
        /// <summary>
        /// xử lý sự kiện CellContentClick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <summary>
        /// form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchStudentForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvStudentList.DataSource = Student_BUL.GetStudent();
                DataGridViewImageColumn pic = (DataGridViewImageColumn)dgvStudentList.Columns[7];
                pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu từ Database");
            }
        }

        private void dgvStudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvStudentList.CurrentRow.Index;
            lblFirstName.Text = dgvStudentList.Rows[i].Cells[1].Value.ToString().Trim();
            lblLastName.Text = dgvStudentList.Rows[i].Cells[2].Value.ToString().Trim();
            lblKhoa.Text = dgvStudentList.Rows[i].Cells[8].Value.ToString().Trim();

            byte[] pic = (byte[])dgvStudentList.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            pbxPicStudent.Image = Image.FromStream(picture);

            int sex = Convert.ToInt32(dgvStudentList.Rows[i].Cells[4].Value);
            if (sex == 0) rdNam.Checked = true;
            else if (sex == 1) rdNu.Checked = true;
            else rdOther.Checked = true;
        }
        /// <summary>
        /// tìm kiếm 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvStudentList.DataSource = Student_BUL.FindStudent(Check(), txtFind.Text);
            }
            catch { MessageBox.Show("Không lấy được dữ liệu từ Database"); }
        }
    }
}
