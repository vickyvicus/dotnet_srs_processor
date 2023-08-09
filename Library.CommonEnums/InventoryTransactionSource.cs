using NpgsqlTypes;

namespace Library.CommonEnums
{
    public enum InventoryTransactionSource
    {
        [PgName("excel_upload")]
        EXCEL_UPLOAD,
        [PgName("good_received")]
        GOOD_RECEIVED,
        [PgName("delivery")]
        DELIVERY,
        [PgName("good_return")]
        GOOD_RETURN,
        [PgName("inventory_adjustment")]
        INVENTORY_ADJUSTMENT,
        [PgName("delivery_cancelled")]
        DELIVERY_CANCELLED,
        [PgName("bulk_insert")]
        BULK_INSERT,
        [PgName("bulk_update")]
        BULK_UPDATE
    }

    public enum MovementType
    {
        [PgName("in")]
        IN,
        [PgName("out")]
        OUT,
        [PgName("excel_upload")]
        EXCEL_UPLOAD
    }
}
