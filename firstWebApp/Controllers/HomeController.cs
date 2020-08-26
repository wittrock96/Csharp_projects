using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

namespace firstWebApp
{
    public class homeController : Controller
    {
        // requests
        // localHost:5000/

        // [Route("")]
        // [HttpGet]

        // //localHost:5000/hello
        // [Route("hello")]
        // [HttpGet]

        [HttpGet]
        [Route("")]
        

        public ViewResult Index()
        {
            // ViewResult myview = View();
            // return myview;
            return View();
        }

        // [HttpGet("projects")]
        

        // public string projects()
        // {
        //     return "this is my projects";
        // }

        // [HttpGet]
        // [Route("contact")]

        // public string contact()
        // {
        //     return "this is my contact";
        // }
        



    }
}