using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;

namespace Wave.Schema.Queries
{
    [SchemaQuery]
    public  record User(Objects.User user) //The currently authenticated user.
    {
    }
}
