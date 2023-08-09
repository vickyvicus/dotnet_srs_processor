namespace Library.CommonEnums
{
    public enum PortalUserRole
    {
        GlobalAdmin = 0,
        AccountManager = 3,
        ChannelPartner = 6,
        CompanyAdmin = 10,
        CompanyExecutive = 12,
        GlobalSalesManager = 20,
        NationalSalesManager = 30,
        ZonalSalesManager = 40,
        RegionalAdmin = 45,
        RegionalSalesManager = 50,
        AreaSalesManager = 60,
        Distributor = 70,
        ClientEmployee = 80,
        Unknown = 1000,
        ConglomerateUser = 200
    }

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

    public enum UserType
    {
        SR = 0,
        ISR = 1,
        Supervisor = 2,
        DSR = 3
    }
}
