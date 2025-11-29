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
    public partial class urtDoctorList : UserControl
    {
        public urtDoctorList()
        {
            InitializeComponent();
        }
        List<DataDocter> datAllDocter = new List<DataDocter>();

        public void Clear()
        {
            bindingSourceDoctor.Clear();
        }
        public async void LodaDate()
        {

            datAllDocter = await DataDocter.GetAllDataDocter();
            bindingSourceDoctor.DataSource = datAllDocter;
            dvDocter.DataSource = bindingSourceDoctor;
            lbRecorde.Text = dvDocter.ColumnCount.ToString();
            cmFilter.SelectedIndex = 0;

            if (dvDocter.Rows.Count > 0)
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
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtFilterVaaluse.Text == "" ||cmFilter.Text == "None")
            {
                bindingSourceDoctor.DataSource = datAllDocter;
                return;
            }

            string Searchtext = txtFilterVaaluse.Text.ToLower();
            IEnumerable<DataDocter> filteredList = new List<DataDocter>(); ;
            switch (cmFilter.Text)
            {
                case "Doctor ID":
                    {
                        if(int.TryParse(txtFilterVaaluse.Text ,out int searchId))
                        {
                            filteredList = datAllDocter.Where(dcotor => dcotor.DocterID == searchId);

                        }
                        else
                        {
                            filteredList = new List<DataDocter>();
                        }


                        break;
                    }
                case "Full Name":
                    {
                        filteredList = datAllDocter.Where(dcotor => dcotor.Fullname.ToLower().StartsWith(Searchtext));

                        break;
                    }
                case "Specialty":
                    {
                        filteredList = datAllDocter.Where(dcotor => dcotor.Specialty.ToLower().StartsWith(Searchtext));

                        break;
                    }
                default:
                    {
                        filteredList = datAllDocter;    
                        break;
                    }
            }
            bindingSourceDoctor.DataSource = filteredList.ToList();
            bindingSourceDoctor.ResetBindings(false);
            lbRecorde.Text = dvDocter.RowCount.ToString();
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
        
       
        private async void urtDoctorList_Load(object sender, EventArgs e)
        {
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddorUpdate frmAdd = new frmAddorUpdate();
            frmAdd._DocterSelect += AddnewDoctor;
            frmAdd.ShowDialog();

        }

        private void AddOrUpdate(int Mode,DataDocter docter)
        {
            if (Mode == 0)
            {
                datAllDocter.Add(docter);
            }
            else
            {

                DataDocter olddoctor = datAllDocter.FirstOrDefault(doc => doc.DocterID == docter.DocterID);
                if (olddoctor != null)
                {
                    Databusiness.Mappers.AutoMapperConfigs.Mapper.Map(docter, olddoctor);
                    bindingSourceDoctor.ResetBindings(false);

                }

            }
        }

        private void AddnewDoctor(int Mode, DataDocter docter)
        {
            AddOrUpdate(Mode, docter);
        }

        private void editDocterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void updateDocterSelect(int Mode, DataDocter docter)
        {
             AddOrUpdate(Mode, docter);
        }

        private void showDetilesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsoEdit_Click(object sender, EventArgs e)
        {
            int Doctorid = (int)dvDocter.CurrentRow.Cells[0].Value;
            frmAddorUpdate frmAdd = new frmAddorUpdate(Doctorid);
            frmAdd._DocterSelect += updateDocterSelect; ;
            frmAdd.ShowDialog();
        }

        private void tosDelete_Click(object sender, EventArgs e)
        {
            var Docter = dvDocter.CurrentRow.DataBoundItem as DataDocter;
            if (MessageBox.Show("Are you you srue you wante to delete this Docter", "Confrim Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (DataDocter.Delete(Docter.DocterID))
                {
                    datAllDocter.RemoveAll(Do => Do.DocterID == Docter.DocterID);
                    bindingSourceDoctor.ResetBindings(false);
                    MessageBox.Show("Docter delete  successfully", "Delet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Error Not Deleted successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
