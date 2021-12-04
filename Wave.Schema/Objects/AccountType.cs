using Wave.Schema.Attributes;
using Wave.Schema.Enums;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record AccountType(string name,//Account type name.
                            AccountNormalBalanceType normalBalanceType,//Normal balance type of the account type
                            AccountTypeValue value //Account type value.
                            )
    {
    }
}
