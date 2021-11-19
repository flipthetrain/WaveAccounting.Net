using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Objects
{
    public record TrannsactionCreateSalesTaxInput(String abbreviation,//Tax Abbreviation.
                                                    float amount//Tax Amount.
                                                    )
    {
    }
}
