namespace StudentManagement
{
    partial class PrintStudentForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintStudentForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pn = new Panel();
            btnEx = new Guna.UI2.WinForms.Guna2ControlBox();
            lblCount = new Label();
            lblTitleClass = new Label();
            lblTitle = new Label();
            pictureUteIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            label3 = new Label();
            dgvStudent = new Guna.UI2.WinForms.Guna2DataGridView();
            btnPrint = new Guna.UI2.WinForms.Guna2Button();
            cbStudent = new Guna.UI2.WinForms.Guna2ComboBox();
            txtSearchStudent = new Guna.UI2.WinForms.Guna2TextBox();
            pn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureUteIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            SuspendLayout();
            // 
            // pn
            // 
            pn.BackColor = Color.DodgerBlue;
            pn.Controls.Add(btnEx);
            pn.Dock = DockStyle.Top;
            pn.Location = new Point(0, 0);
            pn.Name = "pn";
            pn.Size = new Size(808, 25);
            pn.TabIndex = 117;
            pn.MouseDown += pn_MouseDown;
            // 
            // btnEx
            // 
            btnEx.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEx.Animated = true;
            btnEx.CustomizableEdges = customizableEdges1;
            btnEx.FillColor = Color.IndianRed;
            btnEx.IconColor = Color.White;
            btnEx.Location = new Point(772, -1);
            btnEx.Name = "btnEx";
            btnEx.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnEx.Size = new Size(36, 26);
            btnEx.TabIndex = 112;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCount.ForeColor = Color.Gray;
            lblCount.Location = new Point(38, 240);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(37, 20);
            lblCount.TabIndex = 123;
            lblCount.Text = ".Sl : ";
            // 
            // lblTitleClass
            // 
            lblTitleClass.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleClass.Location = new Point(176, 144);
            lblTitleClass.Name = "lblTitleClass";
            lblTitleClass.Size = new Size(587, 58);
            lblTitleClass.TabIndex = 122;
            lblTitleClass.Text = "Danh sách sinh viên ";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(187, 51);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(587, 92);
            lblTitle.TabIndex = 121;
            lblTitle.Text = "TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT THÀNH PHỐ HỒ CHÍ MINH";
            // 
            // pictureUteIcon
            // 
            pictureUteIcon.BackColor = Color.Transparent;
            pictureUteIcon.BackgroundImageLayout = ImageLayout.Center;
            pictureUteIcon.BorderRadius = 5;
            pictureUteIcon.CustomizableEdges = customizableEdges3;
            pictureUteIcon.ErrorImage = null;
            pictureUteIcon.FillColor = Color.Transparent;
            pictureUteIcon.Image = (Image)resources.GetObject("pictureUteIcon.Image");
            pictureUteIcon.ImageRotate = 0F;
            pictureUteIcon.Location = new Point(38, 40);
            pictureUteIcon.Name = "pictureUteIcon";
            pictureUteIcon.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pictureUteIcon.Size = new Size(135, 135);
            pictureUteIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUteIcon.TabIndex = 120;
            pictureUteIcon.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(38, 213);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 119;
            label3.Text = ". Student List : ";
            // 
            // dgvStudent
            // 
            dgvStudent.AllowUserToAddRows = false;
            dgvStudent.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(194, 200, 207);
            dgvStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvStudent.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle2.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvStudent.ColumnHeadersHeight = 20;
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(214, 218, 223);
            dataGridViewCellStyle3.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(119, 133, 147);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvStudent.DefaultCellStyle = dataGridViewCellStyle3;
            dgvStudent.GridColor = Color.FromArgb(193, 199, 206);
            dgvStudent.Location = new Point(35, 276);
            dgvStudent.Margin = new Padding(2);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.ReadOnly = true;
            dgvStudent.RowHeadersVisible = false;
            dgvStudent.RowHeadersWidth = 62;
            dgvStudent.RowTemplate.Height = 33;
            dgvStudent.Size = new Size(739, 669);
            dgvStudent.TabIndex = 118;
            dgvStudent.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            dgvStudent.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(194, 200, 207);
            dgvStudent.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvStudent.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvStudent.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvStudent.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvStudent.ThemeStyle.BackColor = Color.White;
            dgvStudent.ThemeStyle.GridColor = Color.FromArgb(193, 199, 206);
            dgvStudent.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(52, 73, 94);
            dgvStudent.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvStudent.ThemeStyle.HeaderStyle.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dgvStudent.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvStudent.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvStudent.ThemeStyle.HeaderStyle.Height = 20;
            dgvStudent.ThemeStyle.ReadOnly = true;
            dgvStudent.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(214, 218, 223);
            dgvStudent.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvStudent.ThemeStyle.RowsStyle.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dgvStudent.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvStudent.ThemeStyle.RowsStyle.Height = 33;
            dgvStudent.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(119, 133, 147);
            dgvStudent.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // btnPrint
            // 
            btnPrint.Animated = true;
            btnPrint.BackColor = Color.Transparent;
            btnPrint.BorderRadius = 10;
            btnPrint.CustomizableEdges = customizableEdges5;
            btnPrint.DisabledState.BorderColor = Color.DarkGray;
            btnPrint.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPrint.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPrint.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPrint.FillColor = Color.ForestGreen;
            btnPrint.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.ForeColor = SystemColors.ButtonHighlight;
            btnPrint.Location = new Point(704, 952);
            btnPrint.Margin = new Padding(2);
            btnPrint.Name = "btnPrint";
            btnPrint.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnPrint.Size = new Size(70, 30);
            btnPrint.TabIndex = 124;
            btnPrint.Text = "Print";
            btnPrint.Click += btnPrint_Click;
            // 
            // cbStudent
            // 
            cbStudent.BackColor = Color.Transparent;
            cbStudent.BorderColor = Color.Gray;
            cbStudent.CustomizableEdges = customizableEdges7;
            cbStudent.DrawMode = DrawMode.OwnerDrawFixed;
            cbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStudent.FocusedColor = Color.FromArgb(94, 148, 255);
            cbStudent.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbStudent.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            cbStudent.ForeColor = Color.DimGray;
            cbStudent.ItemHeight = 20;
            cbStudent.Items.AddRange(new object[] { "FirstName", "LastName", "Gender", "Address", "Department" });
            cbStudent.Location = new Point(414, 200);
            cbStudent.Name = "cbStudent";
            cbStudent.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cbStudent.Size = new Size(175, 26);
            cbStudent.StartIndex = 0;
            cbStudent.TabIndex = 126;
            // 
            // txtSearchStudent
            // 
            txtSearchStudent.BorderColor = Color.Gray;
            txtSearchStudent.CustomizableEdges = customizableEdges9;
            txtSearchStudent.DefaultText = "";
            txtSearchStudent.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearchStudent.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearchStudent.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearchStudent.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearchStudent.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchStudent.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtSearchStudent.ForeColor = Color.DimGray;
            txtSearchStudent.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearchStudent.IconLeft = (Image)resources.GetObject("txtSearchStudent.IconLeft");
            txtSearchStudent.Location = new Point(414, 232);
            txtSearchStudent.Margin = new Padding(3, 2, 3, 2);
            txtSearchStudent.Name = "txtSearchStudent";
            txtSearchStudent.Padding = new Padding(20, 0, 0, 0);
            txtSearchStudent.PasswordChar = '\0';
            txtSearchStudent.PlaceholderForeColor = Color.Gray;
            txtSearchStudent.PlaceholderText = "Infomation you want to search";
            txtSearchStudent.SelectedText = "";
            txtSearchStudent.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtSearchStudent.Size = new Size(360, 35);
            txtSearchStudent.TabIndex = 125;
            txtSearchStudent.TextChanged += txtSearchStudent_TextChanged;
            // 
            // PrintStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(808, 984);
            Controls.Add(cbStudent);
            Controls.Add(txtSearchStudent);
            Controls.Add(btnPrint);
            Controls.Add(lblCount);
            Controls.Add(lblTitleClass);
            Controls.Add(lblTitle);
            Controls.Add(pictureUteIcon);
            Controls.Add(label3);
            Controls.Add(dgvStudent);
            Controls.Add(pn);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PrintStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrintStudentForm";
            pn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureUteIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pn;
        private Label lblCount;
        private Label lblTitleClass;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pictureUteIcon;
        private Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStudent;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2ComboBox cbStudent;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchStudent;
        private Guna.UI2.WinForms.Guna2ControlBox btnEx;
    }
}