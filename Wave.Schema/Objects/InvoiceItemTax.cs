using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;

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
