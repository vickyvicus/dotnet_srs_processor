using System.ComponentModel.DataAnnotations;

namespace Libraries.CommonEnums
{
    public enum DayStartType
    {
        [Display(Name = "Retailing")]
        Regular = 0,
        [Display(Name = "Other")]
        Other = 1,
        [Display(Name = "Leave")]
        Leave = 2,
        [Display(Name = "Holiday")]
        Holiday = 3,
        [Display(Name = "WeeklyOff")]
        WeeklyOff = 4,
        [Display(Name = "Official Work")]
        OfficialWork = 5,
        [Display(Name = "NonRetailing Manager Work")]
        NonRetailingManagerWork = 6,
        [Display(Name = "Manager Joint Working")]
        ManagerJointWorking = 7,
        [Display(Name = "Telecaller Day Start")]
        TelecallerDayStart = 8,

        None = 99
    }
    public enum DayStartTypeCategory
    {
        Retailing,
        OfficialWork,
        Leave,
        Absent,
        ManagerJW,
        WeeklyOff,
        Holiday
    }
    public static class DayStartReasonCategory
    {
        public static DayStartType GetDayStartType(string Type)
        {
            return Type == "Retailing" ? DayStartType.Regular :
                 Type == "Leave" ? DayStartType.Leave :
                 Type == "Holiday" ? DayStartType.Holiday :
                 Type == "WeeklyOff" ? DayStartType.WeeklyOff :
                 Type == "Absent" ? DayStartType.None :
                 Type == "Absent" ? DayStartType.None :
                 Type == "ManagerJointWorking" ? DayStartType.ManagerJointWorking :
                 Type == "NonRetailingManagerWork" ? DayStartType.NonRetailingManagerWork :
                 Type == "Other" ? DayStartType.Other :
                 Type == "Weekly Off" ? DayStartType.WeeklyOff :
                 DayStartType.OfficialWork;
        }
    }

}
