using Wave.Schema.Attributes;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record InvoiceDeleteInput(string invoiceId //The unique identifier for the invoice.
                                    )
    {
    }
}
