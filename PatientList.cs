using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NLHBaseWindow;
using NLHospitalLibrary;
using System.Data.SqlClient;
using System.Configuration;
namespace NLHospital
{
    public partial class PatientList : Form
    {
        public PatientList()
        {
            InitializeComponent();
        }

        private void PatientList_Load(object sender, EventArgs e)
        {
            string sSql = "SELECT Beds.WardName, Patients.HealthNumber, Patients.DateOfBirth, Patients.LastName, Patients.FirstName, Patients.Address, Patients.City, Patients.Province, Patients.PostalCode, Patients.Phone, Patients.InsuranceCompany, Patients.InsuranceNumber, Patients.NextOfKin, Patients.NextOfKinRelationship, Patients.Doctor" +
                " FROM Patients INNER JOIN AdmissionRecords ON Patients.HealthNumber = AdmissionRecords.PatientID"+
                " INNER JOIN Beds ON AdmissionRecords.BedNumber = Beds.BedNumber" +
                " ORDER BY Beds.WardName";
            dataGridView1.DataSource = this.GetData(sSql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private DataTable GetData(string sSql)
        {
            string connString = @"Data Source=TECHGIRL\MSSQLSERVER01;Initial Catalog=NLH;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(sSql))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        cmd.Connection = con;
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
    
}

