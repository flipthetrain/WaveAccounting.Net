using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Schema.Objects;

namespace Wave.Schema.Queries
{
    public record Businesses(int page,//1-based page number to retrieve.
                            int pageSize,//Limit on how many items each page should return.
                            BusinessConnection businesses//List businesses.
                            )
    {
    }
}
