using System.Diagnostics;
using ASPNET_DK23TTC11_TRANDINHHOAITHUONG_170123537.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET_DK23TTC11_TRANDINHHOAITHUONG_170123537.Controllers
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
