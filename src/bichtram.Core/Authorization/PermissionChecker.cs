using Abp.Authorization;
using bichtram.Authorization.Roles;
using bichtram.Authorization.Users;

namespace bichtram.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
