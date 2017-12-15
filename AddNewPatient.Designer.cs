namespace NLHospital
{
    partial class AddNewPatient
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
            this.cbDoctors = new System.Windows.Forms.ComboBox();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nLHDataSet = new NLHospital.NLHDataSet();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.txtbNextKinRel = new System.Windows.Forms.TextBox();
            this.txtbNextKin = new System.Windows.Forms.TextBox();
            this.txtbFirstName = new System.Windows.Forms.TextBox();
            this.txtbAddress = new System.Windows.Forms.TextBox();
            this.txtbCity = new System.Windows.Forms.TextBox();
            this.txtbProvince = new System.Windows.Forms.TextBox();
            this.txtbPostalCode = new System.Windows.Forms.TextBox();
            this.txtbPhone = new System.Windows.Forms.TextBox();
            this.txtbInsComp = new System.Windows.Forms.TextBox();
            this.txtbInsNmb = new System.Windows.Forms.TextBox();
            this.txtbLastName = new System.Windows.Forms.TextBox();
            this.txtbHealthNmb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLHDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDoctors
            // 
            this.cbDoctors.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.doctorsBindingSource, "DoctorID", true));
            this.cbDoctors.DataSource = this.doctorsBindingSource;
            this.cbDoctors.DisplayMember = "DoctorID";
            this.cbDoctors.FormattingEnabled = true;
            this.cbDoctors.Location = new System.Drawing.Point(444, 233);
            this.cbDoctors.Name = "cbDoctors";
            this.cbDoctors.Size = new System.Drawing.Size(121, 21);
            this.cbDoctors.TabIndex = 19;
            this.cbDoctors.ValueMember = "DoctorID";
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
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(444, 54);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(146, 20);
            this.dtpBirthDate.TabIndex = 18;
            this.dtpBirthDate.Value = new System.DateTime(2017, 12, 11, 19, 23, 36, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(229, 318);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(75, 23);
            this.btnAddPatient.TabIndex = 16;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // txtbNextKinRel
            // 
            this.txtbNextKinRel.Location = new System.Drawing.Point(170, 233);
            this.txtbNextKinRel.Name = "txtbNextKinRel";
            this.txtbNextKinRel.Size = new System.Drawing.Size(100, 20);
            this.txtbNextKinRel.TabIndex = 13;
            // 
            // txtbNextKin
            // 
            this.txtbNextKin.Location = new System.Drawing.Point(444, 204);
            this.txtbNextKin.Name = "txtbNextKin";
            this.txtbNextKin.Size = new System.Drawing.Size(100, 20);
            this.txtbNextKin.TabIndex = 12;
            // 
            // txtbFirstName
            // 
            this.txtbFirstName.Location = new System.Drawing.Point(444, 88);
            this.txtbFirstName.Name = "txtbFirstName";
            this.txtbFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtbFirstName.TabIndex = 11;
            // 
            // txtbAddress
            // 
            this.txtbAddress.Location = new System.Drawing.Point(170, 144);
            this.txtbAddress.Name = "txtbAddress";
            this.txtbAddress.Size = new System.Drawing.Size(100, 20);
            this.txtbAddress.TabIndex = 10;
            // 
            // txtbCity
            // 
            this.txtbCity.Location = new System.Drawing.Point(444, 144);
            this.txtbCity.Name = "txtbCity";
            this.txtbCity.Size = new System.Drawing.Size(100, 20);
            this.txtbCity.TabIndex = 9;
            // 
            // txtbProvince
            // 
            this.txtbProvince.Location = new System.Drawing.Point(170, 174);
            this.txtbProvince.Name = "txtbProvince";
            this.txtbProvince.Size = new System.Drawing.Size(100, 20);
            this.txtbProvince.TabIndex = 8;
            // 
            // txtbPostalCode
            // 
            this.txtbPostalCode.Location = new System.Drawing.Point(444, 116);
            this.txtbPostalCode.Name = "txtbPostalCode";
            this.txtbPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtbPostalCode.TabIndex = 7;
            // 
            // txtbPhone
            // 
            this.txtbPhone.Location = new System.Drawing.Point(170, 114);
            this.txtbPhone.Name = "txtbPhone";
            this.txtbPhone.Size = new System.Drawing.Size(100, 20);
            this.txtbPhone.TabIndex = 6;
            // 
            // txtbInsComp
            // 
            this.txtbInsComp.Location = new System.Drawing.Point(444, 174);
            this.txtbInsComp.Name = "txtbInsComp";
            this.txtbInsComp.Size = new System.Drawing.Size(100, 20);
            this.txtbInsComp.TabIndex = 5;
            // 
            // txtbInsNmb
            // 
            this.txtbInsNmb.Location = new System.Drawing.Point(170, 204);
            this.txtbInsNmb.Name = "txtbInsNmb";
            this.txtbInsNmb.Size = new System.Drawing.Size(100, 20);
            this.txtbInsNmb.TabIndex = 3;
            // 
            // txtbLastName
            // 
            this.txtbLastName.Location = new System.Drawing.Point(170, 84);
            this.txtbLastName.Name = "txtbLastName";
            this.txtbLastName.Size = new System.Drawing.Size(100, 20);
            this.txtbLastName.TabIndex = 2;
            // 
            // txtbHealthNmb
            // 
            this.txtbHealthNmb.Location = new System.Drawing.Point(170, 54);
            this.txtbHealthNmb.Name = "txtbHealthNmb";
            this.txtbHealthNmb.Size = new System.Drawing.Size(100, 20);
            this.txtbHealthNmb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fill in the following fields to add a patient.";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAddPatient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 395);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtbHealthNmb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbDoctors);
            this.panel2.Controls.Add(this.txtbLastName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtpBirthDate);
            this.panel2.Controls.Add(this.txtbInsNmb);
            this.panel2.Controls.Add(this.txtbInsComp);
            this.panel2.Controls.Add(this.txtbPhone);
            this.panel2.Controls.Add(this.txtbNextKinRel);
            this.panel2.Controls.Add(this.txtbPostalCode);
            this.panel2.Controls.Add(this.txtbNextKin);
            this.panel2.Controls.Add(this.txtbProvince);
            this.panel2.Controls.Add(this.txtbFirstName);
            this.panel2.Controls.Add(this.txtbCity);
            this.panel2.Controls.Add(this.txtbAddress);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 274);
            this.panel2.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(36, 238);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Next Of Kin Relationship :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(336, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Date Of Birth :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Health Number :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(336, 177);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Insurance Company :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(336, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Postal Code :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Province :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(336, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "City :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Address :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Phone Number :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Next Of Kin :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Insurance Number :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Fisrt Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Last Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Doctor ID :";
            // 
            // AddNewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(638, 395);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "AddNewPatient";
            this.Text = "Add New Patient";
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nLHDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDoctors;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private NLHDataSet nLHDataSet;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.TextBox txtbNextKinRel;
        private System.Windows.Forms.TextBox txtbNextKin;
        private System.Windows.Forms.TextBox txtbFirstName;
        private System.Windows.Forms.TextBox txtbAddress;
        private System.Windows.Forms.TextBox txtbCity;
        private System.Windows.Forms.TextBox txtbProvince;
        private System.Windows.Forms.TextBox txtbPostalCode;
        private System.Windows.Forms.TextBox txtbPhone;
        private System.Windows.Forms.TextBox txtbInsComp;
        private System.Windows.Forms.TextBox txtbInsNmb;
        private System.Windows.Forms.TextBox txtbLastName;
        private System.Windows.Forms.TextBox txtbHealthNmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}