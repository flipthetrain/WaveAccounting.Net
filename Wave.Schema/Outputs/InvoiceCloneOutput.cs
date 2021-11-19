using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Schema.Objects;

namespace Wave.Schema.Outputs
{
    public record InvoiceCloneOutput(Invoice invoice,//Invoice that was cloned.
bool didSucceed,//Indicates whether the invoice was successfully cloned.
InputError[] inputErrors //Mutation validation errors.
)
    {
    }
}
