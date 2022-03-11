namespace Session_07_08
{
    partial class ProfessorForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.LbCourses = new DevExpress.XtraEditors.ListBoxControl();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            this.TeRank = new DevExpress.XtraEditors.TextEdit();
            this.TeName = new DevExpress.XtraEditors.TextEdit();
            this.TeAge = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.NameTE = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.AgeTE = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LbCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeRank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.BtnCancel);
            this.layoutControl1.Controls.Add(this.LbCourses);
            this.layoutControl1.Controls.Add(this.BtnSave);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.BtnDelete);
            this.layoutControl1.Controls.Add(this.BtnNew);
            this.layoutControl1.Controls.Add(this.TeRank);
            this.layoutControl1.Controls.Add(this.TeName);
            this.layoutControl1.Controls.Add(this.TeAge);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1092, 189, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(701, 390);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 39);
            this.BtnCancel.StyleController = this.layoutControl1;
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.Text = "Cancel";
            // 
            // LbCourses
            // 
            this.LbCourses.Items.AddRange(new object[] {
            "Finger Skating",
            "Cooking",
            "Procratinat 101"});
            this.LbCourses.Location = new System.Drawing.Point(54, 86);
            this.LbCourses.Name = "LbCourses";
            this.LbCourses.Size = new System.Drawing.Size(136, 225);
            this.LbCourses.StyleController = this.layoutControl1;
            this.LbCourses.TabIndex = 6;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(617, 390);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 39);
            this.BtnSave.StyleController = this.layoutControl1;
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Save";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 189);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(75, 14);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Courses:";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(701, 109);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 39);
            this.BtnDelete.StyleController = this.layoutControl1;
            this.BtnDelete.TabIndex = 14;
            this.BtnDelete.Text = "Delete";
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(617, 109);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 39);
            this.BtnNew.StyleController = this.layoutControl1;
            this.BtnNew.TabIndex = 12;
            this.BtnNew.Text = "New";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // TeRank
            // 
            this.TeRank.Location = new System.Drawing.Point(55, 60);
            this.TeRank.Name = "TeRank";
            this.TeRank.Size = new System.Drawing.Size(733, 20);
            this.TeRank.StyleController = this.layoutControl1;
            this.TeRank.TabIndex = 3;
            // 
            // TeName
            // 
            this.TeName.Location = new System.Drawing.Point(55, 12);
            this.TeName.Name = "TeName";
            this.TeName.Size = new System.Drawing.Size(733, 20);
            this.TeName.StyleController = this.layoutControl1;
            this.TeName.TabIndex = 0;
            // 
            // TeAge
            // 
            this.TeAge.Location = new System.Drawing.Point(55, 36);
            this.TeAge.Name = "TeAge";
            this.TeAge.Size = new System.Drawing.Size(733, 20);
            this.TeAge.StyleController = this.layoutControl1;
            this.TeAge.TabIndex = 2;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.NameTE,
            this.emptySpaceItem1,
            this.AgeTE,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 450);
            this.Root.TextVisible = false;
            // 
            // NameTE
            // 
            this.NameTE.Control = this.TeName;
            this.NameTE.Location = new System.Drawing.Point(0, 0);
            this.NameTE.Name = "NameTE";
            this.NameTE.Size = new System.Drawing.Size(780, 24);
            this.NameTE.Text = "Name:";
            this.NameTE.TextSize = new System.Drawing.Size(31, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 72);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(780, 358);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // AgeTE
            // 
            this.AgeTE.Control = this.TeAge;
            this.AgeTE.Location = new System.Drawing.Point(0, 24);
            this.AgeTE.Name = "AgeTE";
            this.AgeTE.Size = new System.Drawing.Size(780, 24);
            this.AgeTE.Text = "Age:";
            this.AgeTE.TextSize = new System.Drawing.Size(31, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TeRank;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(780, 24);
            this.layoutControlItem1.Text = "Rank:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(31, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 430);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(780, 25);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(93, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(0, 0);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Professor";
            this.Text = "Professor";
            this.Load += new System.EventHandler(this.Professor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            this.layoutControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LbCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeRank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgeTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit TeRank;
        private DevExpress.XtraEditors.TextEdit TeName;
        private DevExpress.XtraEditors.TextEdit TeAge;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem NameTE;
        private DevExpress.XtraLayout.LayoutControlItem AgeTE;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.ListBoxControl LbCourses;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnNew;
    }
}