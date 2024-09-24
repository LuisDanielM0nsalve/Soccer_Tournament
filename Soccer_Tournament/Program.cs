using Soccer_Tournament.Respositories;
using Soccer_Tournament.Respositories.Interfaces;
using Soccer_Tournament.Services;
using Soccer_Tournament.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IMatchRepository, MatchRepository>();
builder.Services.AddSingleton<IPlayerRepository, PlayerRepository>();
builder.Services.AddSingleton<IMatchService, MatchService>();
builder.Services.AddSingleton<IPlayerService, PlayerService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
