using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Objects
{
    public record Vendor(string id,//Unique identifier for the customer.
Business business,//Business that the vendor belongs to.
string name,//Name or business name of the vendor.
Address address,//The address of the vendor.
string firstName,//The first name of the principal contact.
string lastName,//The last name of the principal contact.
string displayId,//User defined id for the vendor. Commonly referred to as Account Number.
string email,//Email of the principal vendor.
string mobile,//The mobile number of the vendor.
string phone,//The phone number of the vendor.
string fax,//Fax number of the vendor.
string tollFree,//Toll-free number of the vendor.
string website,//Website address of the vendor.
string internalNotes,//Internal notes about the vendor.
Currency currency,//Default currency used by the vendor.
VendorShippingDetails shippingDetails,//Details for shipping to the vendor.
DateTime createdAt,//When the vendor was created.
DateTime modifiedAt,//When the vendor was last modified.
bool isArchived //Whether or not the vendor is archived.
)
    {
    }
}
