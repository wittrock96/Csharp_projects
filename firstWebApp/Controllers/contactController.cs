using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

namespace firstWebApp
{
    public class ContactController : Controller
    {


        [HttpGet]
        [Route("/contact")]
        



        public ViewResult contact()
        {
            return View();
        }
        



    }
}