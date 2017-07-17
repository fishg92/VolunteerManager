using System;

namespace VolunteerManager
{
    class MyListItem:IListItem
    {
        public MyListItem(string pItemValue, string pItemDisplay)
        {
            ItemValue = pItemValue;
            ItemDisplay = pItemDisplay;
        }

        public string ItemValue { get; set; }

        public string ItemDisplay { get; set; }

        public int ItemValueInt => Convert.ToInt32(ItemValue);
    }
}
