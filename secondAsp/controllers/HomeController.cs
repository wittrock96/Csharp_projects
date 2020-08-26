using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

namespace firstWebApp
{
    public class homeController : Controller
    {


        [HttpGet]
        [Route("")]
        

        public ViewResult Home()
        {
            // ViewResult myview = View();
            // return myview;
            return View();
        }


        



    }
}