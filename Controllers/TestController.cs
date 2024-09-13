using Microsoft.AspNetCore.Mvc;

namespace MyWebAPP.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
