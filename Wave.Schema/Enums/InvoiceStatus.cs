namespace Wave.Schema.Enums
{
    public enum InvoiceStatus
    {
        DRAFT, //The invoice is still a draft.
        OVERDUE, //The invoice is overdue.
        PAID, //The invoice was paid.
        PARTIAL, //The invoice was partially paid.
        SAVED, //The invoice was saved.
        SENT, //The invoice was sent.
        UNPAID, //The invoice is unpaid.
        VIEWED //The invoice was viewed.

    }
}
