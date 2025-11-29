using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartAppointment.Patient
{
    public partial class frmPatientDetails : Form
    {
        public frmPatientDetails(int PatientId)
        {
            InitializeComponent();
            this.PatientId = PatientId;
        }
        int PatientId = 0;
        private void frmPatientDetails_Load(object sender, EventArgs e)
        {
            usrtPatientDetails1.LodDataByPatientId(PatientId);
        }

        private void butclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
