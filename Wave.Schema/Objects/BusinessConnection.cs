using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Objects
{
    public record BusinessConnection(BusinessEdge[] edges,//List of businesses.
                                    OffsetPageInfo pageInfo //Information about pagination.
                                    )
    {
    }
}
