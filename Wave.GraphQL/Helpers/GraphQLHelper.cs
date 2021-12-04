using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace Wave.GraphQL.Helpers
{
    public static class GraphQLHelper
    {
        private static Uri graphQLUri = new Uri("https://gql.waveapps.com/graphql/public");
        private static string authorizationToken = "npdxhhsYnOVoFv5oHZknJq6PsEla0a";

        public static async Task<string> Query(string query, string operation = null, string variables = null)
        {
            Dictionary<string, string> values = new Dictionary<string, string>();
            if (!string.IsNullOrWhiteSpace(query))
                values.Add("query", query);

            if (!String.IsNullOrEmpty(variables))
                values.Add("operation", operation);

            if (!String.IsNullOrEmpty(variables))
                values.Add("variables", variables);


            string content = JsonConvert.SerializeObject(values);

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authorizationToken);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpRequestMessage reqMsg = new HttpRequestMessage(HttpMethod.Post, graphQLUri);
            reqMsg.Content = new StringContent(content, Encoding.UTF8, "application/json");
            HttpResponseMessage respMsg = await client.SendAsync(reqMsg);
            string responseBody = await respMsg.Content.ReadAsStringAsync();
            return responseBody;
        }

    }
}
