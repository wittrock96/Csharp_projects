using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using quoting_dojo.Models;
using DbConnection;

namespace quoting_dojo
{
    public class QuotesController : Controller
    {


        [HttpPost("/Quote/create")]
        public ActionResult create(Quote thisquote){
            Console.WriteLine(thisquote.Name);

            string query = $"INSERT INTO Quote (Name, saying) VALUES ('{thisquote.Name}', '{thisquote.saying}')";
            DbConnector.Query(query);
            return Redirect("/quotes");
        }

        [HttpGet("/quotes")]

        public ActionResult Quotes()
        {
            List<Dictionary<string,object>> AllQuotes= DbConnector.Query("SELECT * FROM quote");
            ViewBag.quotes = AllQuotes;
            return View();
        }
    }
}