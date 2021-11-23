using Wave.GraphQL.Attributes;
using Wave.Schema.Inputs;
using Wave.Schema.Outputs;

namespace Wave.Schema.Mutations
{
    [SchemaMutationAttribute]
    public record ProductCreate(ProductCreateInput input, ProductCreateOutput productCreate)
    {
    }
}
