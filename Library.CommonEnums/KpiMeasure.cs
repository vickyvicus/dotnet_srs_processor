using System.ComponentModel.DataAnnotations;

namespace Libraries.CommonEnums
{
    public enum KpiMeasure
    {
        Number,
        Percentage,
        Time,
        [Display(Name = "Yes/No")]
        YesNo,
        Currency,
        [Display(Name = "Time Duration")]
        TimeDuration,
        Decimal,
        [Display(Name = "Percentage & Number")]
        PercentageNumber
    }
}
