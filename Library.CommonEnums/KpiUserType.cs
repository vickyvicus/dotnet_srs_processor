using System.ComponentModel.DataAnnotations;

namespace Libraries.CommonEnums
{
    public enum KpiUserType
    {
        [Display(Name = "All Field Users")]
        AllFieldUsers,
        [Display(Name = "Manager As A Field User")]
        ManagerAsAFIeldUser,
        [Display(Name = "Field User Allowed To Book Order")]
        FieldUserAllowedToBookOrder
    }
}
