﻿using System.ComponentModel.DataAnnotations;

namespace Libraries.CommonEnums
{
    public enum EnumForReportAssembly
    {
        Unknown = 0,
        [Display(Name = "Activity Report")]
        ActivityDesign = 40,
        [Display(Name = "Attendance Report")]
        AttendanceReport = 100,
        [Display(Name = "Outlet Wise Sales Report(GeoGraphy)")]
        OutletWiseSalesReport = 180,
        [Display(Name = "Outlet Wise Sales Report(EmpHierarchy)")]
        OutletWiseSalesReportEmpHierarchy = 181,
        [Display(Name = "Outlet Wise Sales Report(V4)")]
        OutletWiseSalesReportV4 = 182,
        [Display(Name = "Daily Sales Report")]
        DetailedSalesReport = 200,
        [Display(Name = "No Sales Reason Analysis")]
        NoSalesAnalysisReport = 210,
        [Display(Name = "Daily Sales Report")]
        DeliveryOrderFlatDesign = 250,
        [Display(Name = "Outlet Wise Target Report")]
        OutletWiseTarget = 270,
        [Display(Name = "Outlet Wise And Primary Category Wise Target Report")]
        OutletWiseTargetPC = 280,
        [Display(Name = "People Performance Report")]
        PeoplePerformanceReport = 290,
        [Display(Name = "Summary Report")]
        SummarySheet = 300,
        [Display(Name = "Summary Report")]
        SummarySheetUsingPivot = 305,
        [Display(Name = "ISR Summary Report (VMT)")]
        ISRSummaryReportVMT = 306,
        [Display(Name = "Opening Closing Stock Report")]
        OpeningClosingReport = 310,
        [Display(Name = "Opening Closing Stock Report Detailed")]
        OpeningClosingReportDetailed = 315,

        //GetSalesDump = 310,
        [Display(Name = "AttendanceSummary")]
        NewAttendanceSummary = 440,
        [Display(Name = "Attendance Summary Second Sheet")]
        NewAttendanceSummarySecondsheet = 450,
        [Display(Name = "Attendance Report(Reports Perspective)")]
        AttendanceReportFromReportPerspective = 451,
        [Display(Name = "Category Analysis")]
        CategoryAnalysis = 460,
        [Display(Name = "Category Analysis Report")]
        CategoryAnalysisReport = 465,

