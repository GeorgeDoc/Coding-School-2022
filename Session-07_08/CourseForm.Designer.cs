namespace Session_07_08
{
    partial class CourseForm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TeCode = new DevExpress.XtraEditors.TextEdit();
            this.TeSubject = new DevExpress.XtraEditors.TextEdit();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnNew = new DevExpress.XtraEditors.SimpleButton();
            this.LblLogo = new DevExpress.XtraEditors.LabelControl();
            this.LblQuote = new DevExpress.XtraEditors.LabelControl();
            this.listBoxCourse = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.TeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSubject.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(257, 69);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Subject:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(257, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Course Code:";
            // 
            // TeCode
            // 
            this.TeCode.Location = new System.Drawing.Point(329, 40);
            this.TeCode.Name = "TeCode";
            this.TeCode.Size = new System.Drawing.Size(117, 20);
            this.TeCode.TabIndex = 2;
            // 
            // TeSubject
            // 
            this.TeSubject.Location = new System.Drawing.Point(329, 66);
            this.TeSubject.Name = "TeSubject";
            this.TeSubject.Size = new System.Drawing.Size(211, 20);
            this.TeSubject.TabIndex = 3;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(616, 170);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 39);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.Text = "Cancel";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(532, 170);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 39);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Save";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(341, 170);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 39);
            this.BtnDelete.TabIndex = 14;
            this.BtnDelete.Text = "Delete";
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(257, 170);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 39);
            this.BtnNew.TabIndex = 12;
            this.BtnNew.Text = "New";
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // LblLogo
            // 
            this.LblLogo.Location = new System.Drawing.Point(602, 73);
            this.LblLogo.Name = "LblLogo";
            this.LblLogo.Size = new System.Drawing.Size(48, 13);
            this.LblLogo.TabIndex = 15;
            this.LblLogo.Text = "Logo here";
            // 
            // LblQuote
            // 
            this.LblQuote.Location = new System.Drawing.Point(424, 115);
            this.LblQuote.Name = "LblQuote";
            this.LblQuote.Size = new System.Drawing.Size(92, 13);
            this.LblQuote.TabIndex = 16;
            this.LblQuote.Text = "Cheesy quote here";
            // 
            // listBoxCourse
            // 
            this.listBoxCourse.FormattingEnabled = true;
            this.listBoxCourse.ItemHeight = 15;
            this.listBoxCourse.Location = new System.Drawing.Point(12, 39);
            this.listBoxCourse.Name = "listBoxCourse";
            this.listBoxCourse.Size = new System.Drawing.Size(187, 169);
            this.listBoxCourse.TabIndex = 17;
            this.listBoxCourse.SelectedIndexChanged += new System.EventHandler(this.listBoxCourse_SelectedIndexChanged);
            // 
            // CourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 221);
            this.Controls.Add(this.listBoxCourse);
            this.Controls.Add(this.LblQuote);
            this.Controls.Add(this.LblLogo);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnNew);
            this.Controls.Add(this.TeSubject);
            this.Controls.Add(this.TeCode);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "CourseForm";
            this.Text = "Course";
            ((System.ComponentModel.ISupportInitialize)(this.TeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSubject.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TeCode;
        private DevExpress.XtraEditors.TextEdit TeSubject;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnNew;
        private DevExpress.XtraEditors.LabelControl LblLogo;
        private DevExpress.XtraEditors.LabelControl LblQuote;
        private ListBox listBoxCourse;
    }
}