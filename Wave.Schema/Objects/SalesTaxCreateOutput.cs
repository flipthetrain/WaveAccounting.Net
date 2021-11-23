using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record SalesTaxCreateOutput(SalesTax salesTax,//Sales tax that was created.
                                    bool didSucceed,//Indicates whether the sales tax was successfully created.
                                    InputError[] inputErrors //Mutation validation errors.
                                    )
    {
    }
}
