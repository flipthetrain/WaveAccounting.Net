using Wave.Schema.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record BusinessConnection(BusinessEdge[] edges,//List of businesses.
                                    OffsetPageInfo pageInfo //Information about pagination.
                                    )
    {
    }
}
