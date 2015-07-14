using System;
using System.Windows.Forms;

namespace VolunteerManager
{
    public partial class frmLogin : Form
    {
        int _loginTries;

        public frmLogin()
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings["BypassSecurity"])
                && System.Configuration.ConfigurationManager.AppSettings["BypassSecurity"] == "true")
            {
                txtCode.Text = @"*snz322!";
            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (txtCode.Text == @"*snz322!")
            {
                DialogResult = DialogResult.OK;
                Hide();
            }
            else
            {
                _loginTries += 1;

                if (_loginTries < 3)
                {

                    lblWrongCode.Text = "Incorrect code entered (attempt " + _loginTries.ToString() + " of 3)";
                    lblWrongCode.Visible = true;
                    txtCode.SelectAll();
                    txtCode.Focus();
                }
                else
                {
                    MessageBox.Show("Too many attempts. Closing application");
                    DialogResult = DialogResult.Cancel;
                    Hide();
                }

 
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Hide();
        }
    }
}
