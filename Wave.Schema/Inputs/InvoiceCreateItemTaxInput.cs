using Wave.Schema.Attributes;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record InvoiceCreateItemTaxInput(string salesTaxId //Sales tax.
                )
    {
    }
}
