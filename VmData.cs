using System;
using System.Collections.Generic;
using DataInterface;
using System.Data;


namespace VolunteerManager
{
    public class VmData
    {
        public static void SetActualHours(int pkVolunteer, int pkWorkDay, DateTime actualStartTime, DateTime actualEndTime)
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.SetActualHours");
            sp.AddInputParameter("@fkWorkDay", pkWorkDay);
            sp.AddInputParameter("@fkVolunteer", pkVolunteer);
            sp.AddInputParameter("@ActualStartTime", actualStartTime);
            sp.AddInputParameter("@ActualEndTime", actualEndTime);
            sp.ExecNonQuery();
        }
        public static void GetVolunteerData(
            int pkVolunteer
            , out string firstName
            , out string lastName
            , out string address
            , out string city
            , out string state
            , out string zip
            , out string homePhone
            , out string workPhone
            , out string workPhoneExt
            , out string cellPhone
            , out string email
            , out bool active
            , out string comments
            , out int fkOrganization
            , out int fkrefPositionType)
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.GetVolunteerData");
            sp.AddInputParameter("@pkVolunteer", pkVolunteer);
            sp.AddOutputParameter("@fkOrganization", SqlDbType.Int);
            sp.AddOutputParameter("@fkrefPositionType", SqlDbType.Int);
            sp.AddOutputParameter("@LastName", SqlDbType.VarChar, 50);
            sp.AddOutputParameter("@FirstName", SqlDbType.VarChar, 50);
            sp.AddOutputParameter("@Address", SqlDbType.VarChar, 50);
            sp.AddOutputParameter("@City", SqlDbType.VarChar, 50);
            sp.AddOutputParameter("@State", SqlDbType.VarChar, 2);
            sp.AddOutputParameter("@Zip", SqlDbType.VarChar, 9);
            sp.AddOutputParameter("@Comments", SqlDbType.VarChar, 500);
            sp.AddOutputParameter("@HomePhone", SqlDbType.VarChar, 10);
            sp.AddOutputParameter("@WorkPhone", SqlDbType.VarChar, 10);
            sp.AddOutputParameter("@WorkPhoneExt", SqlDbType.VarChar, 5);
            sp.AddOutputParameter("@CellPhone", SqlDbType.VarChar, 10);
            sp.AddOutputParameter("@Email", SqlDbType.VarChar, 75);
            sp.AddOutputParameter("@CurrentlyActive", SqlDbType.Bit);
            sp.ExecNonQuery();

