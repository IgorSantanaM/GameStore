using GameStore.Api.Data;
using GameStore.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);
//conexao com banco
    var connString = builder.Configuration.GetConnectionString("GameStore");
    builder.Services.AddSqlite<GameStoreContext>(connString);
    //

var app = builder.Build();

app.MapGamesEndPoints();
app.MapGenresEndPoints();

await app.MigrateDbAsync();

app.Run();