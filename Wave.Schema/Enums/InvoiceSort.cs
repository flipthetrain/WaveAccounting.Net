using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Enums
{
    public enum InvoiceSort
    {
        AMOUNT_DUE_ASC, //Ascending by amount due.
        AMOUNT_DUE_DESC, //Descending by amount due.
        AMOUNT_PAID_ASC, //Ascending by amount paid.
        AMOUNT_PAID_DESC, //Descending by amount paid.
        CREATED_AT_ASC, //Ascending by creation time.
        CREATED_AT_DESC, //Descending by creation time.
        CUSTOMER_NAME_ASC, //Ascending by customer's name.
        CUSTOMER_NAME_DESC, //Descending by customer's name.
        DUE_AT_ASC, //Ascending by due date.
        DUE_AT_DESC, //Descending by due date.
        INVOICE_DATE_ASC, //Ascending by invoice date.
        INVOICE_DATE_DESC, //Descending by invoice date.
        INVOICE_NUMBER_ASC, //Ascending by invoice number.
        INVOICE_NUMBER_DESC, //Descending by invoice number.
        MODIFIED_AT_ASC, //Ascending by modified date.
        MODIFIED_AT_DESC, //Descending by modified date.
        STATUS_ASC, //Ascending by status.
        STATUS_DESC, //Descending by status.
        TOTAL_ASC, //Ascending by total amount.
        TOTAL_DESC //Descending by total amount.
    }
}
