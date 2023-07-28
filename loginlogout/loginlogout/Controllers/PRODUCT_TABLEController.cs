using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using loginlogout;

namespace loginlogout.Controllers
{
    [Authorize]
    public class PRODUCT_TABLEController : Controller
    {
        private PRODUCTEntities db = new PRODUCTEntities();

        // GET: PRODUCT_TABLE
        public ActionResult Index()
        {
            return View(db.PRODUCT_TABLE.ToList());
        }

        // GET: PRODUCT_TABLE/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCT_TABLE pRODUCT_TABLE = db.PRODUCT_TABLE.Find(id);
            if (pRODUCT_TABLE == null)
            {
                return HttpNotFound();
            }
            return View(pRODUCT_TABLE);
        }

        // GET: PRODUCT_TABLE/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PRODUCT_TABLE/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Price,Exdate")] PRODUCT_TABLE pRODUCT_TABLE)
        {
            if (ModelState.IsValid)
            {
                db.PRODUCT_TABLE.Add(pRODUCT_TABLE);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pRODUCT_TABLE);
        }

        // GET: PRODUCT_TABLE/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCT_TABLE pRODUCT_TABLE = db.PRODUCT_TABLE.Find(id);
            if (pRODUCT_TABLE == null)
            {
                return HttpNotFound();
            }
            return View(pRODUCT_TABLE);
        }

        // POST: PRODUCT_TABLE/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Price,Exdate")] PRODUCT_TABLE pRODUCT_TABLE)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRODUCT_TABLE).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pRODUCT_TABLE);
        }

        // GET: PRODUCT_TABLE/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRODUCT_TABLE pRODUCT_TABLE = db.PRODUCT_TABLE.Find(id);
            if (pRODUCT_TABLE == null)
            {
                return HttpNotFound();
            }
            return View(pRODUCT_TABLE);
        }

        // POST: PRODUCT_TABLE/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRODUCT_TABLE pRODUCT_TABLE = db.PRODUCT_TABLE.Find(id);
            db.PRODUCT_TABLE.Remove(pRODUCT_TABLE);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
