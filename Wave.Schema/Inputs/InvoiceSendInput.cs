using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Inputs
{
    public record InvoiceSendInput(Type Field,//Description
string invoiceId,//The unique identifier for the invoice.
string[] to,//Email addresses to receive an email.
string subject,//Subject line of the email.
string message,//Message body of the email.
bool attachPDF,//Include a PDF of the invoice as an attachment.
string fromAddress,//Email address from
bool ccMyself //Carbon copy email.
)
    {
    }
}
