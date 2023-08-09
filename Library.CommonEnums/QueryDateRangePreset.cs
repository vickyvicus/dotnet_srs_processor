using System.ComponentModel.DataAnnotations;

namespace Libraries.CommonEnums
{
    public enum QueryDateRangePreset
    {
        [Display(Name = "Today")]
        Today = 5,
        [Display(Name = "Yesterday")]
        Yesterday = 10,
        [Display(Name = "Last 7 Days")]
        Last7Days = 20,
        [Display(Name = "Last 30 Days")]
        Last30Days = 30,
        [Display(Name = "Last 3 Months")]
        Last3Months = 40,
        [Display(Name = "MTD")]
        MTD = 50,
    }

    public enum ChartType
    {
        [Display(Name = "Bar Chart")]
        Bar = 10,
        [Display(Name = "Additional Bar Chart")]
        AdditionalBar = 11,
        [Display(Name = "Table")]
        Table = 20,
        [Display(Name = "Column")]
        Pie = 30,
        [Display(Name = "Grouped Bar Chart")]
        Grouped = 40,
        [Display(Name = "FullPageTable")]
        FullPageTable = 50,
        [Display(Name = "One Number")]
        OneNumber = 60,
        [Display(Name = "Two Number")]
        TwoNumber = 70,
        [Display(Name = "KPI Chart")]
        KPIChart = 80
    }

    public enum ChartSize
    {
        [Display(Name = "Small")]
        small = 0,
        [Display(Name = "Medium")]
        medium = 10,
        [Display(Name = "Large")]
        large = 20,
    }

    public enum AggregationType
    {
        [Display(Name = "Sum")]
        sum = 0,
        [Display(Name = "Count")]
        count = 10,
    }

    public enum SortingType
    {
        [Display(Name = "Ascending")]
        ascending = 0,
        [Display(Name = "Descending")]
        descending = 10,
    }

    public enum ViewPerspective
    {
        Unknown = 0,
        [Display(Name = "Sales")]
        ProductWiseSales = 1,
        [Display(Name = "Day Summary")]
        DayStart = 2,
        [Display(Name = "No Sales Reason")]
        NoSalesReason = 3,
        [Display(Name = "Live Sales Data")]
        LiveSalesData = 4,
        [Display(Name = "Master Data")]
        MasterData = 5,
        [Display(Name = "Historical Sales Data")]
        HistoricalSalesData = 6,
        [Display(Name = "Stock And Sales")]
        MTStockAndSales = 10,
        [Display(Name = "Live Sales Data (MT)")]
        MTLiveSalesData = 11,
        [Display(Name = "Master+Visit")]
        MasterVisit = 12,
        [Display(Name = "Trend Report Non Linear Time")]
        TrendReportNLT = 13,
        [Display(Name = "Trend Report Linear Time")]
        TrendReportLT = 14,
    }

    public enum ComparisonTimePeriod
    {
        Unkown = 0,
        [Display(Name = "Today")]
        Day = 5,
        [Display(Name = "Current Week")]
        Week = 10,
        [Display(Name = "MTD")]
        Month = 15,
    }

    public enum ComparisonType
    {
        Unkown = 0,
        [Display(Name = "Yesterday")]
        Yesterday = 5,
        [Display(Name = "Last Week")]
        LastWeek = 10,
        [Display(Name = "LMTD")]
        LastMonth = 15,
        [Display(Name = "Last Month Current Week")]
        LastMonthCurrentWeek = 20,
        [Display(Name = "Last Month Current Day")]
        LastMonthCurrentDay = 25,
        //[Display(Name = "This month average")]
        //ThisMonthAverage = 30,
    }

    public enum PerspectiveMeasure
    {
        Unknown = 0,
        CountDistinct = 1,
        Count = 2,
        Bool = 3,
        Sum = 4,
        Avg = 5,
        Percent = 6,
        Value = 7
    }
    public enum DateRangePreset
    {
        //[Display(Name = "Custom")]
        //Custom =0,
        [Display(Name = "Today")]
        Today = 5,
        [Display(Name = "Yesterday")]
        Yesterday = 10,
        [Display(Name = "Last 7 Days")]
        Last7Days = 20,
        [Display(Name = "Last 30 Days")]
        Last30Days = 30,
        [Display(Name = "Last 3 Months")]
        Last3Months = 40,
        [Display(Name = "MTD")]
        MTD = 50,
        [Display(Name = "Custom Date")]
        Unknown = 0,
    }
}
