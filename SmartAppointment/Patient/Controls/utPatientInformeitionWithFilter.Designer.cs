namespace SmartAppointment.Patient
{
    partial class utPatientInformeitionWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txAddNew = new Guna.UI2.WinForms.Guna2Button();
            this.buSearshPatient = new Guna.UI2.WinForms.Guna2Button();
            this.txNationalID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.usrtPatientDetails1 = new SmartAppointment.Patient.usrtPatientDetails();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.txAddNew);
            this.guna2GroupBox1.Controls.Add(this.buSearshPatient);
            this.guna2GroupBox1.Controls.Add(this.txNationalID);
            this.guna2GroupBox1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(621, 130);
            this.guna2GroupBox1.TabIndex = 1;
            this.guna2GroupBox1.Text = "Select Patient";
            // 
            // txAddNew
            // 
            this.txAddNew.BorderRadius = 10;
            this.txAddNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txAddNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txAddNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txAddNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txAddNew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txAddNew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txAddNew.ForeColor = System.Drawing.Color.White;
            this.txAddNew.Image = global::SmartAppointment.Properties.Resources.FindPatient;
            this.txAddNew.Location = new System.Drawing.Point(461, 66);
            this.txAddNew.Name = "txAddNew";
            this.txAddNew.Size = new System.Drawing.Size(85, 36);
            this.txAddNew.TabIndex = 3;
            this.txAddNew.Click += new System.EventHandler(this.txAddNew_Click);
            // 
            // buSearshPatient
            // 
            this.buSearshPatient.BorderRadius = 10;
            this.buSearshPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buSearshPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buSearshPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buSearshPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buSearshPatient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buSearshPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buSearshPatient.ForeColor = System.Drawing.Color.White;
            this.buSearshPatient.Image = global::SmartAppointment.Properties.Resources._326690_magnify_search_zoom_icon__1_;
            this.buSearshPatient.Location = new System.Drawing.Point(345, 66);
            this.buSearshPatient.Name = "buSearshPatient";
            this.buSearshPatient.Size = new System.Drawing.Size(86, 36);
            this.buSearshPatient.TabIndex = 2;
            this.buSearshPatient.Click += new System.EventHandler(this.buSearshPatient_Click);
            this.buSearshPatient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.buSearshPatient_KeyDown);
            // 
            // txNationalID
            // 
            this.txNationalID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txNationalID.DefaultText = "";
            this.txNationalID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txNationalID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txNationalID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txNationalID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txNationalID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txNationalID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txNationalID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txNationalID.Location = new System.Drawing.Point(94, 66);
            this.txNationalID.Name = "txNationalID";
            this.txNationalID.PlaceholderText = "";
            this.txNationalID.SelectedText = "";
            this.txNationalID.Size = new System.Drawing.Size(230, 36);
            this.txNationalID.TabIndex = 1;
            this.txNationalID.Validating += new System.ComponentModel.CancelEventHandler(this.txNationalID_Validating);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(19, 75);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(69, 18);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "National  ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // usrtPatientDetails1
            // 
            this.usrtPatientDetails1.Location = new System.Drawing.Point(3, 149);
            this.usrtPatientDetails1.Name = "usrtPatientDetails1";
            this.usrtPatientDetails1.Size = new System.Drawing.Size(625, 251);
            this.usrtPatientDetails1.TabIndex = 0;
            // 
            // utPatientInformeitionWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.usrtPatientDetails1);
            this.Name = "utPatientInformeitionWithFilter";
            this.Size = new System.Drawing.Size(628, 408);
            this.Load += new System.EventHandler(this.utPatientInformeitionWithFilter_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private usrtPatientDetails usrtPatientDetails1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2Button txAddNew;
        private Guna.UI2.WinForms.Guna2Button buSearshPatient;
        private Guna.UI2.WinForms.Guna2TextBox txNationalID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
