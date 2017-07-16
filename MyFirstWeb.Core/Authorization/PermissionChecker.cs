using Abp.Authorization;
using MyFirstWeb.Authorization.Roles;
using MyFirstWeb.MultiTenancy;
using MyFirstWeb.Users;

namespace MyFirstWeb.Authorization
{
    public class PermissionChecker : PermissionChecker< Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
