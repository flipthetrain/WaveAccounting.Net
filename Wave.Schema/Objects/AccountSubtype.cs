using Wave.Schema.Attributes;
using Wave.Schema.Enums;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record AccountSubtype(string name,//Account subtype name.
                                AccountSubtypeValue value,//Account subtype value.
                                AccountType type,//Account type for the subtype.
                                bool archivable,//Indicates if accounts of this subtype can be archived.
                                bool systemCreated,//Indicates if accounts of this subtype is system created accounts.
                                string description //Account subtype descripti
                                )
    {
    }
}
