using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record Estimate(string id,//Unique identifier for the estimate.
                            Business business //Business that the estimate belongs to.
                            )
    {
    }
}
