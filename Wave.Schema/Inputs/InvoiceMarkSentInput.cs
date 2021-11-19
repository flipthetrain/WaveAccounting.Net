using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Schema.Enums;

namespace Wave.Schema.Inputs
{
    public record InvoiceMarkSentInput(string invoiceId,//The unique identifier for the invoice.
InvoiceSendMethod sendMethod,//How the invoice was sent.
DateTime sentAt //When the invoice was sent.
)
    {
    }
}
