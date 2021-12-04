using Wave.Schema.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record InvoiceItemTax(Money amount,//Sales tax amount.
                                Decimal rate,//Sales tax rate.
                                SalesTax salesTax //Sales tax.
                                )
    {
    }
}
