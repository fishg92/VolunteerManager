using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
//using CrystalDecisions.CrystalReports.Engine;

namespace VolunteerManager
{
    public partial class frmWorkDay : Form
    {
        int _pkWorkDay;
        DataSet _dsAvailable;
        bool _fillingOrganizations = true;
        int _targetSelectedPk = -1;

        public frmWorkDay(int ppkWorkDay)
        {
            InitializeComponent();
            FillData(ppkWorkDay);

        }

        private void FillData(int ppkWorkDay)
        {
            _pkWorkDay = ppkWorkDay;
            FillProjectList();
            FillOrganizationList();

            if (_pkWorkDay == -1)
            {
                WorkDate = DateTime.Today;

            }
            else
            {
                FillWorkDayDetails();
            }
            FillSelectedVolunteerList();
            FillAvailableVolunteerList();

        }

        private void FillWorkDayDetails()
        {
            int project;
            DateTime dWorkDate;
            string workDesc;
            string comments;
            int lunchfkOrganization;

            VmData.GetWorkDayDetails(_pkWorkDay, out project, out dWorkDate, out workDesc, out comments, out lunchfkOrganization);
            WorkDate = dWorkDate;
            fkBuildProject = project;
            WorkDescription = workDesc;
            Comments = comments;
            LunchfkOrganization = lunchfkOrganization;
        }

        private void FillProjectList()
        {
            cboProject.DataSource = CommonFunctions.ComboItemList(VmData.ProjectList(), "pkBuildProject", "ProjectName");
        }

        private void FillOrganizationList()
        {
            cboOrganization.DataSource = CommonFunctions.ComboItemList(VmData.OrganizationList(true, "All"), "pkOrganization", "OrganizationName");
            _fillingOrganizations = false;

            cboLunch.DataSource = CommonFunctions.ComboItemList(VmData.OrganizationList(true, ""), "pkOrganization", "OrganizationName");
        }

        private void FillAvailableVolunteerList()
        {
            txtFilter.Text = "";
            _dsAvailable = VmData.WorkDayAvailableVolunteers(_pkWorkDay, CommonFunctions.ComboBoxSelectedIntValue(cboOrganization));
            dgvAvailableVolunteer.DataSource = _dsAvailable.Tables[0].DefaultView ;
        }

        private void FillSelectedVolunteerList()
        {
            int firstVisible = -1;
            if (dgvSelectedVolunteers.Rows.Count > 0)
            {
                firstVisible = dgvSelectedVolunteers.FirstDisplayedScrollingRowIndex;
            }

            DataSet dsSelected = VmData.WorkDaySelectedVolunteers(_pkWorkDay, CommonFunctions.ComboBoxSelectedIntValue(cboOrganization));
            dgvSelectedVolunteers.DataSource = dsSelected.Tables[0];

            //If we have a target row, select only that one
            //and ensure that it is visible
            if (_targetSelectedPk != -1)
            {
                DataGridViewRow targetRow = null;

                foreach (DataGridViewRow dr in dgvSelectedVolunteers.Rows)
                {
                    int currentPk = (int)dr.Cells["colpkVolunteerSelected"].Value;

                    if (currentPk == _targetSelectedPk)
                    {
                        targetRow = dr;
                        break;
                    }
                }

                if (targetRow != null)
                {
                    dgvSelectedVolunteers.MultiSelect = false;
                    dgvSelectedVolunteers.MultiSelect = true;
                    targetRow.Selected = true;
                    if (targetRow.Displayed == false)
                    {
                        dgvSelectedVolunteers.FirstDisplayedScrollingRowIndex = targetRow.Index;
                    }
                }
            }
            else
            {
                if (firstVisible != -1 && firstVisible < dgvSelectedVolunteers.Rows.Count)
                {
                    dgvSelectedVolunteers.FirstDisplayedScrollingRowIndex = firstVisible;
                }
            }

            _targetSelectedPk = -1;

            decimal totalActualHours = 0;
            
            foreach (DataRow dr in dsSelected.Tables[0].Rows)
            {
                totalActualHours += (decimal)dr["ActualHours"];
            }

            lblTotalActualHours.Text = "Total Actual Hours: " + totalActualHours.ToString("0.00");
            lblVolunteerCount.Text = "Volunteers: " + dsSelected.Tables[0].Rows.Count;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_pkWorkDay == -1)
            {
                _pkWorkDay = VmData.SaveWorkDay(_pkWorkDay, fkBuildProject, WorkDate, "", "", LunchfkOrganization);
            }

            List<int> removeList = new List<int>();
            foreach (DataGridViewRow row in dgvAvailableVolunteer.SelectedRows)
            {
                removeList.Add((int)row.Cells["colpkVolunteerAvailable"].Value);
                dgvAvailableVolunteer.Rows.Remove(row);
            }

