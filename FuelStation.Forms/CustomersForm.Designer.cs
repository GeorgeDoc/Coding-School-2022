namespace FuelStation.Forms {
    partial class CustomersForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.gvCustomers = new System.Windows.Forms.DataGridView();
            this.btnCustSave = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCardNo = new System.Windows.Forms.TextBox();
            this.btmCustRemove = new System.Windows.Forms.Button();
            this.btnCustCancel = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.initialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gvCustomers
            // 
            this.gvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCustomers.Location = new System.Drawing.Point(12, 197);
            this.gvCustomers.Name = "gvCustomers";
            this.gvCustomers.RowTemplate.Height = 25;
            this.gvCustomers.Size = new System.Drawing.Size(523, 205);
            this.gvCustomers.TabIndex = 0;
            // 
            // btnCustSave
            // 
            this.btnCustSave.Location = new System.Drawing.Point(460, 77);
            this.btnCustSave.Name = "btnCustSave";
            this.btnCustSave.Size = new System.Drawing.Size(75, 23);
            this.btnCustSave.TabIndex = 1;
            this.btnCustSave.Text = "Save";
            this.btnCustSave.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(72, 61);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 23);
            this.tbName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Surname";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(72, 90);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(100, 23);
            this.tbSurname.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Card No.";
            // 
            // tbCardNo
            // 
            this.tbCardNo.Location = new System.Drawing.Point(72, 119);
            this.tbCardNo.Name = "tbCardNo";
            this.tbCardNo.Size = new System.Drawing.Size(100, 23);
            this.tbCardNo.TabIndex = 6;
            // 
            // btmCustRemove
            // 
            this.btmCustRemove.Location = new System.Drawing.Point(460, 118);
            this.btmCustRemove.Name = "btmCustRemove";
            this.btmCustRemove.Size = new System.Drawing.Size(75, 23);
            this.btmCustRemove.TabIndex = 8;
            this.btmCustRemove.Text = "Remove";
            this.btmCustRemove.UseVisualStyleBackColor = true;
            this.btmCustRemove.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCustCancel
            // 
            this.btnCustCancel.Location = new System.Drawing.Point(541, 379);
            this.btnCustCancel.Name = "btnCustCancel";
            this.btnCustCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCustCancel.TabIndex = 9;
            this.btnCustCancel.Text = "Cancel";
            this.btnCustCancel.UseVisualStyleBackColor = true;
            this.btnCustCancel.Click += new System.EventHandler(this.btnCustCancel_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(83, 158);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 10;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.button1_Click);
            // 
            // initialBindingSource
            // 
            this.initialBindingSource.DataSource = typeof(FuelStation.EF.Migrations.initial);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnCustCancel);
            this.Controls.Add(this.btmCustRemove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbCardNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnCustSave);
            this.Controls.Add(this.gvCustomers);
            this.Name = "CustomersForm";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gvCustomers;
        private Button btnCustSave;
        private TextBox tbName;
        private Label label1;
        private Label label2;
        private TextBox tbSurname;
        private Label label3;
        private TextBox tbCardNo;
        private Button btmCustRemove;
        private Button btnCustCancel;
        private Button btnBuy;
        private BindingSource initialBindingSource;
    }
}