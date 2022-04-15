using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University2._0.Forms
{
    internal class StudentForm : Form
    {
        private DevExpress.XtraEditors.TextEdit teName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit teSurname;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit teRegno;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit teFullname;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SpinEdit spinAge;
        private DevExpress.XtraEditors.LookUpEdit leStudentType;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LookUpEdit leGender;
        private DevExpress.XtraGrid.GridControl grdCourses;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.SimpleButton btnCancel;

        private void InitializeComponent()
        {
            this.teName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.teSurname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.teRegno = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.teFullname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.spinAge = new DevExpress.XtraEditors.SpinEdit();
            this.leStudentType = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.leGender = new DevExpress.XtraEditors.LookUpEdit();
            this.grdCourses = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRegno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFullname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leStudentType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // teName
            // 
            this.teName.Location = new System.Drawing.Point(84, 36);
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(187, 20);
            this.teName.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(47, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Name:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Surname:";
            // 
            // teSurname
            // 
            this.teSurname.Location = new System.Drawing.Point(84, 62);
            this.teSurname.Name = "teSurname";
            this.teSurname.Size = new System.Drawing.Size(187, 20);
            this.teSurname.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 117);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Reg. number:";
            // 
            // teRegno
            // 
            this.teRegno.Location = new System.Drawing.Point(84, 114);
            this.teRegno.Name = "teRegno";
            this.teRegno.Size = new System.Drawing.Size(187, 20);
            this.teRegno.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(28, 91);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(50, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Full Name:";
            // 
            // teFullname
            // 
            this.teFullname.Location = new System.Drawing.Point(84, 88);
            this.teFullname.Name = "teFullname";
            this.teFullname.Size = new System.Drawing.Size(187, 20);
            this.teFullname.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(55, 143);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(23, 13);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Age:";
            // 
            // spinAge
            // 
            this.spinAge.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinAge.Location = new System.Drawing.Point(84, 140);
            this.spinAge.Name = "spinAge";
            this.spinAge.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinAge.Size = new System.Drawing.Size(100, 20);
            this.spinAge.TabIndex = 9;
            // 
            // leStudentType
            // 
            this.leStudentType.Location = new System.Drawing.Point(84, 166);
            this.leStudentType.Name = "leStudentType";
            this.leStudentType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leStudentType.Size = new System.Drawing.Size(187, 20);
            this.leStudentType.TabIndex = 10;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(9, 169);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(69, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Student Type:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(39, 195);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(39, 13);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "Gender:";
            // 
            // leGender
            // 
            this.leGender.Location = new System.Drawing.Point(84, 192);
            this.leGender.Name = "leGender";
            this.leGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leGender.Size = new System.Drawing.Size(187, 20);
            this.leGender.TabIndex = 13;
            // 
            // grdCourses
            // 
            this.grdCourses.Location = new System.Drawing.Point(9, 229);
            this.grdCourses.MainView = this.gridView1;
            this.grdCourses.Name = "grdCourses";
            this.grdCourses.Size = new System.Drawing.Size(400, 200);
            this.grdCourses.TabIndex = 14;
            this.grdCourses.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdCourses;
            this.gridView1.Name = "gridView1";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(475, 406);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(556, 406);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            // 
            // StudentForm
            // 
            this.ClientSize = new System.Drawing.Size(643, 441);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grdCourses);
            this.Controls.Add(this.leGender);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.leStudentType);
            this.Controls.Add(this.spinAge);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.teRegno);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.teFullname);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.teSurname);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.teName);
            this.Name = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRegno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFullname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leStudentType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
