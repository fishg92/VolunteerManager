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
    public partial class ucComboParam : UserControl
    {
        private ParameterField _param;
        public string paramName;

        public ucComboParam(ParameterField p)
        {
            InitializeComponent();
            _param = p;
            paramName = p.Name;
            
            LoadParam();
        }

        public string SelectedValue
        {
            get
            {
                if (this.cboValue.SelectedIndex != -1)
                {
                    myListItem itm = (myListItem)this.cboValue.Items[this.cboValue.SelectedIndex];
                    return itm.ItemValue;
                }
                else
                {
                    return null;
                }
            }
        }

        private void LoadParam()
        {
            this.lblPrompt.Text = _param.PromptText;
            foreach ( ParameterValue p in _param.DefaultValues)
            {
                ParameterDiscreteValue pDis = (ParameterDiscreteValue)p;
                string valuePrompt;
                if (_param.DefaultValueDisplayType == DefaultValueDisplayType.Description)
                {
                    valuePrompt = pDis.Description;
                }
                else
                { 
                    valuePrompt=pDis.Value.ToString() + " - "  + pDis.Description;
                }
                myListItem itm = new myListItem(pDis.Value.ToString(), valuePrompt);
                this.cboValue.Items.Add(itm);
            }
            
        }
    }
}
