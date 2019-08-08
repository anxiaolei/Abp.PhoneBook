using Microsoft.AspNetCore.Antiforgery;
using Abp.PhoneBook.Controllers;

namespace Abp.PhoneBook.Web.Host.Controllers
{
    public class AntiForgeryController : PhoneBookControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
