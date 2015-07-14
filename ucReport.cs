using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;

namespace VolunteerManager
{
    public partial class ucReport : UserControl
    {
        public ucReport()
        {
            InitializeComponent();

            this.FillGrid();
        }

        private void FillGrid()
        {
            this.dgvReport.Rows.Clear();
            foreach (string fileName in Directory.GetFiles(config.ReportFolder,"*.rpt"))
            {
                if (Path.GetFileName(fileName).ToLower() != "volunteerupdate.rpt")
                {
                    this.dgvReport.Rows.Add();
                    this.dgvReport.Rows[this.dgvReport.Rows.Count - 1].Cells[0].Value = Path.GetFileName(fileName);
                    this.dgvReport.Rows[this.dgvReport.Rows.Count - 1].Cells[1].Value = ReportTitle(fileName);// Path.GetFileName(fileName);
                }
            }
        }

        private string ReportTitle(string reportFile)
        {
            ReportDocument rpt = new ReportDocument();
            rpt.Load(reportFile);
            rpt.SetDatabaseLogon(DataInterface.Config.DefaultUserName, DataInterface.Config.DefaultPassword, DataInterface.Config.DefaultServerName, DataInterface.Config.DefaultDatabaseName);
            return rpt.SummaryInfo.ReportTitle;

            //rpt.SetParameterValue("pkWorkDay", this._pkWorkDay);

            //string tempDir = config.ReportFolder + @"TempExport\";
            //Directory.CreateDirectory(tempDir);
            //foreach (string tempFile in Directory.GetFiles(tempDir))
            //{
            //    try
            //    {
            //        File.Delete(tempFile);
            //    }
            //    catch
            //    {
            //    }
            //}

            //string tempPdf = tempDir + Guid.NewGuid().ToString() + ".xls";
            //rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.Excel, tempPdf);
        }

        private void dgvReport_DoubleClick(object sender, EventArgs e)
        {
            this.RunSelectedReport();
        }

        private void RunSelectedReport()
        {
            if (this.dgvReport.SelectedRows.Count > 0)
            {
                string reportFile = config.ReportFolder + this.dgvReport.SelectedRows[0].Cells[0].Value.ToString() ;
                frmReportShow fReport = new frmReportShow();
                fReport.Show();
                fReport.ShowReport(reportFile);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.FillGrid();
        }
    }
}
