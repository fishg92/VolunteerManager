namespace VolunteerManager
{
    partial class frmVolunteer
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
            this.lblOrganization = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCSZ = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.mskZip = new System.Windows.Forms.MaskedTextBox();
            this.mskHomePhone = new System.Windows.Forms.MaskedTextBox();
            this.lblHomePhone = new System.Windows.Forms.Label();
            this.lblCellPhone = new System.Windows.Forms.Label();
            this.mskCellPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblWorkPhone = new System.Windows.Forms.Label();
            this.mskWorkPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblWorkPhoneExt = new System.Windows.Forms.Label();
            this.mskWorkPhoneExt = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cboOrganization = new System.Windows.Forms.ComboBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.epr1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboPositionType = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epr1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrganization
            // 
            this.lblOrganization.AutoSize = true;
            this.lblOrganization.Location = new System.Drawing.Point(16, 143);
            this.lblOrganization.Name = "lblOrganization";
            this.lblOrganization.Size = new System.Drawing.Size(66, 13);
            this.lblOrganization.TabIndex = 0;
            this.lblOrganization.Text = "Organization";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(15, 13);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(67, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Name   Last:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(88, 10);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(199, 20);
            this.txtLastName.TabIndex = 0;
            this.txtLastName.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(318, 13);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(29, 13);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(353, 10);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(199, 20);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.Enter += new System.EventHandler(this.txt_Enter);

            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(88, 36);
            this.txtAddress.MaxLength = 50;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(283, 20);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(37, 39);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address";
            // 
            // lblCSZ
            // 
            this.lblCSZ.AutoSize = true;
            this.lblCSZ.Location = new System.Drawing.Point(32, 65);
            this.lblCSZ.Name = "lblCSZ";
            this.lblCSZ.Size = new System.Drawing.Size(50, 13);
            this.lblCSZ.TabIndex = 7;
            this.lblCSZ.Text = "C / S / Z";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(88, 62);
            this.txtCity.MaxLength = 50;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(199, 20);
            this.txtCity.TabIndex = 3;
            this.txtCity.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // cboState
            // 
            this.cboState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "..",
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "DC",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "PR",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VI",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.cboState.Location = new System.Drawing.Point(293, 62);
            this.cboState.MaxDropDownItems = 50;
            this.cboState.MaxLength = 2;
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(54, 21);
            this.cboState.TabIndex = 4;
            // 
            // mskZip
            // 
            this.mskZip.Location = new System.Drawing.Point(353, 62);
            this.mskZip.Mask = "00000-9999";
            this.mskZip.Name = "mskZip";
            this.mskZip.Size = new System.Drawing.Size(74, 20);
            this.mskZip.TabIndex = 5;
            this.mskZip.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskHomePhone
            // 
            this.mskHomePhone.Location = new System.Drawing.Point(88, 88);
            this.mskHomePhone.Mask = "(999) 000-0000";
            this.mskHomePhone.Name = "mskHomePhone";
            this.mskHomePhone.Size = new System.Drawing.Size(87, 20);
            this.mskHomePhone.TabIndex = 6;
            this.mskHomePhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblHomePhone
            // 
            this.lblHomePhone.AutoSize = true;
            this.lblHomePhone.Location = new System.Drawing.Point(13, 91);
            this.lblHomePhone.Name = "lblHomePhone";
            this.lblHomePhone.Size = new System.Drawing.Size(69, 13);
            this.lblHomePhone.TabIndex = 12;
            this.lblHomePhone.Text = "Home Phone";
            // 
            // lblCellPhone
            // 
            this.lblCellPhone.AutoSize = true;
            this.lblCellPhone.Location = new System.Drawing.Point(197, 94);
            this.lblCellPhone.Name = "lblCellPhone";
            this.lblCellPhone.Size = new System.Drawing.Size(58, 13);
            this.lblCellPhone.TabIndex = 14;
            this.lblCellPhone.Text = "Cell Phone";
            // 
            // mskCellPhone
            // 
            this.mskCellPhone.Location = new System.Drawing.Point(260, 88);
            this.mskCellPhone.Mask = "(999) 000-0000";
            this.mskCellPhone.Name = "mskCellPhone";
            this.mskCellPhone.Size = new System.Drawing.Size(87, 20);
            this.mskCellPhone.TabIndex = 7;
            this.mskCellPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblWorkPhone
            // 
            this.lblWorkPhone.AutoSize = true;
            this.lblWorkPhone.Location = new System.Drawing.Point(373, 94);
            this.lblWorkPhone.Name = "lblWorkPhone";
            this.lblWorkPhone.Size = new System.Drawing.Size(67, 13);
            this.lblWorkPhone.TabIndex = 16;
            this.lblWorkPhone.Text = "Work Phone";
            // 
            // mskWorkPhone
            // 
            this.mskWorkPhone.Location = new System.Drawing.Point(446, 91);
            this.mskWorkPhone.Mask = "(999) 000-0000";
            this.mskWorkPhone.Name = "mskWorkPhone";
            this.mskWorkPhone.Size = new System.Drawing.Size(87, 20);
            this.mskWorkPhone.TabIndex = 8;
            this.mskWorkPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblWorkPhoneExt
            // 
            this.lblWorkPhoneExt.AutoSize = true;
            this.lblWorkPhoneExt.Location = new System.Drawing.Point(539, 94);
            this.lblWorkPhoneExt.Name = "lblWorkPhoneExt";
            this.lblWorkPhoneExt.Size = new System.Drawing.Size(21, 13);
            this.lblWorkPhoneExt.TabIndex = 17;
            this.lblWorkPhoneExt.Text = "ext";
            // 
            // mskWorkPhoneExt
            // 
            this.mskWorkPhoneExt.Location = new System.Drawing.Point(566, 91);
            this.mskWorkPhoneExt.Mask = "99999";
            this.mskWorkPhoneExt.Name = "mskWorkPhoneExt";
            this.mskWorkPhoneExt.Size = new System.Drawing.Size(49, 20);
            this.mskWorkPhoneExt.TabIndex = 9;
            this.mskWorkPhoneExt.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(37, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(88, 114);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(339, 20);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Enter += new System.EventHandler(this.txt_Enter);

            // 
            // cboOrganization
            // 
            this.cboOrganization.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboOrganization.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboOrganization.DisplayMember = "ItemDisplay";
            this.cboOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOrganization.FormattingEnabled = true;
            this.cboOrganization.Location = new System.Drawing.Point(88, 140);
            this.cboOrganization.Name = "cboOrganization";
            this.cboOrganization.Size = new System.Drawing.Size(339, 21);
            this.cboOrganization.TabIndex = 11;
            this.cboOrganization.ValueMember = "ItemValue";
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(448, 142);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(104, 17);
            this.chkActive.TabIndex = 12;
            this.chkActive.Text = "Active Volunteer";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(26, 203);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(56, 13);
            this.lblComments.TabIndex = 23;
            this.lblComments.Text = "Comments";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(88, 200);
            this.txtComments.MaxLength = 500;
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComments.Size = new System.Drawing.Size(527, 124);
            this.txtComments.TabIndex = 14;
            // 
            // epr1
            // 
            this.epr1.ContainerControl = this;
            // 
            // cboPositionType
            // 
            this.cboPositionType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboPositionType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPositionType.DisplayMember = "ItemDisplay";
            this.cboPositionType.FormattingEnabled = true;
            this.cboPositionType.Location = new System.Drawing.Point(88, 168);
            this.cboPositionType.Name = "cboPositionType";
            this.cboPositionType.Size = new System.Drawing.Size(339, 21);
            this.cboPositionType.TabIndex = 13;
            this.cboPositionType.ValueMember = "ItemValue";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(38, 171);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(44, 13);
            this.lblPosition.TabIndex = 26;
            this.lblPosition.Text = "Position";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(539, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(446, 331);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmVolunteer
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(632, 380);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.cboPositionType);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.cboOrganization);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.mskWorkPhoneExt);
            this.Controls.Add(this.lblWorkPhoneExt);
            this.Controls.Add(this.lblWorkPhone);
            this.Controls.Add(this.mskWorkPhone);
            this.Controls.Add(this.lblCellPhone);
            this.Controls.Add(this.mskCellPhone);
            this.Controls.Add(this.lblHomePhone);
            this.Controls.Add(this.mskHomePhone);
            this.Controls.Add(this.mskZip);
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblCSZ);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblOrganization);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVolunteer";
            this.Text = "Edit Volunteer";
            this.Load += new System.EventHandler(this.frmVolunteer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epr1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrganization;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblCSZ;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.MaskedTextBox mskZip;
        private System.Windows.Forms.MaskedTextBox mskHomePhone;
        private System.Windows.Forms.Label lblHomePhone;
        private System.Windows.Forms.Label lblCellPhone;
        private System.Windows.Forms.MaskedTextBox mskCellPhone;
        private System.Windows.Forms.Label lblWorkPhone;
        private System.Windows.Forms.MaskedTextBox mskWorkPhone;
        private System.Windows.Forms.Label lblWorkPhoneExt;
        private System.Windows.Forms.MaskedTextBox mskWorkPhoneExt;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cboOrganization;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.ErrorProvider epr1;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ComboBox cboPositionType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}