namespace StudentManagement.User_Control
{
    partial class UC_Account
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Account));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            lblTitleDelete = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnDelete = new Guna.UI2.WinForms.Guna2ImageButton();
            btnAllow = new Guna.UI2.WinForms.Guna2ImageButton();
            picAccount = new Guna.UI2.WinForms.Guna2PictureBox();
            lblTitleEdit = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnUnAllow = new Guna.UI2.WinForms.Guna2ImageButton();
            lblEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblAccount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAccount).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.White;
            guna2Panel1.BorderColor = Color.Transparent;
            guna2Panel1.BorderRadius = 10;
            guna2Panel1.BorderThickness = 2;
            guna2Panel1.Controls.Add(lblTitleDelete);
            guna2Panel1.Controls.Add(btnDelete);
            guna2Panel1.Controls.Add(btnAllow);
            guna2Panel1.Controls.Add(picAccount);
            guna2Panel1.Controls.Add(lblTitleEdit);
            guna2Panel1.Controls.Add(btnUnAllow);
            guna2Panel1.Controls.Add(lblEmail);
            guna2Panel1.Controls.Add(lblAccount);
            guna2Panel1.CustomizableEdges = customizableEdges6;
            guna2Panel1.Location = new Point(-27, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges7;
            guna2Panel1.Size = new Size(1400, 150);
            guna2Panel1.TabIndex = 1;
            // 
            // lblTitleDelete
            // 
            lblTitleDelete.AutoSize = false;
            lblTitleDelete.BackColor = Color.Transparent;
            lblTitleDelete.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleDelete.Location = new Point(899, 79);
            lblTitleDelete.Name = "lblTitleDelete";
            lblTitleDelete.Size = new Size(70, 22);
            lblTitleDelete.TabIndex = 70;
            lblTitleDelete.Text = "Delete";
            // 
            // btnDelete
            // 
            btnDelete.AnimatedGIF = true;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.CheckedState.ImageSize = new Size(64, 64);
            btnDelete.HoverState.ImageSize = new Size(64, 64);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageOffset = new Point(0, 0);
            btnDelete.ImageRotate = 0F;
            btnDelete.Location = new Point(978, 26);
            btnDelete.Name = "btnDelete";
            btnDelete.PressedState.ImageSize = new Size(64, 64);
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnDelete.Size = new Size(83, 92);
            btnDelete.TabIndex = 69;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAllow
            // 
            btnAllow.AnimatedGIF = true;
            btnAllow.BackColor = Color.Transparent;
            btnAllow.CheckedState.ImageSize = new Size(64, 64);
            btnAllow.HoverState.ImageSize = new Size(64, 64);
            btnAllow.Image = (Image)resources.GetObject("btnAllow.Image");
            btnAllow.ImageOffset = new Point(0, 0);
            btnAllow.ImageRotate = 0F;
            btnAllow.Location = new Point(1147, 26);
            btnAllow.Name = "btnAllow";
            btnAllow.PressedState.ImageSize = new Size(64, 64);
            btnAllow.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAllow.Size = new Size(109, 92);
            btnAllow.TabIndex = 68;
            btnAllow.Click += btnAllow_Click;
            // 
            // picAccount
            // 
            picAccount.BorderRadius = 5;
            picAccount.CustomizableEdges = customizableEdges3;
            picAccount.FillColor = SystemColors.Window;
            picAccount.Image = (Image)resources.GetObject("picAccount.Image");
            picAccount.ImageRotate = 0F;
            picAccount.Location = new Point(41, 11);
            picAccount.Name = "picAccount";
            picAccount.ShadowDecoration.CustomizableEdges = customizableEdges4;
            picAccount.Size = new Size(134, 125);
            picAccount.SizeMode = PictureBoxSizeMode.Zoom;
            picAccount.TabIndex = 63;
            picAccount.TabStop = false;
            // 
            // lblTitleEdit
            // 
            lblTitleEdit.BackColor = Color.Transparent;
            lblTitleEdit.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleEdit.Location = new Point(1092, 79);
            lblTitleEdit.Name = "lblTitleEdit";
            lblTitleEdit.Size = new Size(36, 22);
            lblTitleEdit.TabIndex = 67;
            lblTitleEdit.Text = "Edit :";
            // 
            // btnUnAllow
            // 
            btnUnAllow.AnimatedGIF = true;
            btnUnAllow.BackColor = Color.Transparent;
            btnUnAllow.CheckedState.ImageSize = new Size(64, 64);
            btnUnAllow.HoverState.ImageSize = new Size(64, 64);
            btnUnAllow.Image = (Image)resources.GetObject("btnUnAllow.Image");
            btnUnAllow.ImageOffset = new Point(0, 0);
            btnUnAllow.ImageRotate = 0F;
            btnUnAllow.Location = new Point(1147, 26);
            btnUnAllow.Name = "btnUnAllow";
            btnUnAllow.PressedState.ImageSize = new Size(64, 64);
            btnUnAllow.ShadowDecoration.CustomizableEdges = customizableEdges5;
            btnUnAllow.Size = new Size(109, 92);
            btnUnAllow.TabIndex = 66;
            btnUnAllow.Click += btnUnAllow_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = false;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(207, 83);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(552, 35);
            lblEmail.TabIndex = 65;
            lblEmail.Text = "lorem input dhafkl dhfkashlsdf dsfh a";
            // 
            // lblAccount
            // 
            lblAccount.AutoSize = false;
            lblAccount.BackColor = Color.Transparent;
            lblAccount.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblAccount.Location = new Point(207, 39);
            lblAccount.Name = "lblAccount";
            lblAccount.Size = new Size(599, 44);
            lblAccount.TabIndex = 64;
            lblAccount.Text = "Title";
            // 
            // UC_Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2Panel1);
            Name = "UC_Account";
            Size = new Size(1374, 150);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAccount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox picAccount;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitleEdit;
        private Guna.UI2.WinForms.Guna2ImageButton btnUnAllow;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAccount;
        private Guna.UI2.WinForms.Guna2ImageButton btnAllow;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitleDelete;
        private Guna.UI2.WinForms.Guna2ImageButton btnDelete;
    }
}
