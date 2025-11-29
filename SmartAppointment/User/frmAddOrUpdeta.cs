using AutoMapper;
using Databusiness;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SmartAppointment.User
{
    public partial class frmAddOrUpdeta : Form
    {
        public frmAddOrUpdeta()
        {
            InitializeComponent();
            _Mode = enMode._AddNew;
            
        }
        public frmAddOrUpdeta(int UserID)
        {
            InitializeComponent();
            _UserId =  UserID;
            _Mode = enMode._Update;
        }

        private enum enMode { _AddNew = 0, _Update =1}
        private int _UserId = 0;
        private enMode _Mode;
        DataUser _User = new DataUser();
        UserViewModel _UserViewModel = new UserViewModel();
        public delegate void UserSelectedHandler(int Mode , UserViewModel userView);

        public event UserSelectedHandler UserSelected;
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void frmAddOrUpdeta_Load(object sender, EventArgs e)
        {
                _ResetDefualtValues();
            if (_Mode == enMode._Update)
                _LoadData();
        }
        private void _LoadData()
        {
            _User = DataUser.FindUserById(_UserId,clsGlobal.CurrentUser.UserID);

            if (_User == null)
            {
                MessageBox.Show("لا يوجد مستخدم بالمعرف" + _UserId, "المستخدم غير موجود", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

            }

            lblUserid.Text = _UserId.ToString();
            txtPassword.Text = _User.Password;
            txtUserName.Text = _User.Username;


            if (_User.Role == "Admin")
            {
                RaAdmin.Checked = true;
            }
            else if(_User.Role == "Doctor")
            {

                RaDoctor.Checked = false;
            }
            else
            {
                RaReceptionist.Checked = false; 
            }
        }

        private void _ResetDefualtValues()
        {

            if (_Mode == enMode._AddNew)
            {
                lblTitl.Text = "Add User";
                this.Text = lblTitl.Text;
                _User = new DataUser();
            }
            else
            {
                lblTitl.Text = "Update User";
                this.Text = lblTitl.Text;
            }
            lblUserid.Text = "##";
            txtPassword.Text = "";
            txtUserName.Text = "";
            RaAdmin.Checked = false;
            RaDoctor.Checked = false;
            RaReceptionist .Checked = false;
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Username cannot be empty");
            }
            else
            {
                errorProvider1.SetError(txtUserName, null);
            }

            if (_Mode == enMode._AddNew)
            {
                if (DataUser.IsUserExist(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtUserName, "Username already in use");
                }
                else
                {
                    errorProvider1.SetError(txtUserName, null);
                }
            }
            else

            {
                if (_User.Username != txtUserName.Text.Trim())
                {
                    if (DataUser.IsUserExist(txtUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserName, "Username already in use");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserName, null);
                    }
                }
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password cannot be empty");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
        }

        void UserManagement()
        {
            if (RaAdmin.Checked)
                _User.Role = "Admin";
            else if (RaDoctor.Checked)
                _User.Role = "Doctor";
            else
                _User.Role = "Receptionist";
        }

        private void LodDataToUserViewModel()
        {             

            _UserViewModel = Databusiness.Mappers.AutoMapperConfigs.Mapper.Map<UserViewModel>(_User);
            UserSelected.Invoke((int)_Mode, _UserViewModel);
        }

        private void buSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fields are incorrect. Please hover your cursor over the red icon to view error details", "Verification error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _User.Username = txtUserName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            _User.currentUser  =  (clsGlobal.CurrentUser ==  null)  ? 1 : clsGlobal.CurrentUser.UserID;
            UserManagement();

            if (_User.Save())
            {
                lblUserid.Text = _User.UserID.ToString();

                lblTitl.Text = "Update User";
                this.Text = lblTitl.Text;
                LodDataToUserViewModel();

                _Mode = enMode._Update;

                MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: Data Not saved successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.TextAlign = HorizontalAlignment.Left;
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            txtUserName.TextAlign = HorizontalAlignment.Left;
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {

            txtPassword.TextAlign = HorizontalAlignment.Left;
        }
    }
}
