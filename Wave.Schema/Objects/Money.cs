using Wave.Schema.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record Money(int raw,//Value represented in only the minor currency unit.
                        string value,//Amount represented as a combination of the major and minor currency unit (uses a decimal separator).
                        Currency currency //Currency
                        )
    {
    }
}
