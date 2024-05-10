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

namespace StudentManagement.User_Control
{
    public partial class UC_Subject : UserControl
    {
        private Subject_DTO subject;

        public UC_Subject()
        {
            InitializeComponent();
        }
        private void SetData()
        {
            lblSubjectId.Text = subject.SubjectId;
            lblTenMonHoc.Text = subject.Name;
        }
        public UC_Subject(Subject_DTO subject)
        {
            InitializeComponent();
            this.subject = subject;
            SetData();
        }
        public Subject_DTO Subject { get => subject; set => subject = value; }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DentailSubjectForm UpdateSubject = new DentailSubjectForm(subject);
            UpdateSubject.ShowDialog();
        }
    }
}
