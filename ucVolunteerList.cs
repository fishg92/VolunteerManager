using System;
using System.Windows.Forms;

namespace VolunteerManager
{
    public partial class ucVolunteerList : UserControl
    {
        private bool _filling = true;

        public ucVolunteerList()
        {
            InitializeComponent();
            FillOrganizations();
            FillProjects();
            cboOrganization.SelectedIndex = 0;
            cboProject.SelectedIndex = 0;
            _filling = false;
            FillData();
        }

        private void FillOrganizations()
        {
            cboOrganization.DataSource = VmData.OrganizationList(true,"All").Tables[0];
        }

        private void FillProjects()
        {
            cboProject.DataSource = VmData.ProjectList(true);
        }

        public void FillData()
        {
            dgvVolunteer.DataSource = VmData.VolunteerList(pkOrganization, pkBuildProject, chkActive.Checked).Tables[0];
        }

        private int pkOrganization
        {
            get
            {
                return (int)cboOrganization.SelectedValue;
            }
        }

        private int pkBuildProject
        {
            get
            {

                return (int)cboProject.SelectedValue;
            }
        }

        private void cboOrganization_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!_filling)
                FillData();
        }

        private void dgvVolunteer_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvVolunteer.SelectedRows.Count == 1)
            {
                mnuDeleteVolunteer.Available = true;
                mnuEditVolunteer.Available = true;
            }
            else
            {
                mnuDeleteVolunteer.Available = false;
                mnuEditVolunteer.Available = false;
            }

            if (dgvVolunteer.SelectedRows.Count == 2)
            {
                mnuCombineVolunteers.Available = true;
            }
            else
            {
                mnuCombineVolunteers.Available = false;
            }
        }

        private void mnuDeleteVolunteer_Click(object sender, EventArgs e)
        {
            int pkVolunteer = (int)dgvVolunteer.SelectedRows[0].Cells["colpkVolunteer"].Value;
            string lastName = (string)dgvVolunteer.SelectedRows[0].Cells["colLastName"].Value;
            string firstName = (string)dgvVolunteer.SelectedRows[0].Cells["colFirstName"].Value;

            int ProjectCount;
            int WorkDayCount;
            decimal TotalHours;
            string message;

            VmData.VolunteerHourSummary(pkVolunteer, out ProjectCount, out WorkDayCount, out TotalHours);

            if (TotalHours > 0)
            {
                message = "You cannot delete " + firstName + " " + lastName + " until all work records are first deleted." +
                    "\r\n\r\nThis volunteer has the following work recorded in the system:" +
                    "\r\nWork Days: " + WorkDayCount +
                    "\r\nHours: " + TotalHours;
                MessageBox.Show(message, "Volunteer delete not allowed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            message = "Are you sure that you want to delete all volunteer records for " + firstName + " " + lastName + "?"
                    + "\r\n\r\n" + "This deletion will be permanent, and all records will be erased.";
            if (MessageBox.Show(message, "Volunteer Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                VmData.VolunteerDelete(pkVolunteer);
                MessageBox.Show(firstName + " " + lastName + " deleted");
                FillData();
            }

        }

        private void mnuAddVolunteer_Click(object sender, EventArgs e)
        {
            frmVolunteer fVol = new frmVolunteer(-1);
            if (fVol.ShowDialog() == DialogResult.OK)
            {
                FillData();
            }
        }

        private void mnuEditVolunteer_Click(object sender, EventArgs e)
        {
            int pkVolunteer = (int)dgvVolunteer.SelectedRows[0].Cells["colpkVolunteer"].Value;
            frmVolunteer fVol = new frmVolunteer(pkVolunteer);
            if (fVol.ShowDialog() == DialogResult.OK)
            {
                FillData();
            }

        }

        private void dgvVolunteer_DoubleClick(object sender, EventArgs e)
        {
            mnuEditVolunteer_Click(null, null);
        }

        private void mnuCombineVolunteers_Click(object sender, EventArgs e)
        {
            int pkVolunteer1 = (int)dgvVolunteer.SelectedRows[0].Cells["colpkVolunteer"].Value;
            string lastName1 = (string)dgvVolunteer.SelectedRows[0].Cells["colLastName"].Value;
            string firstName1 = (string)dgvVolunteer.SelectedRows[0].Cells["colFirstName"].Value;
            string organization1 = (string)dgvVolunteer.SelectedRows[0].Cells["colOrganizationName"].Value;

            int pkVolunteer2 = (int)dgvVolunteer.SelectedRows[1].Cells["colpkVolunteer"].Value;
            string lastName2 = (string)dgvVolunteer.SelectedRows[1].Cells["colLastName"].Value;
            string firstName2 = (string)dgvVolunteer.SelectedRows[1].Cells["colFirstName"].Value;
            string organization2 = (string)dgvVolunteer.SelectedRows[1].Cells["colOrganizationName"].Value;

            string message = "Are you sure that you want to combine the records for the following volunteers?" +
                "\n\r\n\r" + firstName1 + " " + lastName1 + " (" + organization1 + ")" +
                "\n\r" + firstName2 + " " + lastName2 + " (" + organization2 + ")" +
                "\n\r\n\r" + "This change is permanent and cannot be reversed!";

            if (MessageBox.Show(message, "Confirm combine volunteers", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                VmData.CombineVolunteers(pkVolunteer1, pkVolunteer2);
                FillData();
            }

        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            FillData();
        }

        private void chkDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            gbxDateRange.Visible = chkDateFilter.Checked;
        }

        private void cboProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_filling)
                FillData();

        }
    }
}
