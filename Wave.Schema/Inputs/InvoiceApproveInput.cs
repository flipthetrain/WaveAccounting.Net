using Wave.Schema.Attributes;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record InvoiceApproveInput(string invoiceId //The unique identifier for the invoice.
                                        )
    {
    }
}
