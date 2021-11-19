using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Objects
{
    public record RecurringInvoice(string id,//Unique identifier for the recurring invoice.
                                    Business business //Business that the recurring invoice belongs to.
                                    )
    {
    }
}
