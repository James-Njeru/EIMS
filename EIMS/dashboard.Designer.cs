namespace EIMS
{
    partial class dashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.universityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.academicYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearOfStudyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facultyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examinerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentExamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printPreviewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilitiesToolStripMenuItem,
            this.facultyToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.examinationToolStripMenuItem,
            this.administrationToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.universityToolStripMenuItem,
            this.centreToolStripMenuItem,
            this.academicYearToolStripMenuItem,
            this.yearOfStudyToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // universityToolStripMenuItem
            // 
            this.universityToolStripMenuItem.Name = "universityToolStripMenuItem";
            this.universityToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.universityToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.universityToolStripMenuItem.Text = "University";
            this.universityToolStripMenuItem.Click += new System.EventHandler(this.universityToolStripMenuItem_Click);
            // 
            // centreToolStripMenuItem
            // 
            this.centreToolStripMenuItem.Name = "centreToolStripMenuItem";
            this.centreToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.centreToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.centreToolStripMenuItem.Text = "Centre";
            this.centreToolStripMenuItem.Click += new System.EventHandler(this.centreToolStripMenuItem_Click);
            // 
            // academicYearToolStripMenuItem
            // 
            this.academicYearToolStripMenuItem.Name = "academicYearToolStripMenuItem";
            this.academicYearToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.academicYearToolStripMenuItem.Text = "Academic Year";
            this.academicYearToolStripMenuItem.Click += new System.EventHandler(this.academicYearToolStripMenuItem_Click);
            // 
            // yearOfStudyToolStripMenuItem
            // 
            this.yearOfStudyToolStripMenuItem.Name = "yearOfStudyToolStripMenuItem";
            this.yearOfStudyToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.yearOfStudyToolStripMenuItem.Text = "Year of Study";
            this.yearOfStudyToolStripMenuItem.Click += new System.EventHandler(this.yearOfStudyToolStripMenuItem_Click);
            // 
            // facultyToolStripMenuItem
            // 
            this.facultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facultyToolStripMenuItem1,
            this.departmentToolStripMenuItem,
            this.programToolStripMenuItem,
            this.courseToolStripMenuItem});
            this.facultyToolStripMenuItem.Name = "facultyToolStripMenuItem";
            this.facultyToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.facultyToolStripMenuItem.Text = "School";
            // 
            // facultyToolStripMenuItem1
            // 
            this.facultyToolStripMenuItem1.Name = "facultyToolStripMenuItem1";
            this.facultyToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.facultyToolStripMenuItem1.Text = "Faculty";
            this.facultyToolStripMenuItem1.Click += new System.EventHandler(this.facultyToolStripMenuItem1_Click);
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.departmentToolStripMenuItem.Text = "Department";
            this.departmentToolStripMenuItem.Click += new System.EventHandler(this.departmentToolStripMenuItem_Click);
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.programToolStripMenuItem.Text = "Program";
            this.programToolStripMenuItem.Click += new System.EventHandler(this.programToolStripMenuItem_Click);
            // 
            // courseToolStripMenuItem
            // 
            this.courseToolStripMenuItem.Name = "courseToolStripMenuItem";
            this.courseToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.courseToolStripMenuItem.Text = "Course";
            this.courseToolStripMenuItem.Click += new System.EventHandler(this.courseToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.studentToolStripMenuItem.Text = "Student";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // examinationToolStripMenuItem
            // 
            this.examinationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.examToolStripMenuItem,
            this.examinerToolStripMenuItem,
            this.studentExamToolStripMenuItem});
            this.examinationToolStripMenuItem.Name = "examinationToolStripMenuItem";
            this.examinationToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.examinationToolStripMenuItem.Text = "Examination";
            this.examinationToolStripMenuItem.Click += new System.EventHandler(this.examinationToolStripMenuItem_Click);
            // 
            // examToolStripMenuItem
            // 
            this.examToolStripMenuItem.Name = "examToolStripMenuItem";
            this.examToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.examToolStripMenuItem.Text = "Exam";
            this.examToolStripMenuItem.Click += new System.EventHandler(this.examToolStripMenuItem_Click);
            // 
            // examinerToolStripMenuItem
            // 
            this.examinerToolStripMenuItem.Name = "examinerToolStripMenuItem";
            this.examinerToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.examinerToolStripMenuItem.Text = "Examiner";
            this.examinerToolStripMenuItem.Click += new System.EventHandler(this.examinerToolStripMenuItem_Click);
            // 
            // studentExamToolStripMenuItem
            // 
            this.studentExamToolStripMenuItem.Name = "studentExamToolStripMenuItem";
            this.studentExamToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.studentExamToolStripMenuItem.Text = "Student Exam";
            this.studentExamToolStripMenuItem.Click += new System.EventHandler(this.studentExamToolStripMenuItem_Click);
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.administrationToolStripMenuItem.Text = "&Administration";
            this.administrationToolStripMenuItem.Click += new System.EventHandler(this.administrationToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.printToolStripButton,
            this.printPreviewToolStripButton,
            this.toolStripSeparator2,
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1064, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "New";
            this.newToolStripButton.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "Open";
            this.openToolStripButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "Print";
            // 
            // printPreviewToolStripButton
            // 
            this.printPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printPreviewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripButton.Image")));
            this.printPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printPreviewToolStripButton.Name = "printPreviewToolStripButton";
            this.printPreviewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printPreviewToolStripButton.Text = "Print Preview";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "Help";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 612);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1064, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1064, 634);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "dashboard";
            this.Text = "dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton printPreviewToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem universityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem academicYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearOfStudyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facultyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examinerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentExamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}



