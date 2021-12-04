using Wave.Schema.Attributes;
using Wave.Schema.Enums;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record BusinessSubtype(string name,//The description of the business subtype in human-friendly form.
                                BusinessSubtypeValue value //The enum value of the business subtype.
                                )
    {
    }
}
