using Wave.Schema.Attributes;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record SalesTaxCreateInput(string businessId,//The unique identifier for the business.
                                        string name,//Name of the tax.
                                        string abbreviation,//An short form or code representing the sales tax. Max 10 characters, and MUST BE UNIQUE within business.
                                        decimal rate,//The current rate, as a decimal (e.g. 0.15 represents 15%; rounded to nearest 6 decimal places with ties going away from zero).
                                        string description,//User defined description for the sales tax.
                                        string taxNumber,//The tax's issued identification number from a taxing authority.
                                        bool showTaxNumberOnInvoices,//Display tax number beside the tax name on an invoice.
                                        bool isCompound,//Is a compound tax, or stacked tax. This tax is calculated on top of the subtotal and other tax amounts.
                                        bool isRecoverable//Is a recoverable tax. It is recoverable if you can deduct the tax that you as a business paid from the tax that you have collected.
                                        )
    {
    }
}
