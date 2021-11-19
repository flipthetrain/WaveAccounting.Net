﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Objects
{
    public record SalesTaxRateCreateInput(string id,//The unique identifier for the sales tax.
                                            DateTime effective,//The date from which the sales tax rate applies.
                                            decimal rate//Sales tax rate, as a decimal (e.g. 0.15 represents 15%; rounded to nearest 6 decimal places with ties going away from zero).
)
    {
    }
}
