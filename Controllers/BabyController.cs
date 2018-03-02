using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BabySitter.Models;


namespace BabySitter.Controllers
{
    public class BabiesController : Controller
    {
        [HttpGet("/babies")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost("/babies")]
        public ActionResult Index2()
        {
            string name = Request.Form[("new-name")];
            string stringAge = Request.Form[("new-age")];
            string parent = Request.Form[("new-parent")];
            int age = int.Parse(stringAge);

            Baby newBaby = new Baby(name, age, parent);
            return View(newBaby);
        }

        [HttpGet("/babies/new")]
        public ActionResult CreateForm()
        {
            return View();
        }
    }
}
