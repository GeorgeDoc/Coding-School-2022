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
            ((System.ComponentModel.ISupportInitialize)(this.TeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeSubject.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(40, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Subject:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Course Code:";
            // 
            // TeCode
            // 
            this.TeCode.Location = new System.Drawing.Point(84, 33);
            this.TeCode.Name = "TeCode";
            this.TeCode.Size = new System.Drawing.Size(117, 20);
            this.TeCode.TabIndex = 2;
            // 
            // TeSubject
            // 
            this.TeSubject.Location = new System.Drawing.Point(84, 59);
            this.TeSubject.Name = "TeSubject";
            this.TeSubject.Size = new System.Drawing.Size(211, 20);
            this.TeSubject.TabIndex = 3;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(371, 147);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 39);
            this.BtnCancel.TabIndex = 13;
            this.BtnCancel.Text = "Cancel";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(287, 147);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 39);
            this.BtnSave.TabIndex = 11;
            this.BtnSave.Text = "Save";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(96, 147);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 39);
            this.BtnDelete.TabIndex = 14;
            this.BtnDelete.Text = "Delete";
            // 
            // BtnNew
            // 
            this.BtnNew.Location = new System.Drawing.Point(12, 147);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 39);
            this.BtnNew.TabIndex = 12;
            this.BtnNew.Text = "New";
            // 
            // LblLogo
            // 
            this.LblLogo.Location = new System.Drawing.Point(357, 66);
            this.LblLogo.Name = "LblLogo";
            this.LblLogo.Size = new System.Drawing.Size(48, 13);
            this.LblLogo.TabIndex = 15;
            this.LblLogo.Text = "Logo here";
            // 
            // LblQuote
            // 
            this.LblQuote.Location = new System.Drawing.Point(179, 108);
            this.LblQuote.Name = "LblQuote";
            this.LblQuote.Size = new System.Drawing.Size(92, 13);
            this.LblQuote.TabIndex = 16;
            this.LblQuote.Text = "Cheesy quote here";
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 214);
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
            this.Name = "Course";
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
    }
}