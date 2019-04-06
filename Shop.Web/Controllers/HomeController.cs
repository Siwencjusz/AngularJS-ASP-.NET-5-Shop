using System.Web.Mvc;

namespace Shop.Web.Controllers
{
    public class HomeController : ShopControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}