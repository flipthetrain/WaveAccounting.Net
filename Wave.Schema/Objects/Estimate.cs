using Wave.Schema.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record Estimate(string id,//Unique identifier for the estimate.
                            Business business //Business that the estimate belongs to.
                            )
    {
    }
}
