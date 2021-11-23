using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record MoneyDepositTransactionCreateFeeInput(string accountId,//ID of the account associated with the fee.
                                                        float amount //Amount.
                                                        )
    {
    }
}
