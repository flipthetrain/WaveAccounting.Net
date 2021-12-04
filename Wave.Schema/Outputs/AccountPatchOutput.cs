using Wave.Schema.Objects;

namespace Wave.Schema.Outputs
{
    public record AccountPatchOutput(Account account,//Account that was patched.
bool didSucceed,//Indicates whether the account was successfully patched.
InputError[] inputErrors //Mutation validation errors.
)
    {
    }
}
