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
    public partial class frmLisstDopcter : Form
    {
        public frmLisstDopcter()
        {
            InitializeComponent();
        }

     
        List<DataDocter> datAllDocter;
        private async void frmLisstDopcter_Load(object sender, EventArgs e)
        {
            datAllDocter =  await DataDocter.GetAllDataDocter();
            dvDocter.DataSource = datAllDocter;
            lbRecorde.Text = dvDocter.ColumnCount.ToString();
            cmFilter.SelectedIndex = 0;

            if(dvDocter.Rows.Count > 0 )
            {
                dvDocter.Columns[0].HeaderText = "DoctorID";
                dvDocter.Columns[0].Width = 120;
               
                dvDocter.Columns[1].HeaderText = "FullName";
                dvDocter.Columns[1].Width = 320;
               
                dvDocter.Columns[2].HeaderText = "Specialty";
                dvDocter.Columns[2].Width = 200;
               
                dvDocter.Columns[3].HeaderText = "Phone";
                dvDocter.Columns[3].Width = 100;


                dvDocter.Columns[4].HeaderText = "Email";
                dvDocter.Columns[4].Width = 100;


            }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmFilter.Text == "None")
            {
                txtFilterVaaluse.Text = "";
                txtFilterVaaluse.Visible = false;

                return;
            }

            txtFilterVaaluse.Visible = true;

            txtFilterVaaluse.Focus();
        }

        private void txtFilterVaaluse_TextChanged(object sender, EventArgs e)
        {

            string CoulmnsFilter = "";
            switch (cmFilter.Text)
            {
                case "Doctor ID":
                    CoulmnsFilter = "DoctorID";
                    break;
                case "Full Name":
                    CoulmnsFilter = "FullName";
                    break;
                case "Specialty":
                    CoulmnsFilter = "Specialty";
                    break;
                default:
                    CoulmnsFilter = "None";
                    break;
            }

            if (CoulmnsFilter == "None" || txtFilterVaaluse.Text == "")
            {
               // datAllDocter.DefaultView.RowFilter = "";

                return;
            }

            if (CoulmnsFilter == "Doctor ID")
            {
               // datAllDocter.DefaultView.RowFilter = string.Format("[{0}] ={1}", CoulmnsFilter, txtFilterVaaluse.Text);
            }
            else
              //  datAllDocter.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", CoulmnsFilter, txtFilterVaaluse.Text);
            lbRecorde.Text = dvDocter.RowCount.ToString();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DocterId = (int)dvDocter.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you you srue you wante to delete this Docter", "Confrim Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DataDocter.Delete(DocterId))
                {
                    MessageBox.Show("Docter delete  successfully", "Delet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmLisstDopcter_Load(null, null);
                }
            }
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddorUpdate frmAddor = new frmAddorUpdate();
            frmAddor.ShowDialog();
            this.Show();
        }

        private void editDocterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            int DocterId = (int)dvDocter.CurrentRow.Cells[0].Value;
            frmAddorUpdate frmAddor = new frmAddorUpdate(DocterId);
            frmAddor.ShowDialog();
            this.Show();
        }
    }
}
