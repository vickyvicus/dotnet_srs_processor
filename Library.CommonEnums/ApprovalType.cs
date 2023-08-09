using NpgsqlTypes;

namespace Library.CommonEnums
{
    public enum ApprovalType
    {
        [PgName("po")]
        po,
        [PgName("so")]
        so,
        [PgName("invoice")]
        invoice,
        [PgName("claim")]
        claim
    }

    public enum ApprovalStatus
    {
        [PgName("pending")]
        pending,
        [PgName("approved")]
        approved,
        [PgName("rejected")]
        rejected,
        [PgName("handled_by_someone_else")]
        handled_by_someone_else,
        [PgName("awaiting_at_other_level")]
        awaiting_at_other_level
    }
}
