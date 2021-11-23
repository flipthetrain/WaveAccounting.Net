// See https://aka.ms/new-console-template for more information
using Wave.GraphQL;

Console.WriteLine("Hello, World!");
string businessQuery=new QueryEngine().generateQuery<Wave.Schema.Queries.Business>();

