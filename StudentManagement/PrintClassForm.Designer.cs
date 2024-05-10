namespace StudentManagement
{
    partial class PrintClassForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintClassForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblCount = new Label();
            lblTitleClass = new Label();
            lblTitle = new Label();
            pictureUteIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            btnPrint = new Guna.UI2.WinForms.Guna2Button();
            label3 = new Label();
            dgvClass = new Guna.UI2.WinForms.Guna2DataGridView();
            pn = new Panel();
            guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)pictureUteIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClass).BeginInit();
            pn.SuspendLayout();
            SuspendLayout();
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCount.ForeColor = Color.Gray;
            lblCount.Location = new Point(36, 203);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(37, 20);
            lblCount.TabIndex = 124;
            lblCount.Text = ".Sl : ";
            // 
            // lblTitleClass
            // 
            lblTitleClass.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitleClass.Location = new Point(187, 144);
            lblTitleClass.Name = "lblTitleClass";
            lblTitleClass.Size = new Size(587, 58);
            lblTitleClass.TabIndex = 123;
            lblTitleClass.Text = "Danh sách Các Lớp ";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(187, 47);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(587, 92);
            lblTitle.TabIndex = 122;
            lblTitle.Text = "TRƯỜNG ĐẠI HỌC SƯ PHẠM KỸ THUẬT THÀNH PHỐ HỒ CHÍ MINH";
            // 
            // pictureUteIcon
            // 
            pictureUteIcon.BackColor = Color.Transparent;
            pictureUteIcon.BackgroundImageLayout = ImageLayout.Center;
            pictureUteIcon.BorderRadius = 5;
            pictureUteIcon.CustomizableEdges = customizableEdges1;
            pictureUteIcon.ErrorImage = null;
            pictureUteIcon.FillColor = Color.Transparent;
            pictureUteIcon.Image = (Image)resources.GetObject("pictureUteIcon.Image");
            pictureUteIcon.ImageRotate = 0F;
            pictureUteIcon.Location = new Point(38, 36);
            pictureUteIcon.Name = "pictureUteIcon";
            pictureUteIcon.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pictureUteIcon.Size = new Size(135, 135);
            pictureUteIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureUteIcon.TabIndex = 121;
            pictureUteIcon.TabStop = false;
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
            btnPrint.Location = new Point(704, 943);
            btnPrint.Margin = new Padding(2);
            btnPrint.Name = "btnPrint";
            btnPrint.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnPrint.Size = new Size(70, 30);
            btnPrint.TabIndex = 120;
            btnPrint.Text = "Print";
            btnPrint.Click += btnPrint_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(35, 180);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 119;
            label3.Text = ". Student List : ";
            // 
            // dgvClass
            // 
            dgvClass.AllowUserToAddRows = false;
            dgvClass.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(194, 200, 207);
            dgvClass.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvClass.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(52, 73, 94);
            dataGridViewCellStyle2.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClass.ColumnHeadersHeight = 20;
            dgvClass.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(214, 218, 223);
            dataGridViewCellStyle3.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(119, 133, 147);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvClass.DefaultCellStyle = dataGridViewCellStyle3;
            dgvClass.GridColor = Color.FromArgb(193, 199, 206);
            dgvClass.Location = new Point(35, 231);
            dgvClass.Margin = new Padding(2);
            dgvClass.Name = "dgvClass";
            dgvClass.ReadOnly = true;
            dgvClass.RowHeadersVisible = false;
            dgvClass.RowHeadersWidth = 62;
            dgvClass.RowTemplate.Height = 40;
            dgvClass.Size = new Size(739, 704);
            dgvClass.TabIndex = 118;
            dgvClass.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            dgvClass.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(194, 200, 207);
            dgvClass.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvClass.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvClass.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvClass.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvClass.ThemeStyle.BackColor = Color.White;
            dgvClass.ThemeStyle.GridColor = Color.FromArgb(193, 199, 206);
            dgvClass.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(52, 73, 94);
            dgvClass.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClass.ThemeStyle.HeaderStyle.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dgvClass.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvClass.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvClass.ThemeStyle.HeaderStyle.Height = 20;
            dgvClass.ThemeStyle.ReadOnly = true;
            dgvClass.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(214, 218, 223);
            dgvClass.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClass.ThemeStyle.RowsStyle.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dgvClass.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            dgvClass.ThemeStyle.RowsStyle.Height = 40;
            dgvClass.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(119, 133, 147);
            dgvClass.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // pn
            // 
            pn.BackColor = Color.DodgerBlue;
            pn.Controls.Add(guna2ControlBox2);
            pn.Dock = DockStyle.Top;
            pn.Location = new Point(0, 0);
            pn.Name = "pn";
            pn.Size = new Size(808, 25);
            pn.TabIndex = 125;
            pn.MouseDown += pn_MouseDown;
            // 
            // guna2ControlBox2
            // 
            guna2ControlBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox2.Animated = true;
            guna2ControlBox2.CustomizableEdges = customizableEdges5;
            guna2ControlBox2.FillColor = Color.IndianRed;
            guna2ControlBox2.IconColor = Color.White;
            guna2ControlBox2.Location = new Point(772, 0);
            guna2ControlBox2.Name = "guna2ControlBox2";
            guna2ControlBox2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2ControlBox2.Size = new Size(36, 26);
            guna2ControlBox2.TabIndex = 126;
            // 
            // PrintClassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(808, 984);
            Controls.Add(pn);
            Controls.Add(lblCount);
            Controls.Add(lblTitleClass);
            Controls.Add(lblTitle);
            Controls.Add(pictureUteIcon);
            Controls.Add(btnPrint);
            Controls.Add(label3);
            Controls.Add(dgvClass);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PrintClassForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrintClassForm";
            ((System.ComponentModel.ISupportInitialize)pictureUteIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClass).EndInit();
            pn.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCount;
        private Label lblTitleClass;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pictureUteIcon;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView dgvClass;
        private Panel pn;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
    }
}