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
    public partial class AddPatientAmentities : Form
    {
        private string admissionID;
        private string patientID;
        private bool tV;
        private bool semiP;
        private bool Private;
        private bool pN;
        Extras extra = new Extras();
        public AddPatientAmentities()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            patientID = cbPatientID.Text;
            admissionID = cbAdmRecID.Text;
            tV = rbTV.Checked;
            pN = rbPhone.Checked;
            semiP = rbSemiPrivate.Checked;
            Private = rbPrivate.Checked;
            string sMsg = "";

            try
            {
                sMsg = extra.AddData(admissionID, patientID, tV, pN, semiP, Private);
            }
            catch
            {
                sMsg = "Error saving data." + "\n\n" + e.ToString();
            }
            finally
            {
                MessageBox.Show(sMsg, "Add Patients Amentites", MessageBoxButtons.OK);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rbTV.Checked = false;
            rbPhone.Checked = false;
            rbSemiPrivate.Checked = false;
            rbPrivate.Checked = false;
        }

        private void cbAdmRecID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddPatientAmentities_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nLHDataSet1.AdmissionRecords' table. You can move, or remove it, as needed.
            this.admissionRecordsTableAdapter.Fill(this.nLHDataSet1.AdmissionRecords);

        }
    }
}
