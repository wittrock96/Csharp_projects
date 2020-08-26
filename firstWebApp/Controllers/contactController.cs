using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

namespace firstWebApp
{
    public class ContactController : Controller
    {
        // requests
        // localHost:5000/

        // [Route("")]
        // [HttpGet]

        // //localHost:5000/hello
        // [Route("hello")]
        // [HttpGet]

        [HttpGet]
        [Route("/contact")]
        

        // public string Index()
        // {
        //     return "welcome";
        // }

        // [HttpGet("projects")]
        

        // public string projects()
        // {
        //     return "this is my projects";
        // }

        // [HttpGet]
        // [Route("contact")]

        public string contact()
        {
            return "this is my contact";
        }
        



    }
}