using SmartAppointment.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartAppointment
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void urctListUser1_Click(object sender, EventArgs e)
        {
            //urctListUser1.Loda();
           
        }

        private int _lastSelectedIndex = -1;
        private void TabOpretions_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (_lastSelectedIndex == -1)
            {
                
                _lastSelectedIndex = 0;
                //return;
            }
           else
            {
                _lastSelectedIndex = TabOpretions.SelectedIndex - 1;
            }

            var oldTab = TabOpretions.TabPages[_lastSelectedIndex];

            if (oldTab == taUesrmanagement)
            {
                  urctListUser1.Clear(); 
            }
            else if (oldTab == taPatient)
            {
                urtPatienList1.Clear();
            }
            else if (oldTab == taDoctor)
            {
                urtDoctorList1.Clear();
            }
            //else if (TabOpretions.SelectedTab == taPayment)
            //{

            //}
            //if (TabOpretions.SelectedTab == taAppoitement)
            //{
            //}

            var currentTab = TabOpretions.SelectedTab;
            if (currentTab == taUesrmanagement)
            {
               urctListUser1.Loda();
            }
            else if (currentTab == taPatient)
            {
                urtPatienList1.LodData();
            }
            else if (currentTab == taDoctor)
            {
                urtDoctorList1.LodaDate();
            }
        }
    }
}
