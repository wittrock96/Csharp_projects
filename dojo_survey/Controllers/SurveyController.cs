using System;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;


namespace dojo_survey
{
    public class SurveyController : Controller
    {
        [HttpGet]
        [Route("")]

        public IActionResult Survey()
        {

            return View();
        }

        [HttpPost("/result")]

        public IActionResult result(string Name, string location, string language)
        {
            ViewBag.name = Name;
            ViewBag.location = location;
            ViewBag.language = language;

            return View();
        }


        // public JsonResult jsonThis(string Name, string location, string language)
        // {
        //     var surveyResult = new {
        //         thisName = Name,
        //         thislocation = location,
        //         thislanguage = language
        //     };
        //     return Json(surveyResult); 
        // }
    }
}