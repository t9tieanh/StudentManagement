namespace StudentManagement
{
    partial class InfomationClassForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfomationClassForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label3 = new Label();
            dgvStudent = new Guna.UI2.WinForms.Guna2DataGridView();
            btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            btnPrint = new Guna.UI2.WinForms.Guna2Button();
            pictureUteIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            lblTitle = new Label();
            lblTitleClass = new Label();
            pn = new Panel();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            lblCount = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureUteIcon).BeginInit();
            pn.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(34, 173);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 110;
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
            dgvStudent.Location = new Point(34, 221);
            dgvStudent.Margin = new Padding(2);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.ReadOnly = true;
            dgvStudent.RowHeadersVisible = false;
            dgvStudent.RowHeadersWidth = 62;
            dgvStudent.RowTemplate.Height = 33;
            dgvStudent.Size = new Size(739, 718);
            dgvStudent.TabIndex = 109;
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
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.Animated = true;
            btnExit.CustomizableEdges = customizableEdges1;
            btnExit.FillColor = Color.IndianRed;
            btnExit.IconColor = Color.White;
            btnExit.Location = new Point(772, -1);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnExit.Size = new Size(36, 26);
            btnExit.TabIndex = 111;
            // 
            // btnPrint
            // 
            btnPrint.Animated = true;
            btnPrint.BackColor = Color.Transparent;
            btnPrint.BorderRadius = 10;
            btnPrint.CustomizableEdges = customizableEdges3;
            btnPrint.DisabledState.BorderColor = Color.DarkGray;
            btnPrint.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPrint.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPrint.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPrint.FillColor = Color.ForestGreen;
            btnPrint.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPrint.ForeColor = SystemColors.ButtonHighlight;
            btnPrint.Location = new Point(703, 953);
            btnPrint.Margin = new Padding(2);
            btnPrint.Name = "btnPrint";
            btnPrint.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnPrint.Size = new Size(70, 30);
            btnPrint.TabIndex = 112;
            btnPrint.Text = "Print";
            btnPrint.Click += btnPrint_Click;
            // 
            // pictureUteIcon
            // 
            pictureUteIcon.BackColor = Color.Transparent;
            pictureUteIcon.BackgroundImageLayout = ImageLayout.Center;
            pictureUteIcon.BorderRadius = 5;
            pictureUteIcon.CustomizableEdges = customizableEdges5;
            pictureUteIcon.ErrorImage = null;
            pictureUteIcon.FillColor = Color.Transparent;
            pictureUteIcon.Image = (Image)resources.GetObject("pictureUteIcon.Image");
            pictureUteIcon.ImageRotate = 0F;
            pictureUteIcon.Location = new Point(37, 34);
            pictureUteIcon.Name = "pictureUteIcon";
            pictureUteIcon.ShadowDecoration.CustomizableEdges = customizableEdges6;
            pictureUteIcon.Size = new Size(135, 135);
            pictureUteIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUteIcon.TabIndex = 113;
            pictureUteIcon.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(186, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(587, 92);
            lblTitle.TabIndex = 114;
            lblTitle.Text = "TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT THÀNH PHỐ HỒ CHÍ MINH";
            // 
            // lblTitleClass
            // 
            lblTitleClass.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleClass.Location = new Point(186, 142);
            lblTitleClass.Name = "lblTitleClass";
            lblTitleClass.Size = new Size(587, 58);
            lblTitleClass.TabIndex = 115;
            lblTitleClass.Text = "Danh sách sinh viên lớp : ";
            // 
            // pn
            // 
            pn.BackColor = Color.DodgerBlue;
            pn.Controls.Add(btnExit);
            pn.Dock = DockStyle.Top;
            pn.Location = new Point(0, 0);
            pn.Name = "pn";
            pn.Size = new Size(808, 25);
            pn.TabIndex = 116;
            pn.MouseDown += pn_MouseDown;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCount.ForeColor = Color.Gray;
            lblCount.Location = new Point(35, 196);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(37, 20);
            lblCount.TabIndex = 117;
            lblCount.Text = ".Sl : ";
            // 
            // InfomationClassForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(808, 984);
            Controls.Add(lblCount);
            Controls.Add(pn);
            Controls.Add(lblTitleClass);
            Controls.Add(lblTitle);
            Controls.Add(pictureUteIcon);
            Controls.Add(btnPrint);
            Controls.Add(label3);
            Controls.Add(dgvStudent);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "InfomationClassForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InfomationClassForm";
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureUteIcon).EndInit();
            pn.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStudent;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2PictureBox pictureUteIcon;
        private Label lblTitle;
        private Label lblTitleClass;
        private Panel pn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label lblCount;
    }
}