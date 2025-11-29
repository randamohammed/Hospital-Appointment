namespace SmartAppointment.User
{
    partial class frmSingin
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
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.buLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassowrd = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtUserName.Location = new System.Drawing.Point(79, 119);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUserName.PlaceholderText = "Username";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(327, 34);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.BackColor = System.Drawing.Color.White;
            this.chkRememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.chkRememberMe.Location = new System.Drawing.Point(55, 232);
            this.chkRememberMe.Margin = new System.Windows.Forms.Padding(2);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkRememberMe.Size = new System.Drawing.Size(121, 22);
            this.chkRememberMe.TabIndex = 2;
            this.chkRememberMe.Text = "Remander Me";
            this.chkRememberMe.UseVisualStyleBackColor = false;
            // 
            // buLogin
            // 
            this.buLogin.BackColor = System.Drawing.Color.Transparent;
            this.buLogin.BorderRadius = 10;
            this.buLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buLogin.Font = new System.Drawing.Font("Arial", 16.25F, System.Drawing.FontStyle.Bold);
            this.buLogin.ForeColor = System.Drawing.Color.White;
            this.buLogin.Location = new System.Drawing.Point(79, 291);
            this.buLogin.Margin = new System.Windows.Forms.Padding(2);
            this.buLogin.Name = "buLogin";
            this.buLogin.Size = new System.Drawing.Size(291, 36);
            this.buLogin.TabIndex = 3;
            this.buLogin.Text = "Log in";
            this.buLogin.Click += new System.EventHandler(this.buLogin_Click);
            // 
            // txtPassowrd
            // 
            this.txtPassowrd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassowrd.DefaultText = "";
            this.txtPassowrd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassowrd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassowrd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassowrd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassowrd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassowrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtPassowrd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassowrd.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtPassowrd.Location = new System.Drawing.Point(79, 180);
            this.txtPassowrd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassowrd.Name = "txtPassowrd";
            this.txtPassowrd.PasswordChar = '*';
            this.txtPassowrd.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassowrd.PlaceholderText = "Password";
            this.txtPassowrd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassowrd.SelectedText = "";
            this.txtPassowrd.Size = new System.Drawing.Size(327, 34);
            this.txtPassowrd.TabIndex = 1;
            this.txtPassowrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.LinkColor = System.Drawing.Color.RoyalBlue;
            this.linkLabel1.Location = new System.Drawing.Point(145, 341);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(179, 22);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Create an account";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(163, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hostpital Management";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::SmartAppointment.Properties.Resources.hospital2;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, -3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(489, 483);
            this.guna2PictureBox1.TabIndex = 7;
            this.guna2PictureBox1.TabStop = false;
            // 
            // frmSingin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkRememberMe);
            this.Controls.Add(this.buLogin);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtPassowrd);
            this.Controls.Add(this.guna2PictureBox1);
            this.Name = "frmSingin";
            this.Text = "Singin";
            this.Load += new System.EventHandler(this.frmSingin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkRememberMe;
        private Guna.UI2.WinForms.Guna2Button buLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtPassowrd;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}