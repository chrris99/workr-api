using FastEndpoints;
using FastEndpoints.Security;

namespace Workr.Web._Features_.Auth;

public sealed class LoginEndpoint : Endpoint<LoginRequest, AuthResponse>
{
    public override void Configure()
    {
        Post("/api/login");
        AllowAnonymous();
    }
    
    public override async Task HandleAsync(LoginRequest req, CancellationToken ct)
    {
        /*
        if (await authService.CredentialsAreValid(req.Email, req.Password, ct))
        {
            var jwtToken = JWTBearer.CreateToken(
                signingKey: "TokenSigningKey",
                expireAt: DateTime.UtcNow.AddDays(1),
                priviledges: u =>
                {
                    u.Roles.Add("Manager");
                    u.Permissions.AddRange(new[] { "ManageUsers", "ManageInventory" });
                    u.Claims.Add(new("Email", req.Email));
                    u["UserID"] = "001"; //indexer based claim setting
                });

            await SendAsync(new AuthResponse(req.Email, jwtToken));
        }
        else
        {
            ThrowError("The supplied credentials are invalid!");
        }*/

        await SendAsync(new AuthResponse(req.Email, "token"));
    }
}