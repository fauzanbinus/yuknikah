using Abp.Authorization;
using yuknikah.Authorization.Roles;
using yuknikah.Authorization.Users;

namespace yuknikah.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
