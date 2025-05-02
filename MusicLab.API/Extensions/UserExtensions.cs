using System.Security.Claims;

namespace MusicLab.API.Extensions
{
    public static class UserExtensions
    {
        public static int GetId(this ClaimsPrincipal user)
        {
            return int.Parse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value ?? "-1");
        }
    }
}
