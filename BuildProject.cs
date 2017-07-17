using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VolunteerManager
{
    public class BuildProject:IListItem
    {
        public decimal pkBuildProject { get; set; }
        public string ProjectName { get; set; }

        public string ItemValue
        {
            get { return pkBuildProject.ToString(); }
            set { pkBuildProject = Convert.ToDecimal(value); }
        }

        public string ItemDisplay
        {
            get { return ProjectName; }
            set { ProjectName = value; }
        }
        public int ItemValueInt { get { return (int) pkBuildProject; } }
    }
}