            foreach (int pkVolunteer in removeList)
            {
                VmData.AddVolunteerWorkDay(_pkWorkDay, pkVolunteer);
                _targetSelectedPk = pkVolunteer;
            }

            //this.FillAvailableVolunteerList();
            FillSelectedVolunteerList();


            dgvSelectedVolunteers.Focus();

            //For volunteers added after the work date has passed,
            //show the individual form to set hours
            if (DateTime.Now > WorkDate && removeList.Count==1 )
            {
                EditSelectedVolunteer(removeList[0]);
            }

            if (txtFilter.Text.Trim().Length > 0)
            {
                txtFilter.Text = "";
                txtFilter.Focus();
            }

        }


        private void btnNewVolunteer_Click(object sender, EventArgs e)
        {
            frmVolunteer fVol = new frmVolunteer(-1);
            if (cboOrganization.SelectedIndex > 0)
            {
                fVol.setPkOrganization(CommonFunctions.ComboBoxSelectedIntValue(cboOrganization));
            }

            if (fVol.ShowDialog() == DialogResult.OK)
            {
                if (_pkWorkDay == -1)
                {
                    _pkWorkDay = VmData.SaveWorkDay(_pkWorkDay, (int)cboProject.SelectedValue, WorkDate, "", "", LunchfkOrganization);
                }

                VmData.AddVolunteerWorkDay(_pkWorkDay, fVol.pkVolunteer);

                FillAvailableVolunteerList();
                FillSelectedVolunteerList();

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (_pkWorkDay == -1)
            {
                _pkWorkDay = VmData.SaveWorkDay(_pkWorkDay, (int)cboProject.SelectedValue, WorkDate, "", "",LunchfkOrganization);
            }

            List<int> removeList = new List<int>();
            foreach (DataGridViewRow row in dgvSelectedVolunteers.SelectedRows)
            {
                removeList.Add((int)row.Cells["colpkVolunteerSelected"].Value);
            }

            foreach (int pkVolunteer in removeList)
            {
                VmData.DeleteVolunteerWorkDay(_pkWorkDay, pkVolunteer);
            }

            FillAvailableVolunteerList();
            FillSelectedVolunteerList();
        }

        private void dgvSelectedVolunteers_DoubleClick(object sender, EventArgs e)
        {
            if (dgvSelectedVolunteers.SelectedRows.Count > 0)
            {
                int pkVolunteer = (int)dgvSelectedVolunteers.SelectedRows[0].Cells["colpkVolunteerSelected"].Value;

                EditSelectedVolunteer(pkVolunteer);
            }
        }

        private void EditSelectedVolunteer(int pkVolunteer)
        {
            _targetSelectedPk = pkVolunteer;
            frmVolunteerWorkDay fVolDay = new frmVolunteerWorkDay(_pkWorkDay, pkVolunteer);
            if (fVolDay.ShowDialog() == DialogResult.OK)
            {
                FillSelectedVolunteerList();
            }
        }

        public DateTime WorkDate
        {
            get
            {
                return dtpDate.Value;
            }
            set
            {
                dtpDate.Value = value;
            }
        }

        public int fkBuildProject
        {
            get
            {
                return Convert.ToInt32(cboProject.SelectedValue);
            }
            set
            {
                CommonFunctions.SetComboBoxValue(cboProject, value);
            }
        }

        public int LunchfkOrganization
        {
            get
            {
                return Convert.ToInt32(cboLunch.SelectedValue);
            }
            set
            {
                CommonFunctions.SetComboBoxValue(cboLunch, value);
            }
        }

        public string WorkDescription
        {
            get
            {
                return txtWorkDescription.Text.Trim();
            }
            set
            {
                txtWorkDescription.Text = value;
            }
        }

        public string Comments
        {
            get
            {
                return txtComments.Text.Trim();
            }
            set
            {
                txtComments.Text = value;
            }
        }

        private void dgvAvailableVolunteer_DoubleClick(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
        }

        private void frmWorkDay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ValidateWorkHours())
            {
                e.Cancel = true;
                return;
            }
            //Save value before closing
            //Don't save a blank work day
            if (_pkWorkDay != -1 || txtComments.Text.Trim().Length >0)
            {
                VmData.SaveWorkDay(_pkWorkDay, fkBuildProject, WorkDate, WorkDescription, Comments,LunchfkOrganization);
            }
        }

        private bool ValidateWorkHours()
        {
            bool retVal = true;
            foreach (DataGridViewRow row in dgvSelectedVolunteers.Rows)
            {
                if (row.Cells["colActual"].Value.ToString() == "" &&  (bool)row.Cells["colNoShow"].Value == false)
                {
                    retVal = false;
                    MessageBox.Show("Volunteers must have actual hours entered or be marked No Show");
                    row.Selected = true;
                }

            }
            return retVal;
        }

        private void mnuAddSelectedVolunteers_Click(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
        }

        private void mnuEditVolunteer_Click(object sender, EventArgs e)
        {
            if (dgvAvailableVolunteer.SelectedRows.Count > 0)
            {
                int pkVolunteer = (int)dgvAvailableVolunteer.SelectedRows[0].Cells["colpkVolunteerAvailable"].Value;
                frmVolunteer fVol = new frmVolunteer(pkVolunteer);
                fVol.ShowDialog();
            }
        }

        private void mnuRemoveVolunteer_Click(object sender, EventArgs e)
        {
            btnRemove.PerformClick();
        }

        private void mnuEditVolunteerSelected_Click(object sender, EventArgs e)
        {
            if (dgvSelectedVolunteers.SelectedRows.Count > 0)
            {
                int pkVolunteer = (int)dgvSelectedVolunteers.SelectedRows[0].Cells["colpkVolunteerSelected"].Value;
                frmVolunteer fVol = new frmVolunteer(pkVolunteer);
                fVol.ShowDialog();
            }
        }

        private void mnuMultiSetTime_Click(object sender, EventArgs e)
        {
            if (dgvSelectedVolunteers.SelectedRows.Count > 0)
            {
                frmMultiSetTime fMulti = new frmMultiSetTime(WorkDate);
                if (fMulti.ShowDialog() == DialogResult.OK)
                {
                    foreach (DataGridViewRow dr in dgvSelectedVolunteers.SelectedRows)
                    {
                        int pkVolunteer = (int)dr.Cells["colpkVolunteerSelected"].Value;
                        VmData.SetActualHours(pkVolunteer, _pkWorkDay, fMulti.ActualStartTime, fMulti.ActualEndTime);

                    }
                    FillSelectedVolunteerList();

                }
                else
                {
                    MessageBox.Show(fMulti.DialogResult.ToString());
                }
            }
        }

        private void dgvAvailableVolunteer_KeyPress(object sender, KeyPressEventArgs e)
        {
            string letterPressed = e.KeyChar.ToString().ToLower();

            foreach (DataGridViewRow row in dgvAvailableVolunteer.SelectedRows)
            {
                row.Selected = false;
            }

            foreach (DataGridViewRow row in dgvAvailableVolunteer.Rows)
            {
                if (row.Cells["colVolunteerNameAvailable"].Value.ToString().ToLower().StartsWith(letterPressed))
                {
                    row.Selected = true;
                    dgvAvailableVolunteer.FirstDisplayedCell = row.Cells["colVolunteerNameAvailable"];
                    break;
                }
            }
        }

        private void cboOrganization_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_fillingOrganizations)
            {
                FillAvailableVolunteerList();
                FillSelectedVolunteerList();
            }

        }

        private void btnChangeProject_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to assign this day to a different project?\r\n\r\nThis is a rather unusual change to make, and making it accidentally could result in a loss of data.", "Confirm project change", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                cboProject.Enabled = true;
            }
        }


        private void dgvSelectedVolunteers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (dgvSelectedVolunteers.SelectedRows.Count == 1)
                {
                    int pkVolunteer = (int)dgvSelectedVolunteers.SelectedRows[0].Cells["colpkVolunteerSelected"].Value;
                    _targetSelectedPk = pkVolunteer;
                    frmVolunteerWorkDay fVolDay = new frmVolunteerWorkDay(_pkWorkDay, pkVolunteer);
                    if (fVolDay.ShowDialog() == DialogResult.OK)
                    {
                        FillSelectedVolunteerList();
                    }
                }

            }
        }

        private void dgvAvailableVolunteer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter && dgvAvailableVolunteer.SelectedRows.Count==1)
            {
                btnAdd.PerformClick();
            }
        }

        private void dtpDate_Validating(object sender, CancelEventArgs e)
        {

            int dupWorkDay = VmData.DuplicateWorkDayExists(_pkWorkDay, WorkDate);
            if (dupWorkDay != -1)
            {
                if (MessageBox.Show("There is already another work day record for " + WorkDate.ToShortDateString() + " Do you want to edit the other work day record instead?", "Duplicate work day warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    FillData(dupWorkDay);
                }
            }

        }

        private void btnUpdateEmail_Click(object sender, EventArgs e)
        {


        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            lblWeekday.Text = dtpDate.Value.ToString("dddd");
        }

        private void txtFilter_Enter(object sender, EventArgs e)
        {
            txtFilter.SelectAll();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            DataView dv = (DataView)dgvAvailableVolunteer.DataSource;
            dv.RowFilter = "Name like '" + txtFilter.Text.Trim() + "%'";
            dgvAvailableVolunteer.DataSource = dv;
        }

    }
}
