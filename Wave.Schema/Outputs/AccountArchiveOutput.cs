using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Schema.Objects;

namespace Wave.Schema.Outputs
{
    public record AccountArchiveOutput(bool didSucceed,//Indicates whether the account was successfully archived.
InputError[] inputError //Mutation validation errors.
)
    {
    }
}
