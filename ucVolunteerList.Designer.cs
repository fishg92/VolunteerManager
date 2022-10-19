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
            this.cboProject = new System.Windows.Forms.ComboBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.chkDateFilter = new System.Windows.Forms.CheckBox();
            this.gbxDateRange = new System.Windows.Forms.GroupBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolunteer)).BeginInit();
            this.cmVolunteer.SuspendLayout();
            this.gbxDateRange.SuspendLayout();
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
            this.cboOrganization.Size = new System.Drawing.Size(231, 21);
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
            this.chkActive.Location = new System.Drawing.Point(367, 39);
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
            this.dgvVolunteer.Location = new System.Drawing.Point(13, 88);
            this.dgvVolunteer.Name = "dgvVolunteer";
            this.dgvVolunteer.ReadOnly = true;
            this.dgvVolunteer.RowHeadersVisible = false;
            this.dgvVolunteer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVolunteer.Size = new System.Drawing.Size(870, 349);
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
            this.cmVolunteer.Size = new System.Drawing.Size(222, 92);
            // 
            // mnuAddVolunteer
            // 
            this.mnuAddVolunteer.Name = "mnuAddVolunteer";
            this.mnuAddVolunteer.Size = new System.Drawing.Size(221, 22);
            this.mnuAddVolunteer.Text = "Add New Volunteer";
            this.mnuAddVolunteer.Click += new System.EventHandler(this.mnuAddVolunteer_Click);
            // 
            // mnuEditVolunteer
            // 
            this.mnuEditVolunteer.Name = "mnuEditVolunteer";
            this.mnuEditVolunteer.Size = new System.Drawing.Size(221, 22);
            this.mnuEditVolunteer.Text = "Edit Volunteer";
            this.mnuEditVolunteer.Click += new System.EventHandler(this.mnuEditVolunteer_Click);
            // 
            // mnuDeleteVolunteer
            // 
            this.mnuDeleteVolunteer.Name = "mnuDeleteVolunteer";
            this.mnuDeleteVolunteer.Size = new System.Drawing.Size(221, 22);
            this.mnuDeleteVolunteer.Text = "Delete Volunteer";
            this.mnuDeleteVolunteer.Click += new System.EventHandler(this.mnuDeleteVolunteer_Click);
            // 
            // mnuCombineVolunteers
            // 
            this.mnuCombineVolunteers.Name = "mnuCombineVolunteers";
            this.mnuCombineVolunteers.Size = new System.Drawing.Size(221, 22);
            this.mnuCombineVolunteers.Text = "Combine Volunteer Records";
            this.mnuCombineVolunteers.Click += new System.EventHandler(this.mnuCombineVolunteers_Click);
            // 
            // cboProject
            // 
            this.cboProject.DisplayMember = "ProjectName";
            this.cboProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProject.FormattingEnabled = true;
            this.cboProject.Location = new System.Drawing.Point(102, 9);
            this.cboProject.Name = "cboProject";
            this.cboProject.Size = new System.Drawing.Size(231, 21);
            this.cboProject.TabIndex = 5;
            this.cboProject.ValueMember = "pkBuildProject";
            this.cboProject.SelectedIndexChanged += new System.EventHandler(this.cboProject_SelectedIndexChanged);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(30, 12);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(40, 13);
            this.lblProject.TabIndex = 6;
            this.lblProject.Text = "Project";
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(80, 19);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(103, 20);
            this.dtpStart.TabIndex = 7;
            // 
            // chkDateFilter
            // 
            this.chkDateFilter.AutoSize = true;
            this.chkDateFilter.Location = new System.Drawing.Point(536, 11);
            this.chkDateFilter.Name = "chkDateFilter";
            this.chkDateFilter.Size = new System.Drawing.Size(116, 17);
            this.chkDateFilter.TabIndex = 8;
            this.chkDateFilter.Text = "Filter by date range";
            this.chkDateFilter.UseVisualStyleBackColor = true;
            this.chkDateFilter.CheckedChanged += new System.EventHandler(this.chkDateFilter_CheckedChanged);
            // 
            // gbxDateRange
            // 
            this.gbxDateRange.Controls.Add(this.lblEndDate);
            this.gbxDateRange.Controls.Add(this.dtpEnd);
            this.gbxDateRange.Controls.Add(this.lblStartDate);
            this.gbxDateRange.Controls.Add(this.dtpStart);
            this.gbxDateRange.Location = new System.Drawing.Point(658, 6);
            this.gbxDateRange.Name = "gbxDateRange";
            this.gbxDateRange.Size = new System.Drawing.Size(189, 76);
            this.gbxDateRange.TabIndex = 9;
            this.gbxDateRange.TabStop = false;
            this.gbxDateRange.Text = "Date Range";
            this.gbxDateRange.Visible = false;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(35, 51);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(26, 13);
            this.lblEndDate.TabIndex = 10;
            this.lblEndDate.Text = "End";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(80, 45);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(103, 20);
            this.dtpEnd.TabIndex = 9;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(32, 25);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(29, 13);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Start";
            // 
            // ucVolunteerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxDateRange);
            this.Controls.Add(this.chkDateFilter);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.cboProject);
            this.Controls.Add(this.dgvVolunteer);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.lblOrganization);
            this.Controls.Add(this.cboOrganization);
            this.Controls.Add(this.lblTitle);
            this.Name = "ucVolunteerList";
            this.Size = new System.Drawing.Size(896, 449);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVolunteer)).EndInit();
            this.cmVolunteer.ResumeLayout(false);
            this.gbxDateRange.ResumeLayout(false);
            this.gbxDateRange.PerformLayout();
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
        private System.Windows.Forms.ComboBox cboProject;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.CheckBox chkDateFilter;
        private System.Windows.Forms.GroupBox gbxDateRange;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblStartDate;
    }
}
