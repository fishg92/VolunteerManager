using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VolunteerManager
{
    public class BuildProject:IListItem
    {
        public int pkBuildProject { get; set; }
        public string ProjectName { get; set; }

        public string ItemValue
        {
            get { return pkBuildProject.ToString(); }
            set { pkBuildProject = Convert.ToInt32(value); }
        }

        public string ItemDisplay
        {
            get { return ProjectName; }
            set { ProjectName = value; }
        }
        public int ItemValueInt { get { return (int) pkBuildProject; } }
    }
}
