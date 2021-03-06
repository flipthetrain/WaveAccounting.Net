using Wave.Schema.Attributes;
using Wave.Schema.Enums;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record CustomerPatchInput(string id,//The unique identifier for the customer.
                                    string name,//Name or business name of the customer.
                                    string firstName,//First name of the principal contact.
                                    string lastName,//Last name of the principal contact.
                                    AddressInput address,//Address
                                    string displayId,//User defined id for the customer.
                                    string email,//Email of the principal contact.
                                    string mobile,//Mobile telephone number of the principal contact.
                                    string phone,//Telephone number of the customer.
                                    string fax,//Fax number of the customer.
                                    string tollFree,//Toll-free number of the customer.
                                    string website,//Website address of the customer.
                                    string internalNotes,//Internal notes about the customer.
                                    CurrencyCode currency,//Default currency used by the customer.
                                    CustomerPatchShippingDetailsInput shippingDetails //Details for shipping to the customer.
                                    )
    {
    }
}
