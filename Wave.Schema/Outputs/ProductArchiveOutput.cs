using Wave.Schema.Objects;

namespace Wave.Schema.Outputs
{
    public record ProductArchiveOutput(Product product,//Product that was archived.
bool didSucceed,//Indicates whether the product was successfully deleted.
InputError[] inputErrors //Mutation validation errors.
)
    {
    }
}
