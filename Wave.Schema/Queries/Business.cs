﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Queries
{
    public record Business(string id,//ID of business. - If defined, it will fetch that business. - If not defined and the access token is restricted to a single business, it will fetch that business. - If not defined and the access token can access multiple businesses, it will fetch the user's default business. To set a default business see https://support.waveapps.com/hc/en-us/articles/208621226
                            Business business//Get a business.
                            )
    {
    }
}
