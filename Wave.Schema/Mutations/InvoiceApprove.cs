using Wave.Schema.Attributes;
using Wave.Schema.Inputs;
using Wave.Schema.Outputs;

namespace Wave.Schema.Mutations
{
    [SchemaMutationAttribute]
    public record InvoiceApprove(InvoiceApproveInput input, InvoiceApproveOutput invoiceApprove)
    {
    }
}
