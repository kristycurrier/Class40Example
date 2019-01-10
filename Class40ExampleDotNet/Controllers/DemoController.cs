using Class40ExampleDotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Class40ExampleDotNet.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            var model = new DemoInputModel
            {
                FirstName = "Kristy",
                Game = "Mario Cart",
                Age = 32,
                PlaysGame = false
            };

            return View(model);
        }
    }
}