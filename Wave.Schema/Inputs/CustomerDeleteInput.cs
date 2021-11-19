using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Inputs
{
    public record CustomerDeleteInput(string id //The unique identifier for the customer.
                                       )
    {
    }
}
