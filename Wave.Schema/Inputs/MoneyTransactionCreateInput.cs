using Wave.Schema.Attributes;

namespace Wave.Schema.Inputs
{
    [SchemaInput]
    public record MoneyTransactionCreateInput(string businessId,//The unique identifier for the business.
                                            string externalId,//ID of the transaction in an external system. If you don't have one, generate a UUID and provide it.
                                            DateTime date,//Date of the transaction.
                                            string description,//Description for the transaction.
                                            string notes,//Extra notes about the transaction.
                                            MoneyTransactionCreateAnchorInput anchor,//Anchor item.
                                            MoneyTransactionCreateLineItemInput[] lineItems //Line items.
                                            )
    {
    }
}
