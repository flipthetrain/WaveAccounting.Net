using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Schema.Objects;

namespace Wave.Schema.Outputs
{
    public record InvoiceMarkSentOutput(Invoice invoice,//Invoice that was marked as sent.
bool didSucceed,//Indicates whether the invoice was successfully marked as sent.
InputError[] inputErrors //Mutation validation errors.
)
    {
    }
}
