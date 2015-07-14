namespace VolunteerManager
{
    partial class ucVolunteerList
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboOrganization = new System.Windows.Forms.ComboBox();
            this.lblOrganization = new System.Windows.Forms.Label();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.dgvVolunteer = new System.Windows.Forms.DataGridView();
            this.colpkVolunteer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfkOrganization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfkrefPositionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHomePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCellPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colPositionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrganizationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastVolunteerDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmVolunteer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAddVolunteer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditVolunteer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteVolunteer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCombineVolunteers = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolunteer)).BeginInit();
            this.cmVolunteer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(362, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Volunteer List";
            // 
            // cboOrganization
            // 
            this.cboOrganization.DisplayMember = "OrganizationName";
            this.cboOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrganization.FormattingEnabled = true;
            this.cboOrganization.Location = new System.Drawing.Point(102, 37);
            this.cboOrganization.Name = "cboOrganization";
            this.cboOrganization.Size = new System.Drawing.Size(275, 21);
            this.cboOrganization.TabIndex = 1;
            this.cboOrganization.ValueMember = "pkOrganization";
            this.cboOrganization.SelectedIndexChanged += new System.EventHandler(this.cboOrganization_SelectedIndexChanged);
            // 
            // lblOrganization
            // 
            this.lblOrganization.AutoSize = true;
            this.lblOrganization.Location = new System.Drawing.Point(30, 40);
            this.lblOrganization.Name = "lblOrganization";
            this.lblOrganization.Size = new System.Drawing.Size(66, 13);
            this.lblOrganization.TabIndex = 2;
            this.lblOrganization.Text = "Organization";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(426, 39);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(159, 17);
            this.chkActive.TabIndex = 3;
            this.chkActive.Text = "Show active volunteers only";
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.CheckedChanged += new System.EventHandler(this.chkActive_CheckedChanged);
            // 
            // dgvVolunteer
            // 
            this.dgvVolunteer.AllowUserToAddRows = false;
            this.dgvVolunteer.AllowUserToDeleteRows = false;
            this.dgvVolunteer.AllowUserToOrderColumns = true;
            this.dgvVolunteer.AllowUserToResizeColumns = false;
            this.dgvVolunteer.AllowUserToResizeRows = false;
            this.dgvVolunteer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVolunteer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVolunteer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVolunteer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colpkVolunteer,
            this.colfkOrganization,
            this.colfkrefPositionType,
            this.colLastName,
            this.colFirstName,
            this.colHomePhone,
            this.colCellPhone,
            this.colEmail,
            this.colActive,
            this.colPositionType,
            this.colOrganizationName,
            this.colLastVolunteerDate,
            this.colProjectHours});
            this.dgvVolunteer.ContextMenuStrip = this.cmVolunteer;
            this.dgvVolunteer.Location = new System.Drawing.Point(13, 64);
            this.dgvVolunteer.Name = "dgvVolunteer";
            this.dgvVolunteer.ReadOnly = true;
            this.dgvVolunteer.RowHeadersVisible = false;
            this.dgvVolunteer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVolunteer.Size = new System.Drawing.Size(870, 373);
            this.dgvVolunteer.TabIndex = 4;
            this.dgvVolunteer.SelectionChanged += new System.EventHandler(this.dgvVolunteer_SelectionChanged);
            this.dgvVolunteer.DoubleClick += new System.EventHandler(this.dgvVolunteer_DoubleClick);
            // 
            // colpkVolunteer
            // 
            this.colpkVolunteer.DataPropertyName = "pkVolunteer";
            this.colpkVolunteer.HeaderText = "pkVolunteer";
            this.colpkVolunteer.Name = "colpkVolunteer";
            this.colpkVolunteer.ReadOnly = true;
            this.colpkVolunteer.Visible = false;
            // 
            // colfkOrganization
            // 
            this.colfkOrganization.DataPropertyName = "fkOrganization";
            this.colfkOrganization.HeaderText = "fkOrganization";
            this.colfkOrganization.Name = "colfkOrganization";
            this.colfkOrganization.ReadOnly = true;
            this.colfkOrganization.Visible = false;
            // 
            // colfkrefPositionType
            // 
            this.colfkrefPositionType.DataPropertyName = "fkrefPositionType";
            this.colfkrefPositionType.HeaderText = "fkrefPositionType";
            this.colfkrefPositionType.Name = "colfkrefPositionType";
            this.colfkrefPositionType.ReadOnly = true;
            this.colfkrefPositionType.Visible = false;
            // 
            // colLastName
            // 
            this.colLastName.DataPropertyName = "LastName";
            this.colLastName.HeaderText = "Last Name";
            this.colLastName.Name = "colLastName";
            this.colLastName.ReadOnly = true;
            // 
            // colFirstName
            // 
            this.colFirstName.DataPropertyName = "FirstName";
            this.colFirstName.HeaderText = "First Name";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            // 
            // colHomePhone
            // 
            this.colHomePhone.DataPropertyName = "HomePhone";
            this.colHomePhone.HeaderText = "Home Phone";
            this.colHomePhone.Name = "colHomePhone";
            this.colHomePhone.ReadOnly = true;
            // 
            // colCellPhone
            // 
            this.colCellPhone.DataPropertyName = "CellPhone";
            this.colCellPhone.HeaderText = "Cell Phone";
            this.colCellPhone.Name = "colCellPhone";
            this.colCellPhone.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // colActive
            // 
            this.colActive.DataPropertyName = "CurrentlyActive";
            this.colActive.HeaderText = "Active";
            this.colActive.Name = "colActive";
            this.colActive.ReadOnly = true;
            // 
            // colPositionType
            // 
            this.colPositionType.DataPropertyName = "PositionType";
            this.colPositionType.HeaderText = "Position Type";
            this.colPositionType.Name = "colPositionType";
            this.colPositionType.ReadOnly = true;
            this.colPositionType.Visible = false;
            // 
            // colOrganizationName
            // 
            this.colOrganizationName.DataPropertyName = "OrganizationName";
            this.colOrganizationName.HeaderText = "Organization";
            this.colOrganizationName.Name = "colOrganizationName";
            this.colOrganizationName.ReadOnly = true;
            // 
            // colLastVolunteerDate
            // 
            this.colLastVolunteerDate.DataPropertyName = "LastVolunteerDate";
            this.colLastVolunteerDate.HeaderText = "Last Date";
            this.colLastVolunteerDate.Name = "colLastVolunteerDate";
            this.colLastVolunteerDate.ReadOnly = true;
            // 
            // colProjectHours
            // 
            this.colProjectHours.DataPropertyName = "ProjectHours";
            this.colProjectHours.HeaderText = "Project Hours";
            this.colProjectHours.Name = "colProjectHours";
            this.colProjectHours.ReadOnly = true;
            // 
            // cmVolunteer
            // 
            this.cmVolunteer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddVolunteer,
            this.mnuEditVolunteer,
            this.mnuDeleteVolunteer,
            this.mnuCombineVolunteers});
            this.cmVolunteer.Name = "cmVolunteer";
            this.cmVolunteer.Size = new System.Drawing.Size(223, 92);
            // 
            // mnuAddVolunteer
            // 
            this.mnuAddVolunteer.Name = "mnuAddVolunteer";
            this.mnuAddVolunteer.Size = new System.Drawing.Size(222, 22);
            this.mnuAddVolunteer.Text = "Add New Volunteer";
            this.mnuAddVolunteer.Click += new System.EventHandler(this.mnuAddVolunteer_Click);
            // 
            // mnuEditVolunteer
            // 
            this.mnuEditVolunteer.Name = "mnuEditVolunteer";
            this.mnuEditVolunteer.Size = new System.Drawing.Size(222, 22);
            this.mnuEditVolunteer.Text = "Edit Volunteer";
            this.mnuEditVolunteer.Click += new System.EventHandler(this.mnuEditVolunteer_Click);
            // 
            // mnuDeleteVolunteer
            // 
            this.mnuDeleteVolunteer.Name = "mnuDeleteVolunteer";
            this.mnuDeleteVolunteer.Size = new System.Drawing.Size(222, 22);
            this.mnuDeleteVolunteer.Text = "Delete Volunteer";
            this.mnuDeleteVolunteer.Click += new System.EventHandler(this.mnuDeleteVolunteer_Click);
            // 
            // mnuCombineVolunteers
            // 
            this.mnuCombineVolunteers.Name = "mnuCombineVolunteers";
            this.mnuCombineVolunteers.Size = new System.Drawing.Size(222, 22);
            this.mnuCombineVolunteers.Text = "Combine Volunteer Records";
            this.mnuCombineVolunteers.Click += new System.EventHandler(this.mnuCombineVolunteers_Click);
            // 
            // ucVolunteerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvVolunteer);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.lblOrganization);
            this.Controls.Add(this.cboOrganization);
            this.Controls.Add(this.lblTitle);
            this.Name = "ucVolunteerList";
            this.Size = new System.Drawing.Size(896, 449);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolunteer)).EndInit();
            this.cmVolunteer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboOrganization;
        private System.Windows.Forms.Label lblOrganization;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.DataGridView dgvVolunteer;
        private System.Windows.Forms.ContextMenuStrip cmVolunteer;
        private System.Windows.Forms.ToolStripMenuItem mnuAddVolunteer;
        private System.Windows.Forms.ToolStripMenuItem mnuEditVolunteer;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteVolunteer;
        private System.Windows.Forms.ToolStripMenuItem mnuCombineVolunteers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpkVolunteer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfkOrganization;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfkrefPositionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHomePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCellPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPositionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrganizationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastVolunteerDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectHours;
    }
}
