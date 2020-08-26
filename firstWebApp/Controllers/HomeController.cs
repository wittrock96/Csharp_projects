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

        [HttpGet]
        [Route("/getuser")]

        public RedirectToActionResult method(){

      
            return RedirectToAction("aboutMe");

        }

        [HttpGet]
        [Route("/aboutMe")]

        public JsonResult aboutMe(){

            var AnonObject = new {
                FirstName = "Raz",
                LastName = "Aquato",
                Age = 10
            };
            return Json(AnonObject);

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