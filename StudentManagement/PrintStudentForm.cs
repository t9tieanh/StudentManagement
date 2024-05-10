﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class PrintStudentForm : Form
    {
        public PrintStudentForm()
        {
            InitializeComponent();
            GetStudent();
        }
        #region di chuyển tab form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);
        private void pn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        #endregion 
        private void GetStudent()
        {
            try
            {
                // Xóa dữ liệu trong các hàng
                foreach (DataGridViewRow row in dgvStudent.Rows)
                {
                    dgvStudent.Rows.Remove(row);
                }

                dgvStudent.Columns.Clear();

                DataTable dt = BUL.Student_BUL.FindStudent(cbStudent.Text, txtSearchStudent.Text.Trim());
                dgvStudent.DataSource = dt;
                lblCount.Text = "Số lượng: " + dt.Rows.Count;
                /*if (dt.Rows.Count > 15)
                {
                    dgvStudent.RowTemplate.Height = 571 / dt.Rows.Count;
                    Font newFont = new Font("Consolas", 20 / dt.Rows.Count + 6, FontStyle.Regular); // Thay đổi "Arial" và 12 để phù hợp với yêu cầu của bạn

                    // Đặt Font cho tất cả các ô trong DataGridView
                    dgvStudent.DefaultCellStyle.Font = newFont;
                }*/
                //thêm cột stt
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = "Số Thứ Tự";
                dgvStudent.Columns.Insert(0, column);
                DataGridViewImageColumn pic = (DataGridViewImageColumn)dgvStudent.Columns[8];
                pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
                lblTitleClass.Text = "Danh Sách Sinh Viên " + cbStudent.Text + " : " + txtSearchStudent.Text.Trim();
            }
            catch
            {
                MessageBox.Show("Lỗi không lấy được dữ liệu!", "Notice");
            }
            // Xử lý sự kiện khi số lượng hàng thay đổi
            dgvStudent.RowsAdded += DataGridView1_RowsAdded;
            dgvStudent.RowsRemoved += DataGridView1_RowsRemoved;
        }
        #region thêm cột stt
        private void DataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            // Cập nhật lại số thứ tự khi hàng mới được thêm vào
            for (int i = e.RowIndex; i < dgvStudent.Rows.Count; i++)
            {
                dgvStudent.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        private void DataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // Cập nhật lại số thứ tự khi hàng được xóa
            for (int i = e.RowIndex; i < dgvStudent.Rows.Count; i++)
            {
                dgvStudent.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }
        #endregion

        private void txtSearchStudent_TextChanged(object sender, EventArgs e)
        {
            GetStudent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            btnPrint.Visible = false;
            pn.Visible = false;
            txtSearchStudent.Visible = false;
            cbStudent.Visible = false;
            // Tạo một Bitmap để chứa nội dung của form
            Bitmap bmp = new Bitmap(this.Width, this.Height);

            // Vẽ nội dung của form lên bitmap
            this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height));

            // Hiển thị bitmap trong một hộp thoại xem trước khi in
            using (PrintDocument pd = new PrintDocument())
            {
                pd.PrintPage += (s, ev) =>
                {
                    // Vẽ hình ảnh lên tài liệu in
                    ev.Graphics.DrawImage(bmp, 0, 0, ev.PageBounds.Width, ev.PageBounds.Height);
                };

                PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
                printPreviewDialog1.Document = pd;
                //
                printPreviewDialog1.ShowDialog();
            }
            pn.Visible = true;
            btnPrint.Visible = true;
            txtSearchStudent.Visible = false;
            cbStudent.Visible = false;
        }
    }
}
