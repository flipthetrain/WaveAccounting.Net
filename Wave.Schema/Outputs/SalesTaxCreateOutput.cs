using Wave.Schema.Attributes;
using Wave.Schema.Objects;

namespace Wave.Schema.Outputs
{
    [SchemaOutput]
    public record SalesTaxCreateOutput(SalesTax salesTax,//Sales tax that was created.
                                        bool didSucceed,//Indicates whether the sales tax was successfully created.
                                        InputError[] inputErrors//Mutation validation errors
                                        )
    {
    }
}
