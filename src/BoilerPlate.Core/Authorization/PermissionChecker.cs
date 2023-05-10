using Abp.Authorization;
using BoilerPlate.Authorization.Roles;
using BoilerPlate.Authorization.Users;

namespace BoilerPlate.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
