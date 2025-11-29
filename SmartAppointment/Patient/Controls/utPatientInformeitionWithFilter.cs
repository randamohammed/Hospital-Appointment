using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartAppointment.Patient.Controls
{
    public partial class utPatientInformeitionWithFilter : UserControl
    {
        public utPatientInformeitionWithFilter()
        {
            InitializeComponent();
        }
        public int patientId = 0;
        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void buSearshPatient_Click(object sender, EventArgs e)
        {
           
            usrtPatientDetails1.PatientSelected += UsrtPatientDetails1_PatientSelected;
            usrtPatientDetails1.LodDataByNationalID(txNationalID.Text);

        }

        private void UsrtPatientDetails1_PatientSelected(int PatientId)
        {
            patientId = PatientId;
        }

        private void txAddNew_Click(object sender, EventArgs e)
        {
            AddOrUpdatepatient newpatient = new AddOrUpdatepatient();
            newpatient.PatientSelected += Newpatient_PatientSelected;
            newpatient.ShowDialog();

        }

        private void Newpatient_PatientSelected(Databusiness.PatientViewModel patientView, int Mode)
        {
            patientId = patientView.PatientId;
        }

        private void txNationalID_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txNationalID.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txNationalID, "Set National Id");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txNationalID, "");
            }
        }

        private void utPatientInformeitionWithFilter_Load(object sender, EventArgs e)
        {
            txNationalID.Focus();
        }

        private void buSearshPatient_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
