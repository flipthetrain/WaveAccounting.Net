using Wave.Schema.Enums;

namespace Wave.Schema.Inputs
{
    public record MoneyTransactionCreateAnchorInput(string accountId,//ID of the anchor account.
                                                    decimal amount,//Amount of the transaction (unsigned).
                                                    TransactionDirection direction //Direction of a transaction
                                                    )
    {
    }
}
