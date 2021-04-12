using System.Web.Mvc;
using PraciceWebApp.Models;
using PraciceWebApp;
namespace PraciceWebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Model1 model)
        {
            RangeClass range_object = new RangeClass(model.number);
            ViewBag.Range = "Range: "+range_object.GetRange();
            PrimeNoClass prime_object = new PrimeNoClass(model.number);
            ViewBag.Prime = "Type: " + prime_object.GetValue();
            return View();
        }
    }
}