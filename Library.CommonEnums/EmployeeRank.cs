using System.ComponentModel.DataAnnotations;

namespace Libraries.CommonEnums
{
    public enum EmployeeRank
    {
        ESM = 0,
        ASM = 1,
        RSM = 2,
        ZSM = 3,
        NSM = 4,
        GSM = 5,
        Admin = 10,
        Executive = 12
    }
    public enum FieldUserType
    {
        All = 0,
        ESM = 1,
        Managers = 2
    }
    public enum EmployeeType
    {
        [Display(Name = "SR")]
        SR = 0,
        [Display(Name = "ISR")]
        ISR = 1,
        [Display(Name = "Supervisor")]
        Supervisor = 2,
        [Display(Name = "DSR")]
        DSR = 3
    }
    public enum UserActiveStatus
    {
        [Display(Name = "Active")]
        Active = 0,
        [Display(Name = "Not Active")]
        Inactive = 1
    }
}
