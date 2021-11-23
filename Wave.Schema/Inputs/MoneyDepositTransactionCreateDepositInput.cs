using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record MoneyDepositTransactionCreateDepositInput(string accountId,//Id of the account.
                                                           float amount //Date of the transaction.
                                                            )
    {
    }
}
