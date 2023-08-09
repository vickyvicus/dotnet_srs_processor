using System.ComponentModel.DataAnnotations;

namespace Libraries.CommonEnums
{

    public enum OutletFocusType
    {
        [Display(Name = "Not Focus")]
        NotFocus = 0,
        [Display(Name = "Focus")]
        Focus = 1,
        [Display(Name = "Not Applicable")]
        NotApplicable = 2
    }
}
