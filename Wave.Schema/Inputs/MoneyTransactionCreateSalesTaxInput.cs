using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Inputs
{
    public record MoneyTransactionCreateSalesTaxInput(string salesTaxId,//ID of the sales tax.
decimal amount //Override the amount of the tax (unsigned).
)
    {
    }
}