        [Display(Name = "Month On Month Category Analysis")]
        MonthOnMonthCategoryAnalysis = 470,
        [Display(Name = "Category Analysis Report(V4)")]
        CategoryAnalysisReportFromPerspective = 471,
        [Display(Name = "Month On Month Category Analysis(V4)")]
        MonthOnMonthCategoryAnalysisFromPerspective = 472,
        /// <summary>
        /// enum for dump
        /// </summary>
        [Display(Name = "Sales Secondary Order Dump")]
        FlatSales = 320,
        [Display(Name = "Sales Secondary Order Dump")]
        FlatSalesWithParams = 321,
        [Display(Name = "Sales Secondary Order Dump ZSM-All")]
        FlatSalesWithAllAtZSM = 322,
        [Display(Name = "Sales Secondary Order Dump(From Perspective)")]
        FlatSalesFromReportPerspective = 323,
        [Display(Name = "Sales Secondary Order Dump(From Perspective created in Parts)")]
        FlatSalesFromReportPerspectiveCreatedInPartsMechanism = 324,
        [Display(Name = "Sales Dump Report with Geographical filters")]
        FlateSalesGeographicalHierarchy = 325,
        [Display(Name = "Sales Secondary Order Dump (Dist From Sales)")]
        FlatSalesDistFromSales = 326,
        [Display(Name = "Sales Secondary Order Dump (Live)")]
        FlatSalesLive = 327,
        [Display(Name = "No Sales Reason Report")]
        NoSalesReasonReport = 328,
        [Display(Name = "Retailer Stock Report")]
        FlatRetailerStockReport = 330,
        [Display(Name = "Return Replacement Dump Report")]
        FlatSaleReturnReplacement = 340,
        [Display(Name = "Distributor Stock Dump Report")]
        FlatDistributorStock = 350,
        [Display(Name = "Flat Secondary Order Validation Dump ")]
        SecondaryOrderValidationReport = 360,
        [Display(Name = "Flat Secondary Order Validation Dump(From Perspective)")]
        SecondaryOrderValidationReportFromReportPerspective = 361,
        [Display(Name = "Flat Secondary Order Validation Dump ")]
        SecondaryOrderValidationReportWithParams = 351,
        [Display(Name = "Employee-Distributor Performance Report")]
        EmployeePerformanceReport = 370,
        [Display(Name = "Employee Performance Report")]
        EmployeePerformanceReportFromReportsPerspective = 375,
        [Display(Name = "Outlet Coverage Efficiency Report")]
        LVCR = 380,
        [Display(Name = "Summary Sheet PD Wise(From Perspective)")]
        SummarySheetPDWiseFromPerspective = 389,
        [Display(Name = "Summary Sheet")]
        SummarySheet_SC = 390,
        [Display(Name = "Summary Sheet Jockey")]
        SummarySheetJockey = 391,
        [Display(Name = "Summary Sheet Jockey(From Perspective)")]
        SummarySheetJockeyFromPerspective = 392,
        [Display(Name = "Summary Sheet PC Wise(From Perspective)")]
        SummarySheetFromPerspective = 393,
        [Display(Name = "Summary Sheet SC Wise(From Perspective)")]
        SummarySheetSCWiseFromPerspective = 394,
        [Display(Name = "Summary Sheet SC Wise New Ids(From Perspective)")]
        SummarySheetSCWiseFromPerspectiveUsingNewIds = 395,
        [Display(Name = "Summary Sheet MT")]
        SummarySheetMT = 396,
        [Display(Name = "Manager Working Report(V4)")]
        SummarySheetManagerWorkingFromPerspective = 397,
        [Display(Name = "Summary Sheet MT SuperVisor")]
        SummarySheetMTSuperVisor = 398,
        [Display(Name = "People Performance Report")]
        PeoplePerformanceReportSC = 400,
        [Display(Name = "Month on Month Employee Performance")]
        MOMEmpPerformance = 410,
        [Display(Name = "Modern Trade Tertiary Sales")]
        ModernTradeTeritiarySales = 480,
        [Display(Name = "Modern Trade Store Stock")]
        ModernTradeStoreStock = 490,
        [Display(Name = "Modern Trade Store Stock (VMT)")]
        ModernTradeStoreStockVMT = 495,
        [Display(Name = "Modern Trade Purchase Orders")]
        ModernTradePurchaseOrdedrs = 500,
        [Display(Name = "Modern TradeFill Rate")]
        ModernTradeFillRate = 510,
        [Display(Name = "MT Focus Product Report V4")]
        MTFocusProductReportFromV4 = 1036,
        //[Display(Name = "Beat Performance Report")]
        //BeatPerformanceReport = 520,
        [Display(Name = "ASM RSM Working")]
        ASMRSMWorking = 530,
        [Display(Name = "New Outlet Sale Report")]
        NewOutletSale = 540,
        [Display(Name = "New KRA Target Report")]
        NewKRATargetReport = 560,
        [Display(Name = "Employee Wise Target Report")]
        EmployeeWiseTargetReport = 570,
        [Display(Name = "Employee Wise Target Report")]
        EmployeeWiseTargetReportOverAll = 575,
        [Display(Name = "Detailed Sales Report Book")]
        DetailedSalesReportBook = 580,
        [Display(Name = "Dist. Performance Report(On Basis)")]
        DistributorPerformanceOnBasis = 550,
        [Display(Name = "New Activity Sheet")]
        NewActivitySheet = 430,
        [Display(Name = "Product Survey Response Report")]
        ProductSurveyResponseReport = 600,
        [Display(Name = "Flat Scheme Sales")]
        FlatSchemeSales = 610,
        [Display(Name = "Flat Primary Order Report")]
        FlatPrimaryOrderReport = 620,
        [Display(Name = "Consolidated Survey Report")]
        ConsolidatedSurveyReport = 630,
        [Display(Name = "Flat Survey Report")]
        FlatSurveyReport = 635,
        [Display(Name = "Daily Summary")]
        FlatSurveyReportDailySummary = 636,
        [Display(Name = "Flat Survey Report V4")]
        FlatSurveyReportFromV4 = 637,
        [Display(Name = "Embedded Daily Email")]
        EmbeddedDailyEmail = 640,
        [Display(Name = "OutletDump GeoHierarchy")]
        OutletDumpGeoHierarchy = 650,
        [Display(Name = "OutletDump EmpHierarchy")]
        OutletDumpEmpHierarchy = 660,
        [Display(Name = "Tour Plan Submission Report")]
        TourPlanSubmission = 670,
        [Display(Name = "PJP Adherence Report")]
        PJPAdherence = 680,
        [Display(Name = "PJP Adherence Report(V4)")]
        PJPAdherenceFromReportPerspective = 681,
        [Display(Name = "PJP Adherence Report All Seg(V4) ")]
        PJPAdherenceFromReportPerspectiveAllSeg = 682,
        [Display(Name = "Payment Collection Flat Report")]
        FlatPaymentReport = 690,
        [Display(Name = "OCER")]
        OCER = 700,
        [Display(Name = "OCER")]
        OCERFromReport = 701,
        [Display(Name = "BCER")]
        BCER = 710,
        [Display(Name = "Flat Star TV Report")]
        FlatStarTVReport = 720,
        [Display(Name = "Brand Wise MTD Report")]
        BrandWiseMTDReport = 730,
        [Display(Name = "Flat Returns Report Dump")]
        FlatRetailerReturnReportDump = 740,
        [Display(Name = "Flat Returns Report")]
        FlatRetailerReturnReport = 745,
        [Display(Name = "TA DA Report")]
        TADAReport = 750,
        [Display(Name = "Delivery Order Apparel")]
        DeliveryOrderApparel = 760,
        [Display(Name = "Flat Dist Sales Report")]
        FlatSalesDistFromSalesWithoutParams = 770,
        [Display(Name = "Flat Walk-In Order Report")]
        FlatWalkInOrderReport = 780,
        [Display(Name = "Stock Inward Report")]
        StockInwardReport = 790,
        [Display(Name = "Stock Inward Report (VMT)")]
        StockInwardReportVMT = 795,
        [Display(Name = "Stock Tertiary Report")]
        StockTertiaryReport = 800,
        [Display(Name = "Stock Tertiary Report (VMT)")]
        StockTertiaryReportVMT = 805,
        [Display(Name = "Route Change Request Report")]
        RouteChangeRequestReport = 810,
        [Display(Name = "Modern Trade Closing Stock Report")]
        ModernTradeClosingStockReport = 820,
        [Display(Name = "Modern Trade Closing Stock Report (VMT)")]
        ModernTradeClosingStockReportVMT = 825,
        [Display(Name = "Outlet Creation Request Dump Report")]
        OutletCreationRequestReport = 830,
        [Display(Name = "Master Data Dump Outlet Count Report")]
        MasterDataDumpOutletCountReport = 840,
        [Display(Name = "Image Recognition Report")]
        ImageRecognitionReport = 850,
        [Display(Name = "Summary Report2.0")]
        SummaryReportVersion2 = 860,
        [Display(Name = "Image Auditing Report - Total Score")]
        ImageAuditingReportTotalScore = 870,
        [Display(Name = "Must Sell Report")]
        MustSellReportFromReportPerspective = 880,
        [Display(Name = "KRA Adherence Report")]
        KRAAdherenceReportFromReportPerspective = 890,
        [Display(Name = "New Outlet Detailed Report(V4)")]
        NewOutletDetailedReport = 900,
        [Display(Name = "Employee Productivity Report(V4)")]
        EmployeeProductivityReportFromPerspective = 910,
        [Display(Name = "Focus Product Report V4")]
        FocusProductReportFromV4 = 917,
        [Display(Name = "Tour Plan Adherence Report(V4)")]
        TourPlanAdherenceReportFromPerspective = 920,
        [Display(Name = "EOCER Report(V4)")]
        EOCERFromPerspective = 930,
        [Display(Name = "Outlet Reach Report(V4)")]
        OutletReachReportV4 = 935,
        [Display(Name = "BVCR Report(V4)")]
        BVCRFromPerspective = 940,
        [Display(Name = "Daily Distributor Sales Report")]
        DailyDistributorSalesReport = 945,
        [Display(Name = "Time Line Report")]
        TimeLineReport = 950,
        [Display(Name = "Daily Location Report(V4)")]
        DailyLocationReportV4 = 960,
        [Display(Name = "Transaction Dump Report(V4)")]
        TransactionDumpReport = 970,
        [Display(Name = "Opening Closing Stock Report(V4)")]
        OpeningClosingStockReportV4 = 980,
        [Display(Name = "Route Plan Report(V4)")]
        RoutePlanReport = 990,
        [Display(Name = "Other")]
        Other = 1000,
        [Display(Name = "Visit DumpReport(V4)")]
        VisitDumpReportFromPerspective = 1010,
        [Display(Name = "Employee Wise Target Vs Ach. Report")]
        EmployeeWiseTargetVsAch = 1015,
        [Display(Name = "New MT Employee Wise Target Vs Ach. Report")]
        MTEmployeeTargetVsAch = 1016,
        [Display(Name = "MTCalculatedClosingReport")]
        MTCalculatedClosingReport = 1020,
        [Display(Name = "MTCalculatedClosingReport (VMT)")]
        MTCalculatedClosingReportVMT = 1025,
        [Display(Name = "MT Employee Wise Target Vs Ach. Report")]
        MTEmployeeWiseTargetVsAch = 1030,
        [Display(Name = "MT Attendance Report(V4)")]
        MTAttendanceReport = 1035,
        [Display(Name = "Daily Stats Report Live(V4)")]
        DailyStatsReportLiveV4 = 1040,
        [Display(Name = "Dead Outlet Report")]
        DeadOutletReport = 1050,
        [Display(Name = "Employee Distributor Performance Report (New)")]
        EmployeeDistributorPerformanceReport = 1060,
        [Display(Name = "Live Primary Order Report")]
        LivePrimaryOrderReport = 1065,
        [Display(Name = "Payment Collection Report")]
        PaymentCollectionReport = 1070,
        [Display(Name = "Battle Ground Report")]
        BattleGroundReport = 1075,
        [Display(Name = "MT Summary Report (V4)")]
        MTSummaryReport = 1080,
        [Display(Name = "MT Performance Analysis Report")]
        MTPerformanceAnalysisReport = 1085,
        [Display(Name = "MT ISR Summary Report(V4)")]
        MTISRSummaryReport = 1090,
        [Display(Name = "Flat Scheme Performance Report (New)")]
        FlatSchemePerformanceReport = 1095,
        [Display(Name = "Outlet Target Report (V4)")]
        OutletTargetReportV4 = 1100,
        [Display(Name = "New Outlet Detailed Report (Hybrid)(V4)")]
        NewOutletDetailedHybridReport = 1105,
        [Display(Name = "Van Stock Report")]
        VanStockReport = 1110,


