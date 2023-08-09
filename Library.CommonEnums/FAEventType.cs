using System.ComponentModel.DataAnnotations;

namespace Libraries.CommonEnums
{
    public enum FAEventType
    {
        [Display(Name = "Unknown")]
        Unknown = 0,
        [Display(Name = "Call")]
        Call = 201,
        [Display(Name = "Call Review")]
        CallReview = 202,
        [Display(Name = "New Outlet Call")]
        NewOutletCall = 203,
        [Display(Name = "Distributor Stock Pick")]
        DistributorStockPick = 204,
        [Display(Name = "Other Activities")]
        OtherActivities = 206,
        [Display(Name = "Independent Event")]
        IndependentEvent = 205,
        [Display(Name = "Primary Order")]
        PrimaryOrder = 207,
        [Display(Name = "Secondary Sales")]
        SecondarySales = 208,
        [Display(Name = "Manager Joint Working")]
        ManagerJointWorking = 209,
        [Display(Name = "Manager Distributor Visit")]
        ManagerDistributorVisit = 210,
        [Display(Name = "Manager Other Activity")]
        ManagerOtherActivity = 211,
        [Display(Name = "ISR Stock Capture")]
        ISRStockCapture = 212,
        [Display(Name = "Tertiary Sale")]
        TertiarySale = 213,
        [Display(Name = "MT Purchase Order")]
        MTPurchaseOrder = 214,
        [Display(Name = "Dispatch Against MT Purchase Order")]
        DispatchAgainstMTPurchaseOrder = 215,
        [Display(Name = "Action Card Response")]
        ActionCardResponse = 216,
        [Display(Name = "Create Outlet Request")]
        CreateOutletRequest = 217,
        [Display(Name = "Manager Retailing")]
        ManagerRetailing = 218,
        [Display(Name = "Beat Change")]
        BeatChange = 221,
        [Display(Name = "Joint Working User Change")]
        JointWorkingUserChange = 222,
        [Display(Name = "Month Wise Distributor Stock")]
        MonthWiseDistributorStock = 223,
        [Display(Name = "Depot Visit")]
        DepotVisit = 224,
        [Display(Name = "Distributor Search")]
        DistributorSearch = 225,
        [Display(Name = "Gate Meeting")]
        GateMeeting = 226,
        [Display(Name = "Head Office Visit")]
        HeadOfficeVisit = 227,
        [Display(Name = "Promotional Activity")]
        PromotionalActivity = 228,
        [Display(Name = "Distributor Visit")]
        DistributorVisit = 229,
        ISRClosingStock = 219,
        ISRStockInward = 220,
        [Display(Name = "Manager Alert")]
        ManagerAlert = 231,
        [Display(Name = "Other Activity 1")]
        OtherActivity1 = 232,
        [Display(Name = "Other Activity 2")]
        OtherActivity2 = 233,
        [Display(Name = "Other Activity 3")]
        OtherActivity3 = 234,
        [Display(Name = "Training")]
        Training = 235,
        [Display(Name = "Create Outlet Request (New)")]
        LocationAdditionRequest = 236,
        [Display(Name = "Journey Diversion")]
        JourneyDiversion = 237,
        [Display(Name = "Week Wise Distributor Stock")]
        WeekWiseDistributorStock = 238,
        [Display(Name = "Campaign Task Data")]
        CampaignTask = 240,
        [Display(Name = "Server Generated Action Card Response")]
        ServerGeneratedActionCardResponse = 500,
        [Display(Name = "ISR Stock Edit Request")]
        ISRStockEditRequest = 301,
        [Display(Name = "Overdue ISR Stock Request")]
        OverdueISRStockRequest = 302,
        [Display(Name = "ISR Tertiary Sale Edit Request")]
        ISRTertiarySaleEditRequest = 303,
        [Display(Name = "ISR Inward Edit Request")]
        ISRInwardEditRequest = 304,
        [Display(Name = "Current Stock Event")]
        CurrentStockEvent = 305,
        [Display(Name = "Consumer Sales Event")]
        ConsumerSalesEvent = 306,

        [Display(Name = "Workozy Event")]
        WorkozyEvent = 1000,
        [Display(Name = "VanSales Activity")]
        VanSalesActivity = 610,

    }
}
