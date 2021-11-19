using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Objects
{
    public record SalesTaxRate(DateTime effective,//Date from which the sales tax rate applies.
                                decimal rate //Tax rate applying from the effective date as a decimal (e.g. 0.15 represents 15%).
                                )
    {
    }
}
