using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using testing_mvc.Models;

namespace testing_mvc.Controllers
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

        [HttpGet("names")]

        public IActionResult Names()
        {
            string[] names = new string[]
            {
                "sally", "Billy", "Joes", "Moose"
            };
            return View(names);
        }

        [HttpGet("numbers")]

        public IActionResult numbers()
        {
            int[] numbers = new int[]
            {
                51,2,2,3,34,55,66,113,44,55,77,134
            };
            return View(numbers); 
        }

        [HttpGet("user")]

        public IActionResult user()
        {
            string thisuser = "cole";

            return View((object)thisuser);
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
