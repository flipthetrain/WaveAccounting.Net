using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record AccountPatchInput(string id,//The unique identifier for the account.
                                    int sequence,//The most recent reversion you are aware of. As soon as something modifies an account, its sequence is incremented.
                                    string name,//Name of the account.
                                    string description,//User defined description for the account. Use null to unset the current value.
                                    string displayId //User defined id for the account. Use null to unset the current value.
                                    )
    {
    }
}
