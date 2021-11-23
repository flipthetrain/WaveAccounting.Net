using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record TrannsactionCreateSalesTaxInput(String abbreviation,//Tax Abbreviation.
                                                    float amount//Tax Amount.
                                                    )
    {
    }
}
