using Wave.Schema.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record SalesTax(string id,//The unique identifier for the sales tax.
                            string name,//Name of the tax.
                            string abbreviation,//A short form or code representing the sales tax.
                            string description,//User defined description for the sales tax.
                            string taxNumber,//The tax's issued identification number from a taxing authority.
                            bool showTaxNumberOnInvoices,//Display tax number beside the tax name on an invoice.
                            Decimal rate,//Tax rate effective on 'for' date, or current date if no parameter, as a decimal (e.g. 0.15 represents 15%).
                            DateTime @for,//
                            SalesTaxRate[] rates,//Tax rates with their effective dates of application
                            bool isCompound,//Is a compound tax, or stacked tax. This tax is calculated on top of the subtotal and other tax amounts.
                            bool isRecoverable,//Is a recoverable tax. It is recoverable if you can deduct the tax that you as a business paid from the tax that you have collected.
                            bool isArchived,//Is the sales tax hidden from view by default.
                            DateTime createdAt,//When the sales tax was created.
                            DateTime modifiedAt,//When the sales tax was last modified.
                            Business business //Business that the sales tax belongs to.
                            )
    {
    }
}
