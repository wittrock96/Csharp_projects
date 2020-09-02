using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            // ViewBag.BaseballLeagues = _context.Leagues
            //     .Where(l => l.Sport.Contains("Baseball"))
            //     .ToList();

            // List<League> BaseballLeagues = _context.Leagues
            //     .Where(l => l.Sport.Contains("Baseball"))
            //     .ToList();
            
            // Console.WriteLine(BaseballLeagues[0].Name);

            
            return View();
        }
        public JsonResult convertToJson()
        {
            var anonobject = new {
                BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList(),
                womensLeague = _context.Leagues.Where(League => League.Name.Contains("Womens")).ToList()
             

            };
            
            return Json(anonobject);
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            // ViewBag.womensLeague = _context.Leagues.Where(League => League.Name.Contains("Womens")).ToList();
            ViewBag.thisJson= convertToJson();
            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}