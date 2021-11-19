using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Enums
{
    public enum TransactionOrigin
    {
        MANUAL, //Manually created transaction.
        ZAPIER //Transaction created through Zapier.
    }
}
