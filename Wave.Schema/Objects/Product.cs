using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record Product(string id,//Unique identifier for the product.
                        string name,//Name of the product.
                        string description,//Description of the product.
                        Decimal unitPrice,//Price per unit in the major currency unit.
                        bool isSold,//Is product sold by the business. Allow this product or service to be added to Invoices.
                        bool isBought,//Is product bought by the business. Allow this product or service to be added to Bills.
                        bool isArchived,//Is the product hidden from view by default.
                        DateTime createdAt,//When the product was created.
                        DateTime modifiedAt,//When the product was last modified.
                        Business business,//Business that the product belongs to.
                        Account incomeAccount,//The income account to associate with this product, set when isSold.
                        Account expenseAccount,//The expense account to associate with this product, set when isBought.
                        SalesTax[] defaultSalesTaxes //Default sales taxes to apply on product.
                        )
    {
    }
}
