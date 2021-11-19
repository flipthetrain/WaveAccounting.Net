﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Objects
{
    public record Province(string code,//[ISO 3166-2](https://en.wikipedia.org/wiki/ISO_3166-2) identifier.
                            string name //Plain-lanuage representaton.
                            )
    {
    }
}