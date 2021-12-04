using Wave.Schema.Attributes;
using Wave.Schema.Enums;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record Currency(CurrencyCode code,//Currency code.
                        string symbol,//Symbol used to denote that a number is a monetary value.
                        string name,//Plain-language representation.
                        string plural,//Plural version of currency name.
                        int exponent //Expresses the relationship between a major currency unit and its minor currency unit. The number of digits found to the right of the decimal place to represent the fractional part of this currency (assumes a base of 10).
                        )
    {
    }
}
