namespace SmartAppointment.Doctor
{
    partial class urtDoctorList
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
            this.label3 = new System.Windows.Forms.Label();
            this.lbRecorde = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dvDocter = new System.Windows.Forms.DataGridView();
            this.conmShowDoctorDetailes = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsoShowPatientDetailes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsoEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tosDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butAddNewPatient = new Guna.UI2.WinForms.Guna2Button();
            this.txtFilterVaaluse = new Guna.UI2.WinForms.Guna2TextBox();
            this.bindingSourceDoctor = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dvDocter)).BeginInit();
            this.conmShowDoctorDetailes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Find By:";
            // 
            // lbRecorde
            // 
            this.lbRecorde.AutoSize = true;
            this.lbRecorde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecorde.Location = new System.Drawing.Point(100, 456);
            this.lbRecorde.Name = "lbRecorde";
            this.lbRecorde.Size = new System.Drawing.Size(36, 20);
            this.lbRecorde.TabIndex = 38;
            this.lbRecorde.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "# Recorde :";
            // 
            // dvDocter
            // 
            this.dvDocter.AllowUserToAddRows = false;
            this.dvDocter.AllowUserToDeleteRows = false;
            this.dvDocter.AllowUserToOrderColumns = true;
            this.dvDocter.BackgroundColor = System.Drawing.Color.White;
            this.dvDocter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvDocter.ContextMenuStrip = this.conmShowDoctorDetailes;
            this.dvDocter.Location = new System.Drawing.Point(16, 94);
            this.dvDocter.Name = "dvDocter";
            this.dvDocter.ReadOnly = true;
            this.dvDocter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvDocter.Size = new System.Drawing.Size(881, 349);
            this.dvDocter.TabIndex = 35;
            // 
            // conmShowDoctorDetailes
            // 
            this.conmShowDoctorDetailes.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.conmShowDoctorDetailes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsoShowPatientDetailes,
            this.tsoEdit,
            this.tosDelete});
            this.conmShowDoctorDetailes.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.conmShowDoctorDetailes.Name = "conmShowPatientDetailes";
            this.conmShowDoctorDetailes.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.conmShowDoctorDetailes.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.conmShowDoctorDetailes.RenderStyle.ColorTable = null;
            this.conmShowDoctorDetailes.RenderStyle.RoundedEdges = true;
            this.conmShowDoctorDetailes.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.conmShowDoctorDetailes.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.conmShowDoctorDetailes.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.conmShowDoctorDetailes.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.conmShowDoctorDetailes.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.conmShowDoctorDetailes.Size = new System.Drawing.Size(174, 149);
            // 
            // tsoShowPatientDetailes
            // 
            this.tsoShowPatientDetailes.Image = global::SmartAppointment.Properties.Resources.show;
            this.tsoShowPatientDetailes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsoShowPatientDetailes.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.tsoShowPatientDetailes.Name = "tsoShowPatientDetailes";
            this.tsoShowPatientDetailes.Padding = new System.Windows.Forms.Padding(0, 1, 0, 6);
            this.tsoShowPatientDetailes.Size = new System.Drawing.Size(173, 35);
            this.tsoShowPatientDetailes.Text = "      Show Detailes";
            this.tsoShowPatientDetailes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tsoEdit
            // 
            this.tsoEdit.Image = global::SmartAppointment.Properties.Resources._103514_edit_text_document_icon;
            this.tsoEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsoEdit.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.tsoEdit.Name = "tsoEdit";
            this.tsoEdit.Padding = new System.Windows.Forms.Padding(0, 1, 0, 6);
            this.tsoEdit.Size = new System.Drawing.Size(173, 35);
            this.tsoEdit.Text = "      Edit";
            this.tsoEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsoEdit.Click += new System.EventHandler(this.tsoEdit_Click);
            // 
            // tosDelete
            // 
            this.tosDelete.Image = global::SmartAppointment.Properties.Resources.delete1;
            this.tosDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tosDelete.Name = "tosDelete";
            this.tosDelete.Padding = new System.Windows.Forms.Padding(0, 1, 0, 6);
            this.tosDelete.Size = new System.Drawing.Size(173, 35);
            this.tosDelete.Text = "      Delete";
            this.tosDelete.Click += new System.EventHandler(this.tosDelete_Click);
            // 
            // cmFilter
            // 
            this.cmFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmFilter.FormattingEnabled = true;
            this.cmFilter.Items.AddRange(new object[] {
            "None",
            "Doctor ID",
            "Full Name",
            "Specialty"});
            this.cmFilter.Location = new System.Drawing.Point(90, 61);
            this.cmFilter.Name = "cmFilter";
            this.cmFilter.Size = new System.Drawing.Size(155, 28);
            this.cmFilter.TabIndex = 33;
            this.cmFilter.SelectedIndexChanged += new System.EventHandler(this.cmFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(421, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Manage Last Docter";
            // 
            // butAddNewPatient
            // 
            this.butAddNewPatient.BorderRadius = 8;
            this.butAddNewPatient.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butAddNewPatient.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butAddNewPatient.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butAddNewPatient.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butAddNewPatient.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.butAddNewPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.butAddNewPatient.ForeColor = System.Drawing.Color.White;
            this.butAddNewPatient.Image = global::SmartAppointment.Properties.Resources.Add2;
            this.butAddNewPatient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAddNewPatient.Location = new System.Drawing.Point(662, 50);
            this.butAddNewPatient.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.butAddNewPatient.Name = "butAddNewPatient";
            this.butAddNewPatient.Size = new System.Drawing.Size(187, 36);
            this.butAddNewPatient.TabIndex = 40;
            this.butAddNewPatient.Text = "   Add a new doctor";
            // 
            // txtFilterVaaluse
            // 
            this.txtFilterVaaluse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterVaaluse.DefaultText = "";
            this.txtFilterVaaluse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterVaaluse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterVaaluse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterVaaluse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterVaaluse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterVaaluse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFilterVaaluse.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterVaaluse.Location = new System.Drawing.Point(251, 62);
            this.txtFilterVaaluse.Name = "txtFilterVaaluse";
            this.txtFilterVaaluse.PlaceholderText = "";
            this.txtFilterVaaluse.SelectedText = "";
            this.txtFilterVaaluse.Size = new System.Drawing.Size(200, 28);
            this.txtFilterVaaluse.TabIndex = 41;
            this.txtFilterVaaluse.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // urtDoctorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtFilterVaaluse);
            this.Controls.Add(this.butAddNewPatient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbRecorde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvDocter);
            this.Controls.Add(this.cmFilter);
            this.Controls.Add(this.label1);
            this.Name = "urtDoctorList";
            this.Size = new System.Drawing.Size(912, 516);
            this.Load += new System.EventHandler(this.urtDoctorList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvDocter)).EndInit();
            this.conmShowDoctorDetailes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRecorde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dvDocter;
        private System.Windows.Forms.ComboBox cmFilter;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button butAddNewPatient;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterVaaluse;
        private System.Windows.Forms.BindingSource bindingSourceDoctor;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip conmShowDoctorDetailes;
        private System.Windows.Forms.ToolStripMenuItem tsoShowPatientDetailes;
        private System.Windows.Forms.ToolStripMenuItem tsoEdit;
        private System.Windows.Forms.ToolStripMenuItem tosDelete;
    }
}
