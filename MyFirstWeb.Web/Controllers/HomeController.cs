using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace MyFirstWeb.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MyFirstWebControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}