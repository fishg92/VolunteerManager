using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace VolunteerManager
{
    public partial class frmReport : Form
    {
        private string _reportName;
        private List<param> _paramList = new List<param>();

        public frmReport()
        {
            InitializeComponent();
        }

        public string ReportName
        {
            get
            {
                return _reportName;
            }
            set
            {
                _reportName = value;
            }
        }

        public void AddParam(string paramName, string paramValue)
        {
            param p = new param();
            p.paramName = paramName;
            p.paramValue = paramValue;
            _paramList.Add(p);
        }

        public void ShowReport()
        {
           
            ReportDocument rpt = new ReportDocument();
            rpt.Load(config.ReportFolder + _reportName);
            rpt.SetDatabaseLogon(DataInterface.Config.DefaultUserName, DataInterface.Config.DefaultPassword, DataInterface.Config.DefaultServerName, DataInterface.Config.DefaultDatabaseName);
            
            ParameterFieldDefinitions crParameterFieldDefinitions = default(ParameterFieldDefinitions);
            crParameterFieldDefinitions = rpt.DataDefinition.ParameterFields;

            foreach (ParameterFieldDefinition crParameterFieldLocation in crParameterFieldDefinitions)
            {
                foreach (param p in _paramList)
                {
                    if (p.paramName == crParameterFieldLocation.Name)
                    {
                        rpt.SetParameterValue(p.paramName, p.paramValue);
                    }
                }
            }
            
            this.crViewer.ReportSource = rpt;
        }

        private class param
        {
            public string paramName;
            public string paramValue;
        }
    }
}
