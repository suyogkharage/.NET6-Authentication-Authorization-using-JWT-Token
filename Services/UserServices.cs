using System.Security.Claims;

namespace JWTWebAPI.Services
{
    public interface IUserServices
    {
        public string GetUserName();
    }
    public class UserServices : IUserServices
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserServices(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public string GetUserName()
        {
            var result = string.Empty;
            if(_httpContextAccessor.HttpContext != null) 
            {
                result = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            }
            return result;
        }
    }
}
