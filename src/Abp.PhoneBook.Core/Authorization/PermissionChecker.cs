using Abp.Authorization;
using Abp.PhoneBook.Authorization.Roles;
using Abp.PhoneBook.Authorization.Users;

namespace Abp.PhoneBook.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
