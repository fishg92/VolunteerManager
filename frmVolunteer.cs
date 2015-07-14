using System;
using System.Windows.Forms;

namespace VolunteerManager
{
    public partial class frmVolunteer : Form
    {
        private int _pkVolunteer;

        public frmVolunteer(int ppkVolunteer)
        {
            InitializeComponent();
            FillCombos();
            pkVolunteer = ppkVolunteer;
            if (ppkVolunteer != -1)
                FillData();
        }

        public void setPkOrganization(int ppkOrganization)
        {
            if (ppkOrganization != -1)
            {
                CommonFunctions.SetComboBoxValue(cboOrganization, ppkOrganization);
            }
        }
        private void FillData()
        { 
            string firstName;
            string lastName;
            string address;
            string city;
            string state;
            string zip;
            string homePhone;
            string workPhone;
            string workPhoneExt;
            string cellPhone;
            string email;
            bool active;
            string comments;
            int fkOrganization;
            int fkrefPositionType;

            VmData.GetVolunteerData(
                _pkVolunteer
                , out firstName
                , out  lastName
                , out  address
                , out  city
                , out  state
                , out  zip
                , out  homePhone
                , out  workPhone
                , out  workPhoneExt
                , out  cellPhone
                , out  email
                , out  active
                , out  comments
                , out  fkOrganization
                , out  fkrefPositionType);

            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            txtAddress.Text = address;
            txtCity.Text = city;

            for (int i = 0; i < cboState.Items.Count; i++)
            {
                if ((string)cboState.Items[i] == state)
                {
                    cboState.SelectedIndex = i;
                    break;
                }
            }

            cboState.Text = state;
            mskZip.Text = zip;
            mskHomePhone.Text = homePhone;
            mskWorkPhone.Text = workPhone;
            mskWorkPhoneExt.Text = workPhoneExt;
            txtEmail.Text = email;
            chkActive.Checked = active;
            CommonFunctions.SetComboBoxValue(cboOrganization, fkOrganization);
            CommonFunctions.SetComboBoxValue(cboPositionType, fkrefPositionType);




        }
        public bool SaveData()
        {
            bool retVal;

            if (string.Equals(txtFirstName.Text.Trim(), txtFirstName.Text.Trim().ToLower(), StringComparison.CurrentCulture))
            {
                txtFirstName.Text = txtFirstName.Text.Substring(0, 1).ToUpper() + txtFirstName.Text.Trim().Substring(1);
            }

            if (string.Equals(txtLastName.Text.Trim(), txtLastName.Text.Trim().ToLower(), StringComparison.CurrentCulture))
            {
                txtLastName.Text = txtLastName.Text.Substring(0, 1).ToUpper() + txtLastName.Text.Trim().Substring(1);
            }

            if (ValidateData())
            {
                _pkVolunteer = VmData.SaveVolunteer(
                    pkVolunteer
                    , txtFirstName.Text.Trim()
                    , txtLastName.Text.Trim()
                    , txtAddress.Text.Trim()
                    , txtCity.Text.Trim()
                    , (string)cboState.SelectedItem
                    , mskZip.Text
                    , mskHomePhone.Text
                    , mskWorkPhone.Text
                    , mskWorkPhoneExt.Text
                    , mskCellPhone.Text
                    , txtEmail.Text.Trim()
                    , chkActive.Checked
                    , txtComments.Text.Trim()
                    , CommonFunctions.ComboBoxSelectedIntValue(cboOrganization)
                    , CommonFunctions.ComboBoxSelectedIntValue(cboPositionType));
                retVal = true;
            }
            else
                retVal = false;

            return retVal;
        }

        private bool ValidateData()
        {
            bool retVal = true;

            epr1.Clear();

            if (txtFirstName.Text.Trim().Length == 0)
            {
                epr1.SetError(txtFirstName, "First name cannot be blank");
                retVal = false;
            }

            if (txtLastName.Text.Trim().Length == 0)
            {
                epr1.SetError(txtLastName, "Last name cannot be blank");
                retVal = false;
            }

            if (cboPositionType.SelectedIndex == -1)
            {
                epr1.SetError(cboPositionType, "Please select position type");
                retVal = false;
            }

            if (cboOrganization.SelectedIndex == 0)
            {
                epr1.SetError(cboOrganization, "Please select an organization");
                retVal = false;
            }
            return retVal;
        }

        private void FillCombos()
        {
            cboOrganization.DataSource = CommonFunctions.ComboItemList(VmData.OrganizationList(true, ""), "pkOrganization", "OrganizationName");
            cboPositionType.DataSource = CommonFunctions.ComboItemList(VmData.PositionTypeList(true), "pkrefPositionType", "Description");
        }

        public int pkVolunteer
        {
            get
            {
                return _pkVolunteer;
            }
            set
            {
                _pkVolunteer = value;
                if (_pkVolunteer == -1)
                {
                    Text = "Add new volunteer";
                    //set defaults

                    for (int i = 0; i < cboState.Items.Count; i++)
                    {
                        if ((string)cboState.Items[i] == "OH")
                        {
                            cboState.SelectedIndex = i;
                            break;
                        }
                    }

                    CommonFunctions.SetComboBoxValue(cboPositionType, 1);
                    chkActive.Checked = true;
                }
            }
        }

        private void frmVolunteer_Load(object sender, EventArgs e)
        {
            // FillCombos();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (SaveData())
            {
                DialogResult = DialogResult.OK;
                Hide();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.SelectAll();
        }

   

    }
}
