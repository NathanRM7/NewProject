// See https://aka.ms/new-console-template for more information
using System.Security.Claims;

public abstract class HttpContext
{
    public abstract ClaimsPrincipal User { get; set; }
}