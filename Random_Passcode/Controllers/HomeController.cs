using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Random_Passcode.Models;
using Microsoft.AspNetCore.Http;
// using System.Web.HttpContext.Current.Session;
// using System.Web.UI.Page.Session;

namespace Random_Passcode.Controllers
{
    public class HomeController : Controller
    {
        public int _Counter = 0;
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // _Counter = Convert.ToInt32(Session["mycounter!"]);
            
            
            // HttpContext.Session.SetInt32("count", 0);
            return View();
        }
        [HttpGet("Random_code")]
        public IActionResult Random_code()
        {
             
            
            HttpContext.Session.SetInt32("count", _Counter);
            _Counter += 1;                  
            
            Console.WriteLine(_Counter);
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
