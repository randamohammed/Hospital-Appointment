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
    public partial class uctrAddOrUpdatePatient : UserControl
    {

        DataPaitent _dataPaitent = new DataPaitent();
        private enum enMode { _AddNew = 0, _Update = 1 }
        enMode _Mode = enMode._AddNew;
        public uctrAddOrUpdatePatient()
        {
            InitializeComponent();
        }

        public int PatientId = 0;
        private void uctrAddOrUpdatePatient_Load(object sender, EventArgs e)
        {
            rbFemale.Checked = true;
            _Mode = enMode._AddNew;
        }

        public delegate void PatientSelectedHandler(PatientViewModel patientView, int Mode);
        public  event PatientSelectedHandler PatientSelected;
        PatientViewModel PatientView = new PatientViewModel();

        private void SelectAddOrupdate()
        {
            decimal Blance =0;
            DateTime RegistrationDate = DateTime.Now;
            if (_Mode == enMode._AddNew)
            {
                Blance = 0;
               RegistrationDate = _dataPaitent.RegistrationDate;
            }
            else
            {
                DataPaitent.GetPatientSummary(ref Blance,ref RegistrationDate,_dataPaitent.PatientId);
            }
            PatientView.PatientId = _dataPaitent.PatientId;
            PatientView.phone = _dataPaitent.phone;
            PatientView.fullname = _dataPaitent.fullname;
            PatientView.DateOfBarth = _dataPaitent.DateOfBarth;
            PatientView.Gender = _dataPaitent.Gender == 0 ? "Male" : "Female";
            PatientView.Blance = Blance;
            PatientView.RegistrationDate = RegistrationDate;


            PatientSelected.Invoke(PatientView, (int)_Mode);
        }
        public void SavDate()
        {
            if(!ValidateChildren())
            {
                MessageBox.Show("there Same Things with red Icon(s) is worng");
                return;
            }
            _dataPaitent.fullname = txbFullName.Text;
            _dataPaitent.Email = txtEmail.Text;
            _dataPaitent.Address = txbAddress.Text;
            _dataPaitent.DateOfBarth = dtpBarthDay.Value;
            _dataPaitent.phone = txtPhone.Text;
            _dataPaitent.NationalID = txbNationalID.Text;
            _dataPaitent.Gender = rbFemale.Checked ? Convert.ToSByte(0) : Convert.ToSByte(1);
            _dataPaitent.PatientId = PatientId;
            _dataPaitent.Notes = txtNots.Text;

            if (_dataPaitent.Save())
            {
                PatientId = _dataPaitent.PatientId;
                lbNumber.Text = _dataPaitent.PatientId.ToString();

                SelectAddOrupdate();
                _Mode = enMode._Update;
            }

        }

        public void LodData(int PatientId)
        {
             _Mode = enMode._Update;
            _dataPaitent = DataPaitent.FindPaitentByID(PatientId);

            if (_dataPaitent != null)
            {
                txbFullName.Text = _dataPaitent.fullname;
                txbAddress.Text = _dataPaitent.Address;
                txbNationalID.Text = _dataPaitent.NationalID;
                txtEmail.Text = _dataPaitent.Email;
                txtNots.Text = _dataPaitent.Notes;
                txtPhone.Text = _dataPaitent.phone;
                dtpBarthDay.Value = _dataPaitent.DateOfBarth;

                if (_dataPaitent.Gender == 0)
                {
                    rbFemale.Checked = true;
                }
                else
                {
                    rbMale.Checked = true;
                }
            }
        }

        private void txbAddress_Validating(object sender, CancelEventArgs e)
        {
            if (txbAddress.Text == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(txbAddress, "The address must not be empty to communicate");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txbAddress, "");
            }
        }

        private void txbNationalID_Validating(object sender, CancelEventArgs e)
        {
            if (_dataPaitent.ISPatienExistByNationalID(txbNationalID.Text))
            {

                e.Cancel = true;
                errorProvider1.SetError(txbNationalID, "National ID already used");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txbNationalID   , "");
            }

            if (txbNationalID.Text =="")
            {

                e.Cancel = true;
                errorProvider1.SetError(txbNationalID, "National ID must not be empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txbNationalID, "");
            }
        }

        private void GroupBox_Click(object sender, EventArgs e)
        {

        }
    }
}

