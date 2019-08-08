using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.PhoneBook.Authorization.Accounts.Dto;

namespace Abp.PhoneBook.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
