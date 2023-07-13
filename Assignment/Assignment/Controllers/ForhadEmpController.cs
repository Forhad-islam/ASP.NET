using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment.Models;

namespace Assignment.Controllers
{
    public class ForhadEmpController : Controller
    {
        // GET: ForhadEmp
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveData(employee idea)
        {
            if (idea != null)
            {
                return View();
            }
            return View("Index");
        }
    }
}