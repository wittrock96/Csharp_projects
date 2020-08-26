using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

namespace firstWebApp
{
    public class ProjectsController : Controller
    {



        

        [HttpGet]
        [Route("/projects")]
        

        public ViewResult projects()
        {
            return View();
        }


        



    }
}