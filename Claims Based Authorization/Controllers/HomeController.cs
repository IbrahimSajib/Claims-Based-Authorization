using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Claims_Based_Authorization.Models;
using System.Diagnostics;

namespace Claims_Based_Authorization.Controllers
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
        public IActionResult Public()
        {
            return View();
        }

        [Authorize]
        public IActionResult Private()
        {
            return View();
        }
        
        [Authorize(Policy ="AdminPolicy")]
        public IActionResult Admin_Only()
        {
            return View();
        }
        
        [Authorize(Policy ="MalePolicy")]
        public IActionResult Male()
        {
            return View();
        }
        
        [Authorize(Policy ="FemalePolicy")]
        public IActionResult Female()
        {
            return View();
        }
          

        [Authorize(Policy = "BangladeshPolicy")]
        public IActionResult Bangladesh()
        {
            return View();
        }
        [Authorize(Policy = "JapanPolicy")]
        public IActionResult Japan()
        {
            return View();
        }
        [Authorize(Policy = "AustraliaPolicy")]
        public IActionResult Australia()
        {
            return View();
        }
        
        [Authorize(Policy = "CanadaPolicy")]
        public IActionResult Canada()
        {
            return View();
        }
        [Authorize(Policy = "AsianPolicy")]
        public IActionResult Asian()
        {
            return View();
        }

        [Authorize]
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
