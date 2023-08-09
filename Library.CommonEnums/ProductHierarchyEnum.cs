namespace Libraries.CommonEnums
{
    public enum ProductHierarchyEnum
    {
        Product = 0,
        SecondaryCategory = 1,
        PrimaryCategory = 2,
        FocussedProduct = 3,
        ProductMustSell = 4,
        Assorted = 5
    }
    public enum CategoryEnum
    {
        PrimaryCategory = 1,
        SecondaryCategory = 2,
        ProductDivision = 3
    }
    public enum ProductHierarchy
    {
        NoFilter = 0,
        Division = 10,
        PrimaryCategory = 20,
        SecondaryCategory = 30,
        Product = 40
    }
}
