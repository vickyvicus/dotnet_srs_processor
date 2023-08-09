namespace Libraries.CommonEnums
{
    public enum TargetOn
    {
        OverAll = 0,
        PrimaryCategory = 1,
        ProductDivision = 2
    }
    public enum EmployeeTargetOn
    {
        None,
        PrimaryCategory,
        Overall,
        Daily
    }
    public enum TargetValueTypeDashboard
    {
        Revenue,
        Quantity,
        StandardUnit
    }
    public enum EmployeeTargetsCalculationType
    {
        Order,
        DispatchAgainstOrder,
        Invoices,
    }
}
