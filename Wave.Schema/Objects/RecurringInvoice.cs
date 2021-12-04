using Wave.Schema.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record RecurringInvoice(string id,//Unique identifier for the recurring invoice.
                                    Business business //Business that the recurring invoice belongs to.
                                    )
    {
    }
}
