using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Wave.GraphQL.Helpers;
using Wave.Schema.Objects;
using Wave.Schema.Responses;

namespace Wave.GraphQL.Engines
{
    public static class PHHOA
    {
        public static IEnumerable<Business> GetAllBusinesses(int page=1, int pageSize=10)
        {
            int lastPage = int.MaxValue;

            while (page < lastPage)
            {
                string query = @"
                            query($page:Int, $pageSize:Int) {
                              businesses(page: $page, pageSize: $pageSize) {
                                pageInfo {
                                  currentPage
                                  totalPages
                                  totalCount
                                }
                                edges {
                                  node {
                                    id
                                    name
                                  }
                                }
                              }
                            }";

                string variables = @$"
                                {{
                                    ""page"" : {page},
                                    ""pageSize""  : {pageSize}
                                }}
                                ";

                string results = GraphQLHelper.Query(query: query, variables: variables).Result;

                Query<Businesses> businessees = JsonConvert.DeserializeObject<Query<Businesses>>(results);

                lastPage = businessees.data.businesses.pageInfo.totalPages;

                foreach (BusinessEdge item in businessees.data.businesses.edges)
                {
                    yield return item.node;
                }

                page++;
            }
        }
    }
}
