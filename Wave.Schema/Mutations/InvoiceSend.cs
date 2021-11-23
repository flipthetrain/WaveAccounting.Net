using Wave.GraphQL.Attributes;
using Wave.Schema.Inputs;
using Wave.Schema.Outputs;

namespace Wave.Schema.Mutations
{
    [SchemaMutationAttribute]
    public record InvoiceSend(InvoiceSendInput input, InvoiceSendOutput invoiceSend)
    {
    }
}
