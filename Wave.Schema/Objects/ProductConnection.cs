using Wave.Schema.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record ProductConnection(ProductEdge[] edges,//List of products.
                                    OffsetPageInfo pageInfo //Information about pagination.
                                    )
    {
    }
}
