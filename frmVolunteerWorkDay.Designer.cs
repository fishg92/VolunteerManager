namespace VolunteerManager
{
    partial class frmVolunteerWorkDay
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
            this.lblVolunteer = new System.Windows.Forms.Label();
            this.lblProjectedHours = new System.Windows.Forms.Label();
            this.lblActualHours = new System.Windows.Forms.Label();
            this.cboProjectedStart = new System.Windows.Forms.ComboBox();
            this.lblProjectedHoursTo = new System.Windows.Forms.Label();
            this.cboProjectedEnd = new System.Windows.Forms.ComboBox();
            this.cboActualEnd = new System.Windows.Forms.ComboBox();
            this.cboActualStart = new System.Windows.Forms.ComboBox();
            this.lblActualHoursTo = new System.Windows.Forms.Label();
            this.lblActualCalculated = new System.Windows.Forms.Label();
            this.btnCopyToActual = new System.Windows.Forms.Button();
            this.chkNoShow = new System.Windows.Forms.CheckBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epr = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtQuickEnter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.epr)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVolunteer
            // 
            this.lblVolunteer.AutoSize = true;
            this.lblVolunteer.Location = new System.Drawing.Point(12, 9);
            this.lblVolunteer.Name = "lblVolunteer";
            this.lblVolunteer.Size = new System.Drawing.Size(63, 13);
            this.lblVolunteer.TabIndex = 0;
            this.lblVolunteer.Text = "<volunteer>";
            // 
            // lblProjectedHours
            // 
            this.lblProjectedHours.AutoSize = true;
            this.lblProjectedHours.Location = new System.Drawing.Point(12, 35);
            this.lblProjectedHours.Name = "lblProjectedHours";
            this.lblProjectedHours.Size = new System.Drawing.Size(83, 13);
            this.lblProjectedHours.TabIndex = 1;
            this.lblProjectedHours.Text = "Projected Hours";
            // 
            // lblActualHours
            // 
            this.lblActualHours.AutoSize = true;
            this.lblActualHours.Location = new System.Drawing.Point(27, 64);
            this.lblActualHours.Name = "lblActualHours";
            this.lblActualHours.Size = new System.Drawing.Size(68, 13);
            this.lblActualHours.TabIndex = 2;
            this.lblActualHours.Text = "Actual Hours";
            // 
            // cboProjectedStart
            // 
            this.cboProjectedStart.FormattingEnabled = true;
            this.cboProjectedStart.Items.AddRange(new object[] {
            "7:00 AM",
            "7:15 AM",
            "7:30 AM",
            "7:45 AM",
            "8:00 AM",
            "8:15 AM",
            "8:30 AM",
            "8:45 AM",
            "9:00 AM",
            "9:15 AM",
            "9:30 AM",
            "9:45 AM",
            "10:00 AM"});
            this.cboProjectedStart.Location = new System.Drawing.Point(101, 32);
            this.cboProjectedStart.Name = "cboProjectedStart";
            this.cboProjectedStart.Size = new System.Drawing.Size(121, 21);
            this.cboProjectedStart.TabIndex = 1;
            this.cboProjectedStart.TabStop = false;
            // 
            // lblProjectedHoursTo
            // 
            this.lblProjectedHoursTo.AutoSize = true;
            this.lblProjectedHoursTo.Location = new System.Drawing.Point(228, 35);
            this.lblProjectedHoursTo.Name = "lblProjectedHoursTo";
            this.lblProjectedHoursTo.Size = new System.Drawing.Size(16, 13);
            this.lblProjectedHoursTo.TabIndex = 4;
            this.lblProjectedHoursTo.Text = "to";
            // 
            // cboProjectedEnd
            // 
            this.cboProjectedEnd.FormattingEnabled = true;
            this.cboProjectedEnd.Items.AddRange(new object[] {
            "7:00 AM",
            "7:15 AM",
            "7:30 AM",
            "7:45 AM",
            "8:00 AM",
            "8:15 AM",
            "8:30 AM",
            "8:45 AM",
            "9:00 AM",
            "9:15 AM",
            "9:30 AM",
            "9:45 AM",
            "10:00 AM"});
            this.cboProjectedEnd.Location = new System.Drawing.Point(250, 32);
            this.cboProjectedEnd.Name = "cboProjectedEnd";
            this.cboProjectedEnd.Size = new System.Drawing.Size(121, 21);
            this.cboProjectedEnd.TabIndex = 2;
            this.cboProjectedEnd.TabStop = false;
            // 
            // cboActualEnd
            // 
            this.cboActualEnd.FormattingEnabled = true;
            this.cboActualEnd.Items.AddRange(new object[] {
            "7:00 AM",
            "7:15 AM",
            "7:30 AM",
            "7:45 AM",
            "8:00 AM",
            "8:15 AM",
            "8:30 AM",
            "8:45 AM",
            "9:00 AM",
            "9:15 AM",
            "9:30 AM",
            "9:45 AM",
            "10:00 AM"});
            this.cboActualEnd.Location = new System.Drawing.Point(250, 61);
            this.cboActualEnd.Name = "cboActualEnd";
            this.cboActualEnd.Size = new System.Drawing.Size(121, 21);
            this.cboActualEnd.TabIndex = 5;
            this.cboActualEnd.SelectedIndexChanged += new System.EventHandler(this.cboActualEnd_SelectedIndexChanged);
            this.cboActualEnd.Validating += new System.ComponentModel.CancelEventHandler(this.cboActualEnd_Validating);
            // 
            // cboActualStart
            // 
            this.cboActualStart.FormattingEnabled = true;
            this.cboActualStart.Items.AddRange(new object[] {
            "7:00 AM",
            "7:15 AM",
            "7:30 AM",
            "7:45 AM",
            "8:00 AM",
            "8:15 AM",
            "8:30 AM",
            "8:45 AM",
            "9:00 AM",
            "9:15 AM",
            "9:30 AM",
            "9:45 AM",
            "10:00 AM"});
            this.cboActualStart.Location = new System.Drawing.Point(101, 59);
            this.cboActualStart.Name = "cboActualStart";
            this.cboActualStart.Size = new System.Drawing.Size(121, 21);
            this.cboActualStart.TabIndex = 4;
            this.cboActualStart.SelectedIndexChanged += new System.EventHandler(this.cboActualStart_SelectedIndexChanged);
            this.cboActualStart.Validating += new System.ComponentModel.CancelEventHandler(this.cboActualStart_Validating);
            // 
            // lblActualHoursTo
            // 
            this.lblActualHoursTo.AutoSize = true;
            this.lblActualHoursTo.Location = new System.Drawing.Point(228, 64);
            this.lblActualHoursTo.Name = "lblActualHoursTo";
            this.lblActualHoursTo.Size = new System.Drawing.Size(16, 13);
            this.lblActualHoursTo.TabIndex = 8;
            this.lblActualHoursTo.Text = "to";
            // 
            // lblActualCalculated
            // 
            this.lblActualCalculated.AutoSize = true;
            this.lblActualCalculated.Location = new System.Drawing.Point(377, 64);
            this.lblActualCalculated.Name = "lblActualCalculated";
            this.lblActualCalculated.Size = new System.Drawing.Size(77, 13);
            this.lblActualCalculated.TabIndex = 9;
            this.lblActualCalculated.Text = "<actual hours>";
            // 
            // btnCopyToActual
            // 
            this.btnCopyToActual.Location = new System.Drawing.Point(377, 30);
            this.btnCopyToActual.Name = "btnCopyToActual";
            this.btnCopyToActual.Size = new System.Drawing.Size(92, 23);
            this.btnCopyToActual.TabIndex = 3;
            this.btnCopyToActual.Text = "Copy to actual";
            this.btnCopyToActual.UseVisualStyleBackColor = true;
            this.btnCopyToActual.Click += new System.EventHandler(this.btnCopyToActual_Click);
            // 
            // chkNoShow
            // 
            this.chkNoShow.AutoSize = true;
            this.chkNoShow.Location = new System.Drawing.Point(490, 61);
            this.chkNoShow.Name = "chkNoShow";
            this.chkNoShow.Size = new System.Drawing.Size(70, 17);
            this.chkNoShow.TabIndex = 11;
            this.chkNoShow.TabStop = false;
            this.chkNoShow.Text = "No Show";
            this.chkNoShow.UseVisualStyleBackColor = true;
            this.chkNoShow.CheckedChanged += new System.EventHandler(this.chkNoShow_CheckedChanged);
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(12, 104);
            this.txtComments.MaxLength = 500;
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(548, 109);
            this.txtComments.TabIndex = 6;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(12, 88);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(56, 13);
            this.lblComments.TabIndex = 13;
            this.lblComments.Text = "Comments";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(478, 219);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 33);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(390, 219);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 33);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // epr
            // 
            this.epr.ContainerControl = this;
            // 
            // txtQuickEnter
            // 
            this.txtQuickEnter.Location = new System.Drawing.Point(490, 28);
            this.txtQuickEnter.MaxLength = 4;
            this.txtQuickEnter.Name = "txtQuickEnter";
            this.txtQuickEnter.Size = new System.Drawing.Size(70, 20);
            this.txtQuickEnter.TabIndex = 0;
            this.txtQuickEnter.Visible = false;
            this.txtQuickEnter.Validated += new System.EventHandler(this.txtQuickEnter_Validated);
            // 
            // frmVolunteerWorkDay
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(576, 264);
            this.Controls.Add(this.txtQuickEnter);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.chkNoShow);
            this.Controls.Add(this.btnCopyToActual);
            this.Controls.Add(this.lblActualCalculated);
            this.Controls.Add(this.lblActualHoursTo);
            this.Controls.Add(this.cboActualStart);
            this.Controls.Add(this.cboActualEnd);
            this.Controls.Add(this.cboProjectedEnd);
            this.Controls.Add(this.lblProjectedHoursTo);
            this.Controls.Add(this.cboProjectedStart);
            this.Controls.Add(this.lblActualHours);
            this.Controls.Add(this.lblProjectedHours);
            this.Controls.Add(this.lblVolunteer);
            this.Name = "frmVolunteerWorkDay";
            this.Text = "Edit Volunteer Work Day";
            this.Load += new System.EventHandler(this.frmVolunteerWorkDay_Load);
            this.Shown += new System.EventHandler(this.frmVolunteerWorkDay_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.epr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVolunteer;
        private System.Windows.Forms.Label lblProjectedHours;
        private System.Windows.Forms.Label lblActualHours;
        private System.Windows.Forms.ComboBox cboProjectedStart;
        private System.Windows.Forms.Label lblProjectedHoursTo;
        private System.Windows.Forms.ComboBox cboProjectedEnd;
        private System.Windows.Forms.ComboBox cboActualEnd;
        private System.Windows.Forms.ComboBox cboActualStart;
        private System.Windows.Forms.Label lblActualHoursTo;
        private System.Windows.Forms.Label lblActualCalculated;
        private System.Windows.Forms.Button btnCopyToActual;
        private System.Windows.Forms.CheckBox chkNoShow;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider epr;
        private System.Windows.Forms.TextBox txtQuickEnter;
    }
}