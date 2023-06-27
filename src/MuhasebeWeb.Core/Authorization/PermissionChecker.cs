using Abp.Authorization;
using MuhasebeWeb.Authorization.Roles;
using MuhasebeWeb.Authorization.Users;

namespace MuhasebeWeb.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
