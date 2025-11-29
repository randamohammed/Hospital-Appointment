using Databusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartAppointment.Appointment
{
    public partial class fromAddOrUpdateAppointment : Form
    {
        public fromAddOrUpdateAppointment()
        {
            InitializeComponent();
        }
        DataPaitent DataPaitent { get; set; }
        DataAppointment DataAppointment;
        private void utPatientInformeitionWithFilter1_Load(object sender, EventArgs e)
        {

        }

        private void LodaDocterDate()
        {
            
        }
     
        private void butClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void LodaDocter()
        {
            DataTable dataTable = await DataDocter.GetAllDocterForCombox();

            comdocters.DisplayMember = "DoctorName"; 
            comdocters.ValueMember = "DoctorID";

            comdocters.DataSource = dataTable;

        }
        private void fromAddOrUpdateAppointment_Load(object sender, EventArgs e)
        {
            butSave.Enabled = false;
            LodaDocter();
        }

        private void butNext_Click(object sender, EventArgs e)
        {

        }

        private void butSave_Click(object sender, EventArgs e)
        {
            DataAppointment.PaitentID = utPatientInformeitionWithFilter1.patientId;
            DataAppointment.DocterID =Convert.ToInt32( comdocters.ValueMember);
            DataAppointment.ReasonForVisit = txtReasonforvisit.Text;

        }
    }
}
