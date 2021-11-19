﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Objects
{
    public record Money(int raw,//Value represented in only the minor currency unit.
                        string value,//Amount represented as a combination of the major and minor currency unit (uses a decimal separator).
                        Currency currency //Currency
                        )
    {
    }
}
