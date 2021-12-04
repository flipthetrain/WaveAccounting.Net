using Wave.Schema.Attributes;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record SalesTaxArchiveInput(string id//The unique identifier for the sales tax.
                                        )
    {
    }
}
