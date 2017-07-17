using System;

namespace VolunteerManager
{
    class TimeComboValueItem
    {
        public TimeComboValueItem(DateTime pDate)
        {
            DateValue = pDate;
        }

        public DateTime DateValue { get; set; }

        public string DisplayValue
        {
            get
            {
                int hour = DateValue.Hour;
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

                var retVal = hour.ToString("00") + ":" + DateValue.Minute.ToString("00") + " " + ampm;
                return retVal;
            }
        }

    }
}
