using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Objects
{
    public record SalesTaxConnection(SalesTaxEdge[] edges,//List of sales taxes.
                                        OffsetPageInfo pageInfo //Information about pagination.
                                        )
    {
    }
}
