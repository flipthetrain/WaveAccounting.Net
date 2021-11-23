using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;
using Wave.Schema.Enums;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record AddressInput(string addressLine1,//Address line 1 (Street address/PO Box/Company name).
                                string addressLine2,//Address line 2 (Apartment/Suite/Unit/Building).
                                string city,//City/District/Suburb/Town/Village.
                                string provinceCode,//State/County/Province/Region Code ([ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2)).
                                CountryCode countryCode,//Country Code.
                                string postalCode //Zip/Postal Code.
                            )
    {
    }
}
