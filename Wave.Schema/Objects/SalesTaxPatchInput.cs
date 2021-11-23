using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record SalesTaxPatchInput(string id,//The unique identifier for the sales tax.
                    string name,//Name of the tax.
                    string abbreviation,//An short form or code representing the sales tax
                    string description,//User defined description for the sales tax.
                    string taxNumber,//The tax's issued identification number from a taxing authority.
                    bool showTaxNumberOnInvoices//Display tax number beside the tax name on an invoice.
                    )
    {
    }
}
