using Wave.Schema.Attributes;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record InvoiceCloneInput(string invoiceId //The unique identifier for the invoice.
                                     )
    {
    }
}
