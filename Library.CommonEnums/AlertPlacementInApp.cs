using System.ComponentModel.DataAnnotations;


namespace Libraries.CommonEnums
{
    public enum AlertPlacementInApp
    {
        [Display(Name = "No Notification")]
        NoNotification,
        [Display(Name = "Beat Dashboard")]
        BeatDashboard,
        [Display(Name = "Outlet List")]
        OutletList,
        [Display(Name = "Call Preparation")]
        CallPreparation,
        [Display(Name = "OrderConfirmationn")]
        OrderConfirmation,
        [Display(Name = "BeforeStartDay")]
        BeforeStartDay

    }
}
