using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Objects
{
    public record ProductConnection(ProductEdge[] edges,//List of products.
                                    OffsetPageInfo pageInfo //Information about pagination.
                                    )
    {
    }
}
