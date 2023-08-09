using System.ComponentModel.DataAnnotations;

namespace Libraries.CommonEnums
{
    public enum ActionOnLeave
    {
        [Display(Name = "No Action Taken")]
        NoAction = 0,
        [Display(Name = "Approved")]
        Approved = 1,
        [Display(Name = "Reject")]
        DisApproved = 2
    }
}
