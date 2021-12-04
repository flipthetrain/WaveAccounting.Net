using Wave.Schema.Attributes;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record CustomerDeleteInput(string id //The unique identifier for the customer.
                                       )
    {
    }
}
