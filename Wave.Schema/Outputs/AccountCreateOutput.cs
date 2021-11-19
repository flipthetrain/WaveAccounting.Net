using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Schema.Objects;

namespace Wave.Schema.Outputs
{
    public record AccountCreateOutput(Account account,//Account that was created.
bool didSucceed,//Indicates whether the account was successfully created.
InputError[] inputErrors //Mutation validation errors.
)
    {
    }
}
