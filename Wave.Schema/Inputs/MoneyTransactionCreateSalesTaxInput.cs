using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record MoneyTransactionCreateSalesTaxInput(string salesTaxId,//ID of the sales tax.
                                                    decimal amount //Override the amount of the tax (unsigned).
                                                    )
    {
    }
}
