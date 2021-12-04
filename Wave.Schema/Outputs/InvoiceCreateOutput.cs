using Wave.Schema.Objects;

namespace Wave.Schema.Outputs
{
    public record InvoiceCreateOutput(Invoice invoice,//Invoice that was created.
bool didSucceed,//Indicates whether the invoice was successfully created.
InputError[] inputErrors //Mutation validation errors.
)
    {
    }
}
