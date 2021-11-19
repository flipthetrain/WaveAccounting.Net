using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Objects
{
    public record InvoiceConnection(InvoiceEdge[] edges,//List of invoices.
                                    OffsetPageInfo pageInfo //Information about pagination.
                                    )
    {
    }
}