            firstName = sp.OutputParameterValueString("@FirstName", "");
            lastName = sp.OutputParameterValueString("@LastName", "");
            address = sp.OutputParameterValueString("@Address", "");
            city = sp.OutputParameterValueString("@City", "");
            state = sp.OutputParameterValueString("@State", "");
            zip = sp.OutputParameterValueString("@Zip", "");
            homePhone = sp.OutputParameterValueString("@HomePhone", "");
            workPhone = sp.OutputParameterValueString("@WorkPhone", "");
            workPhoneExt = sp.OutputParameterValueString("@WorkPhoneExt", "");
            cellPhone = sp.OutputParameterValueString("@CellPhone", "");
            email = sp.OutputParameterValueString("@Email", "");
            active = (sp.OutputParameterValueString("@CurrentlyActive", "") == "True");
            comments = sp.OutputParameterValueString("@Comments", "");
            fkOrganization = sp.OutputParameterValueInt("@fkOrganization", -1);
            fkrefPositionType = sp.OutputParameterValueInt("@fkrefPositionType", -1);

        }

        public static int SaveVolunteer(
            int pkVolunteer
            , string firstName
            , string lastName
            , string address
            , string city
            , string state
            , string zip
            , string homePhone
            , string workPhone
            , string workPhoneExt
            , string cellPhone
            , string email
            , bool active
            , string comments
            , int fkOrganization
            , int fkrefPositionType)
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString,"haah.VolunteerSave");
            sp.AddInputParameter("@pkVolunteer", pkVolunteer);
            sp.AddInputParameter("@fkOrganization", fkOrganization);
            sp.AddInputParameter("@fkrefPositionType", fkrefPositionType);
            sp.AddInputParameter("@LastName", lastName);
            sp.AddInputParameter("@FirstName", firstName);
            sp.AddInputParameter("@Address", address);
            sp.AddInputParameter("@City", city);
            sp.AddInputParameter("@State", state);
            sp.AddInputParameter("@Zip", zip);
            sp.AddInputParameter("@HomePhone", homePhone);
            sp.AddInputParameter("@WorkPhone", workPhone);
            sp.AddInputParameter("@WorkPhoneExt", workPhoneExt);
            sp.AddInputParameter("@CellPhone", cellPhone);
            sp.AddInputParameter("@Email", email);
            sp.AddInputParameter("@CurrentlyActive", active);
            sp.AddInputParameter("@Comments", comments);

            sp.AddOutputParameter("@pkVolunteerReturn", SqlDbType.Int);

            sp.ExecNonQuery();

            return sp.OutputParameterValueInt("@pkVolunteerReturn", -1);

        }

        public static DataSet OrganizationList(bool addBlank, string blankName)
        {
            string sql = "select pkOrganization, OrganizationName, ShortName from haah.Organization";
            if (addBlank)
                sql += " union select -1,'" + blankName + "',''";

            sql += " order by OrganizationName";

            return DBInterface.GetDSfromSQL(config.ConnectionString, sql);
        }

        public static DataSet PositionTypeList(bool addBlank)
        {
            string sql = "select pkrefPositionType, Description, LeadershipPosition from haah.refPositionType";
            if (addBlank)
                sql += " union select -1,'',0";
            sql += " order by Description";
            return DBInterface.GetDSfromSQL(config.ConnectionString, sql);
        }

        public static List<BuildProject> ProjectList(bool includeAll)
        {
            string sql = "select pkBuildProject, ProjectName = ProjectName + ' (' + convert(varchar,datepart(year,StartDate)) + ')' " +
            "from haah.BuildProject order by StartDate desc";

            List<BuildProject> retList = new List<BuildProject>();

            DataSet dsProject = DBInterface.GetDSfromSQL(config.ConnectionString, sql);

            foreach (DataRow dr in dsProject.Tables[0].Rows)
            {
                retList.Add(new BuildProject {pkBuildProject = Convert.ToDecimal(dr["pkBuildProject"]),ProjectName = dr["ProjectName"].ToString()});
            }

            if (includeAll)
            {
                retList.Insert(0,new BuildProject {pkBuildProject = -1,ProjectName = "All"});
            }
            return retList;
        }

        public static void AddVolunteerWorkDay(int pkWorkDay, int pkVolunteer)
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.VolunteerWorkDaySave");
            sp.AddInputParameter("@fkWorkDay", pkWorkDay);
            sp.AddInputParameter("@fkVolunteer", pkVolunteer);
            sp.ExecNonQuery();
        }

        public static void DeleteVolunteerWorkDay(int pkWorkDay, int pkVolunteer)
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.VolunteerWorkDayDelete");
            sp.AddInputParameter("@fkWorkDay", pkWorkDay);
            sp.AddInputParameter("@fkVolunteer", pkVolunteer);
            sp.ExecNonQuery();
        }

        public static DataSet WorkDayAvailableVolunteers(int pkWorkDay, int pkOrganization)
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.GetWorkDayVolunteersAvailable");
            sp.AddInputParameter("@pkWorkDay", pkWorkDay);
            sp.AddInputParameter("@pkOrganization", pkOrganization);
            return sp.GetDsResult();

        }

        public static DataSet WorkDaySelectedVolunteers(int pkWorkDay, int pkOrganization)
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.GetWorkDayVolunteersSelected");
            sp.AddInputParameter("@pkWorkDay", pkWorkDay);
            sp.AddInputParameter("@pkOrganization", pkOrganization);
            return sp.GetDsResult();

        }


        public static string GetConfigValueString(string itemKey)
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.GetConfigValueString");
            sp.AddInputParameter("@ItemKey", itemKey);
            return sp.ScalarString("");
        }

        public static int GetConfigValueInt(string itemKey)
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.GetConfigValueInt");
            sp.AddInputParameter("@ItemKey", itemKey);
            return sp.ScalarInteger(0);
        }

        public static DateTime GetConfigValueDateTime(string itemKey)
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.GetConfigValueDateTime");
            sp.AddInputParameter("@ItemKey", itemKey);
            return sp.ScalarDateTime(DateTime.MinValue);
        }

        public static decimal GetConfigValueDecimal(string itemKey)
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.GetConfigValueDecimal");
            sp.AddInputParameter("@ItemKey", itemKey);
            return sp.ScalarDecimal(0);
        }

        public static int SaveWorkDay(
            int pkWorkDay
            , int fkBuildProject
            , DateTime workDate
            , string workDescription
            , string comments
            , int lunchfkOrganization)
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.WorkDaySave");
            sp.AddInputParameter("@pkWorkDay", pkWorkDay);
            sp.AddInputParameter("@fkBuildProject", fkBuildProject);
            sp.AddInputParameter("@WorkDate", workDate);
            sp.AddInputParameter("@workDescription", workDescription);
            sp.AddInputParameter("@Comments", comments);
            sp.AddInputParameter("@LunchfkOrganization", lunchfkOrganization);
            sp.AddOutputParameter("@pkWorkDayReturn", SqlDbType.Int);
            sp.ExecNonQuery();
            return sp.OutputParameterValueInt("@pkWorkDayReturn", -1);
        }

        public static int SaveWorkDay(
            int pkWorkDay
            , string workDescription)
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.WorkDaySave");
            sp.AddInputParameter("@pkWorkDay", pkWorkDay);
            sp.AddInputParameter("@workDescription", workDescription);
            sp.AddOutputParameter("@pkWorkDayReturn", SqlDbType.Int);
            sp.ExecNonQuery();
            return sp.OutputParameterValueInt("@pkWorkDayReturn", -1);
        }

        public static int SaveWorkDay(
            int pkWorkDay
            , DateTime workDate)
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.WorkDaySave");
            sp.AddInputParameter("@pkWorkDay", pkWorkDay);
            sp.AddInputParameter("@WorkDate", workDate);
            sp.AddOutputParameter("@pkWorkDayReturn", SqlDbType.Int);
            sp.ExecNonQuery();
            return sp.OutputParameterValueInt("@pkWorkDayReturn", -1);
        }

        public static int SaveWorkDay(
            int pkWorkDay
            , int fkBuildProject)
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.WorkDaySave");
            sp.AddInputParameter("@pkWorkDay", pkWorkDay);
            sp.AddInputParameter("@fkBuildProject", fkBuildProject);
            sp.AddOutputParameter("@pkWorkDayReturn", SqlDbType.Int);
            sp.ExecNonQuery();
            return sp.OutputParameterValueInt("@pkWorkDayReturn", -1);

        }


        public static DataSet GetWorkDays(int pkBuildProject, out decimal totalProjectHours)
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.GetWorkDays");
            sp.AddInputParameter("@fkBuildProject", pkBuildProject);
            DataSet ds = sp.GetDsResult();

            totalProjectHours = 0;
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                totalProjectHours += (decimal)dr["TotalHours"];
            }

            return ds;
        }

        public static void GetWorkDayDetails(
            int pkWorkDay
            , out int fkBuildProject
            , out DateTime workDate
            , out string workDescription
            , out string comments
            , out int lunchfkOrganization)
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.GetWorkDayDetails");
            sp.AddInputParameter("@pkWorkDay", pkWorkDay);
            sp.AddOutputParameter("@fkBuildProject", SqlDbType.Int);
            sp.AddOutputParameter("@WorkDate", SqlDbType.DateTime);
            sp.AddOutputParameter("@WorkDescription", SqlDbType.VarChar, 500);
            sp.AddOutputParameter("@Comments", SqlDbType.VarChar, 500);
            sp.AddOutputParameter("@LunchfkOrganization", SqlDbType.Int);

            sp.ExecNonQuery();
            fkBuildProject = sp.OutputParameterValueInt("@fkBuildProject", -1);
            workDate = sp.OutputParameterValueDateTime("@WorkDate", DateTime.MinValue);
            workDescription = sp.OutputParameterValueString("@WorkDescription", "");
            comments = sp.OutputParameterValueString("@Comments", "");
            lunchfkOrganization = sp.OutputParameterValueInt("@LunchfkOrganization", -1);
        }

        public static void GetVolunteerWorkDay(
            int pkVolunteer
            , int pkWorkDay
            , out DateTime actualStartTime
            , out DateTime actualEndTime
            , out DateTime projectedStartTime
            , out DateTime projectedEndTime
            , out string comments
            , out bool noShow
            , out DateTime baseDate
            , out string volunteerName
            , out string organizationName)
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.GetVolunteerWorkDay");
            sp.AddInputParameter("@pkVolunteer", pkVolunteer);
            sp.AddInputParameter("@pkWorkDay", pkWorkDay);
            sp.AddOutputParameter("@ActualStartTime", SqlDbType.DateTime);
            sp.AddOutputParameter("@ActualEndTime", SqlDbType.DateTime);
            sp.AddOutputParameter("@ProjectedStartTime", SqlDbType.DateTime);
            sp.AddOutputParameter("@ProjectedEndTime", SqlDbType.DateTime);
            sp.AddOutputParameter("@Comments", SqlDbType.VarChar, 500);
            sp.AddOutputParameter("@NoShow", SqlDbType.Bit);
            sp.AddOutputParameter("@BaseDate", SqlDbType.DateTime);
            sp.AddOutputParameter("@VolunteerName", SqlDbType.VarChar, 100);
            sp.AddOutputParameter("@OrganizationName", SqlDbType.VarChar, 100);

            sp.ExecNonQuery();

            actualStartTime = sp.OutputParameterValueDateTime("@ActualStartTime", DateTime.MinValue);
            actualEndTime = sp.OutputParameterValueDateTime("@ActualEndTime", DateTime.MinValue);
            projectedStartTime = sp.OutputParameterValueDateTime("@ProjectedStartTime", DateTime.MinValue);
            projectedEndTime = sp.OutputParameterValueDateTime("@ProjectedEndTime", DateTime.MinValue);
            comments = sp.OutputParameterValueString("@Comments", "");
            noShow = (sp.OutputParameterValueString("@NoShow", "") == "True");
            baseDate = sp.OutputParameterValueDateTime("@BaseDate", DateTime.MinValue);
            volunteerName = sp.OutputParameterValueString("@VolunteerName", "");
            organizationName = sp.OutputParameterValueString("@OrganizationName", "");
        }

        public static void SaveVolunteerWorkDay(
            int pkWorkDay
            , int pkVolunteer
            , DateTime projectedStartTime
            , DateTime projectedEndTime
            , DateTime actualStartTime
            , DateTime actualEndTime
            , string comments
            , bool noShow)
        {

            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.VolunteerWorkDaySave");
            sp.AddInputParameter("@fkWorkDay", pkWorkDay);
            sp.AddInputParameter("@fkVolunteer", pkVolunteer);
            if (actualStartTime != DateTime.MinValue)
                sp.AddInputParameter("@ActualStartTime", actualStartTime);
            if (actualEndTime != DateTime.MinValue)
                sp.AddInputParameter("@ActualEndTime", actualEndTime);
            if (projectedStartTime != DateTime.MinValue)
                sp.AddInputParameter("@ProjectedStartTime", projectedStartTime);
            if (projectedEndTime != DateTime.MinValue)
                sp.AddInputParameter("@ProjectedEndTime", projectedEndTime);
            sp.AddInputParameter("@Comments", comments);
            sp.AddInputParameter("@NoShow", noShow);
            sp.ExecNonQuery();

        }

        public static void DeleteWorkDay(int pkWorkDay)
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.WorkDayDelete");
            sp.AddInputParameter("@pkWorkDay", pkWorkDay);
            sp.ExecNonQuery();
        }

        public static int DuplicateWorkDayExists(int pkWorkDay, DateTime workDate)
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.DuplicateWorkDayExists");
            sp.AddInputParameter("@pkWorkDay", pkWorkDay);
            sp.AddInputParameter("@WorkDate", workDate);
            return sp.ScalarInteger(-1);
        }

        public static DataSet VolunteerList(int pkOrganization, int pkBuildProject, bool activeOnly)
        {

            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.VolunteerList");
            sp.AddInputParameter("@pkOrganization", pkOrganization);
            sp.AddInputParameter("@pkBuildProject", pkBuildProject);
            sp.AddInputParameter("@ActiveOnly", activeOnly);

            return sp.GetDsResult();

        }

        public static void VolunteerHourSummary(
            int pkVolunteer
            , out int projectCount
            , out int workDayCount
            , out decimal totalHours)
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.VolunteerHourSummary");
            sp.AddInputParameter("@pkVolunteer", pkVolunteer);
            sp.AddOutputParameter("@ProjectCount", SqlDbType.Int);
            sp.AddOutputParameter("@WorkDayCount", SqlDbType.Int);
            sp.AddOutputParameter("@TotalHours", SqlDbType.Decimal);
            sp.ExecNonQuery();
            projectCount = sp.OutputParameterValueInt("@ProjectCount", 0);
            workDayCount = sp.OutputParameterValueInt("@WorkDayCount", 0);
            totalHours = sp.OutputParameterValueDecimal("@TotalHours", 0);
        }


        public static void VolunteerDelete(int pkVolunteer)
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.VolunteerDelete");
            sp.AddInputParameter("@pkVolunteer", pkVolunteer);
            sp.ExecNonQuery();
        }

        public static void CombineVolunteers(int pkVolunteerSource, int pkVolunteerTarget)
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.CombineVolunteers");
            sp.AddInputParameter("@pkVolunteerSource", pkVolunteerSource);
            sp.AddInputParameter("@pkVolunteerTarget", pkVolunteerTarget);
            sp.ExecNonQuery();
        }

        public static DataSet GetBuildProjectParameterDefaults()
        {
            SQLStoredProc sp = new SQLStoredProc(config.ConnectionString, "haah.GetBuildProjectParameterDefaults");
            return sp.GetDsResult();
        }

    }
}
