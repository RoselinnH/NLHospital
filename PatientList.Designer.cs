namespace NLHospital
{
    partial class PatientList
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
            this.nLHDataSet = new NLHospital.NLHDataSet();
            this.nLHDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admissionRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admissionRecordsTableAdapter = new NLHospital.NLHDataSetTableAdapters.AdmissionRecordsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientsTableAdapter = new NLHospital.NLHDataSetTableAdapters.PatientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nLHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLHDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admissionRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nLHDataSet
            // 
            this.nLHDataSet.DataSetName = "NLHDataSet";
            this.nLHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nLHDataSetBindingSource
            // 
            this.nLHDataSetBindingSource.DataSource = this.nLHDataSet;
            this.nLHDataSetBindingSource.Position = 0;
            // 
            // admissionRecordsBindingSource
            // 
            this.admissionRecordsBindingSource.DataMember = "AdmissionRecords";
            this.admissionRecordsBindingSource.DataSource = this.nLHDataSetBindingSource;
            // 
            // admissionRecordsTableAdapter
            // 
            this.admissionRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(823, 424);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.nLHDataSetBindingSource;
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // PatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 424);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PatientList";
            this.Text = "PatientList";
            this.Load += new System.EventHandler(this.PatientList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nLHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLHDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admissionRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource nLHDataSetBindingSource;
        private NLHDataSet nLHDataSet;
        private System.Windows.Forms.BindingSource admissionRecordsBindingSource;
        private NLHDataSetTableAdapters.AdmissionRecordsTableAdapter admissionRecordsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private NLHDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
    }
}