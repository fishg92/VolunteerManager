using System;
using System.Windows.Forms;

namespace VolunteerManager
{
    public partial class frmMain : Form
    {

        private ucVolunteerList _volList = new ucVolunteerList();
        private ucWorkDayList _workDayList = new ucWorkDayList();
        //private ucReport _reportList = new ucReport();

        public frmMain()
        {
            InitializeComponent();
            pnlMain.Controls.Add(_volList);
            _volList.Dock = DockStyle.Fill;
            _volList.Hide();

            pnlMain.Controls.Add(_workDayList);
            _workDayList.Dock = DockStyle.Fill;
            _workDayList.Hide();

            ShowWorkDayList();
        }

        private void btnVolunteer_Click(object sender, EventArgs e)
        {
            ShowVolunteerList();
        }

        private void ShowVolunteerList()
        {
            foreach (Control ctl in pnlMain.Controls)
            {
                ctl.Hide();
            }
            _volList.Show();
            _volList.FillData();
        }

        private void ShowWorkDayList()
        {
            foreach (Control ctl in pnlMain.Controls)
            {
                ctl.Hide();
            }
            _workDayList.Show();
        }

        private void ShowReports()
        {
            foreach (Control ctl in pnlMain.Controls)
            {
                ctl.Hide();
            }
        }

        private void btnWorkDay_Click(object sender, EventArgs e)
        {
            ShowWorkDayList();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ShowReports();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin fLogin = new frmLogin();
            if (fLogin.ShowDialog(this) != DialogResult.OK)
            {
                Application.Exit();
            }
        }

    }
}
