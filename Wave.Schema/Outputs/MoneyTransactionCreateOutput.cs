using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
