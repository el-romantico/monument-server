using System.Web.Mvc;

namespace Monument.Server.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Data(int id)
        {
            return View("Data", id);
        }
    }
}
