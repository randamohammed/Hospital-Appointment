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

namespace SmartAppointment.Patient
{
    public partial class AddOrUpdatepatient : Form
    {
        public AddOrUpdatepatient()
        {
            InitializeComponent();
        }
        public delegate void PatientSelectedHandler(PatientViewModel patientView, int Mode);
        public event PatientSelectedHandler PatientSelected;
        public AddOrUpdatepatient(int PatientId)
        {
            InitializeComponent();
            this.PatientId = PatientId;
        }
        int PatientId = 0;

      void _RefrashData()
        {
            if (PatientId == 0)
            {
                this.Text = "Add New Patient";
                return;
            }
            else
            {
                this.Text = "Update Patient";
                uctrAddOrUpdatePatient1.LodData(PatientId);
            }
        }
        private void AddOrUpdatepatient_Load(object sender, EventArgs e)
        {
            _RefrashData();
        }

        private void butSave_Click(object sender, EventArgs e)
        {
            uctrAddOrUpdatePatient1.SavDate();
            uctrAddOrUpdatePatient1.PatientSelected += UctrAddOrUpdatePatient1_PatientSelected; ;
        }

        private void UctrAddOrUpdatePatient1_PatientSelected(Databusiness.PatientViewModel patientView, int Mode)
        {
            if (patientView.PatientId == 0)
                MessageBox.Show("Error Don't Save the Patient", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("save the patient Successfuly", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PatientSelected.Invoke(patientView, Mode);
        }

       
        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
