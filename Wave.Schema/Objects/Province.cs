using Wave.Schema.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record Province(string code,//[ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2) identifier.
                            string name //Plain-lanuage representaton.
                            )
    {
    }
}
