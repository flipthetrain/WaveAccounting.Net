//using Wave.GraphQL.Engines;

//var business=PHHOA.GetAllBusinesses(1, 10);

//var businessList = business.ToList();

using Wave.GraphQL.Engines;
using Wave.Schema.Queries;

string query=QueryEngine.generateQuery<Businesses>();


int i = 0;

