using Wave.Schema.Attributes;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record ProductArchiveInput(string id//The unique identifier for the product.
                                        )
    {
    }
}
