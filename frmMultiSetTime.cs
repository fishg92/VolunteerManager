using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace VolunteerManager
{
    public partial class frmMultiSetTime : Form
    {
        DateTime _baseDate;

        public frmMultiSetTime(DateTime pBaseDate)
        {
            InitializeComponent();

            _baseDate = pBaseDate;
            CommonFunctions.FillTimeComboBoxItems(cboActualStart, _baseDate);
            CommonFunctions.FillTimeComboBoxItems(cboActualEnd, _baseDate);

            ActualStartTime = config.DefaultStartTime(_baseDate);
            ActualEndTime = config.DefaultEndTime(_baseDate);

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


    }
}
