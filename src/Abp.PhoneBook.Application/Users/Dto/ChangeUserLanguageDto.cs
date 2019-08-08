using System.ComponentModel.DataAnnotations;

namespace Abp.PhoneBook.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}