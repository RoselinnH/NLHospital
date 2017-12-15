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
    public partial class AddNewPatient : Form
    {
        Patients patient = new Patients();

        public AddNewPatient()
        {
            InitializeComponent();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            string patientID = txtbHealthNmb.Text;
            string lName = txtbLastName.Text;
            string fName = txtbFirstName.Text;
            string address = txtbAddress.Text;
            string city = txtbCity.Text;
            string province = txtbProvince.Text;
            string postalCode = txtbPostalCode.Text;
            string phoneNumb = txtbPhone.Text;
            string insComp = txtbInsComp.Text;
            string insNumb = txtbInsNmb.Text;
            string nextOfKin = txtbNextKin.Text;
            string nextOfKinRel = txtbNextKinRel.Text;
            string bDay = dtpBirthDate.Value.ToString("yyyy-MM-dd");
            string doctorID = cbDoctors.Text;
            string sMsg = "";

            try
            {
                sMsg = patient.AddData(lName, fName, patientID, bDay, address, city, province, postalCode, phoneNumb, insComp, insNumb, nextOfKin, nextOfKinRel, doctorID);
            }
            catch
            {
                sMsg = "Error saving data." + "\n\n" + e.ToString();
            }
            finally
            {
                MessageBox.Show(sMsg, "Add Patient", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtbHealthNmb.Clear();
            txtbLastName.Clear();
            txtbFirstName.Clear();
            txtbAddress.Clear();
            txtbCity.Clear();
            txtbProvince.Clear();
            txtbPostalCode.Clear();
            txtbPhone.Clear();
            txtbInsComp.Clear();
            txtbInsNmb.Clear();
            txtbNextKin.Clear();
            txtbNextKinRel.Clear();
            dtpBirthDate.Value= DateTime.Today;
            cbDoctors.SelectedIndex=-1;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
