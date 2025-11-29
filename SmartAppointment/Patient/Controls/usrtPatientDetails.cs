using Databusiness;
using SmartAppointment.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace SmartAppointment.Patient
{
    public partial class usrtPatientDetails : UserControl
    {
        public usrtPatientDetails()
        {
            InitializeComponent();
        }

        public delegate void PatientSelectedHandler(int PatientId);
        public event PatientSelectedHandler PatientSelected;
        DataPaitent _dataPaitent = new DataPaitent();
        private void usrtPatientDetails_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            lbNumber.Text = "N/Y";
            lbFullName.Text ="??";
            lbAddress.Text = "??";
            lbNationalID.Text = "??";
            lbEmail.Text = "??";
            lbNots.Text = "??";
            lbPhone.Text = "??";
            lbDataBbarth.Text = "dd/MMM/yyy";
            lbGender.Text = "??";
        }

        
        private void LodData()
        {

            lbNumber.Text = _dataPaitent.PatientId.ToString();
            lbFullName.Text = _dataPaitent.fullname;
            lbAddress.Text = _dataPaitent.Address;
            lbNationalID.Text = _dataPaitent.NationalID;
            lbEmail.Text = _dataPaitent.Email;
            lbNots.Text = _dataPaitent.Notes;
            lbPhone.Text = _dataPaitent.phone;
            lbDataBbarth.Text = ClsFormat.FormatDate(_dataPaitent.DateOfBarth);
            lbGender.Text = _dataPaitent.Gender == 0 ? "Female" : "Male";
            PatientSelected.Invoke(_dataPaitent.PatientId);
        }

        public void LodDataByPatientId(int PatientId)
        {
            _dataPaitent = DataPaitent.FindPaitentByID(PatientId);

            if (_dataPaitent != null)
                LodData();
            else
                RefreshData();
        }

        public void LodDataByNationalID(string NationalID)
        {
             _dataPaitent = DataPaitent.FindPatientByNationalID(NationalID);

            if (_dataPaitent != null)
                LodData();
            else
                RefreshData();
        }

        private void GroupBox_Click(object sender, EventArgs e)
        {

        }
    }
}
