using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Schema.Objects;

namespace Wave.Schema.Outputs
{
    public record CustomerDeleteOutput(bool didSucceed,//Indicates whether the customer was successfully deleted.
InputError[] inputErrors //Mutation validation errors.
)
    {
    }
}
