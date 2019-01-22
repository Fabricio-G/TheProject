using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;

namespace System.BackEnd.Authorization
{
    public class UserAccessAuthorization : IAuthorizationRequirement
    {
        public UserAccessAuthorization(IConfiguration configuration)
        {
        }
    }
}
