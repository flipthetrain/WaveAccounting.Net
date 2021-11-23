using Wave.GraphQL.Attributes;
using Wave.Schema.Inputs;
using Wave.Schema.Outputs;

namespace Wave.Schema.Mutations
{
    [SchemaMutationAttribute]
    public record CustomerCreate(CustomerCreateInput input, CustomerCreateOutput customerCreate)
    {
    }
}
