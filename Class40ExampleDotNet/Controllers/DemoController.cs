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
            
            return View();
        }

        public ActionResult Edit(DemoInputModel model)
        {
            //Maybe save this?
            if(ModelState.IsValid == false)
            {
                //we can throw an error here
            }
            return RedirectToAction("Index");
        }
    }
}