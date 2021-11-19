﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Objects
{
    public record VendorConnection(VendorEdge[] edges,//List of vendors.
OffsetPageInfo pageInfo //Information about pagination.
)
    {
    }
}