using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record VendorConnection(VendorEdge[] edges,//List of vendors.
                                OffsetPageInfo pageInfo //Information about pagination.
                                )
    {
    }
}
