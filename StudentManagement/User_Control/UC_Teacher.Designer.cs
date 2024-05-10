namespace StudentManagement.User_Control
{
    partial class UC_Teacher
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Teacher));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            pbxTeacher = new Guna.UI2.WinForms.Guna2PictureBox();
            lblTitleEdit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnEdit = new Guna.UI2.WinForms.Guna2ImageButton();
            lblDescebri = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblNameTeacher = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxTeacher).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.BorderColor = Color.Transparent;
            guna2Panel1.BorderRadius = 10;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(pbxTeacher);
            guna2Panel1.Controls.Add(lblTitleEdit);
            guna2Panel1.Controls.Add(btnEdit);
            guna2Panel1.Controls.Add(lblDescebri);
            guna2Panel1.Controls.Add(lblNameTeacher);
            guna2Panel1.CustomizableEdges = customizableEdges4;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2Panel1.Size = new Size(1226, 150);
            guna2Panel1.TabIndex = 0;
            // 
            // pbxTeacher
            // 
            pbxTeacher.BorderRadius = 5;
            pbxTeacher.CustomizableEdges = customizableEdges1;
            pbxTeacher.ErrorImage = (Image)resources.GetObject("pbxTeacher.ErrorImage");
            pbxTeacher.FillColor = SystemColors.Window;
            pbxTeacher.Image = (Image)resources.GetObject("pbxTeacher.Image");
            pbxTeacher.ImageRotate = 0F;
            pbxTeacher.Location = new Point(2, 1);
            pbxTeacher.Name = "pbxTeacher";
            pbxTeacher.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pbxTeacher.Size = new Size(160, 146);
            pbxTeacher.SizeMode = PictureBoxSizeMode.Zoom;
            pbxTeacher.TabIndex = 63;
            pbxTeacher.TabStop = false;
            // 
            // lblTitleEdit
            // 
            lblTitleEdit.BackColor = Color.Transparent;
            lblTitleEdit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleEdit.Location = new Point(1041, 89);
            lblTitleEdit.Name = "lblTitleEdit";
            lblTitleEdit.Size = new Size(37, 22);
            lblTitleEdit.TabIndex = 67;
            lblTitleEdit.Text = "Edit :";
            // 
            // btnEdit
            // 
            btnEdit.AnimatedGIF = true;
            btnEdit.BackColor = Color.Transparent;
            btnEdit.CheckedState.ImageSize = new Size(64, 64);
            btnEdit.HoverState.ImageSize = new Size(64, 64);
            btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
            btnEdit.ImageOffset = new Point(0, 0);
            btnEdit.ImageRotate = 0F;
            btnEdit.ImageSize = new Size(50, 50);
            btnEdit.Location = new Point(1094, 32);
            btnEdit.Name = "btnEdit";
            btnEdit.PressedState.ImageSize = new Size(64, 64);
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnEdit.Size = new Size(109, 92);
            btnEdit.TabIndex = 66;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblDescebri
            // 
            lblDescebri.AutoSize = false;
            lblDescebri.BackColor = Color.Transparent;
            lblDescebri.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescebri.Location = new Point(207, 89);
            lblDescebri.Name = "lblDescebri";
            lblDescebri.Size = new Size(552, 35);
            lblDescebri.TabIndex = 65;
            lblDescebri.Text = "lorem input dhafkl dhfkashlsdf dsfh a";
            // 
            // lblNameTeacher
            // 
            lblNameTeacher.AutoSize = false;
            lblNameTeacher.BackColor = Color.Transparent;
            lblNameTeacher.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblNameTeacher.Location = new Point(207, 39);
            lblNameTeacher.Name = "lblNameTeacher";
            lblNameTeacher.Size = new Size(599, 44);
            lblNameTeacher.TabIndex = 64;
            lblNameTeacher.Text = "Title";
            // 
            // UC_Teacher
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(guna2Panel1);
            Name = "UC_Teacher";
            Size = new Size(1227, 150);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxTeacher).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox pbxTeacher;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitleEdit;
        private Guna.UI2.WinForms.Guna2ImageButton btnEdit;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDescebri;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNameTeacher;
    }
}
