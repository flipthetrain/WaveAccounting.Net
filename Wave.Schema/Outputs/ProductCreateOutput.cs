using Wave.Schema.Objects;

namespace Wave.Schema.Outputs
{
    public record ProductCreateOutput(Product product,//Product that was created.
bool didSucceed,//Indicates whether the product was successfully created.
InputError[] inputErrors //Mutation validation errors.
)
    {
    }
}
