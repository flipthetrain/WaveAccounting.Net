using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;
using Wave.Schema.Enums;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record Invoice(string id,//Unique identifier for the invoice.
                            DateTime createdAt,//When the invoice was created.
                            DateTime modifiedAt,//When the invoice was last modified.
                            //InvoiceSource source,//Entity that was the precursor to the invoice.
                            string pdfUrl,//URL to access PDF representation of the invoice.
                            string viewUrl,//URL to view the invoice online as seen by a customer.
                            InvoiceStatus status,//Status of the Invoice.
                            string title,//Invoice title at the top of the document.
                            string subhead,//Invoice subheading text.
                            string invoiceNumber,//Unique number assigned to the invoice.
                            string poNumber,//Purchase order or sales order number for the invoice.
                            DateTime invoiceDate,//Date when invoice is issued.
                            DateTime dueDate,//Date when payment is due.
                            Money amountDue,//Invoice total less amount already paid.
                            Money amountPaid,//Total of all payments so far made against this invoice.
                            Money taxTotal,//Total of all sales taxes on all line items within the invoice.
                            Money total,//Total value of the invoice including sales taxes.
                            Currency currency,//Currency of the invoice.
                            Decimal exchangeRate,//Exchange rate to business's currency from the invoice's currency. Used to value the invoice income within Wave's accounting transactions.
                            InvoiceItem[] items,//The line items (product, unit and price) that make up the invoiced sale.
                            string memo,//Invoice memo (notes) text.
                            string footer,//Invoice footer text.
                            bool disableCreditCardPayments,//Within a business that is enabled to accept credit card payments, indicates if this individual invoice has been marked to not be payable by card.
                            bool disableBankPayments,//Within a business that is enabled to accept bank payments, indicates if this individual invoice has been marked to not be payable by bank payment.
                            bool disableAmexPayments,//Within a business that is enabled to accept credit card payments, indicates if this individual invoice has been marked to not be payable by American Express.
                            string itemTitle,//The label for the 'Item' column in the line items listing.
                            string unitTitle,//The label for the 'Unit' column in the listing of line items on the invoice.
                            string priceTitle,//The label for the 'Price' column in the listing of line items on the invoice.
                            string amountTitle,//The label for the 'Amount' (= unit x price) column in the listing of line items on the invoice.
                            bool hideName,//Indicates whether item's product name in item column is hidden in the line items listing.
                            bool hideDescription,//Indicates whether item's description in item column is hidden in the line items listing.
                            bool hideUnit,//Indicates whether item's unit is hidden in the line items listing.
                            bool hidePrice,//Indicates whether item's price is hidden in the line items listing.
                            bool hideAmount,//Indicates whether item's amount is hidden in the line items listing.
                            DateTime lastSentAt,//When the invoice was last sent.
                            InvoiceSendMethod lastSentVia,//How the invoice was last sent.
                            DateTime lastViewedAt,//When the invoice was last viewed by the customer.
                            Business business,//Business that the invoice belongs to.
                            Customer customer //Customer the invoice is for.
                            )
    {
    }
}
