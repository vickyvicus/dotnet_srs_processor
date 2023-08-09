using Libraries.CommonEnums;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.ApiClients.Models
{
    public class CompanySettingModel
    {
        public JourneyPlanType JourneyPlanType { get; set; }
        public List<string> OfficialWorkType { get; set; }
        public Dictionary<string, string> NomenClature { get; set; }
        public bool UsesConversionFactor { get; set; }
        public bool UsesVanSales { get; set; }
        public bool IsPrintingAvailable { get; set; }
        public TypeofTaxCalculation TypeOfTaxCalculation { get; set; }
        public bool UsesCloseToExpiry { get; set; }
        public bool UsesRetailerStock { get; set; }
        public string DiscountType { get; set; }
        public bool UsesDistributorCashDiscount { get; set; }
        public List<string> MustSellResaons { get; set; }
        public List<string> ReasonForNotTakingRetailerStock { get; set; }
        public List<string> ReasonForProductReturn { get; set; }
        public List<string> TaskRejectionReason { get; set; }
        public string CurrencySymbol { get; set; }
        public TimeSpan TimeZone { get; set; }
        public String TypeofDistributorMapping { get; set; }
        public TypeofDistributorMapping TypeofDistributorMappingEnum { get; set; }
        public int NoOfDaysForMarkingDeadOutlet { get; set; }
        public bool TelephonicOrdersAvailable { get; set; }
        public int MaxOutletInBeatOrRoute { get; set; }
        public bool BlockOrderBookingIfNotPhysicallyPresent { get; set; }
        public bool CompanyUsesAddOutletRequest { get; set; }
        public bool NewOutletCreationByOTP { get; set; }
        public bool ShowShopAdditionScreen { get; set; }
        public double MapInvalidDistanceLimit { get; set; }
        public string NewOutletApprovalLevel { get; set; }
        public List<string> ReasonForJourneyDiversion { get; set; }
        public bool IsUsesOutletMargin { get; set; }
        public bool IsOrderReviewAllowed { get; set; }
        public bool UsesDistProdDivBeatMappings { get; set; }
        public bool UsesTabularWhatsAppOrderFormat { get; set; }
        public string DistributorStockType { get; set; }
        public int MinimumDaysForTourPlan { get; set; }
        public bool UsesIntelligentSchemes { get; set; }
        public bool UsesSecondarySales { get; set; }
        public bool UsesPrimaryOrder { get; set; }
        public bool CallReviewAllowedForPrimaryOrder { get; set; }
        public EmployeeTargetOn EmployeeTargetType { get; set; }
        public EmployeeTargetsCalculationType CalculateAchievementAgainstEmployeeTargets { get; set; }
        public bool DuplicateOutletCheckOnline { get; set; }
        public bool EnableExternalAssets { get; set; }
        public bool CompanyUsesOutletReach { get; set; }
        public bool UsesFocusProductTarget { get; set; }
        public string FABattleGround { get; set; }
        public bool IsCompanyUsingApparelUI { get; set; }
        public DuplicateOutletCheck DuplicateOutletCheck { get; set; }
        public CountryInfo CountryInfo { get; set; }
        public bool UsesApparelUI { get; set; }

        public bool AutoSyncCarryForwardStock { get; set; }
        public bool IsUsingLMS { get; set; }
        public bool UsesTADA { get; set; }
        public JArray FAFloIntegrationSettings { get; set; }
        public List<string> CityGrades { get; set; }
        public TargetOn TargetOn { get; set; }
        public bool UsesPaymentFeature { get; set; }
        public OrderBookingScreenType AppOrderBookingScreenType { get; set; }
        public string OutletWiseTarget { get; set; }
        public double GSTTaxCalculationPercentage { get; set; }
        public bool UsesFAUnify { get; set; }
        public bool UsesMonthWiseOpeningStockMT { get; set; }
        public int YearStartMonth { get; set; }
        public int MonthStartDate { get; set; }
        public bool MTCompanyUsesValidGeoLocationAtDayStart { get; set; }
        public bool EnableCustomerInteraction { get; set; }
        public bool tertiaryOfftakeManual { get; set; }
        public bool UsesJourneyCalendar { get; set; }
        public bool E11Company { get; set; }
        public bool SkipGeoFenceSecondTime { get; set; }
        public bool JockeyMTHackTertiarySales { get; set; }
        public bool UsesFaFlo { get; set; }

        public bool UsesAzureFaceApiDetection { get; set; }
        public bool UsesConsumerWiseTertiary { get; set; }
        public bool UpdatePriceViaPrimaryInvoice { get; set; }
        public bool CompanyUsesBatch { get; set; }
        public bool CompanyUsesDMSApprovalforVanLoadout { get; set; }
        public bool CompanyUsesDMSApprovalforVanLoadin { get; set; }
        public bool PurchasePriceInclusiveOfTax { get; set; }
        public bool CompanyUsesSrs { get; set; }
    }
}
