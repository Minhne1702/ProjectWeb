using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace Lab02.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1, int id =0)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = id;

            return View();
        }
    }
}
