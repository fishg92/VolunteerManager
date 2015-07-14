namespace VolunteerManager
{
    partial class frmWorkDay
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
            this.cboProject = new System.Windows.Forms.ComboBox();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dgvAvailableVolunteer = new System.Windows.Forms.DataGridView();
            this.colpkVolunteerAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVolunteerNameAvailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrganization = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmVolunteerAvailable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAddSelectedVolunteers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditVolunteer = new System.Windows.Forms.ToolStripMenuItem();
            this.lblAvailableVolunteers = new System.Windows.Forms.Label();
            this.dgvSelectedVolunteers = new System.Windows.Forms.DataGridView();
            this.colpkVolunteerSelected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameSelected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrganizationSelected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActualHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoShow = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colProjectedStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProjectedEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActualStartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActualEndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colpkWorkDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmVolunteerSelected = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuMultiSetTime = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveVolunteer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditVolunteerSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSelectedVolunteers = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnNewVolunteer = new System.Windows.Forms.Button();
            this.lblWorkDescription = new System.Windows.Forms.Label();
            this.txtWorkDescription = new System.Windows.Forms.TextBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.lblTotalActualHours = new System.Windows.Forms.Label();
            this.cboOrganization = new System.Windows.Forms.ComboBox();
            this.lblOrganization = new System.Windows.Forms.Label();
            this.btnChangeProject = new System.Windows.Forms.Button();
            this.cboLunch = new System.Windows.Forms.ComboBox();
            this.lblLunch = new System.Windows.Forms.Label();
            this.btnUpdateEmail = new System.Windows.Forms.Button();
            this.lblVolunteerCount = new System.Windows.Forms.Label();
            this.lblWeekday = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableVolunteer)).BeginInit();
            this.cmVolunteerAvailable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedVolunteers)).BeginInit();
            this.cmVolunteerSelected.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboProject
            // 
            this.cboProject.DisplayMember = "ItemDisplay";
            this.cboProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProject.Enabled = false;
            this.cboProject.FormattingEnabled = true;
            this.cboProject.Location = new System.Drawing.Point(84, 7);
            this.cboProject.Name = "cboProject";
            this.cboProject.Size = new System.Drawing.Size(248, 21);
            this.cboProject.TabIndex = 0;
            this.cboProject.TabStop = false;
            this.cboProject.ValueMember = "ItemValue";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(38, 10);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(40, 13);
            this.lblProject.TabIndex = 1;
            this.lblProject.Text = "Project";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(467, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(503, 7);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(107, 20);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            this.dtpDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpDate_Validating);
            // 
            // dgvAvailableVolunteer
            // 
            this.dgvAvailableVolunteer.AllowUserToAddRows = false;
            this.dgvAvailableVolunteer.AllowUserToDeleteRows = false;
            this.dgvAvailableVolunteer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvAvailableVolunteer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvailableVolunteer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableVolunteer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colpkVolunteerAvailable,
            this.colVolunteerNameAvailable,
            this.colOrganization});
            this.dgvAvailableVolunteer.ContextMenuStrip = this.cmVolunteerAvailable;
            this.dgvAvailableVolunteer.Location = new System.Drawing.Point(12, 101);
            this.dgvAvailableVolunteer.Name = "dgvAvailableVolunteer";
            this.dgvAvailableVolunteer.ReadOnly = true;
            this.dgvAvailableVolunteer.RowHeadersVisible = false;
            this.dgvAvailableVolunteer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableVolunteer.Size = new System.Drawing.Size(278, 428);
            this.dgvAvailableVolunteer.TabIndex = 0;
            this.dgvAvailableVolunteer.DoubleClick += new System.EventHandler(this.dgvAvailableVolunteer_DoubleClick);
            this.dgvAvailableVolunteer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAvailableVolunteer_KeyDown);
            this.dgvAvailableVolunteer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvAvailableVolunteer_KeyPress);
            // 
            // colpkVolunteerAvailable
            // 
            this.colpkVolunteerAvailable.DataPropertyName = "pkVolunteer";
            this.colpkVolunteerAvailable.HeaderText = "pkVolunteer";
            this.colpkVolunteerAvailable.Name = "colpkVolunteerAvailable";
            this.colpkVolunteerAvailable.ReadOnly = true;
            this.colpkVolunteerAvailable.Visible = false;
            // 
            // colVolunteerNameAvailable
            // 
            this.colVolunteerNameAvailable.DataPropertyName = "Name";
            this.colVolunteerNameAvailable.HeaderText = "Volunteer";
            this.colVolunteerNameAvailable.Name = "colVolunteerNameAvailable";
            this.colVolunteerNameAvailable.ReadOnly = true;
            // 
            // colOrganization
            // 
            this.colOrganization.DataPropertyName = "Organization";
            this.colOrganization.HeaderText = "Organization";
            this.colOrganization.Name = "colOrganization";
            this.colOrganization.ReadOnly = true;
            // 
            // cmVolunteerAvailable
            // 
            this.cmVolunteerAvailable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddSelectedVolunteers,
            this.mnuEditVolunteer});
            this.cmVolunteerAvailable.Name = "cmVolunteerAvailable";
            this.cmVolunteerAvailable.Size = new System.Drawing.Size(262, 48);
            // 
            // mnuAddSelectedVolunteers
            // 
            this.mnuAddSelectedVolunteers.Name = "mnuAddSelectedVolunteers";
            this.mnuAddSelectedVolunteers.Size = new System.Drawing.Size(261, 22);
            this.mnuAddSelectedVolunteers.Text = "Add selected volunteers to work day";
            this.mnuAddSelectedVolunteers.Click += new System.EventHandler(this.mnuAddSelectedVolunteers_Click);
            // 
            // mnuEditVolunteer
            // 
            this.mnuEditVolunteer.Name = "mnuEditVolunteer";
            this.mnuEditVolunteer.Size = new System.Drawing.Size(261, 22);
            this.mnuEditVolunteer.Text = "Edit volunteer";
            this.mnuEditVolunteer.Click += new System.EventHandler(this.mnuEditVolunteer_Click);
            // 
            // lblAvailableVolunteers
            // 
            this.lblAvailableVolunteers.AutoSize = true;
            this.lblAvailableVolunteers.Location = new System.Drawing.Point(64, 60);
            this.lblAvailableVolunteers.Name = "lblAvailableVolunteers";
            this.lblAvailableVolunteers.Size = new System.Drawing.Size(103, 13);
            this.lblAvailableVolunteers.TabIndex = 5;
            this.lblAvailableVolunteers.Text = "Available Volunteers";
            // 
            // dgvSelectedVolunteers
            // 
            this.dgvSelectedVolunteers.AllowUserToAddRows = false;
            this.dgvSelectedVolunteers.AllowUserToDeleteRows = false;
            this.dgvSelectedVolunteers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSelectedVolunteers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSelectedVolunteers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedVolunteers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colpkVolunteerSelected,
            this.colNameSelected,
            this.colOrganizationSelected,
            this.colProjected,
            this.colActual,
            this.colComments,
            this.colActualHours,
            this.colNoShow,
            this.colProjectedStartTime,
            this.colProjectedEndTime,
            this.colActualStartTime,
            this.colActualEndTime,
            this.colpkWorkDay,
            this.colBaseDate});
            this.dgvSelectedVolunteers.ContextMenuStrip = this.cmVolunteerSelected;
            this.dgvSelectedVolunteers.Location = new System.Drawing.Point(369, 76);
            this.dgvSelectedVolunteers.Name = "dgvSelectedVolunteers";
            this.dgvSelectedVolunteers.ReadOnly = true;
            this.dgvSelectedVolunteers.RowHeadersVisible = false;
            this.dgvSelectedVolunteers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSelectedVolunteers.Size = new System.Drawing.Size(683, 453);
            this.dgvSelectedVolunteers.TabIndex = 4;
            this.dgvSelectedVolunteers.DoubleClick += new System.EventHandler(this.dgvSelectedVolunteers_DoubleClick);
            this.dgvSelectedVolunteers.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSelectedVolunteers_KeyDown);
            // 
            // colpkVolunteerSelected
            // 
            this.colpkVolunteerSelected.DataPropertyName = "pkVolunteer";
            this.colpkVolunteerSelected.HeaderText = "pkVolunteer";
            this.colpkVolunteerSelected.Name = "colpkVolunteerSelected";
            this.colpkVolunteerSelected.ReadOnly = true;
            this.colpkVolunteerSelected.Visible = false;
            // 
            // colNameSelected
            // 
            this.colNameSelected.DataPropertyName = "Name";
            this.colNameSelected.HeaderText = "Volunteer";
            this.colNameSelected.Name = "colNameSelected";
            this.colNameSelected.ReadOnly = true;
            // 
            // colOrganizationSelected
            // 
            this.colOrganizationSelected.DataPropertyName = "Organization";
            this.colOrganizationSelected.HeaderText = "Organization";
            this.colOrganizationSelected.Name = "colOrganizationSelected";
            this.colOrganizationSelected.ReadOnly = true;
            // 
            // colProjected
            // 
            this.colProjected.DataPropertyName = "Projected";
            this.colProjected.HeaderText = "Projected";
            this.colProjected.Name = "colProjected";
            this.colProjected.ReadOnly = true;
            // 
            // colActual
            // 
            this.colActual.DataPropertyName = "Actual";
            this.colActual.HeaderText = "Actual";
            this.colActual.Name = "colActual";
            this.colActual.ReadOnly = true;
            // 
            // colComments
            // 
            this.colComments.DataPropertyName = "Comments";
            this.colComments.HeaderText = "Comments";
            this.colComments.Name = "colComments";
            this.colComments.ReadOnly = true;
            this.colComments.Visible = false;
            // 
            // colActualHours
            // 
            this.colActualHours.DataPropertyName = "ActualHours";
            this.colActualHours.HeaderText = "Hours";
            this.colActualHours.Name = "colActualHours";
            this.colActualHours.ReadOnly = true;
            // 
            // colNoShow
            // 
            this.colNoShow.DataPropertyName = "NoShow";
            this.colNoShow.FalseValue = "0";
            this.colNoShow.HeaderText = "NoShow";
            this.colNoShow.Name = "colNoShow";
            this.colNoShow.ReadOnly = true;
            this.colNoShow.TrueValue = "1";
            // 
            // colProjectedStartTime
            // 
            this.colProjectedStartTime.DataPropertyName = "ProjectedStartTime";
            this.colProjectedStartTime.HeaderText = "ProjectedStartTime";
            this.colProjectedStartTime.Name = "colProjectedStartTime";
            this.colProjectedStartTime.ReadOnly = true;
            this.colProjectedStartTime.Visible = false;
            // 
            // colProjectedEndTime
            // 
            this.colProjectedEndTime.DataPropertyName = "ProjectedEndTime";
            this.colProjectedEndTime.HeaderText = "ProjectedEndTime";
            this.colProjectedEndTime.Name = "colProjectedEndTime";
            this.colProjectedEndTime.ReadOnly = true;
            this.colProjectedEndTime.Visible = false;
            // 
            // colActualStartTime
            // 
            this.colActualStartTime.DataPropertyName = "ActualStartTime";
            this.colActualStartTime.HeaderText = "ActualStartTime";
            this.colActualStartTime.Name = "colActualStartTime";
            this.colActualStartTime.ReadOnly = true;
            this.colActualStartTime.Visible = false;
            // 
            // colActualEndTime
            // 
            this.colActualEndTime.DataPropertyName = "ActualEndTime";
            this.colActualEndTime.HeaderText = "ActualEndTime";
            this.colActualEndTime.Name = "colActualEndTime";
            this.colActualEndTime.ReadOnly = true;
            this.colActualEndTime.Visible = false;
            // 
            // colpkWorkDay
            // 
            this.colpkWorkDay.DataPropertyName = "pkWorkDay";
            this.colpkWorkDay.HeaderText = "pkWorkDay";
            this.colpkWorkDay.Name = "colpkWorkDay";
            this.colpkWorkDay.ReadOnly = true;
            this.colpkWorkDay.Visible = false;
            // 
            // colBaseDate
            // 
            this.colBaseDate.DataPropertyName = "BaseDate";
            this.colBaseDate.HeaderText = "BaseDate";
            this.colBaseDate.Name = "colBaseDate";
            this.colBaseDate.ReadOnly = true;
            this.colBaseDate.Visible = false;
            // 
            // cmVolunteerSelected
            // 
            this.cmVolunteerSelected.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMultiSetTime,
            this.mnuRemoveVolunteer,
            this.mnuEditVolunteerSelected});
            this.cmVolunteerSelected.Name = "cmVolunteerSelected";
            this.cmVolunteerSelected.Size = new System.Drawing.Size(294, 70);
            // 
            // mnuMultiSetTime
            // 
            this.mnuMultiSetTime.Name = "mnuMultiSetTime";
            this.mnuMultiSetTime.Size = new System.Drawing.Size(293, 22);
            this.mnuMultiSetTime.Text = "Set actual times for selected volunteers";
            this.mnuMultiSetTime.Click += new System.EventHandler(this.mnuMultiSetTime_Click);
            // 
            // mnuRemoveVolunteer
            // 
            this.mnuRemoveVolunteer.Name = "mnuRemoveVolunteer";
            this.mnuRemoveVolunteer.Size = new System.Drawing.Size(293, 22);
            this.mnuRemoveVolunteer.Text = "Remove selected volunteers from work day";
            this.mnuRemoveVolunteer.Click += new System.EventHandler(this.mnuRemoveVolunteer_Click);
            // 
            // mnuEditVolunteerSelected
            // 
            this.mnuEditVolunteerSelected.Name = "mnuEditVolunteerSelected";
            this.mnuEditVolunteerSelected.Size = new System.Drawing.Size(293, 22);
            this.mnuEditVolunteerSelected.Text = "Edit volunteer";
            this.mnuEditVolunteerSelected.Click += new System.EventHandler(this.mnuEditVolunteerSelected_Click);
            // 
            // lblSelectedVolunteers
            // 
            this.lblSelectedVolunteers.AutoSize = true;
            this.lblSelectedVolunteers.Location = new System.Drawing.Point(500, 60);
            this.lblSelectedVolunteers.Name = "lblSelectedVolunteers";
            this.lblSelectedVolunteers.Size = new System.Drawing.Size(102, 13);
            this.lblSelectedVolunteers.TabIndex = 7;
            this.lblSelectedVolunteers.Text = "Selected Volunteers";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(296, 132);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(297, 183);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(66, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.TabStop = false;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnNewVolunteer
            // 
            this.btnNewVolunteer.Location = new System.Drawing.Point(297, 244);
            this.btnNewVolunteer.Name = "btnNewVolunteer";
            this.btnNewVolunteer.Size = new System.Drawing.Size(66, 41);
            this.btnNewVolunteer.TabIndex = 10;
            this.btnNewVolunteer.TabStop = false;
            this.btnNewVolunteer.Text = "New Volunteer";
            this.btnNewVolunteer.UseVisualStyleBackColor = true;
            this.btnNewVolunteer.Click += new System.EventHandler(this.btnNewVolunteer_Click);
            // 
            // lblWorkDescription
            // 
            this.lblWorkDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblWorkDescription.AutoSize = true;
            this.lblWorkDescription.Location = new System.Drawing.Point(12, 542);
            this.lblWorkDescription.Name = "lblWorkDescription";
            this.lblWorkDescription.Size = new System.Drawing.Size(89, 13);
            this.lblWorkDescription.TabIndex = 11;
            this.lblWorkDescription.Text = "Work Description";
            // 
            // txtWorkDescription
            // 
            this.txtWorkDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtWorkDescription.Location = new System.Drawing.Point(15, 559);
            this.txtWorkDescription.MaxLength = 500;
            this.txtWorkDescription.Multiline = true;
            this.txtWorkDescription.Name = "txtWorkDescription";
            this.txtWorkDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWorkDescription.Size = new System.Drawing.Size(275, 77);
            this.txtWorkDescription.TabIndex = 5;
            // 
            // txtComments
            // 
            this.txtComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComments.Location = new System.Drawing.Point(369, 559);
            this.txtComments.MaxLength = 500;
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComments.Size = new System.Drawing.Size(683, 77);
            this.txtComments.TabIndex = 6;
            // 
            // lblComments
            // 
            this.lblComments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(366, 542);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(56, 13);
            this.lblComments.TabIndex = 13;
            this.lblComments.Text = "Comments";
            // 
            // lblTotalActualHours
            // 
            this.lblTotalActualHours.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalActualHours.AutoSize = true;
            this.lblTotalActualHours.Location = new System.Drawing.Point(869, 542);
            this.lblTotalActualHours.Name = "lblTotalActualHours";
            this.lblTotalActualHours.Size = new System.Drawing.Size(122, 13);
            this.lblTotalActualHours.TabIndex = 15;
            this.lblTotalActualHours.Text = "Total Actual Hours: 0.00";
            // 
            // cboOrganization
            // 
            this.cboOrganization.DisplayMember = "ItemDisplay";
            this.cboOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrganization.FormattingEnabled = true;
            this.cboOrganization.Location = new System.Drawing.Point(84, 36);
            this.cboOrganization.Name = "cboOrganization";
            this.cboOrganization.Size = new System.Drawing.Size(248, 21);
            this.cboOrganization.TabIndex = 2;
            this.cboOrganization.ValueMember = "ItemValue";
            this.cboOrganization.SelectedIndexChanged += new System.EventHandler(this.cboOrganization_SelectedIndexChanged);
            // 
            // lblOrganization
            // 
            this.lblOrganization.AutoSize = true;
            this.lblOrganization.Location = new System.Drawing.Point(12, 39);
            this.lblOrganization.Name = "lblOrganization";
            this.lblOrganization.Size = new System.Drawing.Size(66, 13);
            this.lblOrganization.TabIndex = 17;
            this.lblOrganization.Text = "Organization";
            // 
            // btnChangeProject
            // 
            this.btnChangeProject.Location = new System.Drawing.Point(338, 7);
            this.btnChangeProject.Name = "btnChangeProject";
            this.btnChangeProject.Size = new System.Drawing.Size(95, 23);
            this.btnChangeProject.TabIndex = 18;
            this.btnChangeProject.Text = "Change Project";
            this.btnChangeProject.UseVisualStyleBackColor = true;
            this.btnChangeProject.Click += new System.EventHandler(this.btnChangeProject_Click);
            // 
            // cboLunch
            // 
            this.cboLunch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboLunch.DisplayMember = "ItemDisplay";
            this.cboLunch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLunch.FormattingEnabled = true;
            this.cboLunch.Location = new System.Drawing.Point(733, 7);
            this.cboLunch.Name = "cboLunch";
            this.cboLunch.Size = new System.Drawing.Size(319, 21);
            this.cboLunch.TabIndex = 19;
            this.cboLunch.ValueMember = "ItemValue";
            // 
            // lblLunch
            // 
            this.lblLunch.AutoSize = true;
            this.lblLunch.Location = new System.Drawing.Point(690, 12);
            this.lblLunch.Name = "lblLunch";
            this.lblLunch.Size = new System.Drawing.Size(37, 13);
            this.lblLunch.TabIndex = 20;
            this.lblLunch.Text = "Lunch";
            // 
            // btnUpdateEmail
            // 
            this.btnUpdateEmail.Location = new System.Drawing.Point(804, 33);
            this.btnUpdateEmail.Name = "btnUpdateEmail";
            this.btnUpdateEmail.Size = new System.Drawing.Size(153, 23);
            this.btnUpdateEmail.TabIndex = 21;
            this.btnUpdateEmail.Text = "Volunteer Update Email";
            this.btnUpdateEmail.UseVisualStyleBackColor = true;
            this.btnUpdateEmail.Visible = false;
            this.btnUpdateEmail.Click += new System.EventHandler(this.btnUpdateEmail_Click);
            // 
            // lblVolunteerCount
            // 
            this.lblVolunteerCount.AutoSize = true;
            this.lblVolunteerCount.Location = new System.Drawing.Point(658, 542);
            this.lblVolunteerCount.Name = "lblVolunteerCount";
            this.lblVolunteerCount.Size = new System.Drawing.Size(69, 13);
            this.lblVolunteerCount.TabIndex = 22;
            this.lblVolunteerCount.Text = "Volunteers: 0";
            // 
            // lblWeekday
            // 
            this.lblWeekday.AutoSize = true;
            this.lblWeekday.Location = new System.Drawing.Point(500, 30);
            this.lblWeekday.Name = "lblWeekday";
            this.lblWeekday.Size = new System.Drawing.Size(56, 13);
            this.lblWeekday.TabIndex = 23;
            this.lblWeekday.Text = "(weekday)";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(15, 76);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(244, 20);
            this.txtFilter.TabIndex = 24;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.Enter += new System.EventHandler(this.txtFilter_Enter);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Image = global::VolunteerManager.Properties.Resources.dialog_cancel;
            this.btnClearFilter.Location = new System.Drawing.Point(265, 76);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(24, 23);
            this.btnClearFilter.TabIndex = 25;
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // frmWorkDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 648);
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblWeekday);
            this.Controls.Add(this.lblVolunteerCount);
            this.Controls.Add(this.btnUpdateEmail);
            this.Controls.Add(this.cboLunch);
            this.Controls.Add(this.btnChangeProject);
            this.Controls.Add(this.lblLunch);
            this.Controls.Add(this.lblOrganization);
            this.Controls.Add(this.cboOrganization);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblTotalActualHours);
            this.Controls.Add(this.txtWorkDescription);
            this.Controls.Add(this.lblWorkDescription);
            this.Controls.Add(this.btnNewVolunteer);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSelectedVolunteers);
            this.Controls.Add(this.dgvSelectedVolunteers);
            this.Controls.Add(this.lblAvailableVolunteers);
            this.Controls.Add(this.dgvAvailableVolunteer);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.cboProject);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Name = "frmWorkDay";
            this.Text = "Edit Work Day";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWorkDay_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableVolunteer)).EndInit();
            this.cmVolunteerAvailable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedVolunteers)).EndInit();
            this.cmVolunteerSelected.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboProject;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DataGridView dgvAvailableVolunteer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpkVolunteerAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVolunteerNameAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrganization;
        private System.Windows.Forms.Label lblAvailableVolunteers;
        private System.Windows.Forms.DataGridView dgvSelectedVolunteers;
        private System.Windows.Forms.Label lblSelectedVolunteers;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnNewVolunteer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpkVolunteerSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrganizationSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActualHours;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colNoShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectedStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProjectedEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActualStartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActualEndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpkWorkDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBaseDate;
        private System.Windows.Forms.Label lblWorkDescription;
        private System.Windows.Forms.TextBox txtWorkDescription;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.ContextMenuStrip cmVolunteerAvailable;
        private System.Windows.Forms.ToolStripMenuItem mnuAddSelectedVolunteers;
        private System.Windows.Forms.ToolStripMenuItem mnuEditVolunteer;
        private System.Windows.Forms.ContextMenuStrip cmVolunteerSelected;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveVolunteer;
        private System.Windows.Forms.ToolStripMenuItem mnuEditVolunteerSelected;
        private System.Windows.Forms.ToolStripMenuItem mnuMultiSetTime;
        private System.Windows.Forms.Label lblTotalActualHours;
        private System.Windows.Forms.ComboBox cboOrganization;
        private System.Windows.Forms.Label lblOrganization;
        private System.Windows.Forms.Button btnChangeProject;
        private System.Windows.Forms.ComboBox cboLunch;
        private System.Windows.Forms.Label lblLunch;
        private System.Windows.Forms.Button btnUpdateEmail;
        private System.Windows.Forms.Label lblVolunteerCount;
        private System.Windows.Forms.Label lblWeekday;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnClearFilter;
    }
}