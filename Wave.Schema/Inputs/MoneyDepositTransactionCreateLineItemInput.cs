using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Schema.Objects;

namespace Wave.Schema.Inputs
{
    public record MoneyDepositTransactionCreateLineItemInput(string accountId,//ID of the account associated with the line item.
                                                            float amount,//Amount.
                                                            string customerId,//ID of the customer associated with the line item.
                                                            TrannsactionCreateSalesTaxInput[] taxes //Taxes applied to the line item
                                                            )
    {
    }
}
