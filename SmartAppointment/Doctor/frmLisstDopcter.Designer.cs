namespace SmartAppointment.Doctor
{
    partial class frmLisstDopcter
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
            this.label3 = new System.Windows.Forms.Label();
            this.lbRecorde = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAddNewUsers = new System.Windows.Forms.Button();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDocter = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDocterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dvDocter = new System.Windows.Forms.DataGridView();
            this.cmFilter = new System.Windows.Forms.ComboBox();
            this.txtFilterVaaluse = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmDocter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvDocter)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 31;
            this.label3.Text = "Find By:";
            // 
            // lbRecorde
            // 
            this.lbRecorde.AutoSize = true;
            this.lbRecorde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecorde.Location = new System.Drawing.Point(137, 544);
            this.lbRecorde.Name = "lbRecorde";
            this.lbRecorde.Size = new System.Drawing.Size(40, 24);
            this.lbRecorde.TabIndex = 30;
            this.lbRecorde.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 542);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "# Recorde :";
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btClose.Location = new System.Drawing.Point(761, 537);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(96, 32);
            this.btClose.TabIndex = 28;
            this.btClose.Text = "Clsoe";
            this.btClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(439, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // btAddNewUsers
            // 
            this.btAddNewUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddNewUsers.Location = new System.Drawing.Point(761, 108);
            this.btAddNewUsers.Name = "btAddNewUsers";
            this.btAddNewUsers.Size = new System.Drawing.Size(96, 64);
            this.btAddNewUsers.TabIndex = 27;
            this.btAddNewUsers.UseVisualStyleBackColor = true;
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cmDocter
            // 
            this.cmDocter.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.cmDocter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetilesToolStripMenuItem,
            this.addNewToolStripMenuItem,
            this.editDocterToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.cmDocter.Name = "contextMenuStrip1";
            this.cmDocter.Size = new System.Drawing.Size(181, 114);
            // 
            // showDetilesToolStripMenuItem
            // 
            this.showDetilesToolStripMenuItem.Name = "showDetilesToolStripMenuItem";
            this.showDetilesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showDetilesToolStripMenuItem.Text = "Show Detiles";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewToolStripMenuItem.Text = "Add New ";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.addNewToolStripMenuItem_Click);
            // 
            // editDocterToolStripMenuItem
            // 
            this.editDocterToolStripMenuItem.Name = "editDocterToolStripMenuItem";
            this.editDocterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editDocterToolStripMenuItem.Text = "Edit Docter";
            this.editDocterToolStripMenuItem.Click += new System.EventHandler(this.editDocterToolStripMenuItem_Click);
            // 
            // dvDocter
            // 
            this.dvDocter.AllowUserToAddRows = false;
            this.dvDocter.AllowUserToDeleteRows = false;
            this.dvDocter.AllowUserToOrderColumns = true;
            this.dvDocter.BackgroundColor = System.Drawing.Color.White;
            this.dvDocter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvDocter.ContextMenuStrip = this.cmDocter;
            this.dvDocter.Location = new System.Drawing.Point(26, 176);
            this.dvDocter.Name = "dvDocter";
            this.dvDocter.ReadOnly = true;
            this.dvDocter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvDocter.Size = new System.Drawing.Size(831, 349);
            this.dvDocter.TabIndex = 26;
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
            this.cmFilter.Location = new System.Drawing.Point(104, 144);
            this.cmFilter.Name = "cmFilter";
            this.cmFilter.Size = new System.Drawing.Size(138, 28);
            this.cmFilter.TabIndex = 24;
            this.cmFilter.SelectedIndexChanged += new System.EventHandler(this.cmFilter_SelectedIndexChanged);
            // 
            // txtFilterVaaluse
            // 
            this.txtFilterVaaluse.Location = new System.Drawing.Point(248, 141);
            this.txtFilterVaaluse.Multiline = true;
            this.txtFilterVaaluse.Name = "txtFilterVaaluse";
            this.txtFilterVaaluse.Size = new System.Drawing.Size(199, 29);
            this.txtFilterVaaluse.TabIndex = 25;
            this.txtFilterVaaluse.Visible = false;
            this.txtFilterVaaluse.TextChanged += new System.EventHandler(this.txtFilterVaaluse_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(420, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Manage Last Docter";
            // 
            // frmLisstDopcter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 581);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbRecorde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btAddNewUsers);
            this.Controls.Add(this.dvDocter);
            this.Controls.Add(this.cmFilter);
            this.Controls.Add(this.txtFilterVaaluse);
            this.Controls.Add(this.label1);
            this.Name = "frmLisstDopcter";
            this.Text = "frmLisstDopcter";
            this.Load += new System.EventHandler(this.frmLisstDopcter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmDocter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvDocter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbRecorde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btAddNewUsers;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmDocter;
        private System.Windows.Forms.ToolStripMenuItem showDetilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDocterToolStripMenuItem;
        private System.Windows.Forms.DataGridView dvDocter;
        private System.Windows.Forms.ComboBox cmFilter;
        private System.Windows.Forms.TextBox txtFilterVaaluse;
        private System.Windows.Forms.Label label1;
    }
}