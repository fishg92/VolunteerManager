using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VolunteerManager
{
    interface IListItem
    {
        string ItemValue { get; set; }
        string ItemDisplay { get; set; }
        int ItemValueInt { get; }
    }
}
