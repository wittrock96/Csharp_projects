using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Random_Passcode.Models;
using Microsoft.AspNetCore.Http;

namespace Random_Passcode.Controllers
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
            // HttpContext.Session.SetInt32("count", 0);
            return View();
        }
        [HttpGet("Random_code")]
        public IActionResult Random_code()
        {
            // SessionExtensions.SetInt32("counter", 0);
            
            int? intvariable = HttpContext.Session.GetInt32("count");
            intvariable += 1;  
            
            Console.WriteLine(intvariable);
            return Redirect("/");
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
