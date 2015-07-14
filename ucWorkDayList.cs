using System;
using System.Data;
using System.Windows.Forms;

namespace VolunteerManager
{
    public partial class ucWorkDayList : UserControl
    {
        public ucWorkDayList()
        {
            InitializeComponent();
            FillProjectList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmWorkDay fDay = new frmWorkDay(-1);
            fDay.ShowDialog();
            cboProject_SelectedIndexChanged(null, null);
        }

        private void FillProjectList()
        {
            cboProject.DataSource = VmData.ProjectList().Tables[0];
            cboProject.SelectedIndex = 0;
        }

        private void cboProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal totalHours;
            DataSet ds = VmData.GetWorkDays((int)cboProject.SelectedValue, out totalHours);
            dgvWorkDay.DataSource=ds.Tables[0];
            lblTotalProjectHours.Text = "Total Project Hours: " + totalHours.ToString("#,##0.00");
        }

        private void dgvWorkDay_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int pkWorkDay = (int)dgvWorkDay.Rows[e.RowIndex].Cells["colpkWorkDay"].Value;

            //Change description
            if (e.ColumnIndex == dgvWorkDay.Columns["colDescription"].Index)
            {
                VmData.SaveWorkDay(pkWorkDay, dgvWorkDay.Rows[e.RowIndex].Cells["colDescription"].Value.ToString());
            }
            //Change date
            else if (e.ColumnIndex == dgvWorkDay.Columns["colWorkDate"].Index)
            {
                string sWorkDate = (string)dgvWorkDay.Rows[e.RowIndex].Cells["colWorkDate"].Value;
                DateTime dWorkDate;
                if (DateTime.TryParse(sWorkDate, out dWorkDate))
                {
                    VmData.SaveWorkDay(pkWorkDay, dWorkDate);
                }
                else
                {
                    MessageBox.Show("Invalid date entered", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboProject_SelectedIndexChanged(null, null);
                }
            }
        }

        private void EditWorkDay(int pkWorkDay)
        {
            frmWorkDay fDay = new frmWorkDay(pkWorkDay);
            fDay.ShowDialog();
            cboProject_SelectedIndexChanged(null, null);

        }

        private void mnuAddWorkDay_Click(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
        }

        private void mnuEditWorkDay_Click(object sender, EventArgs e)
        {
            if (dgvWorkDay.SelectedRows.Count > 0)
            {
                int pkWorkDay = (int)dgvWorkDay.SelectedRows[0].Cells["colpkWorkDay"].Value;
                EditWorkDay(pkWorkDay);
            }
        }

        private void mnuDeleteWorkDay_Click(object sender, EventArgs e)
        {
            if (dgvWorkDay.SelectedRows.Count > 0)
            {
                int pkWorkDay = (int)dgvWorkDay.SelectedRows[0].Cells["colpkWorkDay"].Value;
                string sWorkDate = (string)dgvWorkDay.SelectedRows[0].Cells["colWorkDate"].Value;
                if (MessageBox.Show("Are you sure that you want to delete " + sWorkDate + " as a work day?", "Work day confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    VmData.DeleteWorkDay(pkWorkDay);
                    cboProject_SelectedIndexChanged(null, null);
                }
            }

            
        }

        private void dgvWorkDay_DoubleClick(object sender, EventArgs e)
        {
            if (dgvWorkDay.SelectedRows.Count > 0)
            {
                int pkWorkDay = (int)dgvWorkDay.SelectedRows[0].Cells["colpkWorkDay"].Value;
                EditWorkDay(pkWorkDay);
            }

        }

       
    }
}
