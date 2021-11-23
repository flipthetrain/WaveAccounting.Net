using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record RecurringInvoice(string id,//Unique identifier for the recurring invoice.
                                    Business business //Business that the recurring invoice belongs to.
                                    )
    {
    }
}
