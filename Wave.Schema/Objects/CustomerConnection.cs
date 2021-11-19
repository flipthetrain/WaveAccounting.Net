﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Objects
{
    public record CustomerConnection(CustomerEdge[] edges,//List of customers.
                                    OffsetPageInfo pageInfo //Information about pagination.
                                    )
    {
    }
}