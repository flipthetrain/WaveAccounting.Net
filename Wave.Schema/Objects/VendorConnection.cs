using Wave.Schema.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record VendorConnection(VendorEdge[] edges,//List of vendors.
                                OffsetPageInfo pageInfo //Information about pagination.
                                )
    {
    }
}
