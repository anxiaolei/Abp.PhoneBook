using System.Threading.Tasks;
using Abp.PhoneBook.Configuration.Dto;

namespace Abp.PhoneBook.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
