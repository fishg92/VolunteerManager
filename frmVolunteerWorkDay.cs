using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace VolunteerManager
{
    public partial class frmVolunteerWorkDay : Form
    {
        private int _pkWorkDay;
        private int _pkVolunteer;
        //private DateTime _ProjectedStartTime;
        //private DateTime _ProjectedEndTime;
        //private DateTime _ActualStartTime;
        //private DateTime _ActualEndTime;
        private DateTime _baseDate;

        public frmVolunteerWorkDay(int ppkWorkDay, int ppkVolunteer)
        {
            InitializeComponent();

            _pkVolunteer = ppkVolunteer;
            _pkWorkDay = ppkWorkDay;
            lblActualCalculated.Text = "";
            
            FillData();
        }

        private void FillData()
        {
            DateTime actualStartTime;
            DateTime actualEndTime;
            DateTime projectedStartTime;
            DateTime projectedEndTime;
            string volunteerName;
            string organizationName;
            bool noShow;
            string comments;

            VmData.GetVolunteerWorkDay(
                _pkVolunteer
                , _pkWorkDay
                , out actualStartTime
                , out actualEndTime
                , out projectedStartTime
                , out projectedEndTime
                , out comments
                , out noShow
                , out _baseDate
                , out volunteerName
                , out organizationName);

            CommonFunctions.FillTimeComboBoxItems(cboProjectedStart, _baseDate);
            CommonFunctions.FillTimeComboBoxItems(cboProjectedEnd, _baseDate);
            CommonFunctions.FillTimeComboBoxItems(cboActualStart, _baseDate);
            CommonFunctions.FillTimeComboBoxItems(cboActualEnd, _baseDate);

            ProjectedStartTime = projectedStartTime;
            ProjectedEndTime = projectedEndTime;
            ActualStartTime = actualStartTime;
            ActualEndTime = actualEndTime;

            lblVolunteer.Text = "Volunteer: " + volunteerName + " (" + organizationName + ")";
            NoShow = noShow;
        
        
        }

        public bool NoShow
        {
            get
            {
                return chkNoShow.Checked;
            }
            set
            {
                chkNoShow.Checked = value;
                if (value)
                {
                    cboActualEnd.SelectedIndex = -1;
                    cboActualEnd.Enabled = false;
                    cboActualStart.SelectedIndex = -1;
                    cboActualStart.Enabled = false;
                    btnCopyToActual.Enabled = false;
                }
                else
                {
                    cboActualStart.Enabled = true;
                    cboActualEnd.Enabled = true;
                    btnCopyToActual.Enabled = true;
                }
            }
        }

        public DateTime ProjectedStartTime
        {
            get
            {
                if (cboProjectedStart.SelectedIndex == -1)
                    return DateTime.MinValue;
                return ((TimeComboValueItem)cboProjectedStart.SelectedItem).DateValue;
            }
            set
            {
                CommonFunctions.SetTimeComboBox(cboProjectedStart, value);
            }
        }

        public DateTime ProjectedEndTime
        {
            get
            {
                if (cboProjectedEnd.SelectedIndex == -1)
                    return DateTime.MinValue;
                return ((TimeComboValueItem)cboProjectedEnd.SelectedItem).DateValue;
            }
            set
            {
                CommonFunctions.SetTimeComboBox(cboProjectedEnd, value);
            }
        }

        public DateTime ActualStartTime
        {
            get
            {
                if (cboActualStart.SelectedIndex == -1)
                    return DateTime.MinValue;
                return ((TimeComboValueItem)cboActualStart.SelectedItem).DateValue;
            }
            set
            {
                CommonFunctions.SetTimeComboBox(cboActualStart, value);
            }
        }

        public DateTime ActualEndTime
        {
            get
            {
                if (cboActualEnd.SelectedIndex == -1)
                    return DateTime.MinValue;
                return ((TimeComboValueItem)cboActualEnd.SelectedItem).DateValue;
            }
            set
            {
                CommonFunctions.SetTimeComboBox(cboActualEnd, value);
            }
        }

        public string Comments
        {
            get
            {
                return txtComments.Text.Trim();
            }
        }

        private void cboActualStart_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateActualHours();
        }

        private void cboActualEnd_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateActualHours();
        }

        private void CalculateActualHours()
        {
            if (cboActualStart.SelectedIndex > -1 && cboActualEnd.SelectedIndex > -1)
            {
                if (ActualHours < 0)
                    lblActualCalculated.Text = "End time must be after start time";
                else
                    lblActualCalculated.Text = ActualHours.ToString("0.00") + " hours";

            }
            else
            {
                lblActualCalculated.Text = "";
            }
        }

        private double ActualHours
        {
            get
            {
                double totalHours = ActualEndTime.Subtract(ActualStartTime).TotalHours;
                return totalHours;

            }
        }

        private void btnCopyToActual_Click(object sender, EventArgs e)
        {
            ActualStartTime = ProjectedStartTime;
            ActualEndTime = ProjectedEndTime;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                SaveData();
                DialogResult = DialogResult.OK;
                Hide();
            }

        }

        private void SaveData()
        {
            VmData.SaveVolunteerWorkDay(
                _pkWorkDay
                , _pkVolunteer
                , ProjectedStartTime
                , ProjectedEndTime
                , ActualStartTime
                , ActualEndTime
                , Comments
                , NoShow);
        }

        private bool ValidateData()
        {
            bool retVal = true;
            epr.Clear();

            //Validate projected times
            if (ProjectedEndTime.Subtract(ProjectedStartTime).TotalSeconds < 0)
            {
                epr.SetError(cboProjectedEnd, "Projected end time must be after start time");
                retVal= false;
            }

            //Validate actual times
            if (NoShow == false && ActualEndTime.Subtract(ActualStartTime).TotalSeconds < 0)
            {
                epr.SetError(cboActualEnd, "Actual end time must be after start time, or volunteer must be marked as No Show");
                retVal = false;
            }

            return retVal;
        }

        private void chkNoShow_CheckedChanged(object sender, EventArgs e)
        {
            NoShow = chkNoShow.Checked;
        }

        private void frmVolunteerWorkDay_Load(object sender, EventArgs e)
        {
            cboActualStart.Focus();
        }

        private void txtQuickEnter_Validated(object sender, EventArgs e)
        {
            try
            {
                double quickEnterHours = Convert.ToDouble(txtQuickEnter.Text);
                ActualStartTime = ProjectedStartTime;
                ActualEndTime = ProjectedStartTime;
                
                while (ActualHours < quickEnterHours)
                {
                    cboActualEnd.SelectedIndex += 1;
                }

            }
            catch { };

        }

        private void frmVolunteerWorkDay_Shown(object sender, EventArgs e)
        {
            cboActualStart.Focus();
        }


        private void cboActualEnd_Validating(object sender, CancelEventArgs e)
        {
            DateTime endTime = CommonFunctions.ParseTimeEntry(cboActualEnd.Text, _baseDate);
            if (endTime != DateTime.MinValue)
            {
                ActualEndTime = endTime;
            }
            else
            {
                if (ActualEndTime == DateTime.MinValue)
                {
                    cboActualEnd.Text = "";
                }
            }
        }

        private void cboActualStart_Validating(object sender, CancelEventArgs e)
        {
            DateTime startTime = CommonFunctions.ParseTimeEntry(cboActualStart.Text, _baseDate);
            if (startTime != DateTime.MinValue)
            {
                ActualStartTime = startTime;
            }
            else
            {
                if (ActualStartTime == DateTime.MinValue)
                {
                    cboActualStart.Text = "";
                }
            }
        }

      
    }
}
