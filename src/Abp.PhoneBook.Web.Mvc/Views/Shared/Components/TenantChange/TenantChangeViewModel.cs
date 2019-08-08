using Abp.AutoMapper;
using Abp.PhoneBook.Sessions.Dto;

namespace Abp.PhoneBook.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
