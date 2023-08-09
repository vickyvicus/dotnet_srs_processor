namespace Libraries.CommonEnums
{
    public enum ManagerAlertAction
    {
        Pending,
        Approved,
        Disapproved,
        Archived
    }
    public enum AlertType
    {
        StarKRA,
        TourPlanCreation,
        OutletUpdation,
        LateDayStart,
        LateDayEnd,
        RoutePlanRequest,
        NewOutletCreationRequest,
        OTP,
        OTPNSApp,
        OpportunityOutletRequest,
        ActionCardResponseApprovalRequest,
        OutletVerification,
        TADAApprovals,
        DeadOutletRequest,
        NotificationSummary,
        RegulariseAttendance,
        LeaveHR,
        DistributorStock,
        StockOut = 101,
        ISRStockEditRequest = 102,
        ISRTertiarySalesEditRequest = 103,
        ISRStockInwardRequest = 104
    }

    public enum OTPRequestType
    {
        JourneyDiversion,
        OrderValidation
    }
}
