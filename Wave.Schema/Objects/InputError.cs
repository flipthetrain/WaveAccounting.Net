using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Objects
{
    public record InputError(string[] path,//Path to the input value.
                            string message,//Error message.
                            string code //Error code.
                            )
    {
    }
}
