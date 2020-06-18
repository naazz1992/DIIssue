using Abp.Authorization;
using DIIssue.Authorization.Roles;
using DIIssue.Authorization.Users;

namespace DIIssue.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
