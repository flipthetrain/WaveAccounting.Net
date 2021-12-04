using Wave.Schema.Attributes;
using Wave.Schema.Enums;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record InvoiceMarkSentInput(string invoiceId,//The unique identifier for the invoice.
                                    InvoiceSendMethod sendMethod,//How the invoice was sent.
                                    DateTime sentAt //When the invoice was sent.
                                    )
    {
    }
}
