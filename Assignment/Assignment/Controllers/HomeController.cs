using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment.Models;

namespace Assignment.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult AddOrEdit(int id=0)
        {
            Emp empModel = new Emp();
            

            return View(empModel);
        }
        [HttpPost]
        public ActionResult AddOrEdit(Emp empModel)
        {
            using (DbModels dbModel = new DbModels())
            {
                dbModel.Emp.Add(empModel);
                dbModel.SaveChanges();

            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successfully Complete.";
            return View("AddOrEdit", new Emp());
        }

      //  public ActionResult About()
        //{
          //  ViewBag.Message = "Your application description page.";

            //return View();
        //}

        //public ActionResult Contact()
        //{
          //  ViewBag.Message = "Your contact page.";

            //return View();
        //}
    }
}