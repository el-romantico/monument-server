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
            ViewBag.Locale = locale.ToLower() == "bg" ? "EN" : "BG";
            ViewBag.Id = id;
            //var baseUrl = Path.Combine(Request.Url.Scheme, Request.Url.Host);
            //var route = Path.Combine(Request.Url.Segments.Take(4).ToList().Union(new[] { locale }).ToArray());
            //ViewBag.LocalizationUrl = Path.Combine(baseUrl.ToString(), route.ToString());
            var data = DataService.GetData(id, locale);
            return View(model:data);
        }
    }
}
