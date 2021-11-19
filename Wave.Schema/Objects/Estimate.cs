using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Objects
{
    public record Estimate(string id,//Unique identifier for the estimate.
                            Business business //Business that the estimate belongs to.
                            )
    {
    }
}
