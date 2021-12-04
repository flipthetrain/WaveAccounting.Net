using Wave.Schema.Enums;

namespace Wave.Schema.Queries
{
    public record Currency(CurrencyCode code, //Code of currency.
                            Currency currency //Get a currency
)
    {
    }
}
