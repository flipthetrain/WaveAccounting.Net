using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Objects
{
    public record VendorShippingDetails(string name,//Name or business name of the vendor.
Address address,//Address of the vendor.
string phone,//Telephone number of the vendor.
string instructions //Delivery instructions for handling.
)
    {
    }
}
