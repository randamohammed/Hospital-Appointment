namespace SmartAppointment.Doctor
{
    partial class frmAddorUpdate
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
            this.lbTitel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDocterID = new System.Windows.Forms.Label();
            this.buClose = new Guna.UI2.WinForms.Guna2Button();
            this.buSave = new Guna.UI2.WinForms.Guna2Button();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmil = new System.Windows.Forms.TextBox();
            this.txtDoctername = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitel
            // 
            this.lbTitel.AutoSize = true;
            this.lbTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitel.ForeColor = System.Drawing.Color.Black;
            this.lbTitel.Location = new System.Drawing.Point(157, 21);
            this.lbTitel.Name = "lbTitel";
            this.lbTitel.Size = new System.Drawing.Size(100, 20);
            this.lbTitel.TabIndex = 0;
            this.lbTitel.Text = "Add Docter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Docter Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Specialty";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Emil:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "DocterId:";
            // 
            // lbDocterID
            // 
            this.lbDocterID.AutoSize = true;
            this.lbDocterID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDocterID.Location = new System.Drawing.Point(97, 52);
            this.lbDocterID.Name = "lbDocterID";
            this.lbDocterID.Size = new System.Drawing.Size(21, 16);
            this.lbDocterID.TabIndex = 6;
            this.lbDocterID.Text = "##";
            // 
            // buClose
            // 
            this.buClose.BorderRadius = 10;
            this.buClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buClose.ForeColor = System.Drawing.Color.Black;
            this.buClose.Location = new System.Drawing.Point(26, 368);
            this.buClose.Name = "buClose";
            this.buClose.Size = new System.Drawing.Size(110, 45);
            this.buClose.TabIndex = 7;
            this.buClose.Text = "Close";
            this.buClose.Click += new System.EventHandler(this.buClose_Click);
            // 
            // buSave
            // 
            this.buSave.BorderRadius = 10;
            this.buSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buSave.ForeColor = System.Drawing.Color.Black;
            this.buSave.Location = new System.Drawing.Point(285, 368);
            this.buSave.Name = "buSave";
            this.buSave.Size = new System.Drawing.Size(122, 45);
            this.buSave.TabIndex = 8;
            this.buSave.Text = "Save";
            this.buSave.Click += new System.EventHandler(this.buSave_Click);
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialty.Location = new System.Drawing.Point(27, 169);
            this.txtSpecialty.Multiline = true;
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Size = new System.Drawing.Size(285, 35);
            this.txtSpecialty.TabIndex = 10;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(26, 236);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(285, 35);
            this.txtPhone.TabIndex = 11;
            // 
            // txtEmil
            // 
            this.txtEmil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmil.Location = new System.Drawing.Point(26, 308);
            this.txtEmil.Multiline = true;
            this.txtEmil.Name = "txtEmil";
            this.txtEmil.Size = new System.Drawing.Size(285, 35);
            this.txtEmil.TabIndex = 12;
            this.txtEmil.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmil_Validating);
            // 
            // txtDoctername
            // 
            this.txtDoctername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctername.Location = new System.Drawing.Point(26, 100);
            this.txtDoctername.Multiline = true;
            this.txtDoctername.Name = "txtDoctername";
            this.txtDoctername.Size = new System.Drawing.Size(285, 35);
            this.txtDoctername.TabIndex = 9;
            this.txtDoctername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtDoctername.Validating += new System.ComponentModel.CancelEventHandler(this.txtDoctername_Validating_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddorUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 425);
            this.Controls.Add(this.txtEmil);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtSpecialty);
            this.Controls.Add(this.txtDoctername);
            this.Controls.Add(this.buSave);
            this.Controls.Add(this.buClose);
            this.Controls.Add(this.lbDocterID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTitel);
            this.Name = "frmAddorUpdate";
            this.Text = "frmAddorUpdate";
            this.Load += new System.EventHandler(this.frmAddorUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDocterID;
        private Guna.UI2.WinForms.Guna2Button buClose;
        private Guna.UI2.WinForms.Guna2Button buSave;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmil;
        private System.Windows.Forms.TextBox txtDoctername;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}