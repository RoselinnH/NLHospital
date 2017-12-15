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
    public partial class frmAdmissions : NLHBase
    {
        //private string admissionID;
        //private string patientID;
        //private string bedNumb;
        //private string surgeryScheduled;
        //private string admitDate;
        //private string surgeryDate;
        //private string lName;
        //private string fName;
        //private string address;
        //private string city;
        //private string province;
        //private string postalCode;
        //private string phoneNumb;
        //private string insComp;
        //private string insNumb;
        //private string nextOfKin;
        //private string nextOfKinRel;
        //private string bDay;
        //private string doctorID;
        //private bool tV;
        //private bool semiP;
        //private bool Private;
        //private bool pN;
        //Admissions admissions = new Admissions();
        //Patients patient = new Patients();
        //Extras extra = new Extras();
        public frmAdmissions()
        {
            InitializeComponent();
            pnladmissions.Show();
        }

        #region Menu

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            AddNewPatient addp = new AddNewPatient();
            addp.Show();
        }

        private void btnAmentitiesP_Click(object sender, EventArgs e)
        {
            AddPatientAmentities patientament = new AddPatientAmentities();
            patientament.Show();
        }

        private void btnFindPatient_Click(object sender, EventArgs e)
        {
            FindPatient findp = new FindPatient();
            findp.Show();
        }

        private void btnAdmRec_Click(object sender, EventArgs e)
        {
            AdmissionRecords admrec = new AdmissionRecords();
            admrec.Show();
        }

        private void btnAdmitPatient_Click(object sender, EventArgs e)
        {
            AdmitPatient admp = new AdmitPatient();
            admp.Show();
        }
        #endregion


    }

}
