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
            List<Baby> allBabies = Baby.GetAll();
            return View(allBabies);
        }

        [HttpGet("/babies/new")]
        public ActionResult CreateForm()
        {
            return View();
        }

        [HttpPost("/babies")]
        public ActionResult Create()
        {
            Baby newBaby = new Baby(Request.Form["new-name"]);
            newBaby.Save();
            // string name = Request.Form[("new-name")];
            // string stringAge = Request.Form[("new-age")];
            // string parent = Request.Form[("new-parent")];
            // int age = int.Parse(stringAge);
            //
            // Baby newBaby = new Baby(name, age, parent);
            // return View(newBaby);

            List<Baby> allBabies = Baby.GetAll();
            return View("Index",allBabies );
        }

        [HttpPost("babies/delete")]
        public ActionResult DeleteAll()
        {
          Baby.ClearAll();
          return View();
        }

    }
}
