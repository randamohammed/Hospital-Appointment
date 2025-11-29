using Databusiness;
using SmartAppointment.Doctor;
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
    public partial class frmPatientlist : Form
    {
        public frmPatientlist()
        {
            InitializeComponent();
        }
        int PageNumber =1;
        int pageSize;
        int PatientId = 0;
        DataTable _SemPatient;
        private void frmPatientlist_Load(object sender, EventArgs e)
        {
            cmPageSize.SelectedIndex = 0;
            
            pageSize =Convert.ToInt32(cmPageSize.Text);
            _SemPatient = DataPaitent.GetPatientsPaginated(PageNumber, pageSize);

            dgPatientList.DataSource = _SemPatient;
            lbRecorde.Text = dgPatientList.Rows.Count.ToString();
            cmFlater.SelectedIndex = 0;

            if (dgPatientList.Rows.Count > 0)
            {
                dgPatientList.Columns[0].HeaderText = "PatientID";
                dgPatientList.Columns[0].Width = 100;

                dgPatientList.Columns[1].HeaderText = "FullName";
                dgPatientList.Columns[1].Width = 200;

                dgPatientList.Columns[2].HeaderText = "Phone";
                dgPatientList.Columns[2].Width =90;

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

        private void cmPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            PageNumber = 1;
            frmPatientlist_Load(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butAddNewPatient_Click(object sender, EventArgs e)
        {
            AddOrUpdatepatient addpatient = new AddOrUpdatepatient();
            addpatient.ShowDialog();

        }

        private void butPrevious_Click_1(object sender, EventArgs e)
        {
            if (PageNumber == 1) return;
            PageNumber -= 1;
            frmPatientlist_Load(null, null);
        }

        private void butNext_Click_1(object sender, EventArgs e)
        {

            PageNumber += 1;
            frmPatientlist_Load(null, null);
        }

        private void tsoShowPatientDetailes_Click(object sender, EventArgs e)
        {
            PatientId =(int) dgPatientList.CurrentRow.Cells[0].Value;
            frmPatientDetails patientDetails = new frmPatientDetails(PatientId);
            patientDetails.ShowDialog();
        }

        private void tosDelete_Click(object sender, EventArgs e)
        {
            PatientId = (int)dgPatientList.CurrentRow.Cells[0].Value;
           if(DataPaitent.DeletePatient(PatientId))
            {
                MessageBox.Show("Deleted successfully", "Deleted",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else
                MessageBox.Show("Error Not Deleted successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tsoEdit_Click(object sender, EventArgs e)
        {
            PatientId = (int)dgPatientList.CurrentRow.Cells[0].Value;
            AddOrUpdatepatient frmEdit =  new AddOrUpdatepatient(PatientId);
            frmEdit.ShowDialog();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmFlater_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
