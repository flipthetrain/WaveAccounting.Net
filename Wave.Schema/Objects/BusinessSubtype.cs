using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Schema.Enums;

namespace Wave.Schema.Objects
{
    public record BusinessSubtype(string name,//The description of the business subtype in human-friendly form.
                                BusinessSubtypeValue value //The enum value of the business subtype.
                                )
    {
    }
}
