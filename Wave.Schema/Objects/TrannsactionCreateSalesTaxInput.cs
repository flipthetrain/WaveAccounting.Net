using Wave.Schema.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record TrannsactionCreateSalesTaxInput(String abbreviation,//Tax Abbreviation.
                                                    float amount//Tax Amount.
                                                    )
    {
    }
}
