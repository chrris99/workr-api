using FastEndpoints;
using FastEndpoints.Swagger;
using Microsoft.EntityFrameworkCore;
using Workr.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFastEndpoints();
builder.Services.SwaggerDocument();

builder.Services.AddDbContext<ApplicationDbContext>(optionsBuilder =>
    optionsBuilder.UseNpgsql(builder.Configuration.GetConnectionString("Postgres"))
);

var app = builder.Build();

app.UseFastEndpoints();
app.UseSwaggerGen();

app.Run();
