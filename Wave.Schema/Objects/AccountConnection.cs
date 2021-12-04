using Wave.Schema.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record AccountConnection(AccountEdge[] edges,//List of accounts from the Chart of Accounts.
                                    OffsetPageInfo pageInfo //Information about pagination.
                                    )
    {
    }
}
