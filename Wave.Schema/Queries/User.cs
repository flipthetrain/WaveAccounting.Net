using Wave.Schema.Attributes;

namespace Wave.Schema.Queries
{
    [SchemaQuery("user")]
    public record User(Objects.User user) //The currently authenticated user.
    {
    }
}
