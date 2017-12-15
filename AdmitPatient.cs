using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NLHospitalLibrary;
using NLHBaseWindow;

namespace NLHospital
{
    public partial class AdmitPatient : Form
    {
        private string admissionID;
        private string patientID;
        private string bedNumb;
        private bool surgeryScheduled;
        private DateTime admitDate;
        private DateTime surgeryDate;
        Admissions admissions = new Admissions();

        public AdmitPatient()
        {
            InitializeComponent();
            dtpAdmitedD_1.Value = DateTime.Today;
            rbtnSurgerySch_1.Checked = false;
            txtbAdmissionID_1.Clear();
            dtpSurgeryDate_1.Value = DateTime.Today;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            admissionID = txtbAdmissionID_1.Text;
            patientID = cbPatientID_1.Text;
            bedNumb = cbBedNmb_1.Text;
            admitDate = dtpAdmitedD_1.Value;
            surgeryScheduled = rbtnSurgerySch_1.Checked;
            surgeryDate = dtpSurgeryDate_1.Value;
            string sMsg = "";
            try
            {
                sMsg = admissions.AddAdmissionRecord(admissionID, patientID, bedNumb, surgeryDate, admitDate, surgeryScheduled);
            }
            catch
            {
                sMsg = "Error saving data." + "\n\n" + e.ToString();

            }
            finally
            {
                MessageBox.Show(sMsg, "Add Admission Record", MessageBoxButtons.OK);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtpSurgeryDate_1.Value = DateTime.Today;
            dtpAdmitedD_1.Value = DateTime.Today;
            rbtnSurgerySch_1.Checked = false;
            txtbAdmissionID_1.Clear();
        }

        private void rbtnSurgerySch_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AdmitPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nLHDataSet.Beds' table. You can move, or remove it, as needed.
            this.bedsTableAdapter.Fill(this.nLHDataSet.Beds);
            // TODO: This line of code loads data into the 'nLHDataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.nLHDataSet.Patients);
            // TODO: This line of code loads data into the 'nLHDataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.nLHDataSet.Patients);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bedsTableAdapter.FillBy(this.nLHDataSet.Beds);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
