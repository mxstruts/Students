using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySoccerPortal.Models;

namespace MySoccerPortal.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult Students()
        {
            return View();
        }

        public ActionResult Create()
        {
            var model = new StudentViewModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(StudentViewModel model)
        {

            string firstname = model.FirstName;
            string lastname = model.LastName;
            int age = model.Age;
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

    }
}