using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Schema.Objects;

namespace Wave.Schema.Outputs
{
    public record SalesTaxPatchOutput(SalesTax salesTax,//Sales tax that was patched.
bool didSucceed,//Indicates whether the sales tax was successfully patched.
InputError[] inputErrors //Mutation validation errors.
)
    {
    }
}
