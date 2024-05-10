namespace StudentManagement.User_Control
{
    partial class UC_Subject
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Subject));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblTitleMaSubject = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblTenMonHoc = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pbxTeacher = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            lblSubjectId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnEdit = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            process1 = new System.Diagnostics.Process();
            ((System.ComponentModel.ISupportInitialize)pbxTeacher).BeginInit();
            guna2ShadowPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitleMaSubject
            // 
            lblTitleMaSubject.AutoSize = false;
            lblTitleMaSubject.BackColor = Color.Transparent;
            lblTitleMaSubject.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleMaSubject.ForeColor = SystemColors.ActiveCaptionText;
            lblTitleMaSubject.Location = new Point(12, 63);
            lblTitleMaSubject.Name = "lblTitleMaSubject";
            lblTitleMaSubject.Size = new Size(92, 43);
            lblTitleMaSubject.TabIndex = 13;
            lblTitleMaSubject.Text = "Mã môn học :";
            // 
            // lblTenMonHoc
            // 
            lblTenMonHoc.BackColor = Color.Transparent;
            lblTenMonHoc.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenMonHoc.ForeColor = SystemColors.ControlDarkDark;
            lblTenMonHoc.Location = new Point(14, 18);
            lblTenMonHoc.Name = "lblTenMonHoc";
            lblTenMonHoc.Size = new Size(193, 39);
            lblTenMonHoc.TabIndex = 10;
            lblTenMonHoc.Text = "TÊN MÔN HỌC";
            // 
            // pbxTeacher
            // 
            pbxTeacher.BackColor = Color.Transparent;
            pbxTeacher.BorderStyle = BorderStyle.FixedSingle;
            pbxTeacher.ErrorImage = Properties.Resources._2021_04_02______54181f0453a11f33299f4bae14c12353;
            pbxTeacher.FillColor = Color.Transparent;
            pbxTeacher.Image = (Image)resources.GetObject("pbxTeacher.Image");
            pbxTeacher.ImageRotate = 0F;
            pbxTeacher.Location = new Point(267, 18);
            pbxTeacher.Name = "pbxTeacher";
            pbxTeacher.ShadowDecoration.CustomizableEdges = customizableEdges1;
            pbxTeacher.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            pbxTeacher.Size = new Size(78, 78);
            pbxTeacher.SizeMode = PictureBoxSizeMode.Zoom;
            pbxTeacher.TabIndex = 11;
            pbxTeacher.TabStop = false;
            // 
            // lblSubjectId
            // 
            lblSubjectId.AutoSize = false;
            lblSubjectId.BackColor = Color.Transparent;
            lblSubjectId.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubjectId.ForeColor = SystemColors.ActiveCaptionText;
            lblSubjectId.Location = new Point(107, 63);
            lblSubjectId.Name = "lblSubjectId";
            lblSubjectId.Size = new Size(100, 43);
            lblSubjectId.TabIndex = 14;
            lblSubjectId.Text = "Mã môn học ";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.BackgroundImageLayout = ImageLayout.Center;
            btnEdit.CheckedState.ImageSize = new Size(64, 64);
            btnEdit.HoverState.ImageSize = new Size(64, 64);
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageOffset = new Point(0, 0);
            btnEdit.ImageRotate = 0F;
            btnEdit.ImageSize = new Size(50, 50);
            btnEdit.Location = new Point(215, 102);
            btnEdit.Name = "btnEdit";
            btnEdit.PressedState.ImageSize = new Size(64, 64);
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnEdit.Size = new Size(76, 65);
            btnEdit.TabIndex = 59;
            btnEdit.Click += btnEdit_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(177, 136);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(32, 19);
            guna2HtmlLabel1.TabIndex = 60;
            guna2HtmlLabel1.Text = "edit :";
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(guna2HtmlLabel1);
            guna2ShadowPanel1.Controls.Add(btnEdit);
            guna2ShadowPanel1.Controls.Add(pbxTeacher);
            guna2ShadowPanel1.Controls.Add(lblTitleMaSubject);
            guna2ShadowPanel1.Controls.Add(lblSubjectId);
            guna2ShadowPanel1.Controls.Add(lblTenMonHoc);
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(21, 21);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(362, 176);
            guna2ShadowPanel1.TabIndex = 61;
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // UC_Subject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(guna2ShadowPanel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "UC_Subject";
            Size = new Size(405, 217);
            ((System.ComponentModel.ISupportInitialize)pbxTeacher).EndInit();
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitleMaSubject;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTenMonHoc;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbxTeacher;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubjectId;
        private Guna.UI2.WinForms.Guna2ImageButton btnEdit;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Diagnostics.Process process1;
    }
}
