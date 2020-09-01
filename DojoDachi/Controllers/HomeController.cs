using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DojoDachi.Models;
using DbConnection;

namespace DojoDachi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public Dachi thisdachi = new Dachi();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ViewResult Index()
        {
            // ViewBag.full = thisdachi.fullness;
            
            return View(thisdachi);
        }

        [HttpGet("/feed")]

        public IActionResult feed()
        {       
            Console.WriteLine(thisdachi.fullness);
            thisdachi = thisdachi.feed();
            Console.WriteLine(thisdachi.fullness);
            return RedirectToAction("Index");
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
