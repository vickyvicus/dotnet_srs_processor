using System.ComponentModel.DataAnnotations;

namespace Libraries.CommonEnums
{
    public enum FocussedProductTargetType
    {
        [Display(Name = "Focused Product Rule")]
        FocussedProductRule,
        [Display(Name = "Focused Product")]
        FocussedProduct
    }
    public enum FocussedTargetOn
    {
        [Display(Name = "Std Unit")]
        StandardUnit = 0,
        [Display(Name = "Value")]
        Revenue = 1
    }
}
