namespace Libraries.CommonEnums
{
    public enum NewOutletFields
    {
        Market = 1,
        ContactName = 2,
        ContactNo = 3,
        District = 4,
        State = 5,
        PinCode = 6,
        Email = 7,
        GSTIN = 8,
        ShopType = 9,
        Segmentation = 10,
        Channel = 11,
        Image = 12,
        PAN = 13,
        Aadhar = 14,
        GSTRegistered = 15,
        BankAccountNumber = 16,
        AccountHoldersName = 17,
        IFSCCode = 18,
        PlaceOfDelivery = 19,
        //skipped 20-27 since those are used by jockey
        AttributeText1 = 28,
        AttributeText2 = 29,
        AttributeText3 = 30,
        AttributeText4 = 31,
        AttributeNumber1 = 32,
        AttributeNumber2 = 33,
        AttributeNumber3 = 34,
        AttributeNumber4 = 35,
        AttributeBoolean1 = 36,
        AttributeBoolean2 = 37,
        AttributeDate1 = 38,
        AttributeDate2 = 39,
        AttributeImage1 = 40,
        AttributeImage2 = 41,
        AttributeImage3 = 42
    }
    public enum CalculateOutletLocationAttributesType
    {
        None = 0,
        CalculateAtNewOutlets = 1,
        CalculateAtAllOutlets = 2,
    }
}
