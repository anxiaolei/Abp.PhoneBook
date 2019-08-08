using System.Collections.Generic;
using Abp.PhoneBook.Roles.Dto;

namespace Abp.PhoneBook.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}