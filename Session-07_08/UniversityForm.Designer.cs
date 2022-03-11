namespace Session_07_08
{
    partial class UniversityForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.proffessorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.coursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.gradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.sceduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.DgvSchedule = new System.Windows.Forms.DataGridView();
            this.Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Professor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.studentsToolStripMenuItem,
            this.proffessorsToolStripMenuItem,
            this.coursesToolStripMenuItem,
            this.gradesToolStripMenuItem,
            this.sceduleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem1,
            this.saveToolStripMenuItem1,
            this.openToolStripMenuItem2});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem1.Text = "Load";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // openToolStripMenuItem2
            // 
            this.openToolStripMenuItem2.Name = "openToolStripMenuItem2";
            this.openToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem2.Text = "Open";
            this.openToolStripMenuItem2.Click += new System.EventHandler(this.openToolStripMenuItem2_Click);
            // 
            // proffessorsToolStripMenuItem
            // 
            this.proffessorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem2,
            this.saveToolStripMenuItem2,
            this.openToolStripMenuItem3});
            this.proffessorsToolStripMenuItem.Name = "proffessorsToolStripMenuItem";
            this.proffessorsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.proffessorsToolStripMenuItem.Text = "Proffessors";
            // 
            // loadToolStripMenuItem2
            // 
            this.loadToolStripMenuItem2.Name = "loadToolStripMenuItem2";
            this.loadToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem2.Text = "Load";
            // 
            // saveToolStripMenuItem2
            // 
            this.saveToolStripMenuItem2.Name = "saveToolStripMenuItem2";
            this.saveToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem2.Text = "Save";
            // 
            // openToolStripMenuItem3
            // 
            this.openToolStripMenuItem3.Name = "openToolStripMenuItem3";
            this.openToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem3.Text = "Open";
            this.openToolStripMenuItem3.Click += new System.EventHandler(this.openToolStripMenuItem3_Click);
            // 
            // coursesToolStripMenuItem
            // 
            this.coursesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem3,
            this.saveToolStripMenuItem3,
            this.openToolStripMenuItem4});
            this.coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            this.coursesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.coursesToolStripMenuItem.Text = "Courses";
            // 
            // loadToolStripMenuItem3
            // 
            this.loadToolStripMenuItem3.Name = "loadToolStripMenuItem3";
            this.loadToolStripMenuItem3.Size = new System.Drawing.Size(103, 22);
            this.loadToolStripMenuItem3.Text = "Load";
            // 
            // saveToolStripMenuItem3
            // 
            this.saveToolStripMenuItem3.Name = "saveToolStripMenuItem3";
            this.saveToolStripMenuItem3.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem3.Text = "Save";
            // 
            // openToolStripMenuItem4
            // 
            this.openToolStripMenuItem4.Name = "openToolStripMenuItem4";
            this.openToolStripMenuItem4.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem4.Text = "Open";
            // 
            // gradesToolStripMenuItem
            // 
            this.gradesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem4,
            this.saveToolStripMenuItem4,
            this.openToolStripMenuItem5});
            this.gradesToolStripMenuItem.Name = "gradesToolStripMenuItem";
            this.gradesToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.gradesToolStripMenuItem.Text = "Grades";
            // 
            // loadToolStripMenuItem4
            // 
            this.loadToolStripMenuItem4.Name = "loadToolStripMenuItem4";
            this.loadToolStripMenuItem4.Size = new System.Drawing.Size(103, 22);
            this.loadToolStripMenuItem4.Text = "Load";
            // 
            // saveToolStripMenuItem4
            // 
            this.saveToolStripMenuItem4.Name = "saveToolStripMenuItem4";
            this.saveToolStripMenuItem4.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem4.Text = "Save";
            // 
            // openToolStripMenuItem5
            // 
            this.openToolStripMenuItem5.Name = "openToolStripMenuItem5";
            this.openToolStripMenuItem5.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem5.Text = "Open";
            // 
            // sceduleToolStripMenuItem
            // 
            this.sceduleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem5,
            this.saveToolStripMenuItem5,
            this.openToolStripMenuItem1});
            this.sceduleToolStripMenuItem.Name = "sceduleToolStripMenuItem";
            this.sceduleToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sceduleToolStripMenuItem.Text = "Scedule";
            // 
            // loadToolStripMenuItem5
            // 
            this.loadToolStripMenuItem5.Name = "loadToolStripMenuItem5";
            this.loadToolStripMenuItem5.Size = new System.Drawing.Size(103, 22);
            this.loadToolStripMenuItem5.Text = "Load";
            // 
            // saveToolStripMenuItem5
            // 
            this.saveToolStripMenuItem5.Name = "saveToolStripMenuItem5";
            this.saveToolStripMenuItem5.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem5.Text = "Save";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem1.Text = "Open";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(12, 64);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(237, 21);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "University Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(551, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(237, 21);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Years in service";
            // 
            // DgvSchedule
            // 
            this.DgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Course,
            this.Professor,
            this.DateTime});
            this.DgvSchedule.Location = new System.Drawing.Point(12, 214);
            this.DgvSchedule.Name = "DgvSchedule";
            this.DgvSchedule.RowTemplate.Height = 25;
            this.DgvSchedule.Size = new System.Drawing.Size(644, 249);
            this.DgvSchedule.TabIndex = 4;
            // 
            // Course
            // 
            this.Course.HeaderText = "Course";
            this.Course.Name = "Course";
            this.Course.Width = 200;
            // 
            // Professor
            // 
            this.Professor.HeaderText = "Professor";
            this.Professor.Name = "Professor";
            this.Professor.Width = 200;
            // 
            // DateTime
            // 
            this.DateTime.HeaderText = "DateTime";
            this.DateTime.Name = "DateTime";
            this.DateTime.Width = 200;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(706, 291);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Logo here";
            // 
            // UniversityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.DgvSchedule);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "UniversityForm";
            this.Text = "University Name Here";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem proffessorsToolStripMenuItem;
        private ToolStripMenuItem coursesToolStripMenuItem;
        private ToolStripMenuItem gradesToolStripMenuItem;
        private ToolStripMenuItem sceduleToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem1;
        private ToolStripMenuItem loadToolStripMenuItem1;
        private ToolStripMenuItem saveToolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem2;
        private ToolStripMenuItem loadToolStripMenuItem2;
        private ToolStripMenuItem saveToolStripMenuItem2;
        private ToolStripMenuItem openToolStripMenuItem3;
        private ToolStripMenuItem loadToolStripMenuItem3;
        private ToolStripMenuItem saveToolStripMenuItem3;
        private ToolStripMenuItem openToolStripMenuItem4;
        private ToolStripMenuItem loadToolStripMenuItem4;
        private ToolStripMenuItem saveToolStripMenuItem4;
        private ToolStripMenuItem openToolStripMenuItem5;
        private ToolStripMenuItem loadToolStripMenuItem5;
        private ToolStripMenuItem saveToolStripMenuItem5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DataGridView DgvSchedule;
        private DataGridViewTextBoxColumn Course;
        private DataGridViewTextBoxColumn Professor;
        private DataGridViewTextBoxColumn DateTime;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}