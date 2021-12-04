using Wave.Schema.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record SalesTaxCreateInput(string businessId,//The unique identifier for the business.
                                    String name,//Name of the tax.
                                    String abbreviation,//An short form or code representing the sales tax. Max 10 characters, and MUST BE UNIQUE within business.
                                    Decimal rate,//The current rate, as a decimal (e.g. 0.15 represents 15%; rounded to nearest 6 decimal places with ties going away from zero).
                                    String description,//User defined description for the sales tax.
                                    String taxNumber,//The tax's issued identification number from a taxing authority.
                                    Boolean showTaxNumberOnInvoices,//Display tax number beside the tax name on an invoice.
                                    Boolean isCompound,//Is a compound tax, or stacked tax. This tax is calculated on top of the subtotal and other tax amounts.
                                    Boolean isRecoverable //Is a recoverable tax. It is recoverable if you can deduct the tax that you as a business paid from the tax that you have collected.
                                    )
    {
    }
}
