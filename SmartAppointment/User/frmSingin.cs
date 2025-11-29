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

namespace SmartAppointment.User
{
    public partial class frmSingin : Form
    {
        public frmSingin()
        {
            InitializeComponent();
        }
        DataUser user;
        private void frmSingin_Load(object sender, EventArgs e)
        {

            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredentil(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassowrd.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;
        }

        private void buLogin_Click(object sender, EventArgs e)
        {

            user =  DataUser.CheackUser(txtUserName.Text,txtPassowrd.Text);
            if (user != null)
            {
                
                if (chkRememberMe.Checked)
                {
                    clsGlobal.RememberUsernameAndPassword(txtUserName.Text.Trim(), txtPassowrd.Text.Trim());
                }
                else
                {
                    clsGlobal.RememberUsernameAndPassword("", "");
                }

                clsGlobal.CurrentUser = user;
                this.Hide();
                MainForm form = new MainForm();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid Username or password", "your data is wron  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            clsGlobal.CurrentUser = DataUser.FindUserById(1); ;
            this.Hide();
            frmAddOrUpdeta frmAddOrUpdeta = new frmAddOrUpdeta();
            frmAddOrUpdeta.ShowDialog();
            this.Show();

        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
