using Wave.Schema.Attributes;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record InvoiceCreateItemInput(string productId,//Associated product.
                                        string description,//Override product's description.
                                        decimal quantity,//Number of units (rounded to nearest 8 decimal places with ties going away from zero).
                                        decimal unitPrice,//Override product's unitPrice. Price per unit in the major currency unit (rounded to nearest 8 decimal places with ties going away from zero).
                                        InvoiceCreateItemTaxInput[] taxes //Taxes. To have the product's default sales taxes applied, provide `undefined` as the value.
                                        )
    {
    }
}
