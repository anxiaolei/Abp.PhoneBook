using System.Collections.Generic;
using Abp.PhoneBook.Roles.Dto;
using Abp.PhoneBook.Users.Dto;

namespace Abp.PhoneBook.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
