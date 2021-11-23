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
    public record Account(string id,//Unique identifier for the account.
                        string classicId,//The classic primary key used internally at Wave.
                        string name,//Name of the account.
                        string description,//User defined description for the account.
                        string displayId,//User defined id for the account.
                        Currency currency,//Currency of the account.
                        AccountType type,//Account type.
                        AccountSubtype subtype,//The account subtype classification based on type.
                        AccountNormalBalanceType normalBalanceType,//Credit or Debit.
                        bool isArchived,//Indicates whether the account is hidden from view by default.
                        int sequence,//Numerically increasing version, each representing a revision of account data. As soon as something modifies an account, its sequence is incremented.
                        Decimal balance,//The balance of the account as of the current date.
                        Decimal balanceInBusinessCurrency,//The balance of the account as of the current date in the business currency.
                        Business business//Business that the account belongs to.
                        )
    {
    }
}
