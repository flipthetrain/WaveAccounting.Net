using Wave.Schema.Attributes;
using Wave.Schema.Enums;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record Business(string id,//The unique identifier for the business.
                            string name,//The name of the business.
                            bool isPersonal,//Is the business a personal one with limited functionality compared to regular businesses.
                            OrganizationalType organizationalType,//The organization type of the business.
                            BusinessType type,//The type of the business.
                            BusinessSubtype subtype,//The subtype of the business.
                            Currency currency,//The currency of the business.
                            string timezone,//The timezone of the business.
                            Address address,//The address of the business.
                            string phone,//The phone number of the business.
                            string fax,//The fax number of the business.
                            string mobile,//The mobile/cell number of the business.
                            string tollFree,//The toll free number of the business.
                            string website,//The website of the business.
                            bool isClassicAccounting,//Does business use classic accounting system.
                            bool isClassicInvoicing,//Does business use classic invoicing system.
                            bool isArchived,//Is the business hidden from view by default.
                            DateTime createdAt,//When the business was created.
                            DateTime modifiedAt,//When the business was last modified.
                            Customer customer,//Get a customer of the business.
                            CustomerConnection customers,//List of customers for the business.
                            Account account,//Get an account of the business.
                            AccountConnection accounts,//Chart of Accounts for the business.
                            SalesTax salesTax,//Get a sales tax of the business.
                            SalesTaxConnection salesTaxes,//List of sales taxes for the business.
                            Invoice invoice,//Get an invoice of the business. Requires `isClassicInvoicing` to be `false`.
                            InvoiceConnection invoices,//List of invoices for the business. Requires `isClassicInvoicing` to be `false`.
                            VendorConnection vendors,//List of vendors for the business.
                            Vendor vendor,//Get a vendor of the business.
                            HexColorCode accentColor,//Color to represent the brand of the business.
                            URL logoUrl,//Logo of the business.
                            Product product,//Get a product (or service) of the business.
                            ProductConnection products //List of products (and services) for the business.
                            )
    {
    }
}
