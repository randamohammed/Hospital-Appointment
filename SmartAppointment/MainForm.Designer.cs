namespace SmartAppointment
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabOpretions = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.taUesrmanagement = new System.Windows.Forms.TabPage();
            this.taDoctor = new System.Windows.Forms.TabPage();
            this.urtDoctorList1 = new SmartAppointment.Doctor.urtDoctorList();
            this.taPatient = new System.Windows.Forms.TabPage();
            this.urtPatienList1 = new SmartAppointment.Patient.urtPatienList();
            this.taAppoitement = new System.Windows.Forms.TabPage();
            this.taPayment = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.urctListUser1 = new SmartAppointment.User.urctListUser();
            this.TabOpretions.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.taUesrmanagement.SuspendLayout();
            this.taDoctor.SuspendLayout();
            this.taPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabOpretions
            // 
            this.TabOpretions.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabOpretions.Controls.Add(this.tabPage1);
            this.TabOpretions.Controls.Add(this.taUesrmanagement);
            this.TabOpretions.Controls.Add(this.taDoctor);
            this.TabOpretions.Controls.Add(this.taPatient);
            this.TabOpretions.Controls.Add(this.taAppoitement);
            this.TabOpretions.Controls.Add(this.taPayment);
            this.TabOpretions.ImageList = this.imageList1;
            this.TabOpretions.ItemSize = new System.Drawing.Size(310, 90);
            this.TabOpretions.Location = new System.Drawing.Point(1, 4);
            this.TabOpretions.Margin = new System.Windows.Forms.Padding(20);
            this.TabOpretions.Name = "TabOpretions";
            this.TabOpretions.Padding = new System.Drawing.Point(0, 20);
            this.TabOpretions.SelectedIndex = 0;
            this.TabOpretions.Size = new System.Drawing.Size(1243, 546);
            this.TabOpretions.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TabOpretions.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabOpretions.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabOpretions.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TabOpretions.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.TabOpretions.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TabOpretions.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabOpretions.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabOpretions.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.TabOpretions.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.TabOpretions.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TabOpretions.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TabOpretions.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.TabOpretions.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TabOpretions.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.TabOpretions.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.TabOpretions.TabButtonSize = new System.Drawing.Size(310, 90);
            this.TabOpretions.TabIndex = 0;
            this.TabOpretions.TabMenuBackColor = System.Drawing.Color.White;
            this.TabOpretions.SelectedIndexChanged += new System.EventHandler(this.TabOpretions_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.guna2PictureBox1);
            this.tabPage1.ImageKey = "dashboard.jpg";
            this.tabPage1.Location = new System.Drawing.Point(314, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(925, 538);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::SmartAppointment.Properties.Resources.hospital2;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(184, 6);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(555, 483);
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            // 
            // taUesrmanagement
            // 
            this.taUesrmanagement.Controls.Add(this.urctListUser1);
            this.taUesrmanagement.ImageKey = "users.png";
            this.taUesrmanagement.Location = new System.Drawing.Point(314, 4);
            this.taUesrmanagement.Name = "taUesrmanagement";
            this.taUesrmanagement.Padding = new System.Windows.Forms.Padding(3);
            this.taUesrmanagement.Size = new System.Drawing.Size(925, 538);
            this.taUesrmanagement.TabIndex = 1;
            this.taUesrmanagement.Text = "Uesr management";
            this.taUesrmanagement.UseVisualStyleBackColor = true;
            // 
            // taDoctor
            // 
            this.taDoctor.Controls.Add(this.urtDoctorList1);
            this.taDoctor.ImageKey = "doctor-removebg-preview.png";
            this.taDoctor.Location = new System.Drawing.Point(314, 4);
            this.taDoctor.Name = "taDoctor";
            this.taDoctor.Size = new System.Drawing.Size(925, 538);
            this.taDoctor.TabIndex = 2;
            this.taDoctor.Text = "Doctoer management";
            this.taDoctor.UseVisualStyleBackColor = true;
            // 
            // urtDoctorList1
            // 
            this.urtDoctorList1.Location = new System.Drawing.Point(3, 4);
            this.urtDoctorList1.Name = "urtDoctorList1";
            this.urtDoctorList1.Size = new System.Drawing.Size(917, 516);
            this.urtDoctorList1.TabIndex = 0;
            // 
            // taPatient
            // 
            this.taPatient.Controls.Add(this.urtPatienList1);
            this.taPatient.ImageKey = "examination.png";
            this.taPatient.Location = new System.Drawing.Point(314, 4);
            this.taPatient.Name = "taPatient";
            this.taPatient.Size = new System.Drawing.Size(925, 538);
            this.taPatient.TabIndex = 3;
            this.taPatient.Text = "Patien management";
            this.taPatient.UseVisualStyleBackColor = true;
            // 
            // urtPatienList1
            // 
            this.urtPatienList1.Location = new System.Drawing.Point(11, 15);
            this.urtPatienList1.Name = "urtPatienList1";
            this.urtPatienList1.Size = new System.Drawing.Size(899, 516);
            this.urtPatienList1.TabIndex = 0;
            // 
            // taAppoitement
            // 
            this.taAppoitement.ImageKey = "Appoitement.png";
            this.taAppoitement.Location = new System.Drawing.Point(314, 4);
            this.taAppoitement.Name = "taAppoitement";
            this.taAppoitement.Size = new System.Drawing.Size(925, 538);
            this.taAppoitement.TabIndex = 4;
            this.taAppoitement.Text = "Appoitement";
            this.taAppoitement.UseVisualStyleBackColor = true;
            // 
            // taPayment
            // 
            this.taPayment.ImageKey = "pay.png";
            this.taPayment.Location = new System.Drawing.Point(314, 4);
            this.taPayment.Name = "taPayment";
            this.taPayment.Size = new System.Drawing.Size(925, 538);
            this.taPayment.TabIndex = 5;
            this.taPayment.Text = "Payment";
            this.taPayment.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "delete.png");
            this.imageList1.Images.SetKeyName(1, "add.png");
            this.imageList1.Images.SetKeyName(2, "3453211.png");
            this.imageList1.Images.SetKeyName(3, "Appoitement.png");
            this.imageList1.Images.SetKeyName(4, "dashboard.jpg");
            this.imageList1.Images.SetKeyName(5, "pay.png");
            this.imageList1.Images.SetKeyName(6, "dashboard.jpg");
            this.imageList1.Images.SetKeyName(7, "doctor-removebg-preview.png");
            this.imageList1.Images.SetKeyName(8, "pay.png");
            this.imageList1.Images.SetKeyName(9, "users.png");
            this.imageList1.Images.SetKeyName(10, "pay.png");
            this.imageList1.Images.SetKeyName(11, "examination.png");
            // 
            // urctListUser1
            // 
            this.urctListUser1.Location = new System.Drawing.Point(6, 6);
            this.urctListUser1.Name = "urctListUser1";
            this.urctListUser1.Size = new System.Drawing.Size(842, 467);
            this.urctListUser1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 616);
            this.Controls.Add(this.TabOpretions);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabOpretions.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.taUesrmanagement.ResumeLayout(false);
            this.taDoctor.ResumeLayout(false);
            this.taPatient.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TabControl TabOpretions;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage taUesrmanagement;
        private System.Windows.Forms.TabPage taDoctor;
        private System.Windows.Forms.TabPage taPatient;
        private System.Windows.Forms.TabPage taAppoitement;
        private Doctor.urtDoctorList urtDoctorList1;
        private Patient.urtPatienList urtPatienList1;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage taPayment;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private User.urctListUser urctListUser1;
    }
}