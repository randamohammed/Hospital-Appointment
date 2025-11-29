namespace SmartAppointment.User.Controls
{
    partial class urctListUser
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
            this.dvUsers = new System.Windows.Forms.DataGridView();
            this.cmFilter = new System.Windows.Forms.ComboBox();
            this.txtFilterVaaluse = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbRecorde = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.butAddNewUser = new Guna.UI2.WinForms.Guna2Button();
            this.tooShowDetiles = new System.Windows.Forms.ToolStripMenuItem();
            this.toooEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tooDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSourceUsers = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dvUsers)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Find By:";
            // 
            // dvUsers
            // 
            this.dvUsers.AllowUserToAddRows = false;
            this.dvUsers.AllowUserToDeleteRows = false;
            this.dvUsers.AllowUserToOrderColumns = true;
            this.dvUsers.BackgroundColor = System.Drawing.Color.White;
            this.dvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvUsers.Location = new System.Drawing.Point(7, 81);
            this.dvUsers.Name = "dvUsers";
            this.dvUsers.ReadOnly = true;
            this.dvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvUsers.Size = new System.Drawing.Size(818, 349);
            this.dvUsers.TabIndex = 24;
            // 
            // cmFilter
            // 
            this.cmFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmFilter.FormattingEnabled = true;
            this.cmFilter.Items.AddRange(new object[] {
            "None",
            "User ID",
            "Role",
            "User Name"});
            this.cmFilter.Location = new System.Drawing.Point(91, 47);
            this.cmFilter.Name = "cmFilter";
            this.cmFilter.Size = new System.Drawing.Size(160, 28);
            this.cmFilter.TabIndex = 22;
            this.cmFilter.SelectedIndexChanged += new System.EventHandler(this.cmFilter_SelectedIndexChanged_1);
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
            this.txtFilterVaaluse.Location = new System.Drawing.Point(257, 47);
            this.txtFilterVaaluse.Name = "txtFilterVaaluse";
            this.txtFilterVaaluse.PlaceholderText = "";
            this.txtFilterVaaluse.SelectedText = "";
            this.txtFilterVaaluse.Size = new System.Drawing.Size(200, 28);
            this.txtFilterVaaluse.TabIndex = 26;
            this.txtFilterVaaluse.TextChanged += new System.EventHandler(this.txtFilterVaaluse_TextChanged);
            this.txtFilterVaaluse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterVaaluse_KeyPress);
            // 
            // lbRecorde
            // 
            this.lbRecorde.AutoSize = true;
            this.lbRecorde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecorde.Location = new System.Drawing.Point(118, 440);
            this.lbRecorde.Name = "lbRecorde";
            this.lbRecorde.Size = new System.Drawing.Size(30, 24);
            this.lbRecorde.TabIndex = 28;
            this.lbRecorde.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "# Recorde :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(331, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Manage Last User";
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tooShowDetiles,
            this.toooEditUser,
            this.tooDelete});
            this.guna2ContextMenuStrip1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(168, 134);
            // 
            // butAddNewUser
            // 
            this.butAddNewUser.BorderRadius = 10;
            this.butAddNewUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butAddNewUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butAddNewUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butAddNewUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butAddNewUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.butAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.butAddNewUser.ForeColor = System.Drawing.Color.White;
            this.butAddNewUser.Image = global::SmartAppointment.Properties.Resources._8665950_square_plus_icon;
            this.butAddNewUser.Location = new System.Drawing.Point(667, 31);
            this.butAddNewUser.Name = "butAddNewUser";
            this.butAddNewUser.Size = new System.Drawing.Size(158, 44);
            this.butAddNewUser.TabIndex = 33;
            this.butAddNewUser.Text = "Add New User";
            this.butAddNewUser.Click += new System.EventHandler(this.butAddNewUser_Click);
            // 
            // tooShowDetiles
            // 
            this.tooShowDetiles.Image = global::SmartAppointment.Properties.Resources.show;
            this.tooShowDetiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tooShowDetiles.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.tooShowDetiles.Name = "tooShowDetiles";
            this.tooShowDetiles.Size = new System.Drawing.Size(167, 30);
            this.tooShowDetiles.Text = "      Show Detiles";
            this.tooShowDetiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toooEditUser
            // 
            this.toooEditUser.Image = global::SmartAppointment.Properties.Resources._103514_edit_text_document_icon;
            this.toooEditUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toooEditUser.Margin = new System.Windows.Forms.Padding(0, 0, 10, 20);
            this.toooEditUser.Name = "toooEditUser";
            this.toooEditUser.Size = new System.Drawing.Size(167, 30);
            this.toooEditUser.Text = "     Edit User";
            this.toooEditUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toooEditUser.Click += new System.EventHandler(this.toooEditUser_Click);
            // 
            // tooDelete
            // 
            this.tooDelete.Image = global::SmartAppointment.Properties.Resources.delete1;
            this.tooDelete.Name = "tooDelete";
            this.tooDelete.Size = new System.Drawing.Size(167, 30);
            this.tooDelete.Text = "      Delete";
            this.tooDelete.Click += new System.EventHandler(this.tooDelete_Click);
            // 
            // urctListUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.butAddNewUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbRecorde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFilterVaaluse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dvUsers);
            this.Controls.Add(this.cmFilter);
            this.Name = "urctListUser";
            this.Size = new System.Drawing.Size(842, 467);
            this.Load += new System.EventHandler(this.urctListUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvUsers)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dvUsers;
        private System.Windows.Forms.ComboBox cmFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterVaaluse;
        private System.Windows.Forms.Label lbRecorde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button butAddNewUser;
        private System.Windows.Forms.BindingSource bindingSourceUsers;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tooShowDetiles;
        private System.Windows.Forms.ToolStripMenuItem toooEditUser;
        private System.Windows.Forms.ToolStripMenuItem tooDelete;
    }
}
