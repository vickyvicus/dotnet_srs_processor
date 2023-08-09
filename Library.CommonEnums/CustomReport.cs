using System.ComponentModel.DataAnnotations;

namespace Libraries.CommonEnums
{
    public enum FilterType
    {
        None = 0,
        Geography = 1,
        EmployeeHierarchy = 2,
        EmployeeGeographicalHierarchy = 3,
        DumpRequest = 4,
        EmployeeHierarchyWithRankAndCategory = 5,
        EmployeeHierarchyWithRankAndCategoryAndBasis = 6,
        ProductHierarchy = 7,
        EmployeeHierarchyWithSurvey = 8,
        EmployeeHierarchyWithProductHierarchy = 9,
        EmployeeGeographicalHierarchyWithPC = 10,
        EmployeeHierarchyWithPCAndBasis = 11,
        GeographicalDistributorSelection = 12,
        EmployeeHierarchyWithRankAndCategoryAndBasisAndProductHierarchy = 13,
        EmployeeHierarchySelectionUsingEmployeeTable = 14,
        EmployeeHierarchyWithRankAndCategoryAndBasisAndProductHierarchyPromotedProduct = 15,
        EmployeeHierarchySelectionUsingEmployeeTableWithKRATags = 16,
        EmployeeHierarchyWithCategory = 17,
        EmployeeHierarchySelectionWithKRATags = 18,
        EmployeeHierarchySelectionUsingEmployeeTableAndRank = 19,
        EmployeeHierarchyWithFieldUserType = 20,
        EmployeeHierarchyWithManagerFilters = 21,
        EmployeeHierarchyProductHierarchyWithFocusAndMustSellProducts = 22,
        PositionCodeHierarchy = 23,
        EmployeeHierarchyMultiSelect = 24,
        GeographyMultiSelect = 25,
        EmployeeHierarchyMultiSelectWithFieldUserType = 26,
        EmployeeMSPositionMSCategoryMS = 27,
    }
    public enum DateFiltersType
    {
        None = 0,
        DateRange = 1,
        SingleDate = 2,
        SingleMonth = 3,
        MonthRange = 4,
        JourneyCalendar = 5,
        Quarter = 6
    }
    public enum ReportFrequency
    {
        Daily = 0,
        Weekly = 1,
        Monthly = 2,
        Qaurterly = 3,
        Yearly = 4,
    }
    public enum CategoryName
    {
        [Display(Name = "Employee Details")]
        Employee,
        [Display(Name = "Superstockist / Distributor Details")]
        Distributor,
        [Display(Name = "Beat / Route Details")]
        BeatRoute,
        [Display(Name = "Outlet Details")]
        Outlet,
        [Display(Name = "Order Details")]
        Order,
        [Display(Name = "Product Details")]
        Product,
        [Display(Name = "Scheme Details")]
        Scheme,
        [Display(Name = "Position Details")]
        Position
    }
    public enum ReportCategory
    {
        Others = 0,
        Attendance = 1,
        Sales = 2,
        Analysis = 3,
        Dump_Data = 4,
        MT_ISR_Reports = 5,
        Long_Duration = 6
    }
}
