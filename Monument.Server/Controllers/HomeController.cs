using Monument.Server.Models;
using Monument.Service;
using System.IO;
using System.Linq;
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
            ViewBag.Localization = new IdLocaleViewModel { Id = id, Locale = locale.ToLower() == "bg" ? "EN" : "BG" };
            var data = DataService.GetData(id, locale);
            return View(model:data);
        }
    }
}
