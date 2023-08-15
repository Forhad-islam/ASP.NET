using CRUD_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            using (DBModel db = new DBModel())
            {
                     return View(db.Employees.ToList());
            }
               
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            using (DBModel db = new DBModel ())
            {
                return View(db.Employees.Where(x => x.ID == id).FirstOrDefault());
            }
                
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                // TODO: Add insert logic here
                using (DBModel db = new DBModel())
                {
                    db.Employees.Add(emp);
                    db.SaveChanges();
                }

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBModel db = new DBModel())
            {
                return View(db.Employees.Where(x => x.ID == id).FirstOrDefault());
            }
            return View();
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee emp)
        {
            try
            {
                // TODO: Add update logic here
                using (DBModel db = new DBModel())
                {
                    db.Entry(emp).State = EntityState.Modified;
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBModel db = new DBModel())
            {
                return View(db.Employees.Where(x => x.ID == id).FirstOrDefault());
            }
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Employee emps)
        {
            try
            {
                // TODO: Add delete logic here
                using (DBModel db = new DBModel())
                {
                    emps = db.Employees.Where(x => x.ID == id).FirstOrDefault();
                    db.Employees.Remove(emps);
                    db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
