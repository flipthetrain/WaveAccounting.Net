using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Schema.Objects;

namespace Wave.Schema.Objects
{
    public record Address(string addressLine1,//Address line 1 (Street address/PO Box/Company name).
                        string addressLine2,//Address line 2 (Apartment/Suite/Unit/Building).
                        string city,//City/District/Suburb/Town/Village.
                        Province province,//State/County/Province/Region.
                        Country country,//Country.
                        string postalCode //Zip/Postal Code.
                        )
    {
    }
}
