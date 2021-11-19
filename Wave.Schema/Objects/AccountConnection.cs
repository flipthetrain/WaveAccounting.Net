using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Objects
{
    public record AccountConnection(AccountEdge[] edges,//List of accounts from the Chart of Accounts.
                                    OffsetPageInfo pageInfo //Information about pagination.
                                    )
    {
    }
}
