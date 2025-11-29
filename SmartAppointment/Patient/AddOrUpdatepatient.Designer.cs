namespace SmartAppointment.Patient
{
    partial class AddOrUpdatepatient
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
            this.butSave = new Guna.UI2.WinForms.Guna2Button();
            this.butClose = new Guna.UI2.WinForms.Guna2Button();
            this.uctrAddOrUpdatePatient1 = new SmartAppointment.Patient.Controls.uctrAddOrUpdatePatient();
            this.SuspendLayout();
            // 
            // butSave
            // 
            this.butSave.BorderRadius = 10;
            this.butSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.butSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSave.ForeColor = System.Drawing.Color.White;
            this.butSave.Location = new System.Drawing.Point(535, 258);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(100, 38);
            this.butSave.TabIndex = 1;
            this.butSave.Text = "Save";
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butClose
            // 
            this.butClose.BorderRadius = 10;
            this.butClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.butClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butClose.ForeColor = System.Drawing.Color.White;
            this.butClose.Location = new System.Drawing.Point(387, 258);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(100, 38);
            this.butClose.TabIndex = 3;
            this.butClose.Text = "Close";
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // uctrAddOrUpdatePatient1
            // 
            this.uctrAddOrUpdatePatient1.Location = new System.Drawing.Point(13, 12);
            this.uctrAddOrUpdatePatient1.Name = "uctrAddOrUpdatePatient1";
            this.uctrAddOrUpdatePatient1.Size = new System.Drawing.Size(622, 242);
            this.uctrAddOrUpdatePatient1.TabIndex = 4;
            // 
            // AddOrUpdatepatient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 343);
            this.Controls.Add(this.uctrAddOrUpdatePatient1);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrUpdatepatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrUpdatepatient";
            this.Load += new System.EventHandler(this.AddOrUpdatepatient_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button butSave;
        private Guna.UI2.WinForms.Guna2Button butClose;
        private Controls.uctrAddOrUpdatePatient uctrAddOrUpdatePatient1;
    }
}