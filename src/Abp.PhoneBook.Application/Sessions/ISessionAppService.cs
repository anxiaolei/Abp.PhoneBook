using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.PhoneBook.Sessions.Dto;

namespace Abp.PhoneBook.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
