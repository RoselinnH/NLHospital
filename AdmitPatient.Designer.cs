namespace NLHospital
{
    partial class AdmitPatient
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
            this.btnClear = new System.Windows.Forms.Button();
            this.cbBedNmb_1 = new System.Windows.Forms.ComboBox();
            this.bedsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nLHDataSet = new NLHospital.NLHDataSet();
            this.cbPatientID_1 = new System.Windows.Forms.ComboBox();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpSurgeryDate_1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpAdmitedD_1 = new System.Windows.Forms.DateTimePicker();
            this.txtbAdmissionID_1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnSurgerySch_1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.patientsTableAdapter = new NLHospital.NLHDataSetTableAdapters.PatientsTableAdapter();
            this.bedsTableAdapter = new NLHospital.NLHDataSetTableAdapters.BedsTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bedsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(325, 346);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbBedNmb_1
            // 
            this.cbBedNmb_1.DataSource = this.bedsBindingSource;
            this.cbBedNmb_1.DisplayMember = "BedNumber";
            this.cbBedNmb_1.FormattingEnabled = true;
            this.cbBedNmb_1.Location = new System.Drawing.Point(116, 119);
            this.cbBedNmb_1.Name = "cbBedNmb_1";
            this.cbBedNmb_1.Size = new System.Drawing.Size(121, 21);
            this.cbBedNmb_1.TabIndex = 9;
            this.cbBedNmb_1.ValueMember = "BedNumber";
            // 
            // bedsBindingSource
            // 
            this.bedsBindingSource.DataMember = "Beds";
            this.bedsBindingSource.DataSource = this.nLHDataSet;
            // 
            // nLHDataSet
            // 
            this.nLHDataSet.DataSetName = "NLHDataSet";
            this.nLHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbPatientID_1
            // 
            this.cbPatientID_1.DataSource = this.patientsBindingSource;
            this.cbPatientID_1.DisplayMember = "HealthNumber";
            this.cbPatientID_1.FormattingEnabled = true;
            this.cbPatientID_1.Location = new System.Drawing.Point(387, 77);
            this.cbPatientID_1.Name = "cbPatientID_1";
            this.cbPatientID_1.Size = new System.Drawing.Size(121, 21);
            this.cbPatientID_1.TabIndex = 8;
            this.cbPatientID_1.Tag = "";
            this.cbPatientID_1.ValueMember = "HealthNumber";
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataMember = "Patients";
            this.patientsBindingSource.DataSource = this.nLHDataSet;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(200, 346);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Admit";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpSurgeryDate_1
            // 
            this.dtpSurgeryDate_1.Location = new System.Drawing.Point(387, 163);
            this.dtpSurgeryDate_1.Name = "dtpSurgeryDate_1";
            this.dtpSurgeryDate_1.Size = new System.Drawing.Size(200, 20);
            this.dtpSurgeryDate_1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Fill in the following fields to admit a patient.";
            // 
            // dtpAdmitedD_1
            // 
            this.dtpAdmitedD_1.Location = new System.Drawing.Point(387, 120);
            this.dtpAdmitedD_1.Name = "dtpAdmitedD_1";
            this.dtpAdmitedD_1.Size = new System.Drawing.Size(200, 20);
            this.dtpAdmitedD_1.TabIndex = 4;
            this.dtpAdmitedD_1.Value = new System.DateTime(2017, 12, 10, 0, 0, 0, 0);
            // 
            // txtbAdmissionID_1
            // 
            this.txtbAdmissionID_1.Location = new System.Drawing.Point(116, 78);
            this.txtbAdmissionID_1.Name = "txtbAdmissionID_1";
            this.txtbAdmissionID_1.Size = new System.Drawing.Size(100, 20);
            this.txtbAdmissionID_1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 395);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.fillByToolStrip);
            this.panel2.Controls.Add(this.rbtnSurgerySch_1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtbAdmissionID_1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbBedNmb_1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbPatientID_1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpAdmitedD_1);
            this.panel2.Controls.Add(this.dtpSurgeryDate_1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 297);
            this.panel2.TabIndex = 11;
            // 
            // rbtnSurgerySch_1
            // 
            this.rbtnSurgerySch_1.AutoSize = true;
            this.rbtnSurgerySch_1.Location = new System.Drawing.Point(28, 163);
            this.rbtnSurgerySch_1.Name = "rbtnSurgerySch_1";
            this.rbtnSurgerySch_1.Size = new System.Drawing.Size(116, 17);
            this.rbtnSurgerySch_1.TabIndex = 18;
            this.rbtnSurgerySch_1.Text = "Surgery Scheduled";
            this.rbtnSurgerySch_1.UseVisualStyleBackColor = true;
            this.rbtnSurgerySch_1.CheckedChanged += new System.EventHandler(this.rbtnSurgerySch_1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Surgery Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Admission Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Patient ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Admission ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bed Number :";
            // 
            // patientsTableAdapter
            // 
            this.patientsTableAdapter.ClearBeforeFill = true;
            // 
            // bedsTableAdapter
            // 
            this.bedsTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(111, 25);
            this.fillByToolStrip.TabIndex = 4;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Visible = false;
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // AdmitPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(638, 395);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "AdmitPatient";
            this.Text = "Admit Patient";
            this.Load += new System.EventHandler(this.AdmitPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bedsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbBedNmb_1;
        private System.Windows.Forms.ComboBox cbPatientID_1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpSurgeryDate_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpAdmitedD_1;
        private System.Windows.Forms.TextBox txtbAdmissionID_1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox rbtnSurgerySch_1;
        private NLHDataSet nLHDataSet;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private NLHDataSetTableAdapters.PatientsTableAdapter patientsTableAdapter;
        private System.Windows.Forms.BindingSource bedsBindingSource;
        private NLHDataSetTableAdapters.BedsTableAdapter bedsTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}