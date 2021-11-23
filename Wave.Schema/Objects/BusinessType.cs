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
    public record BusinessType(string name,//The description of the business type in human-friendly form.
                            BusinesTypeValue value //The enum value of the business type.
                            )
    {
    }
}
