using Wave.Schema.Objects;

namespace Wave.Schema.Outputs
{
    public record MoneyTransactionCreateOutput(Transaction transaction,//Created transaction.
bool didSucceed,//Whether or not the transaction was successfully created.
InputError[] inputErrors //Mutation validation errors.
)
    {
    }
}
