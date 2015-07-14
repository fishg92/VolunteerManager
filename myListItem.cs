using System;

namespace VolunteerManager
{
    class myListItem
    {
        private string _ItemValue;
        private string _ItemDisplay;

        public myListItem(string pItemValue, string pItemDisplay)
        {
            _ItemValue = pItemValue;
            _ItemDisplay = pItemDisplay;
        }

        public string ItemValue
        {
            get
            {
                return _ItemValue;
            }
            set
            {
                _ItemValue = value;
            }
        }

        public string ItemDisplay
        {
            get
            {
                return _ItemDisplay;
            }
            set
            {
                _ItemDisplay = value;
            }
        }

        public int ItemValueInt
        {
            get
            {
                return Convert.ToInt32(_ItemValue);
            }
        }

    }
}
