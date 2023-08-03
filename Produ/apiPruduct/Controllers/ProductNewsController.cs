using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using apiPruduct.Models;

namespace apiPruduct.Controllers
{
    public class ProductNewsController : ApiController
    {
        private PRODUCTEntities db = new PRODUCTEntities();

        // GET: api/ProductNews
        public IQueryable<ProductNew> GetProductNew()
        {
            return db.ProductNew;
        }

        // GET: api/ProductNews/5
        [ResponseType(typeof(ProductNew))]
        public IHttpActionResult GetProductNew(int id)
        {
            ProductNew productNew = db.ProductNew.Find(id);
            if (productNew == null)
            {
                return NotFound();
            }

            return Ok(productNew);
        }

        // PUT: api/ProductNews/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProductNew(int id, ProductNew productNew)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != productNew.ID)
            {
                return BadRequest();
            }

            db.Entry(productNew).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductNewExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ProductNews
        [ResponseType(typeof(ProductNew))]
        public IHttpActionResult PostProductNew(ProductNew productNew)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ProductNew.Add(productNew);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = productNew.ID }, productNew);
        }

        // DELETE: api/ProductNews/5
        [ResponseType(typeof(ProductNew))]
        public IHttpActionResult DeleteProductNew(int id)
        {
            ProductNew productNew = db.ProductNew.Find(id);
            if (productNew == null)
            {
                return NotFound();
            }

            db.ProductNew.Remove(productNew);
            db.SaveChanges();

            return Ok(productNew);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductNewExists(int id)
        {
            return db.ProductNew.Count(e => e.ID == id) > 0;
        }
    }
}