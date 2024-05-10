namespace StudentManagement.User_Control
{
    partial class UC_TeacherForUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TeacherForUser));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnPreview = new Guna.UI2.WinForms.Guna2Button();
            picTeacher = new Guna.UI2.WinForms.Guna2PictureBox();
            lblTeacherId = new Label();
            label4 = new Label();
            lblPhoneNumber = new Label();
            lblPhone = new Label();
            lblNameTeacher = new Label();
            ((System.ComponentModel.ISupportInitialize)picTeacher).BeginInit();
            SuspendLayout();
            // 
            // btnPreview
            // 
            btnPreview.BorderRadius = 10;
            btnPreview.CustomizableEdges = customizableEdges1;
            btnPreview.DisabledState.BorderColor = Color.DarkGray;
            btnPreview.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPreview.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPreview.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPreview.FillColor = Color.FromArgb(9, 132, 227);
            btnPreview.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnPreview.ForeColor = Color.White;
            btnPreview.Location = new Point(192, 76);
            btnPreview.Name = "btnPreview";
            btnPreview.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnPreview.Size = new Size(108, 30);
            btnPreview.TabIndex = 13;
            btnPreview.Text = "Preview";
            btnPreview.Click += btnPreview_Click;
            // 
            // picTeacher
            // 
            picTeacher.CustomizableEdges = customizableEdges3;
            picTeacher.Image = (Image)resources.GetObject("picTeacher.Image");
            picTeacher.ImageRotate = 0F;
            picTeacher.Location = new Point(235, 18);
            picTeacher.Name = "picTeacher";
            picTeacher.ShadowDecoration.CustomizableEdges = customizableEdges4;
            picTeacher.Size = new Size(50, 45);
            picTeacher.SizeMode = PictureBoxSizeMode.Zoom;
            picTeacher.TabIndex = 12;
            picTeacher.TabStop = false;
            // 
            // lblTeacherId
            // 
            lblTeacherId.AutoSize = true;
            lblTeacherId.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTeacherId.ForeColor = Color.FromArgb(99, 110, 114);
            lblTeacherId.Location = new Point(104, 9);
            lblTeacherId.Name = "lblTeacherId";
            lblTeacherId.Size = new Size(52, 17);
            lblTeacherId.TabIndex = 11;
            lblTeacherId.Text = "Id here";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(99, 110, 114);
            label4.Location = new Point(14, 9);
            label4.Name = "label4";
            label4.Size = new Size(74, 17);
            label4.TabIndex = 10;
            label4.Text = "Id Teacher";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhoneNumber.ForeColor = Color.FromArgb(99, 110, 114);
            lblPhoneNumber.Location = new Point(83, 89);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(81, 17);
            lblPhoneNumber.TabIndex = 9;
            lblPhoneNumber.Text = "Id User here";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.ForeColor = Color.FromArgb(99, 110, 114);
            lblPhone.Location = new Point(18, 89);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(57, 17);
            lblPhone.TabIndex = 8;
            lblPhone.Text = "Phone :";
            // 
            // lblNameTeacher
            // 
            lblNameTeacher.AutoSize = true;
            lblNameTeacher.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNameTeacher.Location = new Point(14, 41);
            lblNameTeacher.Name = "lblNameTeacher";
            lblNameTeacher.Size = new Size(142, 22);
            lblNameTeacher.TabIndex = 7;
            lblNameTeacher.Text = "Name Teacher";
            // 
            // UC_TeacherForUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            Controls.Add(btnPreview);
            Controls.Add(picTeacher);
            Controls.Add(lblTeacherId);
            Controls.Add(label4);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblPhone);
            Controls.Add(lblNameTeacher);
            Name = "UC_TeacherForUser";
            Size = new Size(312, 119);
            ((System.ComponentModel.ISupportInitialize)picTeacher).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnPreview;
        private Guna.UI2.WinForms.Guna2PictureBox picTeacher;
        private Label lblTeacherId;
        private Label label4;
        private Label lblPhoneNumber;
        private Label lblPhone;
        private Label lblNameTeacher;
    }
}
