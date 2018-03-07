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

        [HttpGet("/babies/{id}")]
        public ActionResult Details(int id)
        {
          Baby baby = Baby.Find(id);
          return View(baby);
        }

        [HttpPost("/babies")]
        public ActionResult Create()
        {
            string name = Request.Form[("new-name")];
            string stringAge = Request.Form[("new-age")];
            string parent = Request.Form[("new-parent")];

            int age = Int32.Parse(stringAge);

            Baby newBaby = new Baby(name, age, parent);
            newBaby.Save();

            List<Baby> allBabies = Baby.GetAll();//List should be reviewed
            return View("Index",allBabies);
        }

        [HttpPost("babies/delete")]
        public ActionResult DeleteAll()
        {
          Baby.ClearAll();
          return View();
        }

    }
}
