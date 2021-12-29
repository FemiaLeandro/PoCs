using IoC.PoC.Web.Models;
using IoC.PoC.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IoC.PoC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITestService _testService;

        public HomeController(ILogger<HomeController> logger, ITestService testService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _testService = testService ?? throw new ArgumentNullException(nameof(testService));
        }

        public IActionResult Index()
        {
            var newVariableWithoutSpecificName = _testService.GetTestString();

            Console.WriteLine(newVariableWithoutSpecificName);

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