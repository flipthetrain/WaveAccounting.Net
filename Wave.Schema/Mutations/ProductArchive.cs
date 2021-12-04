using Wave.Schema.Attributes;
using Wave.Schema.Inputs;
using Wave.Schema.Outputs;

namespace Wave.Schema.Mutations
{
    [SchemaMutation]
    public record ProductArchive(ProductArchiveInput input, ProductArchiveOutput productArchive)
    {
    }
}
