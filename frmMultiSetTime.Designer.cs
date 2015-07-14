namespace VolunteerManager
{
    partial class frmMultiSetTime
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
            this.lblActualCalculated = new System.Windows.Forms.Label();
            this.lblActualHoursTo = new System.Windows.Forms.Label();
            this.cboActualStart = new System.Windows.Forms.ComboBox();
            this.cboActualEnd = new System.Windows.Forms.ComboBox();
            this.lblActualHours = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblActualCalculated
            // 
            this.lblActualCalculated.AutoSize = true;
            this.lblActualCalculated.Location = new System.Drawing.Point(360, 15);
            this.lblActualCalculated.Name = "lblActualCalculated";
            this.lblActualCalculated.Size = new System.Drawing.Size(77, 13);
            this.lblActualCalculated.TabIndex = 14;
            this.lblActualCalculated.Text = "<actual hours>";
            // 
            // lblActualHoursTo
            // 
            this.lblActualHoursTo.AutoSize = true;
            this.lblActualHoursTo.Location = new System.Drawing.Point(211, 15);
            this.lblActualHoursTo.Name = "lblActualHoursTo";
            this.lblActualHoursTo.Size = new System.Drawing.Size(16, 13);
            this.lblActualHoursTo.TabIndex = 13;
            this.lblActualHoursTo.Text = "to";
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
            this.cboActualStart.Location = new System.Drawing.Point(84, 10);
            this.cboActualStart.Name = "cboActualStart";
            this.cboActualStart.Size = new System.Drawing.Size(121, 21);
            this.cboActualStart.TabIndex = 1;
            this.cboActualStart.SelectedIndexChanged += new System.EventHandler(this.cboActualStart_SelectedIndexChanged);
            this.cboActualStart.Validating += new System.ComponentModel.CancelEventHandler(this.cboActualStart_Validating);
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
            this.cboActualEnd.Location = new System.Drawing.Point(233, 12);
            this.cboActualEnd.Name = "cboActualEnd";
            this.cboActualEnd.Size = new System.Drawing.Size(121, 21);
            this.cboActualEnd.TabIndex = 2;
            this.cboActualEnd.SelectedIndexChanged += new System.EventHandler(this.cboActualEnd_SelectedIndexChanged);
            this.cboActualEnd.Validating += new System.ComponentModel.CancelEventHandler(this.cboActualEnd_Validating);
            // 
            // lblActualHours
            // 
            this.lblActualHours.AutoSize = true;
            this.lblActualHours.Location = new System.Drawing.Point(10, 15);
            this.lblActualHours.Name = "lblActualHours";
            this.lblActualHours.Size = new System.Drawing.Size(68, 13);
            this.lblActualHours.TabIndex = 10;
            this.lblActualHours.Text = "Actual Hours";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(362, 55);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(267, 55);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmMultiSetTime
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(486, 106);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblActualCalculated);
            this.Controls.Add(this.lblActualHoursTo);
            this.Controls.Add(this.cboActualStart);
            this.Controls.Add(this.cboActualEnd);
            this.Controls.Add(this.lblActualHours);
            this.Name = "frmMultiSetTime";
            this.Text = "Set Actual Hours for Multiple Volunteers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActualCalculated;
        private System.Windows.Forms.Label lblActualHoursTo;
        private System.Windows.Forms.ComboBox cboActualStart;
        private System.Windows.Forms.ComboBox cboActualEnd;
        private System.Windows.Forms.Label lblActualHours;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}