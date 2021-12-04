using Wave.Schema.Attributes;

namespace Wave.Schema.Objects
{
    [SchemaObject]
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
