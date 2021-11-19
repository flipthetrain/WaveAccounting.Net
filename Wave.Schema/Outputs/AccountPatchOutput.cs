using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Schema.Objects;

namespace Wave.Schema.Outputs
{
    public record AccountPatchOutput(Account account,//Account that was patched.
bool didSucceed,//Indicates whether the account was successfully patched.
InputError[] inputErrors //Mutation validation errors.
)
    {
    }
}
