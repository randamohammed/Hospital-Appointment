namespace SmartAppointment.Patient
{
    partial class frmPatientDetails
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
            this.butclose = new Guna.UI2.WinForms.Guna2Button();
            this.usrtPatientDetails1 = new SmartAppointment.Patient.usrtPatientDetails();
            this.SuspendLayout();
            // 
            // butclose
            // 
            this.butclose.BorderRadius = 10;
            this.butclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butclose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.butclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butclose.ForeColor = System.Drawing.Color.White;
            this.butclose.Location = new System.Drawing.Point(522, 254);
            this.butclose.Name = "butclose";
            this.butclose.Size = new System.Drawing.Size(100, 38);
            this.butclose.TabIndex = 2;
            this.butclose.Text = "close";
            this.butclose.Click += new System.EventHandler(this.butclose_Click);
            // 
            // usrtPatientDetails1
            // 
            this.usrtPatientDetails1.Location = new System.Drawing.Point(6, -1);
            this.usrtPatientDetails1.Name = "usrtPatientDetails1";
            this.usrtPatientDetails1.Size = new System.Drawing.Size(621, 251);
            this.usrtPatientDetails1.TabIndex = 3;
            // 
            // frmPatientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 302);
            this.Controls.Add(this.usrtPatientDetails1);
            this.Controls.Add(this.butclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPatientDetails";
            this.ShowInTaskbar = false;
            this.Text = "Patient Details";
            this.Load += new System.EventHandler(this.frmPatientDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button butclose;
        private usrtPatientDetails usrtPatientDetails1;
    }
}