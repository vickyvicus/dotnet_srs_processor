using System.ComponentModel.DataAnnotations;

namespace Libraries.CommonEnums
{
    public enum OrderKind
    {
        [Display(Name = "Orders")]
        OtherOrder = 0,
        [Display(Name = "First Order at Shops")]
        FirstOrder = 1,
        [Display(Name = "Retailer Target vs Achievment on Order")]
        TargetVsAchievment = 2,
        [Display(Name = "OTP at New Outlet Creation")]
        NewOutletCreation = 3,
        [Display(Name = "Activation Code")]
        ActivationCode = 4
    }
}
