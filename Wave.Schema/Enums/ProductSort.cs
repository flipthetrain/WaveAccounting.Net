using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Enums
{
    public enum ProductSort
    {
        EATED_AT_ASC, //Ascending by creation time.
        CREATED_AT_DESC, //Descending by creation time.
        MODIFIED_AT_ASC, //Ascending by modified time.
        MODIFIED_AT_DESC, //Descending by modified time.
        NAME_ASC, //Ascending by name.
        NAME_DESC //Descending by name.
    }
}
