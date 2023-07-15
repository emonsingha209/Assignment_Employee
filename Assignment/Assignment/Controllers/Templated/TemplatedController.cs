using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment.Models;

namespace Assignment.Controllers.Templated
{
    public class TemplatedController : Controller
    {
        // GET: Templated
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(EmployeeModel empModel)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                ViewBag.Okay = "Data Added";
            }
            return View();
        }
    }
}