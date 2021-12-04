using Wave.Schema.Attributes;
using Wave.Schema.Objects;

namespace Wave.Schema.Queries
{
    [SchemaQuery("businesses")]
    public record Businesses(int page,//1-based page number to retrieve.
                            int pageSize,//Limit on how many items each page should return.
                            BusinessConnection businesses//List businesses.
                            )
    {
    }
}
