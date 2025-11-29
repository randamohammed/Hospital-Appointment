namespace SmartAppointment.Patient
{
    partial class urtPatienList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFilterVaaluse = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmFlater = new System.Windows.Forms.ComboBox();
            this.dgPatientList = new System.Windows.Forms.DataGridView();
            this.conmShowPatientDetailes = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.lbRecorde = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.butNext = new Guna.UI2.WinForms.Guna2Button();
            this.butPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.cmPageSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butAddNewPatient = new Guna.UI2.WinForms.Guna2Button();
            this.tsoShowPatientDetailes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsoEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tosDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSourcePatient = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgPatientList)).BeginInit();
            this.conmShowPatientDetailes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePatient)).BeginInit();
            this.SuspendLayout();
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
            this.txtFilterVaaluse.Location = new System.Drawing.Point(165, 40);
            this.txtFilterVaaluse.Name = "txtFilterVaaluse";
            this.txtFilterVaaluse.PlaceholderText = "";
            this.txtFilterVaaluse.SelectedText = "";
            this.txtFilterVaaluse.Size = new System.Drawing.Size(200, 28);
            this.txtFilterVaaluse.TabIndex = 16;
            this.txtFilterVaaluse.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // cmFlater
            // 
            this.cmFlater.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmFlater.FormattingEnabled = true;
            this.cmFlater.Items.AddRange(new object[] {
            "None",
            "patient ID",
            "FullName",
            "phone"});
            this.cmFlater.Location = new System.Drawing.Point(12, 40);
            this.cmFlater.Name = "cmFlater";
            this.cmFlater.Size = new System.Drawing.Size(147, 28);
            this.cmFlater.TabIndex = 14;
            this.cmFlater.Text = "NationalID";
            // 
            // dgPatientList
            // 
            this.dgPatientList.AllowUserToAddRows = false;
            this.dgPatientList.AllowUserToDeleteRows = false;
            this.dgPatientList.AllowUserToOrderColumns = true;
            this.dgPatientList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dgPatientList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPatientList.BackgroundColor = System.Drawing.Color.White;
            this.dgPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPatientList.ContextMenuStrip = this.conmShowPatientDetailes;
            this.dgPatientList.Location = new System.Drawing.Point(12, 74);
            this.dgPatientList.Name = "dgPatientList";
            this.dgPatientList.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPatientList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgPatientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPatientList.Size = new System.Drawing.Size(880, 389);
            this.dgPatientList.TabIndex = 13;
            // 
            // conmShowPatientDetailes
            // 
            this.conmShowPatientDetailes.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.conmShowPatientDetailes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsoShowPatientDetailes,
            this.tsoEdit,
            this.tosDelete});
            this.conmShowPatientDetailes.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.conmShowPatientDetailes.Name = "conmShowPatientDetailes";
            this.conmShowPatientDetailes.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.conmShowPatientDetailes.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.conmShowPatientDetailes.RenderStyle.ColorTable = null;
            this.conmShowPatientDetailes.RenderStyle.RoundedEdges = true;
            this.conmShowPatientDetailes.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.conmShowPatientDetailes.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.conmShowPatientDetailes.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.conmShowPatientDetailes.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.conmShowPatientDetailes.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.conmShowPatientDetailes.Size = new System.Drawing.Size(214, 149);
            // 
            // lbRecorde
            // 
            this.lbRecorde.BackColor = System.Drawing.Color.Transparent;
            this.lbRecorde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecorde.Location = new System.Drawing.Point(107, 481);
            this.lbRecorde.Name = "lbRecorde";
            this.lbRecorde.Size = new System.Drawing.Size(24, 18);
            this.lbRecorde.TabIndex = 20;
            this.lbRecorde.Text = "???";
            // 
            // butNext
            // 
            this.butNext.BorderRadius = 2;
            this.butNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.butNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.butNext.ForeColor = System.Drawing.Color.White;
            this.butNext.Location = new System.Drawing.Point(607, 478);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(92, 24);
            this.butNext.TabIndex = 19;
            this.butNext.Text = "Next";
            this.butNext.Click += new System.EventHandler(this.butNext_Click);
            // 
            // butPrevious
            // 
            this.butPrevious.BorderRadius = 2;
            this.butPrevious.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butPrevious.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butPrevious.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butPrevious.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butPrevious.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.butPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.butPrevious.ForeColor = System.Drawing.Color.White;
            this.butPrevious.Location = new System.Drawing.Point(509, 478);
            this.butPrevious.Name = "butPrevious";
            this.butPrevious.Size = new System.Drawing.Size(92, 24);
            this.butPrevious.TabIndex = 18;
            this.butPrevious.Text = "Previous";
            this.butPrevious.Click += new System.EventHandler(this.butPrevious_Click);
            // 
            // cmPageSize
            // 
            this.cmPageSize.AutoCompleteCustomSource.AddRange(new string[] {
            "50",
            "100",
            "200",
            "300"});
            this.cmPageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmPageSize.FormattingEnabled = true;
            this.cmPageSize.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400"});
            this.cmPageSize.Location = new System.Drawing.Point(332, 478);
            this.cmPageSize.Name = "cmPageSize";
            this.cmPageSize.Size = new System.Drawing.Size(121, 24);
            this.cmPageSize.TabIndex = 17;
            this.cmPageSize.Text = "Page Size";
            this.cmPageSize.SelectedIndexChanged += new System.EventHandler(this.cmPageSize_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(408, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Manage Patient List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "# Recorde :";
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
            this.butAddNewPatient.Image = global::SmartAppointment.Properties.Resources._8665950_square_plus_icon;
            this.butAddNewPatient.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butAddNewPatient.Location = new System.Drawing.Point(696, 32);
            this.butAddNewPatient.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.butAddNewPatient.Name = "butAddNewPatient";
            this.butAddNewPatient.Size = new System.Drawing.Size(187, 36);
            this.butAddNewPatient.TabIndex = 15;
            this.butAddNewPatient.Text = "   Add a new patient";
            this.butAddNewPatient.Click += new System.EventHandler(this.butAddNewPatient_Click);
            // 
            // tsoShowPatientDetailes
            // 
            this.tsoShowPatientDetailes.Image = global::SmartAppointment.Properties.Resources.show;
            this.tsoShowPatientDetailes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsoShowPatientDetailes.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.tsoShowPatientDetailes.Name = "tsoShowPatientDetailes";
            this.tsoShowPatientDetailes.Padding = new System.Windows.Forms.Padding(0, 1, 0, 6);
            this.tsoShowPatientDetailes.Size = new System.Drawing.Size(213, 35);
            this.tsoShowPatientDetailes.Text = "      Show Patient Detailes";
            this.tsoShowPatientDetailes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsoShowPatientDetailes.Click += new System.EventHandler(this.tsoShowPatientDetailes_Click);
            // 
            // tsoEdit
            // 
            this.tsoEdit.Image = global::SmartAppointment.Properties.Resources._103514_edit_text_document_icon;
            this.tsoEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsoEdit.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.tsoEdit.Name = "tsoEdit";
            this.tsoEdit.Padding = new System.Windows.Forms.Padding(0, 1, 0, 6);
            this.tsoEdit.Size = new System.Drawing.Size(213, 35);
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
            this.tosDelete.Size = new System.Drawing.Size(213, 35);
            this.tosDelete.Text = "      Delete";
            this.tosDelete.Click += new System.EventHandler(this.tosDelete_Click);
            // 
            // urtPatienList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbRecorde);
            this.Controls.Add(this.butNext);
            this.Controls.Add(this.butPrevious);
            this.Controls.Add(this.cmPageSize);
            this.Controls.Add(this.txtFilterVaaluse);
            this.Controls.Add(this.butAddNewPatient);
            this.Controls.Add(this.cmFlater);
            this.Controls.Add(this.dgPatientList);
            this.Name = "urtPatienList";
            this.Size = new System.Drawing.Size(899, 516);
            this.Load += new System.EventHandler(this.urtPatienList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPatientList)).EndInit();
            this.conmShowPatientDetailes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePatient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtFilterVaaluse;
        private Guna.UI2.WinForms.Guna2Button butAddNewPatient;
        private System.Windows.Forms.ComboBox cmFlater;
        private System.Windows.Forms.DataGridView dgPatientList;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbRecorde;
        private Guna.UI2.WinForms.Guna2Button butNext;
        private Guna.UI2.WinForms.Guna2Button butPrevious;
        private System.Windows.Forms.ComboBox cmPageSize;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip conmShowPatientDetailes;
        private System.Windows.Forms.ToolStripMenuItem tsoShowPatientDetailes;
        private System.Windows.Forms.ToolStripMenuItem tsoEdit;
        private System.Windows.Forms.ToolStripMenuItem tosDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSourcePatient;
    }
}
