using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using webapp.Models;

namespace webapp.Controllers
{
    public class HomeController : Controller

    {

        public String GreetVisitor() {

            return "hello everybody";
        
        }
        public String GetAge(String name, int brithyear) {
            int age = DateTime.Now.Year - brithyear;
            return "Hi "+name+". you are  "+age+" years old .";
        
        
        }


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
