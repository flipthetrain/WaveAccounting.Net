using Wave.Schema.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record InvoiceConnection(InvoiceEdge[] edges,//List of invoices.
                                    OffsetPageInfo pageInfo //Information about pagination.
                                    )
    {
    }
}
