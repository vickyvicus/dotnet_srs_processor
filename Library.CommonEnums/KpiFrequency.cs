using System.ComponentModel.DataAnnotations;

namespace Libraries.CommonEnums
{
    public enum KpiFrequency
    {
        Daily,
        [Display(Name = "Game Period")]
        GamePeriod
    }
}
