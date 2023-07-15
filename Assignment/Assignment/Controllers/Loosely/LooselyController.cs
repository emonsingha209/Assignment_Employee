using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment.Controllers.Loosely
{
    public class LooselyController : Controller
    {
        // GET: Loosely
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Save(EmployeeModel model)
        {
            if(ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return View("Index");
            }
        }
    }
}