using Wave.Schema.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record SalesTaxCreateOutput(SalesTax salesTax,//Sales tax that was created.
                                    bool didSucceed,//Indicates whether the sales tax was successfully created.
                                    InputError[] inputErrors //Mutation validation errors.
                                    )
    {
    }
}
