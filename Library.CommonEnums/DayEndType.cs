using System.ComponentModel.DataAnnotations;

namespace Libraries.CommonEnums
{
    public enum DayEndType
    {
        [Display(Name = "Not Ended")]
        NotEnded = 0,
        [Display(Name = "Normal")]
        Normal = 1,
        [Display(Name = "Forced from Device")]
        ForcedAfterCutoff = 2,
        AutomaticAfter4 = 3,
        [Display(Name = "Forced from Sever")]
        ForcedViaURL = 4,
        [Display(Name = "Not Ended (Cleared Data)")]
        ResumedOnSameDevice = 5,
        [Display(Name = "ForceEnd Old Sessions")]
        ForceEndOldSessionFromDevice = 6,
        [Display(Name = "DayEnded For Switch")]
        DayEndedForSwitch = 7,
        [Display(Name = "Telecaller Day End")]
        TelecallerDayEnd = 8,

        NoRetailing = 99,
        MigratedFromOld = 100,

    }
}
