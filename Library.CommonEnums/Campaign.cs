using System.ComponentModel;

namespace Libraries.CommonEnums
{
    public enum CampaignType
    {
        [Description("SKU Availability")]
        SKU_Availability,
        [Description("Planogram Compliance")]
        Planogram_Compliance,
        [Description("Shelf Share")]
        Shelf_Share,
        Other,
        [Description("Promo")]
        Promo,
        [Description("Competitor Survey")]
        Competitor_Survey,
    }

    public enum CampaignFrequency
    {
        [Description("Every Visit")]
        EveryVisit = 0,
        [Description("Daily")]
        Daily = 1,
        [Description("Once Every Month")]
        OnceEveryMonth = 2,
        [Description("Defined Day Of Week")]
        DefinedDayOfWeek = 3
    }

    public enum CampaignWeek
    {

        Sun = 0,
        Mon = 1,
        Tue = 2,
        Wed = 3,
        Thur = 4,
        Fri = 5,
        Sat = 6
    }

    public enum CampaignTaskStatus
    {
        Pending,
        Completed
    }

    public enum CampaignBasis
    {
        PC = 0,
        SC = 1,
        Product = 2,
        Outlet = 3
    }
}