        [Display(Name = "Jockey ExtApi Sales Dispatch")]
        JockeyRetailerSalesDispatch = 4001,
        [Display(Name = "Flexible Report")]
        FlexibleReport = 4004,
        [Display(Name = "Monthly Distributor Stock Report")]
        MonthlyDistributerStockReport = 5004,
        [Display(Name = "DateWise Distributor Stock Report")]
        DateWiseDistributerStockReport = 5017,

        [Display(Name = "Monthly Primary Sales Report")]
        PrimarySalesReport_FromMaster = 5005,
        [Display(Name = "Primary Orders Report")]
        PrimaryOrdersReport = 5006,
        [Display(Name = "User Login Activity")]
        UserLoginActivity = 5007,
        [Display(Name = "Sales Secondary Order Productive Dump(From Perspective)")]
        FlatSalesFromReportPerspectiveIsProductive = 5008,
        [Display(Name = "User Journey Location Report")]
        UserJourneyLocationReport = 5016,

        // from here these reports are LDMS Report- field assist report should be added above this.
        [Display(Name = "LDMS Flat Sales")]
        LDMSFlatSales = 5001,
        [Display(Name = "LDMS Claims")]
        LDMSClaimReports = 5002,
        [Display(Name = "LDMS Inventory")]
        LDMSInventory = 5003,
        [Display(Name = "Invoice Report")]
        InvoiceReport = 5009,
        [Display(Name = "OutletCategoryWiseSales Report")]
        OutletCategoryWiseSalesReport = 5010,
        [Display(Name = "Invoice Report For Account Manager")]
        InvoiceReportForAccountManager = 5015,
        [Display(Name = "L3M Emp Analysis")]
        L3MEmpAnalysis = 5020,
        [Display(Name = "TADA Expense Dump")]
        TADAExpenseDump = 5025,
        [Display(Name = "Monthly TADA Expense Dump")]
        TADAExpenseDumpMonthly = 5026,
        [Display(Name = "Opening Closing Stock Report V4")]
        OpeningClosingReportV4 = 312,
        [Display(Name = "Personalized Secondary Order Dump")]
        PersonalizedSecondaryOrderDump = 329,
        [Display(Name = "Payment Collection Report VanSales")]
        PaymentCollectionReportVanSales = 1071,
        [Display(Name = "MT Live Attendance")]
        MTLiveAttendance = 1120,
        [Display(Name = "Campaign Task Response Dump Report")]
        CampaignTaskResponseDumpReport = 1115,
        [Display(Name = "MT Campaign Stock Report")]
        MTCampaignStockReport = 1125,
        [Display(Name = "Shelf Share Report (VMT)")]
        MTShelfShareReport = 2005,
        MTPOandDispatchReportVMT = 2010,
        [Display(Name = "Open Campaign Response Report")]
        OpenCampaignResponseReport = 2020,
    }
}