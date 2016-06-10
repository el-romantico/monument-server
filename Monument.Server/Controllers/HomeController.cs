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

        public ActionResult Data(string locale, int? id)
        {
            ViewBag.Localization = new IdLocaleViewModel { Id = id, Locale = locale.ToLower() == "bg" ? "EN" : "BG" };
            var data = DataService.GetData(id ?? 0, locale);
            return View(model:data);
        }

        public ActionResult Stats()
        {
            var stats = DataService.GetStats();
            return View(stats);
        }
    }
}
