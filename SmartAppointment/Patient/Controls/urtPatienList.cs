using AutoMapper;
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

namespace SmartAppointment.Patient.Controls
{
    public partial class urtPatienList : UserControl
    {
        public urtPatienList()
        {
            InitializeComponent();
        }

        int PageNumber = 1;
        int pageSize;
        int PatientId = 0;
        DataTable _SemPatient;

        List<PatientViewModel> _Patients = new List<PatientViewModel>();
        private void butAddNewPatient_Click(object sender, EventArgs e)
        {
            AddOrUpdatepatient addpatient = new AddOrUpdatepatient();
            addpatient.PatientSelected += Addpatient_PatientSelected;
            addpatient.ShowDialog();
        }

        private void Addpatient_PatientSelected(PatientViewModel patientView, int Mode)
        {
            AddorUpdate(patientView, Mode);
        }
        public void Clear()
        {
            bindingSourcePatient.Clear();
        }

        public  void LodData()
        {
            PageNumber = 1;
            pageSize = 100;

            cmPageSize.SelectedIndex = 0;

            pageSize = Convert.ToInt32(cmPageSize.Text);

            _Patients = PatientViewModel.GetPatientsPaginated(PageNumber, pageSize);
            bindingSourcePatient.DataSource = _Patients;
            dgPatientList.DataSource = bindingSourcePatient;
            lbRecorde.Text = dgPatientList.Rows.Count.ToString();
            cmFlater.SelectedIndex = 0;

            if (dgPatientList.Rows.Count > 0)
            {
                dgPatientList.Columns[0].HeaderText = "PatientID";
                dgPatientList.Columns[0].Width = 100;

                dgPatientList.Columns[1].HeaderText = "FullName";
                dgPatientList.Columns[1].Width = 200;

                dgPatientList.Columns[2].HeaderText = "Phone";
                dgPatientList.Columns[2].Width = 90;

                dgPatientList.Columns[3].HeaderText = "DateOfBirth";
                dgPatientList.Columns[3].Width = 140;


                dgPatientList.Columns[4].HeaderText = "Gender";
                dgPatientList.Columns[4].Width = 50;

                dgPatientList.Columns[5].HeaderText = "Balance";
                dgPatientList.Columns[5].Width = 100;

                dgPatientList.Columns[6].HeaderText = "Regs Date";
                dgPatientList.Columns[6].Width = 150;

            }
        }
        private void urtPatienList_Load(object sender, EventArgs e)
        {
             PageNumber = 1;
             pageSize = 100;
        }

        private void tsoShowPatientDetailes_Click(object sender, EventArgs e)
        {
            PatientId = (int)dgPatientList.CurrentRow.Cells[0].Value;
            frmPatientDetails patientDetails = new frmPatientDetails(PatientId);
            patientDetails.ShowDialog();
        }

        private void tsoEdit_Click(object sender, EventArgs e)
        {
            PatientId = (int)dgPatientList.CurrentRow.Cells[0].Value;
            AddOrUpdatepatient frmEdit = new AddOrUpdatepatient(PatientId);
            frmEdit.PatientSelected += Edit_PatientSelected;
            frmEdit.ShowDialog();
        }

        private void AddorUpdate(PatientViewModel patientView, int Mode)
        {
            if(Mode == 0)
            {
                _Patients.Add(patientView);
            }
            else
            {
                var oldpatient = _Patients.FindAll(_Patient => _Patient.PatientId == patientView.PatientId);
                if (oldpatient != null)
                {
                    Databusiness.Mappers.AutoMapperConfigs.Mapper.Map(patientView, oldpatient);

                }
            }
            bindingSourcePatient.ResetBindings(false);
        }

        private void Edit_PatientSelected(PatientViewModel patientView, int Mode)
        {
            AddorUpdate(patientView, Mode);
        }

        private void tosDelete_Click(object sender, EventArgs e)
        {
          var   patient =dgPatientList.CurrentRow.DataBoundItem as PatientViewModel;

            if (DataPaitent.DeletePatient(patient.PatientId))

            {
                _Patients.RemoveAll( _patient=> _patient.PatientId==patient.PatientId);
                bindingSourcePatient.ResetBindings(false);
                MessageBox.Show("Deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error Not Deleted successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void butNext_Click(object sender, EventArgs e)
        {
            PageNumber += 1;
            urtPatienList_Load(null, null);
        }

        private void butPrevious_Click(object sender, EventArgs e)
        {
            if (PageNumber == 1) return;
            PageNumber -= 1;
            urtPatienList_Load(null, null);
        }

        private void cmPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            PageNumber = 1;
            urtPatienList_Load(null, null);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtFilterVaaluse.Text == "" || cmFlater.Text == "Non")
            {
                dgPatientList.DataSource = null;
                dgPatientList.DataSource = _Patients;
                return;
            }

            string Searchtext = txtFilterVaaluse.Text.ToLower();
            IEnumerable<PatientViewModel> filteredList = new List<PatientViewModel>(); ;
            switch (cmFlater.Text)
            {
                case "patient ID":
                    {
                        if (int.TryParse(txtFilterVaaluse.Text, out int searchId))
                        {
                            filteredList = _Patients.Where(patient => patient.PatientId == searchId);

                        }
                        else
                        {
                            filteredList = new List<PatientViewModel>();
                        }


                        break;
                    }
                case "FullName":
                    {
                        filteredList = _Patients.Where(patient  => patient.fullname.ToLower().StartsWith(Searchtext));
                        break;
                    }
                case "Gender":
                    {

                        filteredList = _Patients.Where(patient => patient.Gender.ToLower().StartsWith(Searchtext));

                        break;
                    }
                       
                case "phone":

                    {
                        filteredList = _Patients.Where(patient => patient.phone.StartsWith(txtFilterVaaluse.Text));
                        break;
                    }

            }
            bindingSourcePatient.DataSource = filteredList;
            bindingSourcePatient.ResetBindings(false);
            lbRecorde.Text = dgPatientList.RowCount.ToString();
        }
    }
}
