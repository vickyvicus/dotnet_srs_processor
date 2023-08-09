using System.ComponentModel.DataAnnotations;

namespace Libraries.CommonEnums
{
    public enum Relation
    {
        [Display(Name = "Use Direct Report Db")]
        UseDirectReportDb,
        [Display(Name = "Use Direct Master Db")]
        UseDirectMasterDb,
        [Display(Name = "Report Db / Master Db")]
        ReportDbDividedByMasterDb,
        [Display(Name = "Master Db / Report Db")]
        MasterDbDividedByReportDb

    }
}
