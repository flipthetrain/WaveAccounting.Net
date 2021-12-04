using Wave.Schema.Objects;

namespace Wave.Schema.Outputs
{
    public record InvoiceApproveOutput(Invoice invoice,//Invoice that was approved.
bool didSucceed,//Indicates whether the invoice was successfully approved.
InputError[] inputErrors //Mutation validation errors.
)
    {
    }
}
