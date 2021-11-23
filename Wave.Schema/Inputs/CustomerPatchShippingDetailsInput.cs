using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record CustomerPatchShippingDetailsInput(string name,//Name or business name of the customer.
                                                    AddressInput address,//Address of the customer.
                                                    string phone,//Telephone number of the customer.
                                                    string instructions//Delivery instructions for handling.
                                                    )
    {
    }
}
