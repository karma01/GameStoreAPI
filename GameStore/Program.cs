using GameStore.Data;
using GameStore.Endpoints;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddValidation();
builder.PopulateInitialData();

var app = builder.Build();
app.MapEndpoints();
app.MapGenreEndpoints();
app.MigrateDb();

app.Run();