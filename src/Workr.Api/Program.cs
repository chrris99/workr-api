using System.Security.Cryptography;
using System.Text.RegularExpressions;
using FastEndpoints;
using FastEndpoints.Swagger;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Workr.Infrastructure;
using Workr.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddFastEndpoints();

builder.Services.AddAuthentication().AddJwtBearer(options =>
{
    var pem = configuration.GetSection("Jwt:Key").Value!;
    var splitPem = Regex.Matches(pem, ".{1,64}").Select(m => m.Value).ToArray();
    var publicKey = "-----BEGIN PUBLIC KEY-----\n" + string.Join("\n", splitPem) + "\n-----END PUBLIC KEY-----";
    var rsa = RSA.Create();
    rsa.ImportFromPem(publicKey);
    
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidIssuer = "https://fast-sloth-95.clerk.accounts.dev",
        ValidateIssuer = true,
        ValidateLifetime = true,
        ValidateAudience = false,
        ValidateIssuerSigningKey = true,
        ClockSkew = TimeSpan.Zero,
        IssuerSigningKey = new RsaSecurityKey(rsa)
    };
});

builder.Services.SwaggerDocument(options =>
{
    options.AutoTagPathSegmentIndex = 2;
});

builder.Services.AddDbContext<ApplicationDbContext>(optionsBuilder =>
    optionsBuilder.UseNpgsql(configuration.GetConnectionString("Postgres"))
);
builder.Services.AddRepositories();

var app = builder.Build();

app.UseFastEndpoints();

app.UseAuthentication();
app.UseAuthorization();

app.UseSwaggerGen();

app.Run();
