using Wave.Schema.Attributes;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record CustomerShippingDetailsInput(string name,//Name or business name of the customer.
                                                AddressInput address,//Address of the customer.
                                                string phone,//Telephone number of the customer.
                                                string instructions //Delivery instructions for handling.
                                                )
    {
    }
}
