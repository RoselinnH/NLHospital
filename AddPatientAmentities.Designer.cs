namespace NLHospital
{
    partial class AddPatientAmentities
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbPhone = new System.Windows.Forms.CheckBox();
            this.rbTV = new System.Windows.Forms.CheckBox();
            this.rbPrivate = new System.Windows.Forms.CheckBox();
            this.rbSemiPrivate = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPatientID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAdmRecID = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nLHDataSet1 = new NLHospital.NLHDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.admissionRecordsTableAdapter = new NLHospital.NLHDataSetTableAdapters.AdmissionRecordsTableAdapter();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLHDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rbPhone);
            this.panel1.Controls.Add(this.rbTV);
            this.panel1.Controls.Add(this.rbPrivate);
            this.panel1.Controls.Add(this.rbSemiPrivate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbPatientID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbAdmRecID);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 252);
            this.panel1.TabIndex = 11;
            // 
            // rbPhone
            // 
            this.rbPhone.AutoSize = true;
            this.rbPhone.Location = new System.Drawing.Point(190, 194);
            this.rbPhone.Name = "rbPhone";
            this.rbPhone.Size = new System.Drawing.Size(57, 17);
            this.rbPhone.TabIndex = 15;
            this.rbPhone.Text = "Phone";
            this.rbPhone.UseVisualStyleBackColor = true;
            // 
            // rbTV
            // 
            this.rbTV.AutoSize = true;
            this.rbTV.Location = new System.Drawing.Point(308, 194);
            this.rbTV.Name = "rbTV";
            this.rbTV.Size = new System.Drawing.Size(40, 17);
            this.rbTV.TabIndex = 14;
            this.rbTV.Text = "TV";
            this.rbTV.UseVisualStyleBackColor = true;
            // 
            // rbPrivate
            // 
            this.rbPrivate.AutoSize = true;
            this.rbPrivate.Location = new System.Drawing.Point(308, 132);
            this.rbPrivate.Name = "rbPrivate";
            this.rbPrivate.Size = new System.Drawing.Size(59, 17);
            this.rbPrivate.TabIndex = 13;
            this.rbPrivate.Text = "Private";
            this.rbPrivate.UseVisualStyleBackColor = true;
            // 
            // rbSemiPrivate
            // 
            this.rbSemiPrivate.AutoSize = true;
            this.rbSemiPrivate.Location = new System.Drawing.Point(190, 132);
            this.rbSemiPrivate.Name = "rbSemiPrivate";
            this.rbSemiPrivate.Size = new System.Drawing.Size(85, 17);
            this.rbSemiPrivate.TabIndex = 12;
            this.rbSemiPrivate.Text = "Semi-Private";
            this.rbSemiPrivate.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Admission ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Patient ID :";
            // 
            // cbPatientID
            // 
            this.cbPatientID.DataSource = this.bindingSource1;
            this.cbPatientID.DisplayMember = "PatientID";
            this.cbPatientID.FormattingEnabled = true;
            this.cbPatientID.Location = new System.Drawing.Point(104, 62);
            this.cbPatientID.Name = "cbPatientID";
            this.cbPatientID.Size = new System.Drawing.Size(121, 21);
            this.cbPatientID.TabIndex = 0;
            this.cbPatientID.ValueMember = "PatientID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fill in the following fields to add additional amentities to the patients file :";
            // 
            // cbAdmRecID
            // 
            this.cbAdmRecID.DataSource = this.bindingSource1;
            this.cbAdmRecID.DisplayMember = "AdmissionID";
            this.cbAdmRecID.FormattingEnabled = true;
            this.cbAdmRecID.Location = new System.Drawing.Point(412, 62);
            this.cbAdmRecID.Name = "cbAdmRecID";
            this.cbAdmRecID.Size = new System.Drawing.Size(121, 21);
            this.cbAdmRecID.TabIndex = 1;
            this.cbAdmRecID.ValueMember = "AdmissionID";
            this.cbAdmRecID.SelectedIndexChanged += new System.EventHandler(this.cbAdmRecID_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(241, 288);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Patients Amentities";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(272, 322);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 395);
            this.panel3.TabIndex = 2;
            // 
            // nLHDataSet1
            // 
            this.nLHDataSet1.DataSetName = "NLHDataSet";
            this.nLHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "AdmissionRecords";
            this.bindingSource1.DataSource = this.nLHDataSet1;
            // 
            // admissionRecordsTableAdapter
            // 
            this.admissionRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // AddPatientAmentities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(638, 395);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "AddPatientAmentities";
            this.Text = "AddPatientAmentities";
            this.Load += new System.EventHandler(this.AddPatientAmentities_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nLHDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbPatientID;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private NLHDataSet nLHDataSet;
        private System.Windows.Forms.ComboBox cbAdmRecID;
        private System.Windows.Forms.BindingSource admissionRecordsBindingSource;
        private System.Windows.Forms.BindingSource nLHDataSetBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox rbSemiPrivate;
        private System.Windows.Forms.CheckBox rbPhone;
        private System.Windows.Forms.CheckBox rbTV;
        private System.Windows.Forms.CheckBox rbPrivate;
        private NLHDataSet nLHDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private NLHDataSetTableAdapters.AdmissionRecordsTableAdapter admissionRecordsTableAdapter;
    }
}