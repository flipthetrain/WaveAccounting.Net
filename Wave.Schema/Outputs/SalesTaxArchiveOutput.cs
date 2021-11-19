using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Schema.Objects;

namespace Wave.Schema.Outputs
{
    public record SalesTaxArchiveOutput(SalesTax salesTax,//Sales tax that was archived.
bool didSucceed,//Indicates whether the sales tax was successfully deleted.
InputError[] inputErrors //Mutation validation errors.
)
    {
    }
}
