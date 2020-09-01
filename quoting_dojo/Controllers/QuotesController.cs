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
        public ActionResult create(Quote thisquote){

            string query = $"INSERT INTO Quote (Name, saying) VALUES ('{thisquote.Name}, {thisquote.saying}')";

            return Redirect("/");
        }
    }
}