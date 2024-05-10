namespace StudentManagement
{
    partial class ClassTeacherFromUserForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassTeacherFromUserForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            flpnClass = new FlowLayoutPanel();
            picTeacher = new Guna.UI2.WinForms.Guna2PictureBox();
            lblTeacherId = new Label();
            label4 = new Label();
            lblPhoneNumber = new Label();
            lblPhone = new Label();
            lblNameTeacher = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            lblTeacher = new Label();
            pnTop = new Guna.UI2.WinForms.Guna2Panel();
            btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            lblNotice = new Label();
            ((System.ComponentModel.ISupportInitialize)picTeacher).BeginInit();
            guna2Panel1.SuspendLayout();
            pnTop.SuspendLayout();
            SuspendLayout();
            // 
            // flpnClass
            // 
            flpnClass.BackColor = SystemColors.ButtonHighlight;
            flpnClass.Location = new Point(14, 184);
            flpnClass.Name = "flpnClass";
            flpnClass.Size = new Size(868, 467);
            flpnClass.TabIndex = 0;
            // 
            // picTeacher
            // 
            picTeacher.CustomizableEdges = customizableEdges1;
            picTeacher.Image = (Image)resources.GetObject("picTeacher.Image");
            picTeacher.ImageRotate = 0F;
            picTeacher.Location = new Point(238, 18);
            picTeacher.Name = "picTeacher";
            picTeacher.ShadowDecoration.CustomizableEdges = customizableEdges2;
            picTeacher.Size = new Size(50, 45);
            picTeacher.SizeMode = PictureBoxSizeMode.Zoom;
            picTeacher.TabIndex = 170;
            picTeacher.TabStop = false;
            // 
            // lblTeacherId
            // 
            lblTeacherId.AutoSize = true;
            lblTeacherId.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTeacherId.ForeColor = Color.FromArgb(99, 110, 114);
            lblTeacherId.Location = new Point(107, 9);
            lblTeacherId.Name = "lblTeacherId";
            lblTeacherId.Size = new Size(52, 17);
            lblTeacherId.TabIndex = 169;
            lblTeacherId.Text = "Id here";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(99, 110, 114);
            label4.Location = new Point(17, 9);
            label4.Name = "label4";
            label4.Size = new Size(74, 17);
            label4.TabIndex = 168;
            label4.Text = "Id Teacher";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhoneNumber.ForeColor = Color.FromArgb(99, 110, 114);
            lblPhoneNumber.Location = new Point(86, 89);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(81, 17);
            lblPhoneNumber.TabIndex = 167;
            lblPhoneNumber.Text = "Id User here";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhone.ForeColor = Color.FromArgb(99, 110, 114);
            lblPhone.Location = new Point(21, 89);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(57, 17);
            lblPhone.TabIndex = 166;
            lblPhone.Text = "Phone :";
            // 
            // lblNameTeacher
            // 
            lblNameTeacher.AutoSize = true;
            lblNameTeacher.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNameTeacher.Location = new Point(17, 41);
            lblNameTeacher.Name = "lblNameTeacher";
            lblNameTeacher.Size = new Size(133, 25);
            lblNameTeacher.TabIndex = 165;
            lblNameTeacher.Text = "Name Teacher";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.Controls.Add(picTeacher);
            guna2Panel1.Controls.Add(lblNameTeacher);
            guna2Panel1.Controls.Add(lblPhone);
            guna2Panel1.Controls.Add(lblTeacherId);
            guna2Panel1.Controls.Add(lblPhoneNumber);
            guna2Panel1.Controls.Add(label4);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Location = new Point(17, 48);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(312, 119);
            guna2Panel1.TabIndex = 172;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(351, 52);
            label1.Name = "label1";
            label1.Size = new Size(213, 25);
            label1.TabIndex = 173;
            label1.Text = "List of teacher's classes ";
            // 
            // lblTeacher
            // 
            lblTeacher.AutoSize = true;
            lblTeacher.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTeacher.Location = new Point(575, 52);
            lblTeacher.Name = "lblTeacher";
            lblTeacher.Size = new Size(25, 22);
            lblTeacher.TabIndex = 174;
            lblTeacher.Text = "...";
            // 
            // pnTop
            // 
            pnTop.BackColor = Color.FromArgb(64, 73, 94);
            pnTop.Controls.Add(btnExit);
            pnTop.CustomizableEdges = customizableEdges7;
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(0, 0);
            pnTop.Name = "pnTop";
            pnTop.ShadowDecoration.CustomizableEdges = customizableEdges8;
            pnTop.Size = new Size(901, 25);
            pnTop.TabIndex = 175;
            pnTop.MouseDown += pnTop_MouseDown;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Animated = true;
            btnExit.CustomizableEdges = customizableEdges5;
            btnExit.FillColor = Color.IndianRed;
            btnExit.IconColor = Color.White;
            btnExit.Location = new Point(865, 0);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnExit.Size = new Size(36, 26);
            btnExit.TabIndex = 159;
            // 
            // lblNotice
            // 
            lblNotice.AutoSize = true;
            lblNotice.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblNotice.ForeColor = Color.Red;
            lblNotice.Location = new Point(351, 145);
            lblNotice.Name = "lblNotice";
            lblNotice.Size = new Size(25, 22);
            lblNotice.TabIndex = 176;
            lblNotice.Text = "...";
            // 
            // ClassTeacherFromUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(901, 678);
            Controls.Add(lblNotice);
            Controls.Add(pnTop);
            Controls.Add(lblTeacher);
            Controls.Add(label1);
            Controls.Add(guna2Panel1);
            Controls.Add(flpnClass);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ClassTeacherFromUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ClassTeacherFromUserForm";
            ((System.ComponentModel.ISupportInitialize)picTeacher).EndInit();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            pnTop.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpnClass;
        private Guna.UI2.WinForms.Guna2PictureBox picTeacher;
        private Label lblTeacherId;
        private Label label4;
        private Label lblPhoneNumber;
        private Label lblPhone;
        private Label lblNameTeacher;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label label1;
        private Label lblTeacher;
        private Guna.UI2.WinForms.Guna2Panel pnTop;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private Label lblNotice;
    }
}