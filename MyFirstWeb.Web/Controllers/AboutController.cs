using System.Web.Mvc;

namespace MyFirstWeb.Web.Controllers
{
    public class AboutController : MyFirstWebControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}