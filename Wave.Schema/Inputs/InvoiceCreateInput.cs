using Wave.GraphQL.Attributes;
using Wave.Schema.Enums;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record InvoiceCreateInput(string businessId,//The unique identifier for the business.
                                    string customerId,//The customer identifier to associate with invoice.
                                    InvoiceCreateStatus status,//Status of the Invoice.
                                    CurrencyCode currency,//Currency of the invoice. If not provided, will use the business's default currency.
                                    string title,//Invoice title at the top of the document. If not provided, will use the business's default invoice title.
                                    string subhead,//Invoice subheading text. If not provided, will use the business's default invoice subheading.
                                    string invoiceNumber,//Unique number assigned to the invoice. If not provided, will find the current largest invoice number and add 1.
                                    string poNumber,//Purchase order or sales order number for the invoice.
                                    DateTime invoiceDate,//Date when invoice is issued. If not provided, will use today's date.
                                    decimal exchangeRate,//Exchange rate to business's currency from the invoice's currency. Used to value the invoice income within Wave's accounting transactions.
                                    DateTime dueDate,//Date when payment is due. If not provided, will apply the business's default invoice payment terms to `invoiceDate` value.
                                    InvoiceCreateItemInput[] items,//The line items (product, unit and price) that make up the invoiced sale.
                                    string memo,//Invoice memo (notes) text. If not provided, will use the business's default invoice memo.
                                    string footer,//Invoice footer text. If not provided, will use the business's default invoice footer.
                                    bool disableAmexPayments,//Within a business that is enabled to accept credit card payments, indicates if this individual invoice has been marked to not be payable by american express payment. If not provided, will use the business's default invoice settings american express payment state.
                                    bool disableCreditCardPayments,//Within a business that is enabled to accept credit card payments, indicates if this individual invoice has been marked to not be payable by card. If not provided, will use the business's default invoice credit card payment state.
                                    bool disableBankPayments,//Within a business that is enabled to accept bank payments, indicates if this individual invoice has been marked to not be payable by bank payment. If not provided, will use the business's default invoice bank payment state.
                                    string itemTitle,//The label for the 'Item' column in the listing of line items on the invoice. If not provided, will use the business's default invoice column item title.
                                    string unitTitle,//The label for the 'Unit' column in the listing of line items on the invoice. If not provided, will use the business's default invoice column unit title.
                                    string priceTitle,//The label for the 'Price' column in the listing of line items on the invoice. If not provided, will use the business's default invoice column price title.
                                    string amountTitle,//The label for the 'Amount' (= unit x price) column in the listing of line items on the invoice. If not provided, will use the business's default invoice column amount title.
                                    bool hideName,//Indicates whether item's product name in item column is hidden in the line items listing. If not provided, will use the business's default invoice item name visibility.
                                    bool hideDescription,//Indicates whether item's description in item column is hidden in the line items listing. If not provided, will use the business's default invoice item description visibility.
                                    bool hideUnit,//Indicates whether item's unit is hidden in the line items listing. If not provided, will use the business's default invoice item unit visibility.
                                    bool hidePrice,//Indicates whether item's price is hidden in the line items listing. If not provided, will use the business's default invoice item price visibility.
                                    bool hideAmount//Indicates whether item's amount is hidden in the line items listing. If not provided, will use the business's default invoice item amount visibility.
                                    )
    {
    }
}
