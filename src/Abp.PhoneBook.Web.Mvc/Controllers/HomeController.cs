using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.PhoneBook.Controllers;

namespace Abp.PhoneBook.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : PhoneBookControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
