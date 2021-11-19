using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Schema.Enums;

namespace Wave.Schema.Queries
{
    public record Currency(CurrencyCode code, //Code of currency.
                            Currency currency //Get a currency
)
    {
    }
}
