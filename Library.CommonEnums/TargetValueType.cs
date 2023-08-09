using System.ComponentModel.DataAnnotations;

namespace Libraries.CommonEnums
{
    public enum TargetValueType
    {
        Revenue = 0,
        Quantity = 1,
        StandardUnit = 2
    }
    public enum PrimaryTargetType
    {
        [Display(Name = "No Targets")]
        NoTargets = 0,
        [Display(Name = "Revenue")]
        Revenue = 1,
        [Display(Name = "Std Unit")]
        StandardUnit = 2
    }
    public enum PrimaryTargetsAchievementCalculation
    {
        Order = 0,
        Invoices = 1
    }
}
