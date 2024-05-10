using BUL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using ExcelDataReader;
namespace StudentManagement
{
    public partial class StudentListForm : Form
    {
        private void refreshData()
        {
            try
            {
                dgvStudentList.Columns.Clear();
                dgvStudentList.DataSource = Student_BUL.GetStudent();
                DataGridViewImageColumn pic = (DataGridViewImageColumn)dgvStudentList.Columns[7];
                pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
                valuedgv = true;
                btnSave.Visible = false;
            }
            catch { MessageBox.Show("Không lấy được dữ liệu từ Database"); }
        }
        public StudentListForm()
        {
            InitializeComponent();
            refreshData();
        }
        #region di chuyển tab
        /// <summary>
        /// di chuyển tab
        /// </summary>
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        #endregion
        private void pbxRefresh_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void StudentListForm_Load(object sender, EventArgs e)
        {
            refreshData();
        }
        private void pnTab_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnUpdateorDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int i = dgvStudentList.CurrentRow.Index;

                Gender_DTO gender = new Gender_DTO();
                gender = (Gender_DTO)Convert.ToInt32(dgvStudentList.Rows[i].Cells[4].Value);

                byte[] pic = (byte[])dgvStudentList.CurrentRow.Cells[7].Value;
                MemoryStream picture = new MemoryStream(pic);

                Student_DTO student = new Student_DTO(Convert.ToInt32(dgvStudentList.Rows[i].Cells[0].Value.ToString().Trim()), dgvStudentList.Rows[i].Cells[1].Value.ToString().Trim(),
                    dgvStudentList.Rows[i].Cells[2].Value.ToString().Trim(), (DateTime)(dgvStudentList.Rows[i].Cells[3].Value), gender,
                    dgvStudentList.Rows[i].Cells[5].Value.ToString().Trim(), dgvStudentList.Rows[i].Cells[6].Value.ToString().Trim(), picture, dgvStudentList.Rows[i].Cells[8].Value.ToString().Trim());
                UpdateStudentForm updateStudentForm = new UpdateStudentForm(student);
                this.Hide();
                updateStudentForm.ShowDialog();
                this.Show();
            }
            catch
            {
                lblNotice.Text = "You have not selected a student !";
            }
        }

        private void dgvStudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (valuedgv)
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
                else
                {
                    int i = dgvStudentList.CurrentRow.Index;
                    lblFirstName.Text = dgvStudentList.Rows[i].Cells["First Name"].Value.ToString().Trim();
                    lblLastName.Text = dgvStudentList.Rows[i].Cells["Last Name"].Value.ToString().Trim();
                }
            }
            catch 
            {
                MessageBox.Show("File không đúng định dạng!");
            }
        }
        private DataTableCollection dataTableCollection;
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Title = "Chọn file Excel";

                // Thiết lập bộ lọc để chỉ hiển thị file Excel
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

                // Thiết lập loại file mặc định
                openFileDialog.DefaultExt = "xlsx";

                // Cho phép chọn nhiều file
                openFileDialog.Multiselect = false;

                DialogResult result = openFileDialog.ShowDialog(); // Hiển thị hộp thoại mở tệp
                if (result == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    // Sử dụng đường dẫn tệp đã chọn
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet rs = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            dataTableCollection = rs.Tables;
                            foreach (DataTable table in dataTableCollection)
                            {
                                cbImport.Items.Add(table.TableName);
                            }
                            cbImport.Text = "Select Table";
                            cbImport.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi, có thể là có process khác đang truy cập file này hoặc lỗi khác !" + ex.ToString());
            }
        }

        private bool valuedgv = true; // valuedgv xác định datagridview đang có value là dữ liệu ở db hay là người dùng mới import file
        private void cbImport_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = dataTableCollection[cbImport.SelectedItem.ToString()];
                // điều chỉnh lại datatable
                for (int i = dt.Columns.Count - 1; i >= 0; i--)
                {
                    DataColumn column = dt.Columns[i];
                    if (dt.Rows[0][i].ToString().Trim() == "")
                    {
                        dt.Columns.RemoveAt(i);
                    }
                }
                // thêm các cột cần thiết 
                dt.Columns.Add("Email");
                //dt.Columns.Add ("")
                //
                pbxPicStudent.Image = Properties.Resources._416137715_775449341288653_2240139542177004199_n;
                //
                dgvStudentList.DataSource = dt;
                dgvStudentList.Columns.Add("Address", "Address");
                dgvStudentList.Columns.Add("Phone", "Phone");
                foreach (DataGridViewRow row in dgvStudentList.Rows)
                {
                    row.Cells["Email"].Value = row.Cells["Mã SV"].Value.ToString() + "@student.hcmute.edu.vn";
                }
            }
            catch
            {
                MessageBox.Show("File không đúng định dạng !", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            valuedgv = false;
            dgvStudentList.ReadOnly = false;
            btnUpdateorDelete.Visible = false;
            btnSave.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (valuedgv)
                    return;
                string resultSuccess = "";
                string resultFailed = "";
                foreach (DataGridViewRow row in dgvStudentList.Rows)
                {
                    MemoryStream pictureStudent = new MemoryStream();
                    pbxPicStudent.Image.Save(pictureStudent, pbxPicStudent.Image.RawFormat);
                    string addressValue = row.Cells["Address"].Value != null ? row.Cells["Address"].Value.ToString() : "";
                    string phoneValue = row.Cells["Phone"].Value != null ? row.Cells["Phone"].Value.ToString() : "";
                    Student_DTO student = new Student_DTO(Convert.ToInt32(row.Cells["Mã SV"].Value.ToString().Trim()), row.Cells["First Name"].Value.ToString()
                            , row.Cells["Last Name"].Value.ToString()
                            , DateTime.ParseExact(row.Cells["Ngày sinh"].Value.ToString().Trim(), "d/M/yyyy", System.Globalization.CultureInfo.InvariantCulture),
                            row.Cells["Email"].Value.ToString(), pictureStudent, addressValue,phoneValue);
                    if (BUL.Student_BUL.InsertStudent(student))
                        resultSuccess += ("\n" + student.StudentId );
                    else
                        resultFailed += (" \n" + student.StudentId + " do sinh viên này đã tồn tại trong hệ thống ");
                }
                MessageBox.Show("Danh sách sinh viên thêm thành công : " + resultSuccess + "\n\n" + "Danh sách sinh viên thêm thất bại : " + resultFailed, "Notice", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch {
                MessageBox.Show("File không đúng định dạng !", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            refreshData();
            cbImport.Enabled = false;
        }
    }
}
