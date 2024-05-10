namespace StudentManagement.User_Control
{
    partial class UC_Group
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Group));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtNameGroup = new Label();
            label2 = new Label();
            txtIdUser = new Label();
            label4 = new Label();
            txtIdGroup = new Label();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            btnPreview = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNameGroup
            // 
            txtNameGroup.AutoSize = true;
            txtNameGroup.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtNameGroup.Location = new Point(12, 43);
            txtNameGroup.Name = "txtNameGroup";
            txtNameGroup.Size = new Size(125, 22);
            txtNameGroup.TabIndex = 0;
            txtNameGroup.Text = "Name Group";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(99, 110, 114);
            label2.Location = new Point(16, 91);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 1;
            label2.Text = "Id User :";
            // 
            // txtIdUser
            // 
            txtIdUser.AutoSize = true;
            txtIdUser.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdUser.ForeColor = Color.FromArgb(99, 110, 114);
            txtIdUser.Location = new Point(81, 91);
            txtIdUser.Name = "txtIdUser";
            txtIdUser.Size = new Size(81, 17);
            txtIdUser.TabIndex = 2;
            txtIdUser.Text = "Id User here";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(99, 110, 114);
            label4.Location = new Point(12, 11);
            label4.Name = "label4";
            label4.Size = new Size(61, 17);
            label4.TabIndex = 3;
            label4.Text = "IdGroup";
            // 
            // txtIdGroup
            // 
            txtIdGroup.AutoSize = true;
            txtIdGroup.Font = new Font("Century Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdGroup.ForeColor = Color.FromArgb(99, 110, 114);
            txtIdGroup.Location = new Point(85, 11);
            txtIdGroup.Name = "txtIdGroup";
            txtIdGroup.Size = new Size(52, 17);
            txtIdGroup.TabIndex = 4;
            txtIdGroup.Text = "Id here";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = (Image)resources.GetObject("guna2PictureBox1.Image");
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(325, 11);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(50, 45);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 5;
            guna2PictureBox1.TabStop = false;
            // 
            // btnPreview
            // 
            btnPreview.BorderRadius = 10;
            btnPreview.CustomizableEdges = customizableEdges3;
            btnPreview.DisabledState.BorderColor = Color.DarkGray;
            btnPreview.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPreview.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPreview.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPreview.FillColor = Color.FromArgb(9, 132, 227);
            btnPreview.Font = new Font("Century Gothic", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btnPreview.ForeColor = Color.White;
            btnPreview.Location = new Point(255, 81);
            btnPreview.Name = "btnPreview";
            btnPreview.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnPreview.Size = new Size(108, 30);
            btnPreview.TabIndex = 6;
            btnPreview.Text = "Preview";
            btnPreview.Click += btnPreview_Click;
            // 
            // UC_Group
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(btnPreview);
            Controls.Add(guna2PictureBox1);
            Controls.Add(txtIdGroup);
            Controls.Add(label4);
            Controls.Add(txtIdUser);
            Controls.Add(label2);
            Controls.Add(txtNameGroup);
            Name = "UC_Group";
            Size = new Size(390, 119);
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtNameGroup;
        private Label label2;
        private Label txtIdUser;
        private Label label4;
        private Label txtIdGroup;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnPreview;
    }
}
