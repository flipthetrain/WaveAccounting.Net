using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Enums
{
    public enum Schema
    {
        HRBLOCK, //Available only to HR Block integration.
        INTERNAL, //Available only to Wave.
        PUBLIC, //Available to all third parties.
        STAFF //Available only to Wave staff.
    }
}
