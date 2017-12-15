namespace NLHospital
{
    partial class frmAdmissions
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
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nLHDataSet = new NLHospital.NLHDataSet();
            this.bedsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nLHDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admissionRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new NLHospital.NLHDataSetTableAdapters.PatientsTableAdapter();
            this.bedsTableAdapter = new NLHospital.NLHDataSetTableAdapters.BedsTableAdapter();
            this.doctorsTableAdapter = new NLHospital.NLHDataSetTableAdapters.DoctorsTableAdapter();
            this.admissionRecordsTableAdapter = new NLHospital.NLHDataSetTableAdapters.AdmissionRecordsTableAdapter();
            this.pnladmissions = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnAmentitiesP = new System.Windows.Forms.Button();
            this.lbAdmissions = new System.Windows.Forms.Label();
            this.btnFindPatient = new System.Windows.Forms.Button();
            this.btnAdmRec = new System.Windows.Forms.Button();
            this.btnAdmitPatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLHDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admissionRecordsBindingSource)).BeginInit();
            this.pnladmissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "Doctors";
            this.doctorsBindingSource.DataSource = this.nLHDataSet;
            // 
            // nLHDataSet
            // 
            this.nLHDataSet.DataSetName = "NLHDataSet";
            this.nLHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bedsBindingSource
            // 
            this.bedsBindingSource.DataMember = "Beds";
            this.bedsBindingSource.DataSource = this.nLHDataSetBindingSource;
            // 
            // nLHDataSetBindingSource
            // 
            this.nLHDataSetBindingSource.DataSource = this.nLHDataSet;
            this.nLHDataSetBindingSource.Position = 0;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.nLHDataSet;
            // 
            // admissionRecordsBindingSource
            // 
            this.admissionRecordsBindingSource.DataMember = "AdmissionRecords";
            this.admissionRecordsBindingSource.DataSource = this.nLHDataSetBindingSource;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // bedsTableAdapter
            // 
            this.bedsTableAdapter.ClearBeforeFill = true;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // admissionRecordsTableAdapter
            // 
            this.admissionRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // pnladmissions
            // 
            this.pnladmissions.Controls.Add(this.btnAdmitPatient);
            this.pnladmissions.Controls.Add(this.btnAdmRec);
            this.pnladmissions.Controls.Add(this.btnFindPatient);
            this.pnladmissions.Controls.Add(this.label4);
            this.pnladmissions.Controls.Add(this.btnAddPatient);
            this.pnladmissions.Controls.Add(this.btnAmentitiesP);
            this.pnladmissions.Controls.Add(this.lbAdmissions);
            this.pnladmissions.Location = new System.Drawing.Point(85, 32);
            this.pnladmissions.Name = "pnladmissions";
            this.pnladmissions.Size = new System.Drawing.Size(320, 236);
            this.pnladmissions.TabIndex = 5;
            this.pnladmissions.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select one of the following:";
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(16, 80);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(136, 23);
            this.btnAddPatient.TabIndex = 2;
            this.btnAddPatient.Text = "Add New Patient";
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnAmentitiesP
            // 
            this.btnAmentitiesP.Location = new System.Drawing.Point(168, 80);
            this.btnAmentitiesP.Name = "btnAmentitiesP";
            this.btnAmentitiesP.Size = new System.Drawing.Size(136, 23);
            this.btnAmentitiesP.TabIndex = 1;
            this.btnAmentitiesP.Text = "Add Amentities";
            this.btnAmentitiesP.Click += new System.EventHandler(this.btnAmentitiesP_Click);
            // 
            // lbAdmissions
            // 
            this.lbAdmissions.AutoSize = true;
            this.lbAdmissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdmissions.Location = new System.Drawing.Point(32, 8);
            this.lbAdmissions.Name = "lbAdmissions";
            this.lbAdmissions.Size = new System.Drawing.Size(89, 17);
            this.lbAdmissions.TabIndex = 0;
            this.lbAdmissions.Text = "Admissions";
            // 
            // btnFindPatient
            // 
            this.btnFindPatient.Location = new System.Drawing.Point(16, 134);
            this.btnFindPatient.Name = "btnFindPatient";
            this.btnFindPatient.Size = new System.Drawing.Size(136, 23);
            this.btnFindPatient.TabIndex = 6;
            this.btnFindPatient.Text = "Find Patient";
            this.btnFindPatient.Click += new System.EventHandler(this.btnFindPatient_Click);
            // 
            // btnAdmRec
            // 
            this.btnAdmRec.Location = new System.Drawing.Point(168, 134);
            this.btnAdmRec.Name = "btnAdmRec";
            this.btnAdmRec.Size = new System.Drawing.Size(136, 23);
            this.btnAdmRec.TabIndex = 7;
            this.btnAdmRec.Text = "Admissions Records";
            this.btnAdmRec.Click += new System.EventHandler(this.btnAdmRec_Click);
            // 
            // btnAdmitPatient
            // 
            this.btnAdmitPatient.Location = new System.Drawing.Point(91, 181);
            this.btnAdmitPatient.Name = "btnAdmitPatient";
            this.btnAdmitPatient.Size = new System.Drawing.Size(136, 23);
            this.btnAdmitPatient.TabIndex = 9;
            this.btnAdmitPatient.Text = "Admit Patient";
            this.btnAdmitPatient.Click += new System.EventHandler(this.btnAdmitPatient_Click);
            // 
            // frmAdmissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 302);
            this.Controls.Add(this.pnladmissions);
            this.Name = "frmAdmissions";
            this.Text = "Admissions";
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLHDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admissionRecordsBindingSource)).EndInit();
            this.pnladmissions.ResumeLayout(false);
            this.pnladmissions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private NLHDataSet nLHDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private NLHDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.BindingSource nLHDataSetBindingSource;
        private System.Windows.Forms.BindingSource bedsBindingSource;
        private NLHDataSetTableAdapters.BedsTableAdapter bedsTableAdapter;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private NLHDataSetTableAdapters.DoctorsTableAdapter doctorsTableAdapter;
        private System.Windows.Forms.BindingSource admissionRecordsBindingSource;
        private NLHDataSetTableAdapters.AdmissionRecordsTableAdapter admissionRecordsTableAdapter;
        private System.Windows.Forms.Panel pnladmissions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnAmentitiesP;
        private System.Windows.Forms.Label lbAdmissions;
        private System.Windows.Forms.Button btnAdmitPatient;
        private System.Windows.Forms.Button btnAdmRec;
        private System.Windows.Forms.Button btnFindPatient;
    }
}