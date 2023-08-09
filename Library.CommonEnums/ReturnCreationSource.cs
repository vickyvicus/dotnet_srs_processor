using NpgsqlTypes;

namespace Library.CommonEnums
{
    public enum ReturnCreationSource
    {
        [PgName("dms")]
        DMS,
        [PgName("sfa")]
        SFA,
        [PgName("van-sales")]
        VanSales,

        [PgName("pre-sales")]
        PRE_SALES,
    }
}
