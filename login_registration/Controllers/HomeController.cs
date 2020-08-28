using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using login_registration.Models;

namespace login_registration.Controllers
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

        [HttpPost("/RegUser/Create")]
        public ActionResult create(RegUser user)
        {
            if(ModelState.IsValid)
            {
                return Redirect("/success");
            }
            else{
                return Redirect("/");
            }
        }

        [HttpPost("/LogUser/LogIn")]

        public ActionResult login(LogUser user)
        {
            if(ModelState.IsValid){
                return Redirect("/success");
            }
            else{
                return Redirect("/");
            }
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
