using Wave.GraphQL.Attributes;
using Wave.Schema.Inputs;
using Wave.Schema.Outputs;

namespace Wave.Schema.Mutations
{
    [SchemaMutationAttribute]
    public record InvoiceMarkSent(InvoiceMarkSentInput input, InvoiceMarkSentOutput invoiceMarkSent)
    {
    }
}
