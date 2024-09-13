using Microsoft.AspNetCore.Mvc;
using MyWebAPP.Models;
using System.Diagnostics;

namespace MyWebAPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = "Message from ViewData";
            ViewData["CurrentTime"] = DateTime.Now;
            ViewBag.Message1 = "Trinh Cong Duc";

            ViewData["Message"] = "The message in the ViewData";
            ViewBag.Message = "The message in the ViewBag";
            TempData["Message"] = "The message in the TempData";
            TempData["Mess"] = "TCD";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
