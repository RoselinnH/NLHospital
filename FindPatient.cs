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
    public partial class FindPatient : Form
    {
        private string patientID;
        Patients patient = new Patients();

        public FindPatient()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            patientID = txtbHealthNmb_1.Text;
            DataSet thisDataSet = new DataSet();
            string sMsg="";
            try
            {
                thisDataSet = patient.FindData(patientID);
                dgvPatient.DataSource = thisDataSet.Tables[0];
            }
            catch
            {
                sMsg = "Patient record associated to the ID you've entered was not found.";
                MessageBox.Show(sMsg, "Patient Record", MessageBoxButtons.OK);
            }
        }

        private void FindPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nLHDataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.nLHDataSet.Patients);

        }
    }
}
