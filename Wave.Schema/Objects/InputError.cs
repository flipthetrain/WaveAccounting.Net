using Wave.Schema.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record InputError(string[] path,//Path to the input value.
                            string message,//Error message.
                            string code //Error code.
                            )
    {
    }
}
