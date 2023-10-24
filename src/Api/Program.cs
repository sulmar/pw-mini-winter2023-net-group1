using Api.Infrastructure;

using Domain.Abstractions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSingleton<IUserRepository, FakeUserRepository>();

var app = builder.Build();

app.MapControllers();

app.Run();
