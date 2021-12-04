using Wave.Schema.Objects;

namespace Wave.Schema.Outputs
{
    public record CustomerCreateOutput(Customer customer,//Customer that was created.
bool didSucceed,//Indicates whether the customer was successfully created.
InputError[] inputErrors //Mutation validation errors.
)
    {
    }
}
