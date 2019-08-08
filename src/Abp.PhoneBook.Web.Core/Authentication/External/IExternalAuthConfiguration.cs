using System.Collections.Generic;

namespace Abp.PhoneBook.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
