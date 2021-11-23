using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record ProductPatchInput(string id,//The unique identifier for the product.
                                    String name,//Name of the product.
                                    String description,//Description of the product.
                                    Decimal unitPrice,//Price per unit in the major currency unit (rounded to nearest 5 decimal places with ties going away from zero).
                                    string[] defaultSalesTaxIds,//Default sales taxes to apply on product.
                                    string incomeAccountId,//Income account to associate with this product. Account must be one of subtypes: `INCOME`, `DISCOUNTS`, `OTHER_INCOME`.
                                    string expenseAccountId //Expense account to associate with this product. Account must be one of subtypes: `EXPENSE`, `COST_OF_GOODS_SOLD`, `PAYMENT_PROCESSING_FEES`, `PAYROLL_EXPENSES`.
                                    )
    {
    }
}
