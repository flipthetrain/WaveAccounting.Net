﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Inputs
{
    public record InvoiceApproveInput(string invoiceId //The unique identifier for the invoice.
                                        )
    {
    }
}
