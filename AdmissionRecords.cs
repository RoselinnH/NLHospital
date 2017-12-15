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
    public partial class AdmissionRecords : Form
    {
        private string admissionID;
        Admissions admissions = new Admissions();
        DataSet ds_FindData = new DataSet();

        public AdmissionRecords()
        {
            InitializeComponent();

        }

        private void AdmissionRecords_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nLHDataSet.AdmissionRecords' table. You can move, or remove it, as needed.
            this.admissionRecordsTableAdapter.Fill(this.nLHDataSet.AdmissionRecords);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admissionID = txtbAdmissionId.Text;
            string sMsg = "";
            
            try
            {
                ds_FindData = admissions.FindData(admissionID);
                dataGridView.DataSource = ds_FindData.Tables[0];
            }
            catch
            {
                sMsg = "Admissions record associated to the ID you've entered was not found.";
                MessageBox.Show(sMsg, "Admission Record", MessageBoxButtons.OK);
            }
        }

    }
}
