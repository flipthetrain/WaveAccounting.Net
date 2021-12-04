using Wave.Schema.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record CustomerConnection(CustomerEdge[] edges,//List of customers.
                                    OffsetPageInfo pageInfo //Information about pagination.
                                    )
    {
    }
}
