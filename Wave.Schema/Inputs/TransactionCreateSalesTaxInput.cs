using Wave.Schema.Attributes;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record TransactionCreateSalesTaxInput(string abbreviation,//Tax Abbreviation.
                                                float amount//Tax Amount.
                                                )
    {
    }
}
