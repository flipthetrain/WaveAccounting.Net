using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;

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
