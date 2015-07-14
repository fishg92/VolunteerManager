using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace VolunteerManager
{
    public partial class ucReportParameter : UserControl
    {
        public ucReportParameter()
        {
            InitializeComponent();
        }

        public void LoadParameters(ReportDocument reportDoc)
        {
            this.flpParam.Controls.Clear();
            foreach (ParameterField p in reportDoc.ParameterFields)
            {
                if (p.DefaultValues.Count > 0)
                {
                    ucComboParam uc = new ucComboParam(p);
                    this.flpParam.Controls.Add(uc);
                }
            }
        }
    }
}
