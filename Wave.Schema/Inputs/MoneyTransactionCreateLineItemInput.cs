using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Schema.Enums;

namespace Wave.Schema.Inputs
{
    public record MoneyTransactionCreateLineItemInput(string accountId,//ID of the account associated with the line item.
decimal amount,//Amount of the line item (unsigned).
BalanceType balance,//How the account should change in relation to the amount.
string customerId,//ID of the customer associated with the line item.
string description,//Optional description for line item.
MoneyTransactionCreateSalesTaxInput[] taxes //Taxes applied to the line item.
)
    {
    }
}
