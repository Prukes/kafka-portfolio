using Gateway.GraphQL.Queries;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddInMemorySubscriptions();
var app = builder.Build();
app.MapGraphQL("/graphql");
app.Run();
