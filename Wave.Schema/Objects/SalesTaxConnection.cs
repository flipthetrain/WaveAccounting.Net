using Wave.Schema.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record SalesTaxConnection(SalesTaxEdge[] edges,//List of sales taxes.
                                        OffsetPageInfo pageInfo //Information about pagination.
                                        )
    {
    }
}
