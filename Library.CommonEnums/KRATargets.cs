namespace Libraries.CommonEnums
{
    public enum KRATargetEnum
    {
        Unknown,
        TC,
        PC,
        EffectiveCalls,
        TimespentinRetailing,
        TotalTimeLoggedIn,
        QtyperPC,
        QtyStdUnitperPC,
        NetValueperPC,
        LPC,
        DayStartTime,
        FirstCallTime,
        PercentOVCLimit,
        JointWorkingCalls,
        NoofDistributorSearchMonth,
        NoofDistributorsVisitMonth,
        TotalTimeActive,
        FocusedProductLPC,
        PercentPrimaryTargetAchivement,
        UniqueProductiveCall,
        StylePerProductiveCall,
        PhysicalTC,
        PercentJourneyPlanAdherence,
        PercentDispatchAgainstOrderVolume,
        PercentProductivity,
        DailyTarget,
        NewOutletstobecreatedinMonth,
        PercentSecondaryTargetAchiement,
        NewOutletstobecreatedDaily,
        DailyStdUnitTarget,
        DayEndTime
    }
    public enum KRADataType
    {
        Unknown = 0,
        WholeNumber = 10,
        WholeNumberLT100 = 20,
        Time = 30
    }
    public enum KRACalculationType
    {
        Unknown = 0,
        Daily = 10,
        Monthly = 20,
        Both = 30
    }
    public enum KRAUserType
    {
        Unknown = 0,
        FieldUserAll = 10,
        FieldUserWithOrderBooking = 20,
        ManagerWithOrderBooking = 30,
        ManagerNoOrderBooking = 40,
    }
}
