using Wave.Schema.Attributes;

namespace Wave.Schema.Queries
{
    [SchemaQuery("business")]
    public record Business(string id,//ID of business. - If defined, it will fetch that business. - If not defined and the access token is restricted to a single business, it will fetch that business. - If not defined and the access token can access multiple businesses, it will fetch the user's default business. To set a default business see https://support.waveapps.com/hc/en-us/articles/208621226
                            Objects.Business business//Get a business.
                            )
    {
    }
}
