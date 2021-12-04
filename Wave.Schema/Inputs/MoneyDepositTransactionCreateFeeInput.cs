using Wave.Schema.Attributes;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record MoneyDepositTransactionCreateFeeInput(string accountId,//ID of the account associated with the fee.
                                                        float amount //Amount.
                                                        )
    {
    }
}
