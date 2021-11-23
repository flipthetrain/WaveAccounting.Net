using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record OffsetPageInfo(int currentPage,//Current page number.
                                int totalPages,//Total number of pages in the connection.
                                int totalCount //Total number of nodes in the connection.
                                )
    {
    }
}
