using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Chatable.Data
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        public override Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, "nhih0504@gmial.com"),
            }, "apiauth_type");
            var user = new ClaimsPrincipal(identity);
            return  Task.FromResult(new AuthenticationState(user));
        }
    }
}
