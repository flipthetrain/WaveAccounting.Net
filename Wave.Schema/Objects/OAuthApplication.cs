using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wave.GraphQL.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
    public record OAuthApplication(string id,//The unique identifier for the application.
                                    string name,//The name of the application.
                                    string description,//A description of the application.
                                    string clientId,//The client identifier issued to the client during the registration process.
                                    URL logoUrl,//The URL to the application logo.
                                    JSON extraData,//Additional data for the application. - If the requested `clientId` does not match that of the current OAuth application, `extraData` will not be returned.
                                    DateTime createdAt,//When the application was created.
                                    DateTime modifiedAt //When the application was last modified.
                                    )
    {
    }
}
