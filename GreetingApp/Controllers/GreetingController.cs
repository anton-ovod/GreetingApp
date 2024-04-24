using GreetingApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GreetingApp.Controllers
{
    public class GreetingController : Controller
    {
        private readonly ILogger<GreetingController> _logger;

        public GreetingController(ILogger<GreetingController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Greet(UserNameModel userNameModel)
        {
            if (ModelState.IsValid) return View(userNameModel);
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
