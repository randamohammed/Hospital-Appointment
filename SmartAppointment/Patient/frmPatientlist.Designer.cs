namespace SmartAppointment.Patient
{
    partial class frmPatientlist
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgPatientList = new System.Windows.Forms.DataGridView();
            this.conmShowPatientDetailes = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.tsoShowPatientDetailes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsoEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tosDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmFlater = new System.Windows.Forms.ComboBox();
            this.cmPageSize = new System.Windows.Forms.ComboBox();
            this.butAddNewPatient = new Guna.UI2.WinForms.Guna2Button();
            this.butPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.butNext = new Guna.UI2.WinForms.Guna2Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tosShowPatientDetailes = new System.Windows.Forms.ToolStripMenuItem();
            this.toEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toDelet = new System.Windows.Forms.ToolStripMenuItem();
            this.lbRecorde = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPatientList)).BeginInit();
            this.conmShowPatientDetailes.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgPatientList
            // 
            this.dgPatientList.AllowUserToAddRows = false;
            this.dgPatientList.AllowUserToDeleteRows = false;
            this.dgPatientList.AllowUserToOrderColumns = true;
            this.dgPatientList.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dgPatientList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgPatientList.BackgroundColor = System.Drawing.Color.White;
            this.dgPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPatientList.ContextMenuStrip = this.conmShowPatientDetailes;
            this.dgPatientList.Location = new System.Drawing.Point(12, 67);
            this.dgPatientList.Name = "dgPatientList";
            this.dgPatientList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPatientList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgPatientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPatientList.Size = new System.Drawing.Size(874, 389);
            this.dgPatientList.TabIndex = 0;
            // 
            // conmShowPatientDetailes
            // 
            this.conmShowPatientDetailes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsoShowPatientDetailes,
            this.tsoEdit,
            this.tosDelete});
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
            this.conmShowPatientDetailes.Size = new System.Drawing.Size(188, 70);
            // 
            // tsoShowPatientDetailes
            // 
            this.tsoShowPatientDetailes.Name = "tsoShowPatientDetailes";
            this.tsoShowPatientDetailes.Size = new System.Drawing.Size(187, 22);
            this.tsoShowPatientDetailes.Text = "Show Patient Detailes";
            this.tsoShowPatientDetailes.Click += new System.EventHandler(this.tsoShowPatientDetailes_Click);
            // 
            // tsoEdit
            // 
            this.tsoEdit.Name = "tsoEdit";
            this.tsoEdit.Size = new System.Drawing.Size(187, 22);
            this.tsoEdit.Text = "Edit";
            this.tsoEdit.Click += new System.EventHandler(this.tsoEdit_Click);
            // 
            // tosDelete
            // 
            this.tosDelete.Name = "tosDelete";
            this.tosDelete.Size = new System.Drawing.Size(187, 22);
            this.tosDelete.Text = "Delete";
            this.tosDelete.Click += new System.EventHandler(this.tosDelete_Click);
            // 
            // cmFlater
            // 
            this.cmFlater.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmFlater.FormattingEnabled = true;
            this.cmFlater.Items.AddRange(new object[] {
            "phone number",
            "NationalID",
            "FullName"});
            this.cmFlater.Location = new System.Drawing.Point(12, 24);
            this.cmFlater.Name = "cmFlater";
            this.cmFlater.Size = new System.Drawing.Size(121, 24);
            this.cmFlater.TabIndex = 3;
            this.cmFlater.Text = "NationalID";
            this.cmFlater.SelectedIndexChanged += new System.EventHandler(this.cmFlater_SelectedIndexChanged);
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
            this.cmPageSize.Location = new System.Drawing.Point(234, 471);
            this.cmPageSize.Name = "cmPageSize";
            this.cmPageSize.Size = new System.Drawing.Size(121, 24);
            this.cmPageSize.TabIndex = 6;
            this.cmPageSize.Text = "Page Size";
            this.cmPageSize.SelectedIndexChanged += new System.EventHandler(this.cmPageSize_SelectedIndexChanged);
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
            this.butAddNewPatient.Location = new System.Drawing.Point(702, 12);
            this.butAddNewPatient.Name = "butAddNewPatient";
            this.butAddNewPatient.Size = new System.Drawing.Size(180, 36);
            this.butAddNewPatient.TabIndex = 8;
            this.butAddNewPatient.Text = "Add a new patient";
            this.butAddNewPatient.Click += new System.EventHandler(this.butAddNewPatient_Click);
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
            this.butPrevious.Location = new System.Drawing.Point(411, 471);
            this.butPrevious.Name = "butPrevious";
            this.butPrevious.Size = new System.Drawing.Size(92, 24);
            this.butPrevious.TabIndex = 9;
            this.butPrevious.Text = "Previous";
            this.butPrevious.Click += new System.EventHandler(this.butPrevious_Click_1);
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
            this.butNext.Location = new System.Drawing.Point(509, 471);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(92, 24);
            this.butNext.TabIndex = 10;
            this.butNext.Text = "Next";
            this.butNext.Click += new System.EventHandler(this.butNext_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tosShowPatientDetailes,
            this.toEdit,
            this.toDelet});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(188, 70);
            // 
            // tosShowPatientDetailes
            // 
            this.tosShowPatientDetailes.Name = "tosShowPatientDetailes";
            this.tosShowPatientDetailes.Size = new System.Drawing.Size(187, 22);
            this.tosShowPatientDetailes.Text = "Show Patient Detailes";
            // 
            // toEdit
            // 
            this.toEdit.Name = "toEdit";
            this.toEdit.Size = new System.Drawing.Size(187, 22);
            this.toEdit.Text = "Edit";
            // 
            // toDelet
            // 
            this.toDelet.Name = "toDelet";
            this.toDelet.Size = new System.Drawing.Size(187, 22);
            this.toDelet.Text = "Delet";
            // 
            // lbRecorde
            // 
            this.lbRecorde.BackColor = System.Drawing.Color.Transparent;
            this.lbRecorde.Location = new System.Drawing.Point(24, 471);
            this.lbRecorde.Name = "lbRecorde";
            this.lbRecorde.Size = new System.Drawing.Size(21, 15);
            this.lbRecorde.TabIndex = 11;
            this.lbRecorde.Text = "???";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(155, 24);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 24);
            this.guna2TextBox1.TabIndex = 12;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // frmPatientlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(894, 527);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.lbRecorde);
            this.Controls.Add(this.butNext);
            this.Controls.Add(this.butPrevious);
            this.Controls.Add(this.butAddNewPatient);
            this.Controls.Add(this.cmPageSize);
            this.Controls.Add(this.cmFlater);
            this.Controls.Add(this.dgPatientList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPatientlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient list";
            this.Load += new System.EventHandler(this.frmPatientlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPatientList)).EndInit();
            this.conmShowPatientDetailes.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPatientList;
        private System.Windows.Forms.ComboBox cmFlater;
        private System.Windows.Forms.ComboBox cmPageSize;
        private Guna.UI2.WinForms.Guna2Button butAddNewPatient;
        private Guna.UI2.WinForms.Guna2Button butPrevious;
        private Guna.UI2.WinForms.Guna2Button butNext;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tosShowPatientDetailes;
        private System.Windows.Forms.ToolStripMenuItem toEdit;
        private System.Windows.Forms.ToolStripMenuItem toDelet;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip conmShowPatientDetailes;
        private System.Windows.Forms.ToolStripMenuItem tsoShowPatientDetailes;
        private System.Windows.Forms.ToolStripMenuItem tsoEdit;
        private System.Windows.Forms.ToolStripMenuItem tosDelete;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbRecorde;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}