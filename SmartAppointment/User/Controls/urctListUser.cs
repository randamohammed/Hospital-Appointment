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
    public partial class urctListUser : UserControl
    {
        public urctListUser( )
        {
    
            InitializeComponent();
        }

        void _RefrshDefluteValuse()
        {
            cmFilter.SelectedIndex = 0;


        }
        List<UserViewModel> dtAllUser;

        private async void urctListUser_Load(object sender, EventArgs e)
        {
        }

        public void Clear()
        {
            bindingSourceUsers.Clear();
        }

       public async void Loda()
        {

            dtAllUser = await UserViewModel.GetAllUserInList();
            bindingSourceUsers.DataSource = dtAllUser;
            cmFilter.SelectedIndex = 0;
            dvUsers.DataSource = bindingSourceUsers;
            lbRecorde.Text = dvUsers.RowCount.ToString();

            if (dvUsers.Rows.Count > 0)
            {
                dvUsers.Columns[0].HeaderText = "User ID";
                dvUsers.Columns[0].Width = 120;

                dvUsers.Columns[1].HeaderText = "User name";
                dvUsers.Columns[1].Width = 320;

                dvUsers.Columns[2].HeaderText = "Role";
                dvUsers.Columns[2].Width = 200;


                dvUsers.Columns[3].HeaderText = "Phone";
                dvUsers.Columns[3].Width = 100;





            }
        }
        private void txtFilterVaaluse_TextChanged(object sender, EventArgs e)
        {

            List<UserViewModel> User = new List<UserViewModel>();
            if (string.IsNullOrWhiteSpace(txtFilterVaaluse.Text) || cmFilter.Text == "None")
            {
                bindingSourceUsers.DataSource = dtAllUser;
            }
            else
            {
                IEnumerable<UserViewModel> filteredList;
                string searchText = txtFilterVaaluse.Text.ToLower();

                switch (cmFilter.Text)
                {
                    case "User ID":
                        if (int.TryParse(txtFilterVaaluse.Text, out int searchID))
                        {
                            filteredList = dtAllUser.Where(u => u.UserID == searchID);
                        }
                        else
                        {
                            filteredList = new List<UserViewModel>(); 
                        }
                        break;

                    case "User Name":
                        filteredList = dtAllUser.Where(u => u.Username.ToLower().StartsWith(searchText));
                        break;

                    case "Role":
                        filteredList = dtAllUser.Where(u => u.Role.ToLower().StartsWith(searchText));
                        break;

                    default:
                        filteredList = dtAllUser;
                        break;
                }

                bindingSourceUsers.DataSource = filteredList.ToList();
            }

            bindingSourceUsers.ResetBindings(false);
            lbRecorde.Text = dvUsers.RowCount.ToString();
        
    }

        private void cmFilter_SelectedIndexChanged_1(object sender, EventArgs e)
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

       
        private void editUser_UserSelected(int Mode, UserViewModel userView)
        {
            EditDataInDataGraitview(Mode, userView);
        }

        private void addNewToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmAddOrUpdeta addOrUpdeta = new frmAddOrUpdeta();
            addOrUpdeta.ShowDialog();
            addOrUpdeta.UserSelected += addNewToolStripMenuItem;

        }

        private void addNewToolStripMenuItem(int Mode, UserViewModel userView)
        {
            EditDataInDataGraitview(Mode, userView); ;
        }

        private void txtFilterVaaluse_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (cmFilter.Text == "User Name")
                e.Handled = char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void butAddNewUser_Click(object sender, EventArgs e)
        {

            frmAddOrUpdeta addOrUpdeta = new frmAddOrUpdeta();
            addOrUpdeta.UserSelected += UserSelected;
            addOrUpdeta.ShowDialog();

        }

        private void EditDataInDataGraitview(int Mode, UserViewModel userView)
        {
            if (Mode == 0)
            {
                bindingSourceUsers.Add(userView);
            }
            else
            {
                var olduser = dtAllUser.Find(u => u.UserID == userView.UserID);
                if (olduser != null)
                {
                    Databusiness.Mappers.AutoMapperConfigs.Mapper.Map(userView, olduser);
                 


                }

            }
            bindingSourceUsers.ResetBindings(false);
        }

        private void UserSelected(int Mode, UserViewModel userView)
        {
            EditDataInDataGraitview(Mode, userView);
        }

     
        private void toooEditUser_Click(object sender, EventArgs e)
        {
            int UserId = (int)dvUsers.CurrentRow.Cells[0].Value;
            frmAddOrUpdeta addOrUpdeta = new frmAddOrUpdeta(UserId);
            addOrUpdeta.UserSelected += editUser_UserSelected;
            addOrUpdeta.ShowDialog();
        }

        private void tooDelete_Click(object sender, EventArgs e)
        {
            UserViewModel User = dvUsers.CurrentRow.DataBoundItem as UserViewModel;
            if (MessageBox.Show("Are you you srue you wante to delete this User", "Confrim Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (User.UserID == clsGlobal.CurrentUser.UserID)
                {
                    MessageBox.Show("you cont not delete this user it's already used", "Delet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (DataUser.DeleteUser(User.UserID, clsGlobal.CurrentUser.UserID))
                {
                    dtAllUser.RemoveAll(U => U.UserID == User.UserID);
                    MessageBox.Show("User delete  successfully", "Delet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bindingSourceUsers.ResetBindings(false);
                }
            }
        }
    }
}
