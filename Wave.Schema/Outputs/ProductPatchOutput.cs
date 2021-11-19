﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.Schema.Objects;

namespace Wave.Schema.Outputs
{
    public record ProductPatchOutput(Product product,//Product that was updated.
bool didSucceed,//Indicates whether the product was successfully patched.
InputError[] inputErrors //Mutation validation errors.
)
    {
    }
}
