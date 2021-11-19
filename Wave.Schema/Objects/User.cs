using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wave.Schema.Objects
{
    public record User(string id,//The unique identifier for the user.
string defaultEmail,//The user's primary email address.
string firstName,//The user's first name.
string lastName,//The user's last name.
DateTime createdAt,//When the user was created.
DateTime modifiedAt //When the user was last modified.
)
    {
    }
}
