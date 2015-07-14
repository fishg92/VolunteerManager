namespace VolunteerManager
{
    partial class ucWorkDayList
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboProject = new System.Windows.Forms.ComboBox();
            this.dgvWorkDay = new System.Windows.Forms.DataGridView();
            this.cmsWorkDay = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAddWorkDay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditWorkDay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteWorkDay = new System.Windows.Forms.ToolStripMenuItem();
            this.lblProject = new System.Windows.Forms.Label();
            this.colpkWorkDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDayOfWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVolunteerCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalProjectHours = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkDay)).BeginInit();
            this.cmsWorkDay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(362, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(117, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Work Days";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(753, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add new work day";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboProject
            // 
            this.cboProject.DisplayMember = "ProjectName";
            this.cboProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProject.FormattingEnabled = true;
            this.cboProject.Location = new System.Drawing.Point(57, 37);
            this.cboProject.Name = "cboProject";
            this.cboProject.Size = new System.Drawing.Size(422, 21);
            this.cboProject.TabIndex = 2;
            this.cboProject.ValueMember = "pkBuildProject";
            this.cboProject.SelectedIndexChanged += new System.EventHandler(this.cboProject_SelectedIndexChanged);
            // 
            // dgvWorkDay
            // 
            this.dgvWorkDay.AllowUserToAddRows = false;
            this.dgvWorkDay.AllowUserToDeleteRows = false;
            this.dgvWorkDay.AllowUserToOrderColumns = true;
            this.dgvWorkDay.AllowUserToResizeRows = false;
            this.dgvWorkDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWorkDay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorkDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colpkWorkDay,
            this.colDayOfWeek,
            this.colWorkDate,
            this.colDescription,
            this.colVolunteerCount,
            this.colTotalHours});
            this.dgvWorkDay.ContextMenuStrip = this.cmsWorkDay;
            this.dgvWorkDay.Location = new System.Drawing.Point(14, 64);
            this.dgvWorkDay.Name = "dgvWorkDay";
            this.dgvWorkDay.ReadOnly = true;
            this.dgvWorkDay.RowHeadersVisible = false;
            this.dgvWorkDay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkDay.Size = new System.Drawing.Size(719, 341);
            this.dgvWorkDay.TabIndex = 3;
            this.dgvWorkDay.DoubleClick += new System.EventHandler(this.dgvWorkDay_DoubleClick);
            this.dgvWorkDay.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkDay_CellEndEdit);
            // 
            // cmsWorkDay
            // 
            this.cmsWorkDay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddWorkDay,
            this.mnuEditWorkDay,
            this.mnuDeleteWorkDay});
            this.cmsWorkDay.Name = "cmsWorkDay";
            this.cmsWorkDay.Size = new System.Drawing.Size(167, 70);
            // 
            // mnuAddWorkDay
            // 
            this.mnuAddWorkDay.Name = "mnuAddWorkDay";
            this.mnuAddWorkDay.Size = new System.Drawing.Size(166, 22);
            this.mnuAddWorkDay.Text = "Add Work Day";
            this.mnuAddWorkDay.Click += new System.EventHandler(this.mnuAddWorkDay_Click);
            // 
            // mnuEditWorkDay
            // 
            this.mnuEditWorkDay.Name = "mnuEditWorkDay";
            this.mnuEditWorkDay.Size = new System.Drawing.Size(166, 22);
            this.mnuEditWorkDay.Text = "Edit Work Day";
            this.mnuEditWorkDay.Click += new System.EventHandler(this.mnuEditWorkDay_Click);
            // 
            // mnuDeleteWorkDay
            // 
            this.mnuDeleteWorkDay.Name = "mnuDeleteWorkDay";
            this.mnuDeleteWorkDay.Size = new System.Drawing.Size(166, 22);
            this.mnuDeleteWorkDay.Text = "Delete Work Day";
            this.mnuDeleteWorkDay.Click += new System.EventHandler(this.mnuDeleteWorkDay_Click);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(11, 40);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(40, 13);
            this.lblProject.TabIndex = 4;
            this.lblProject.Text = "Project";
            // 
            // colpkWorkDay
            // 
            this.colpkWorkDay.DataPropertyName = "pkWorkDay";
            this.colpkWorkDay.HeaderText = "pkWorkDay";
            this.colpkWorkDay.Name = "colpkWorkDay";
            this.colpkWorkDay.ReadOnly = true;
            this.colpkWorkDay.Visible = false;
            // 
            // colDayOfWeek
            // 
            this.colDayOfWeek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDayOfWeek.DataPropertyName = "DayOfWeek";
            this.colDayOfWeek.HeaderText = "Day";
            this.colDayOfWeek.Name = "colDayOfWeek";
            this.colDayOfWeek.ReadOnly = true;
            this.colDayOfWeek.Width = 51;
            // 
            // colWorkDate
            // 
            this.colWorkDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colWorkDate.DataPropertyName = "WorkDate";
            this.colWorkDate.HeaderText = "Work Date";
            this.colWorkDate.Name = "colWorkDate";
            this.colWorkDate.ReadOnly = true;
            this.colWorkDate.Width = 84;
            // 
            // colDescription
            // 
            this.colDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDescription.DataPropertyName = "WorkDescription";
            this.colDescription.HeaderText = "Work Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            this.colDescription.Width = 105;
            // 
            // colVolunteerCount
            // 
            this.colVolunteerCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colVolunteerCount.DataPropertyName = "VolunteerCount";
            this.colVolunteerCount.HeaderText = "Volunteers";
            this.colVolunteerCount.Name = "colVolunteerCount";
            this.colVolunteerCount.ReadOnly = true;
            this.colVolunteerCount.Width = 82;
            // 
            // colTotalHours
            // 
            this.colTotalHours.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTotalHours.DataPropertyName = "TotalHours";
            this.colTotalHours.HeaderText = "Total Hrs";
            this.colTotalHours.Name = "colTotalHours";
            this.colTotalHours.ReadOnly = true;
            // 
            // lblTotalProjectHours
            // 
            this.lblTotalProjectHours.AutoSize = true;
            this.lblTotalProjectHours.Location = new System.Drawing.Point(498, 40);
            this.lblTotalProjectHours.Name = "lblTotalProjectHours";
            this.lblTotalProjectHours.Size = new System.Drawing.Size(101, 13);
            this.lblTotalProjectHours.TabIndex = 5;
            this.lblTotalProjectHours.Text = "Total Project Hours:";
            // 
            // ucWorkDayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTotalProjectHours);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.dgvWorkDay);
            this.Controls.Add(this.cboProject);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTitle);
            this.Name = "ucWorkDayList";
            this.Size = new System.Drawing.Size(870, 425);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkDay)).EndInit();
            this.cmsWorkDay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboProject;
        private System.Windows.Forms.DataGridView dgvWorkDay;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.ContextMenuStrip cmsWorkDay;
        private System.Windows.Forms.ToolStripMenuItem mnuEditWorkDay;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteWorkDay;
        private System.Windows.Forms.ToolStripMenuItem mnuAddWorkDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colpkWorkDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDayOfWeek;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVolunteerCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalHours;
        private System.Windows.Forms.Label lblTotalProjectHours;
    }
}
