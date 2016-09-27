using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace SampleMvcApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        // mubina is admin
        [Authorize(Roles = "admin")]
        public IActionResult AdministratorIndex()
        {
            return View("~/Views/Home/Index1.cshtml");

            // return "All good. You only get this message if you are authenticated.";
        }

        [Authorize(Roles = "user")]
        public IActionResult UserIndex()
        {
            return View("~/Views/Home/User.cshtml");
        }


    }
}
