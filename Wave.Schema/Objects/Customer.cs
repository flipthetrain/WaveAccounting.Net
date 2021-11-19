using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Objects
{
    public record Customer(string id,//Unique identifier for the customer.
                            string name,//Name or business name of the customer.
                            Address address,//Address of the customer.
                            string firstName,//First name of the principal contact.
                            string lastName,//Last name of the principal contact.
                            string displayId,//User defined id for the customer. Commonly referred to as Account Number.
                            string email,//Email of the principal contact.
                            string mobile,//Mobile telephone number of the principal contact.
                            string phone,//Telephone number of the customer.
                            string fax,//Fax number of the customer.
                            string tollFree,//Toll-free number of the customer.
                            string website,//Website address of the customer.
                            string internalNotes,//Internal notes about the customer.
                            Currency currency,//Default currency used by the customer.
                            CustomerShippingDetails shippingDetails,//Details for shipping to the customer.
                            DateTime createdAt,//When the customer was created.
                            DateTime modifiedAt,//When the customer was last modified.
                            bool isArchived,//Whether or not the customer is archived.
                            Business business,//Business that the customer belongs to.
                            Money outstandingAmount,//Amount due on customer's invoices.
                            Money overdueAmount //Amount due on customer's invoices with due date that have passed.
                            )
    {
    }
}
