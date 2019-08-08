using System.Collections.Generic;
using Abp.PhoneBook.Roles.Dto;

namespace Abp.PhoneBook.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
