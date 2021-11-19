using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Schema.Enums;

namespace Wave.Schema.Objects
{
    public record Country(CountryCode code,//Country code.
                        string name,//Plain-language representation.
                        Currency currency,//Default currency of the country.
                        string nameWithArticle,//Name of the country with the appropriate article.
                        Province[] provinces //List of principal subdivisions.
                        )
    {
    }
}
