using Wave.Schema.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record CustomerShippingDetails(string name,//Name or business name of the customer.
                                        Address address,//Address of the customer.
                                        string phone,//Telephone number of the customer.
                                        string instructions //Delivery instructions for handling.
                                        )
    {
    }
}
