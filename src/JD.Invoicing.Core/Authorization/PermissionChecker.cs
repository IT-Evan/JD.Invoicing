using Abp.Authorization;
using JD.Invoicing.Authorization.Roles;
using JD.Invoicing.Authorization.Users;

namespace JD.Invoicing.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
