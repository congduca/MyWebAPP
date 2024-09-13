using Microsoft.AspNetCore.Mvc;

namespace MyWebAPP.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult SayHello()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC5";
            return View();
        }
    }
}
