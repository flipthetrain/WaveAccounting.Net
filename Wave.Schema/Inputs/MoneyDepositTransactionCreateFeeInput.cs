using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Inputs
{
    public record MoneyDepositTransactionCreateFeeInput(string accountId,//ID of the account associated with the fee.
float amount //Amount.
)
    {
    }
}
