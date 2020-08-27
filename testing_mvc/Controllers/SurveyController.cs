using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using testing_mvc.Models;

namespace testing_mvc
{

    public class SurveyController : Controller{
        public Survey thissurvey;


        [HttpPost("registration")]
        public ActionResult survey(Survey yoursurvey)
        {
            ViewBag.name = yoursurvey.Name;
            ViewBag.location = yoursurvey.location;
            ViewBag.language = yoursurvey.language;
            return View();
        }

        [HttpGet("survey")]       
    
        public ActionResult survey()
        {

            return View();
        }
    }
    




}