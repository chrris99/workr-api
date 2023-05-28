using FastEndpoints;

namespace Workr.Web;

public class BaseRequest
{
    [FromHeader(IsRequired = false)]
    public string? Token { get; set; }
}