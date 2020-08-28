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
    public class UserController : Controller
    {
        [HttpGet("/user/registration")]
        public new ActionResult User()
        {
            return View();
        }

        [HttpPost("/user/register")]
        public ActionResult Create(User newUser)
        {
            if(ModelState.IsValid){
                return Redirect("/user/success");
            }
            else
            {
                return View("User");
            }
        }

        [HttpGet("/user/success")]

        public ActionResult Success()
        {
            return View();
        }
    }
}