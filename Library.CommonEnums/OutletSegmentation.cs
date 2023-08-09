using System.ComponentModel.DataAnnotations;

namespace Libraries.CommonEnums
{
    public enum OutletSegmentation
    {
        Undefined,
        [Display(Name = "A+")]
        Ap,
        [Display(Name = "A")]
        A,
        [Display(Name = "A-")]
        Am,
        [Display(Name = "B+")]
        Bp,
        [Display(Name = "B")]
        B,
        [Display(Name = "B-")]
        Bm,
        [Display(Name = "C+")]
        Cp,
        [Display(Name = "C")]
        C,
        [Display(Name = "C-")]
        Cm,
        [Display(Name = "D+")]
        Dp,
        [Display(Name = "D")]
        D,
        [Display(Name = "D-")]
        Dm
    }

}
