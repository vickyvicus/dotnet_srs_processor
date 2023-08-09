namespace Libraries.CommonEnums
{
    public enum SearchType
    {
        Beat = 0,
        Shop = 1,
        Route = 2
    }
    public enum TelecallingRole
    {
        None = 0,
        Telecaller = 1100,
        Telemanager = 1200
    }
    public enum OrderOwner
    {
        Telecaller = 0,
        Salesman = 1
    }

    public enum SchemeDiscountType
    {
        Unknown = 0,
        Cash_Discount = 1,       // Can Avail bill Amount reduction equal to the Cash Discount
        FOC = 2,                 //Allows to use the Discount Amount only for Purchase in smae Block
        Article = 3,
        Open_FOC = 4,
        Other_Discount = 100
    }

}
