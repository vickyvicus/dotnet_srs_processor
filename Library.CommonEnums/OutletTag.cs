using System.ComponentModel.DataAnnotations;

namespace Libraries.CommonEnums
{
    public enum OutletTag
    {
        [Display(Name = "New")]
        NewOutlet,
        [Display(Name = "Active")]
        Active,
        [Display(Name = "To Be Dormant")]
        ToBeDormant,
        [Display(Name = "Dormant")]
        Dormant,
        [Display(Name = "No Order")]
        VisitedbutNotConverted,
        [Display(Name = "Never Visited")]
        NeverVisited
    }
}
