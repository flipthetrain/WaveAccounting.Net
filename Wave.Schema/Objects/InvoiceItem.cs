using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;
using Wave.Schema.Objects;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record InvoiceItem(string description,//Detailed description.
                                Decimal quantity,//Number of units.
                                Decimal unitPrice,//Price per unit in the major currency unit.
                                Money subtotal,//Pretax total.
                                Money total,//Total including sales taxes.
                                InvoiceItemTax[] taxes,//Taxes.
                                Account account,//Income account.
                                Product product //Associated product.
                                )
    {
    }
}
