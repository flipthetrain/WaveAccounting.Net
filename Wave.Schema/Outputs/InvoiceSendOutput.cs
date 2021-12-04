using Wave.Schema.Objects;

namespace Wave.Schema.Outputs
{
    public record InvoiceSendOutput(bool didSucceed,//Indicates whether the invoice was successfully queued for sending.
InputError[] inputErrors //Mutation validation errors.
)
    {
    }
}
