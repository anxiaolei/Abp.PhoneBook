using Abp.Application.Services.Dto;

namespace Abp.PhoneBook.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

