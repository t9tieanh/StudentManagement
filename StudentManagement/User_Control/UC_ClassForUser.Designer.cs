namespace StudentManagement.User_Control
{
    partial class UC_ClassForUser
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            picTeacher = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            lblClassId = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSubject = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnShowStudent = new Guna.UI2.WinForms.Guna2Button();
            lblYear = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)picTeacher).BeginInit();
            SuspendLayout();
            // 
            // picTeacher
            // 
            picTeacher.FillColor = Color.IndianRed;
            picTeacher.ImageRotate = 0F;
            picTeacher.Location = new Point(17, 7);
            picTeacher.Name = "picTeacher";
            picTeacher.ShadowDecoration.CustomizableEdges = customizableEdges1;
            picTeacher.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            picTeacher.Size = new Size(62, 62);
            picTeacher.SizeMode = PictureBoxSizeMode.Zoom;
            picTeacher.TabIndex = 0;
            picTeacher.TabStop = false;
            // 
            // lblClassId
            // 
            lblClassId.AutoSize = false;
            lblClassId.BackColor = Color.Transparent;
            lblClassId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblClassId.Location = new Point(108, 47);
            lblClassId.Name = "lblClassId";
            lblClassId.Size = new Size(552, 32);
            lblClassId.TabIndex = 67;
            lblClassId.Text = "lorem input dhafkl dhfkashlsdf dsfh a";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = false;
            lblSubject.BackColor = Color.Transparent;
            lblSubject.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubject.Location = new Point(108, 7);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(599, 44);
            lblSubject.TabIndex = 66;
            lblSubject.Text = "Title";
            // 
            // btnShowStudent
            // 
            btnShowStudent.BorderRadius = 10;
            btnShowStudent.CustomizableEdges = customizableEdges2;
            btnShowStudent.DisabledState.BorderColor = Color.DarkGray;
            btnShowStudent.DisabledState.CustomBorderColor = Color.DarkGray;
            btnShowStudent.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnShowStudent.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnShowStudent.FillColor = Color.FromArgb(9, 132, 227);
            btnShowStudent.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnShowStudent.ForeColor = Color.White;
            btnShowStudent.ImageSize = new Size(35, 35);
            btnShowStudent.Location = new Point(727, 47);
            btnShowStudent.Name = "btnShowStudent";
            btnShowStudent.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnShowStudent.Size = new Size(114, 32);
            btnShowStudent.TabIndex = 68;
            btnShowStudent.Text = "Show Student";
            btnShowStudent.Click += btnShowStudent_Click;
            // 
            // lblYear
            // 
            lblYear.AutoSize = false;
            lblYear.BackColor = Color.Transparent;
            lblYear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblYear.Location = new Point(793, 3);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(60, 32);
            lblYear.TabIndex = 69;
            lblYear.Text = "Year";
            // 
            // UC_ClassForUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(lblYear);
            Controls.Add(btnShowStudent);
            Controls.Add(lblClassId);
            Controls.Add(lblSubject);
            Controls.Add(picTeacher);
            Name = "UC_ClassForUser";
            Size = new Size(853, 82);
            ((System.ComponentModel.ISupportInitialize)picTeacher).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox picTeacher;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblClassId;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSubject;
        private Guna.UI2.WinForms.Guna2Button btnShowStudent;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblYear;
    }
}
