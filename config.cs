using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VolunteerManager
{
    class config
    {
        public static DateTime DefaultStartTime(DateTime baseDate)
        {
            baseDate = CommonFunctions.DatePortion(baseDate);
            DateTime configDate = VmData.GetConfigValueDateTime("DefaultStartTime");
            baseDate = baseDate.AddHours(configDate.Hour).AddMinutes(configDate.Minute);
            return baseDate;
        }

        public static DateTime DefaultEndTime(DateTime baseDate)
        {
            baseDate = CommonFunctions.DatePortion(baseDate);
            DateTime configDate = VmData.GetConfigValueDateTime("DefaultEndTime");
            baseDate = baseDate.AddHours(configDate.Hour).AddMinutes(configDate.Minute);
            return baseDate;
        }

        public static string ReportFolder
        {
            get
            {
                return FormatDirectory(System.Configuration.ConfigurationManager.AppSettings["ReportFolder"]);
            }
        }

        private static string FormatDirectory(string rawDir)
        {
            rawDir = rawDir.Trim();
            if (!rawDir.EndsWith(@"\"))
            {
                rawDir += @"\";
            }
            return rawDir;
        }

        public static string ConnectionString
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["CompassFrameworkConnectionString"]; }
        }
    }
}
