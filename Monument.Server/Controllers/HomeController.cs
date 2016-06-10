using Monument.Server.Models;
using Monument.Service;
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

        public ActionResult Data(int id, string locale)
        {
            var data = DataService.GetData(id, locale);
            return View(model:data);
        }
    }
}
