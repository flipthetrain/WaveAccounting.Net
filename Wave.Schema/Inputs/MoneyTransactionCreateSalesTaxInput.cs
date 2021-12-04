using Wave.Schema.Attributes;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record MoneyTransactionCreateSalesTaxInput(string salesTaxId,//ID of the sales tax.
                                                    decimal amount //Override the amount of the tax (unsigned).
                                                    )
    {
    }
}
