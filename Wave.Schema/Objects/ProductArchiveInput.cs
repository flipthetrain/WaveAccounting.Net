using Wave.Schema.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record ProductArchiveInput(string id //The unique identifier for the product.
                                        )
    {
    }
}
