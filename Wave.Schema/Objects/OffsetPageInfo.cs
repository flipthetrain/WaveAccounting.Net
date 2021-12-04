using Wave.Schema.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record OffsetPageInfo(int currentPage,//Current page number.
                                int totalPages,//Total number of pages in the connection.
                                int totalCount //Total number of nodes in the connection.
                                )
    {
    }
}
