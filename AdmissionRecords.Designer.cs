namespace NLHospital
{
    partial class AdmissionRecords
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtbAdmissionId = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nLHDataSet = new NLHospital.NLHDataSet();
            this.admissionRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admissionRecordsTableAdapter = new NLHospital.NLHDataSetTableAdapters.AdmissionRecordsTableAdapter();
            this.admissionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surgeryScheduledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.admitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surgeryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dischargeDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admissionRecordsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbAdmissionId
            // 
            this.txtbAdmissionId.Location = new System.Drawing.Point(361, 331);
            this.txtbAdmissionId.Name = "txtbAdmissionId";
            this.txtbAdmissionId.Size = new System.Drawing.Size(100, 20);
            this.txtbAdmissionId.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.admissionIDDataGridViewTextBoxColumn,
            this.patientIDDataGridViewTextBoxColumn,
            this.bedNumberDataGridViewTextBoxColumn,
            this.surgeryScheduledDataGridViewCheckBoxColumn,
            this.admitDateDataGridViewTextBoxColumn,
            this.surgeryDateDataGridViewTextBoxColumn,
            this.dischargeDateDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.admissionRecordsBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 25);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(750, 246);
            this.dataGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtbAdmissionId);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 443);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Admission ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fill in the following field to search for a specific record.";
            // 
            // nLHDataSet
            // 
            this.nLHDataSet.DataSetName = "NLHDataSet";
            this.nLHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // admissionRecordsBindingSource
            // 
            this.admissionRecordsBindingSource.DataMember = "AdmissionRecords";
            this.admissionRecordsBindingSource.DataSource = this.nLHDataSet;
            // 
            // admissionRecordsTableAdapter
            // 
            this.admissionRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // admissionIDDataGridViewTextBoxColumn
            // 
            this.admissionIDDataGridViewTextBoxColumn.DataPropertyName = "AdmissionID";
            this.admissionIDDataGridViewTextBoxColumn.HeaderText = "AdmissionID";
            this.admissionIDDataGridViewTextBoxColumn.Name = "admissionIDDataGridViewTextBoxColumn";
            // 
            // patientIDDataGridViewTextBoxColumn
            // 
            this.patientIDDataGridViewTextBoxColumn.DataPropertyName = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.HeaderText = "PatientID";
            this.patientIDDataGridViewTextBoxColumn.Name = "patientIDDataGridViewTextBoxColumn";
            // 
            // bedNumberDataGridViewTextBoxColumn
            // 
            this.bedNumberDataGridViewTextBoxColumn.DataPropertyName = "BedNumber";
            this.bedNumberDataGridViewTextBoxColumn.HeaderText = "BedNumber";
            this.bedNumberDataGridViewTextBoxColumn.Name = "bedNumberDataGridViewTextBoxColumn";
            // 
            // surgeryScheduledDataGridViewCheckBoxColumn
            // 
            this.surgeryScheduledDataGridViewCheckBoxColumn.DataPropertyName = "SurgeryScheduled";
            this.surgeryScheduledDataGridViewCheckBoxColumn.HeaderText = "SurgeryScheduled";
            this.surgeryScheduledDataGridViewCheckBoxColumn.Name = "surgeryScheduledDataGridViewCheckBoxColumn";
            // 
            // admitDateDataGridViewTextBoxColumn
            // 
            this.admitDateDataGridViewTextBoxColumn.DataPropertyName = "AdmitDate";
            this.admitDateDataGridViewTextBoxColumn.HeaderText = "AdmitDate";
            this.admitDateDataGridViewTextBoxColumn.Name = "admitDateDataGridViewTextBoxColumn";
            // 
            // surgeryDateDataGridViewTextBoxColumn
            // 
            this.surgeryDateDataGridViewTextBoxColumn.DataPropertyName = "SurgeryDate";
            this.surgeryDateDataGridViewTextBoxColumn.HeaderText = "SurgeryDate";
            this.surgeryDateDataGridViewTextBoxColumn.Name = "surgeryDateDataGridViewTextBoxColumn";
            // 
            // dischargeDateDataGridViewTextBoxColumn
            // 
            this.dischargeDateDataGridViewTextBoxColumn.DataPropertyName = "DischargeDate";
            this.dischargeDateDataGridViewTextBoxColumn.HeaderText = "DischargeDate";
            this.dischargeDateDataGridViewTextBoxColumn.Name = "dischargeDateDataGridViewTextBoxColumn";
            // 
            // AdmissionRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(773, 443);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "AdmissionRecords";
            this.Text = "Admission Records";
            this.Load += new System.EventHandler(this.AdmissionRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nLHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admissionRecordsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbAdmissionId;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private NLHDataSet nLHDataSet;
        private System.Windows.Forms.BindingSource admissionRecordsBindingSource;
        private NLHDataSetTableAdapters.AdmissionRecordsTableAdapter admissionRecordsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn surgeryScheduledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surgeryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dischargeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnReset;
    }
}