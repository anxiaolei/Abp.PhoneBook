using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.PhoneBook.MultiTenancy.Dto;

namespace Abp.PhoneBook.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

