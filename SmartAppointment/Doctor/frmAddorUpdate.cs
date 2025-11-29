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

namespace SmartAppointment.Doctor
{
    public partial class frmAddorUpdate : Form
    {
        public frmAddorUpdate()
        {
            InitializeComponent();
            _Mode = Mode.AddNew;
        }

        public frmAddorUpdate(int DocterId )
        {
            InitializeComponent();
            _Mode = Mode.UpdateNew;
            _DocterId = DocterId;
        }
        int _DocterId = 0;
        enum Mode { AddNew = 0, UpdateNew = 1 }
        Mode _Mode = Mode.AddNew;

        DataDocter _dataDocter;
        public delegate void OnDoctorSelect(int Mode, DataDocter docter);
        public event OnDoctorSelect _DocterSelect;

        void RefreshData()
        {
            lbDocterID.Text = "##";
            lbTitel.Text = "Add New Docter";
            txtDoctername.Text = "";
            txtEmil.Text = "";
            txtPhone.Text = "";
            txtSpecialty.Text = "";
            _dataDocter = new DataDocter();
        }

        void LodaData()
        {
            _dataDocter = DataDocter.FindDocterById( _DocterId );

            if (_dataDocter != null )
            {
                lbDocterID.Text = _dataDocter.DocterID.ToString();
                txtDoctername.Text = _dataDocter.Fullname;
                txtEmil.Text = _dataDocter.Email;
                txtPhone.Text = _dataDocter.phone;  
                txtSpecialty.Text = _dataDocter.Specialty.ToString();

                lbTitel.Text = "Uupdate Docter";

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAddorUpdate_Load(object sender, EventArgs e)
        {
            RefreshData();

            if (_Mode == Mode.UpdateNew)
            {
                LodaData();
            }
        }

        private void buSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are invalid. Please hover over the red icon to view error details.",
                    " Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _dataDocter.DocterID = _DocterId;
            _dataDocter.Email = txtEmil.Text;
            _dataDocter.Fullname = txtDoctername.Text;
            _dataDocter.phone = txtPhone.Text;
            _dataDocter.Specialty    = txtSpecialty.Text;

            if(_dataDocter.Save())
            {
                _DocterId = _dataDocter.DocterID;
                _DocterSelect.Invoke((int)_Mode, _dataDocter);

                _Mode = Mode.UpdateNew;
                lbTitel.Text = "Uupdate Docter";
                lbDocterID.Text =  _DocterId.ToString();
                MessageBox.Show("Data saved successfully","Saved",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data Not saved successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDoctername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDoctername.Text) || clsVildation.ISNumber(txtDoctername.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDoctername, "Invalid Username cannot be empty Or Number");
            }
            else
            {
                errorProvider1.SetError(txtDoctername, null);
            }

        }

        private void txtEmil_Validating(object sender, CancelEventArgs e)
        {
            if (!clsVildation.ValidateEmail(txtEmil.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmil, "Emil cannot be empty");
            }
            else
            {
                errorProvider1.SetError(txtEmil, null);
            }
        }

        private void txtDoctername_Validating_1(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtDoctername.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDoctername, "Invalid Username cannot be empty Or Number");
            }
            else
            {
                errorProvider1.SetError(txtDoctername, null);
            }
        }

        private void buClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
