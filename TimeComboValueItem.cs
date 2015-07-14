using System;

namespace VolunteerManager
{
    class TimeComboValueItem
    {
        private DateTime _dateValue;

        public TimeComboValueItem(DateTime pDate)
        {
            DateValue = pDate;
        }

        public DateTime DateValue
        {
            get
            {
                return _dateValue;
            }
            set
            {
                _dateValue = value;
            }
        }

        public string DisplayValue
        {
            get
            {
                string retVal;
                int hour = _dateValue.Hour;
                string ampm;

                if (hour > 11)
                {
                    ampm = "PM";
                    
                    if (hour > 12)
                        hour -= 12;
                }
                else
                {
                    ampm = "AM";
                }

                retVal = hour.ToString("00") + ":" + _dateValue.Minute.ToString("00") + " " + ampm;
                return retVal;
            }
        }

    }
}
