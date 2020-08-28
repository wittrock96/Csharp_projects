using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using login_registration.Models;

namespace login_registration
{
    public class SuccessController : Controller
    {
        [HttpGet("/success")]
        public ActionResult Success()
        {
            return View();
        }




    }
}