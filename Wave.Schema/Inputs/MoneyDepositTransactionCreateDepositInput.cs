using Wave.Schema.Attributes;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record MoneyDepositTransactionCreateDepositInput(string accountId,//Id of the account.
                                                           float amount //Date of the transaction.
                                                            )
    {
    }
}
