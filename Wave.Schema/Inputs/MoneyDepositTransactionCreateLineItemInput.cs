using Wave.Schema.Attributes;
using Wave.Schema.Objects;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record MoneyDepositTransactionCreateLineItemInput(string accountId,//ID of the account associated with the line item.
                                                            float amount,//Amount.
                                                            string customerId,//ID of the customer associated with the line item.
                                                            TrannsactionCreateSalesTaxInput[] taxes //Taxes applied to the line item
                                                            )
    {
    }
}
