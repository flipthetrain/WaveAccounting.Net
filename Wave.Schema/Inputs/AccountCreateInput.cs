using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Schema.Enums;

namespace Wave.Schema.Inputs
{
    public record AccountCreateInput(string businessId,//The unique identifier for the business.
                                    AccountSubtypeValue subtype,//The account subtype classification.
                                    CurrencyCode currency,//Currency of the account. Will default to business's currency.
                                    string name,//Name of the account.
                                    string description,//User defined description for the account.
                                    string displayId //User defined id for the account.
                                    )
    {
    }
}
