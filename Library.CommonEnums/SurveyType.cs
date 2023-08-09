using System.Runtime.Serialization;

namespace Libraries.CommonEnums
{
    public enum SurveyType
    {
        [EnumMember(Value = "shopVisit")]
        ShopVisit = 0,
        [EnumMember(Value = "newShopAddition")]
        NewShopAddition = 1,
        [EnumMember(Value = "productSurvey")]
        ProductSurvey = 2,
        [EnumMember(Value = "isrVisit")]
        ISRVisit = 3,
        [EnumMember(Value = "noSales")]
        NoSales = 4,
        [EnumMember(Value = "feedbackSurvey")]
        FeedbackSurvey = 5,
        [EnumMember(Value = "complaint")]
        Complaint = 6,
        [EnumMember(Value = "dayStart")]
        DayStart = 7,
        [EnumMember(Value = "dayEnd")]
        DayEnd = 8,
        [EnumMember(Value = "distributorStock")]
        DistributorStock = 9,
        [EnumMember(Value = "independentSurvey")]
        IndependentSurvey = 10,
        [EnumMember(Value = "telephonicShopVisit")]
        TelephonicShopVisit = 11,
        [EnumMember(Value = "regularShopVisit")]
        RegularShopVisit = 12,
        [EnumMember(Value = "managerJointWorking")]
        ManagerJointWroking = 13,
        [EnumMember(Value = "managerDistributorVisit")]
        ManagerDistributorVisit = 14,
        [EnumMember(Value = "managerDistributorSearch")]
        ManagerDistributorSearch = 15,
        [EnumMember(Value = "managerPromotionalActivity")]
        ManagerPromotionalActivity = 16,
        [EnumMember(Value = "managerOtherSurveys")]
        ManagerOtherActivity = 17,
        [EnumMember(Value = "consumerInteraction")]
        ConsumerInteraction = 18,
        [EnumMember(Value = "supervisorShopVisit")]
        SupervisorShopVisit = 19,

        //Action Card Task types
        [EnumMember(Value = "offerExecution")]
        Offer_Execution = 20,
        [EnumMember(Value = "shelfOrganization")]
        Shelf_Organization = 21,
        [EnumMember(Value = "newProductPlacement")]
        New_Product_Placement = 22,
        [EnumMember(Value = "storeAudit")]
        Store_Audit = 23,
        [EnumMember(Value = "isrAudit")]
        ISR_Audit = 24,
        [EnumMember(Value = "competitorInformation")]
        Competitor_Information = 25,
        [EnumMember(Value = "other")]
        Other = 26,

        [EnumMember(Value = "ManagerRetailingJW")]
        ManagerRetailingJW = 27,

        [EnumMember(Value = "IsFocusedPhysicalVisit")]
        IsFocusedPhysicalVisit = 28,
        [EnumMember(Value = "BeforeCallPhysicalVisit")]
        BeforeCallPhysicalVisit = 29,
        [EnumMember(Value = "OfficialWorkSurvey")]
        OfficialWorkSurvey = 30,
        [EnumMember(Value = "In-Store Execution")]
        InStoreExecution = 31,
        [EnumMember(Value = "Other Activity 1")]
        OtherActivity1 = 32,
        [EnumMember(Value = "Other Activity 2")]
        OtherActivity2 = 33,
        [EnumMember(Value = "Other Activity 3")]
        OtherActivity3 = 34
    }
}
