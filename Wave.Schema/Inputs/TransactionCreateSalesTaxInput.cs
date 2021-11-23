using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record TransactionCreateSalesTaxInput(string abbreviation,//Tax Abbreviation.
                                                float amount//Tax Amount.
                                                )
    {
    }
}
