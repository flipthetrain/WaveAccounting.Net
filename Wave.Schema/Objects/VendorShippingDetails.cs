using Wave.Schema.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record VendorShippingDetails(string name,//Name or business name of the vendor.
                                    Address address,//Address of the vendor.
                                    string phone,//Telephone number of the vendor.
                                    string instructions //Delivery instructions for handling.
                                    )
    {
    }
}
