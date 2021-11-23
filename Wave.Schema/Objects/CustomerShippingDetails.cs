using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;

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
