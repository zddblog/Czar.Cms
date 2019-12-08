using General.Entities.SysUser;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace General.Framework.Secunity.Admin
{
    public class AdminAuthService : IAdminAuthService
    {
        private IHttpContextAccessor _httpContextAccessor;

        public AdminAuthService(IHttpContextAccessor httpContextAccessor)
        {
            this._httpContextAccessor = httpContextAccessor;
        }
        public SysUser getCurrentUser()
        {
            var result = _httpContextAccessor.HttpContext.AuthenticateAsync(CookieAdminAuthInfo.AuthenticationScheme).Result;
            var token = result.Principal.FindFirst(ClaimTypes.Sid);
            return new SysUser() { Name="李四"};
        }

        public void sginIn(string token, string name)
        {
            ClaimsIdentity claimsIdentity = new ClaimsIdentity("Forms");
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Sid,token));
            claimsIdentity.AddClaim(new Claim(ClaimTypes.Name,name));
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal();
            _httpContextAccessor.HttpContext.SignInAsync("General", claimsPrincipal);

        }
    }
}
