using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record AccountConnection(AccountEdge[] edges,//List of accounts from the Chart of Accounts.
                                    OffsetPageInfo pageInfo //Information about pagination.
                                    )
    {
    }
}
