﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Schema.Enums;

namespace Wave.Schema.Inputs
{
    public record MoneyDepositTransactionCreateInput(string businessId,//Id of the business.
DateTime date,//Date of the transaction.
string description,//Description for the transaction.
MoneyDepositTransactionCreateDepositInput deposit,//Deposit account and amount.
MoneyDepositTransactionCreateLineItemInput[] lineItems,//Line items.
MoneyDepositTransactionCreateFeeInput[] fees,//Fees.
TransactionOrigin origin,//Origin of the transaction.
string externalId,//ID of the transaction in an external system.
DateTime createdAt,//Transaction timestamp.
string notes //Extra notes about the transaction.
)
    {
    }
}
