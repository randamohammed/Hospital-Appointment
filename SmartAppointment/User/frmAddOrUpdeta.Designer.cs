namespace SmartAppointment.User
{
    partial class frmAddOrUpdeta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitl = new System.Windows.Forms.Label();
            this.buSave = new Guna.UI2.WinForms.Guna2Button();
            this.RaAdmin = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.RaReceptionist = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RaDoctor = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUserid = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.butClose = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitl
            // 
            this.lblTitl.AutoSize = true;
            this.lblTitl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitl.Location = new System.Drawing.Point(137, 20);
            this.lblTitl.Name = "lblTitl";
            this.lblTitl.Size = new System.Drawing.Size(84, 20);
            this.lblTitl.TabIndex = 0;
            this.lblTitl.Text = "Add User";
            // 
            // buSave
            // 
            this.buSave.BackColor = System.Drawing.Color.Transparent;
            this.buSave.BorderRadius = 10;
            this.buSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buSave.ForeColor = System.Drawing.Color.Black;
            this.buSave.Location = new System.Drawing.Point(198, 424);
            this.buSave.Name = "buSave";
            this.buSave.Size = new System.Drawing.Size(103, 44);
            this.buSave.TabIndex = 2;
            this.buSave.Text = "Save";
            this.buSave.Click += new System.EventHandler(this.buSave_Click);
            // 
            // RaAdmin
            // 
            this.RaAdmin.AutoSize = true;
            this.RaAdmin.BackColor = System.Drawing.Color.White;
            this.RaAdmin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RaAdmin.CheckedState.BorderThickness = 0;
            this.RaAdmin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RaAdmin.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RaAdmin.CheckedState.InnerOffset = -4;
            this.RaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaAdmin.Location = new System.Drawing.Point(22, 53);
            this.RaAdmin.Name = "RaAdmin";
            this.RaAdmin.Size = new System.Drawing.Size(72, 24);
            this.RaAdmin.TabIndex = 3;
            this.RaAdmin.Text = "Admin";
            this.RaAdmin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RaAdmin.UncheckedState.BorderThickness = 2;
            this.RaAdmin.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RaAdmin.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RaAdmin.UseVisualStyleBackColor = false;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderRadius = 3;
            this.guna2GroupBox1.Controls.Add(this.RaReceptionist);
            this.guna2GroupBox1.Controls.Add(this.RaDoctor);
            this.guna2GroupBox1.Controls.Add(this.RaAdmin);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(14, 222);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(331, 169);
            this.guna2GroupBox1.TabIndex = 5;
            this.guna2GroupBox1.Text = "Role :";
            // 
            // RaReceptionist
            // 
            this.RaReceptionist.AutoSize = true;
            this.RaReceptionist.BackColor = System.Drawing.Color.White;
            this.RaReceptionist.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RaReceptionist.CheckedState.BorderThickness = 0;
            this.RaReceptionist.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RaReceptionist.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RaReceptionist.CheckedState.InnerOffset = -4;
            this.RaReceptionist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaReceptionist.Location = new System.Drawing.Point(22, 91);
            this.RaReceptionist.Name = "RaReceptionist";
            this.RaReceptionist.Size = new System.Drawing.Size(116, 24);
            this.RaReceptionist.TabIndex = 5;
            this.RaReceptionist.Text = "Receptionist";
            this.RaReceptionist.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RaReceptionist.UncheckedState.BorderThickness = 2;
            this.RaReceptionist.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RaReceptionist.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RaReceptionist.UseVisualStyleBackColor = false;
            // 
            // RaDoctor
            // 
            this.RaDoctor.AutoSize = true;
            this.RaDoctor.BackColor = System.Drawing.Color.White;
            this.RaDoctor.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RaDoctor.CheckedState.BorderThickness = 0;
            this.RaDoctor.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RaDoctor.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RaDoctor.CheckedState.InnerOffset = -4;
            this.RaDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaDoctor.Location = new System.Drawing.Point(22, 129);
            this.RaDoctor.Name = "RaDoctor";
            this.RaDoctor.Size = new System.Drawing.Size(75, 24);
            this.RaDoctor.TabIndex = 4;
            this.RaDoctor.Text = "Doctor";
            this.RaDoctor.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RaDoctor.UncheckedState.BorderThickness = 2;
            this.RaDoctor.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RaDoctor.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RaDoctor.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "User Id:";
            // 
            // lblUserid
            // 
            this.lblUserid.AutoSize = true;
            this.lblUserid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserid.Location = new System.Drawing.Point(87, 79);
            this.lblUserid.Name = "lblUserid";
            this.lblUserid.Size = new System.Drawing.Size(42, 24);
            this.lblUserid.TabIndex = 7;
            this.lblUserid.Text = "N/A";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // butClose
            // 
            this.butClose.BackColor = System.Drawing.Color.Transparent;
            this.butClose.BorderRadius = 10;
            this.butClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.butClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.butClose.ForeColor = System.Drawing.Color.Black;
            this.butClose.Location = new System.Drawing.Point(14, 424);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(103, 44);
            this.butClose.TabIndex = 9;
            this.butClose.Text = "Close";
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.IconLeft = global::SmartAppointment.Properties.Resources.Password;
            this.txtPassword.Location = new System.Drawing.Point(14, 163);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '.';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(331, 38);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPassword_MouseClick);
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtUserName
            // 
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.IconLeft = global::SmartAppointment.Properties.Resources.Name;
            this.txtUserName.Location = new System.Drawing.Point(14, 114);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtUserName.PlaceholderText = "Username";
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(331, 41);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // frmAddOrUpdeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(368, 493);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.lblUserid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.buSave);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblTitl);
            this.Name = "frmAddOrUpdeta";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddOrUpdeta";
            this.Load += new System.EventHandler(this.frmAddOrUpdeta_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitl;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2Button buSave;
        private Guna.UI2.WinForms.Guna2RadioButton RaAdmin;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2RadioButton RaReceptionist;
        private Guna.UI2.WinForms.Guna2RadioButton RaDoctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUserid;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button butClose;
    }
}