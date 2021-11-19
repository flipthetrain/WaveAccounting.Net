using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Inputs
{
    public record MoneyDepositTransactionCreateDepositInput(string accountId,//Id of the account.
float amount //Date of the transaction.
)
    {
    }
}
