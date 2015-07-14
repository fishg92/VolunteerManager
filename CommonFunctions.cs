using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;

namespace VolunteerManager
{
    class CommonFunctions
    {

        public static List<myListItem> ComboItemList(DataSet ds, string valueColumnName, string displayColumnName)
        { 
            List<myListItem> retList = new List<myListItem>();

            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                myListItem itm = new myListItem(dr[valueColumnName].ToString(),dr[displayColumnName].ToString());
                retList.Add(itm);
            }
            return retList;
        }

        public static void SetComboBoxValue(ComboBox cbo, int value)
        {
            for (int index = 0; index < cbo.Items.Count;index++ )
            {
                myListItem myItem = (myListItem)cbo.Items[index];
                if (myItem.ItemValueInt == value)
                {
                    cbo.SelectedIndex = index;
                    break;
                }
            }
        }

        public static int ComboBoxSelectedIntValue(ComboBox cbo)
        {
            if (cbo.SelectedIndex == -1)
            {
                return -1;
            }
            myListItem myItem = (myListItem)cbo.Items[cbo.SelectedIndex];
            return myItem.ItemValueInt;
        }

        public static void SetTimeComboBox(ComboBox cbo, DateTime setTime)
        {
            cbo.SelectedIndex = -1;
            for (int i = 0; i < cbo.Items.Count; i++)
            {
                TimeComboValueItem itm = (TimeComboValueItem) cbo.Items[i];
                if (itm.DateValue == setTime)
                {
                    cbo.SelectedIndex = i;
                    return;
                }
            }
        }

        public static List<TimeComboValueItem> TimeListItems(DateTime baseDate)
        {
            baseDate = DatePortion(baseDate);

            List<TimeComboValueItem> retList = new List<TimeComboValueItem>();

            DateTime itemDate = baseDate.AddHours(6);
            while (itemDate.Hour <= 22)
            { 
                retList.Add(new TimeComboValueItem(itemDate));
                itemDate = itemDate.AddMinutes(15);
            }

            return retList;
        }

        public static void FillTimeComboBoxItems(ComboBox cbo, DateTime baseDate)
        {
            cbo.Items.Clear();
            cbo.DisplayMember = "DisplayValue";
            cbo.ValueMember = "DateValue";
            foreach (TimeComboValueItem itm in TimeListItems(baseDate))
            {
                cbo.Items.Add(itm);
            }
        }

        public static DateTime ParseTimeEntry(string valueEntered, DateTime baseDate)
        {
            baseDate = DatePortion(baseDate);
            DateTime retVal;

            int hour;
            int minute;

            if (valueEntered.Length < 3 || valueEntered.Length > 4)
            {
                return DateTime.MinValue;
            }

            string hourEntered = "";
            string minuteEntered = "";

            if (valueEntered.Length == 3)
            {
                hourEntered = valueEntered.Substring(0, 1);
                minuteEntered = valueEntered.Substring(1, 2);
            }

            if (valueEntered.Length == 4)
            {
                hourEntered = valueEntered.Substring(0, 2);
                minuteEntered = valueEntered.Substring(2, 2);
            }

            try
            {
                hour = Convert.ToInt32(hourEntered);
                minute = Convert.ToInt32(minuteEntered);

                if (minute % 15 != 0)
                    return DateTime.MinValue;

                if (hour < 7)
                    hour += 12;

                retVal = baseDate.AddHours(hour).AddMinutes(minute);

            }
            catch
            {
                return DateTime.MinValue;
            }

            return retVal;
        }

        public static DateTime DatePortion(DateTime baseDate)
        {
            baseDate = baseDate.AddHours(0 - baseDate.Hour);
            baseDate = baseDate.AddMinutes(0 - baseDate.Minute);
            baseDate = baseDate.AddSeconds(0 - baseDate.Second);
            baseDate = baseDate.AddMilliseconds(0 - baseDate.Millisecond);
            return baseDate;

        }
    }
}
