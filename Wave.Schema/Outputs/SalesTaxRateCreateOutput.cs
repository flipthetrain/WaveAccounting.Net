using Wave.Schema.Objects;

namespace Wave.Schema.Outputs
{
    public record SalesTaxRateCreateOutput(bool didSucceed,//Indicates whether the sales tax rate was successfully created.
InputError[] inputErrors //Mutation validation errors.
)
    {
    }
}
