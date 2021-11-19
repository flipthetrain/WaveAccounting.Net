using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Enums
{
    public enum InvoiceSendMethod
    {
        EXPORT_PDF, //Export PDF.
        GMAIL, //Gmail
        MARKED_SENT, //Marked as sent.
        NOT_SENT, //Not sent.
        OUTLOOK, //Outlook.
        SHARED_LINK, //Shared link.
        SKIPPED, //Skipped.
        WAVE, //Wave.
        YAHOO //Yahoo.
    }
}
