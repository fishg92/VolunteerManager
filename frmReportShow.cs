using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace VolunteerManager
{
    public partial class frmReportShow : Form
    {
        private string _reportFile;
        private ReportDocument _reportDoc = null;

        public frmReportShow()
        {
            InitializeComponent();
        }

        public void ShowReport(string reportFile)
        {
            _reportFile = reportFile;
            _reportDoc = new ReportDocument();
            _reportDoc.Load(_reportFile);
            _reportDoc.SetDatabaseLogon(DataInterface.Config.DefaultUserName, DataInterface.Config.DefaultPassword, DataInterface.Config.DefaultServerName, DataInterface.Config.DefaultDatabaseName);
            //this.SetBuildProjectParameter();
            if (_reportDoc.SummaryInfo != null 
                && _reportDoc.SummaryInfo.ReportTitle != null 
                && _reportDoc.SummaryInfo.ReportTitle.Trim().Length > 0)
                this.Text = _reportDoc.SummaryInfo.ReportTitle;

            //this.ucParam.LoadParameters(_reportDoc);
            this.LoadViewer();

        }

        private void SetBuildProjectParameter()
        {
            foreach (ParameterField p in _reportDoc.ParameterFields)
            {
                if (p.Name.ToLower().Trim().Replace(" ", "") == "buildproject"
                    && p.ParameterValueType == ParameterValueKind.NumberParameter)
                {
                    p.DefaultValues.Clear();

                    DataSet ds = VmData.GetBuildProjectParameterDefaults();
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        ParameterDiscreteValue pv = new ParameterDiscreteValue();
                        //ParameterDiscreteValue val = new ParameterDiscreteValue();
                        pv.Value = (int)dr["pkBuildProject"];
                        pv.Description = (string)dr["Description"];
                        p.DefaultValues.Add(pv);
                        p.DefaultValues[p.DefaultValues.Count - 1].Description = (string)dr["Description"];
                    }
                    p.DefaultValueDisplayType = DefaultValueDisplayType.Description;

                    break;
                }
            }
        }

        private void LoadViewer()
        {
            
            this.crViewer.ReportSource = _reportDoc;
            this.crViewer.Dock = DockStyle.Fill;
            this.crViewer.RefreshReport();
        
        }

    }
}
