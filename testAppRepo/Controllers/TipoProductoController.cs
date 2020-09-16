using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using testAppRepo.Models;

namespace testAppRepo.Controllers
{
    public class TipoProductoController : Controller
    {
        private RestaurantEntities db = new RestaurantEntities();

        // GET: TipoProducto
        public ActionResult Index()
        {
            return View(db.TIPOPRODUCTO.ToList());
        }

        // GET: TipoProducto/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPOPRODUCTO tIPOPRODUCTO = db.TIPOPRODUCTO.Find(id);
            if (tIPOPRODUCTO == null)
            {
                return HttpNotFound();
            }
            return View(tIPOPRODUCTO);
        }

        // GET: TipoProducto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoProducto/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDTIPOPRODUCTO,DESCTIPOPRODUCTO")] TIPOPRODUCTO tIPOPRODUCTO)
        {
            if (ModelState.IsValid)
            {
                db.TIPOPRODUCTO.Add(tIPOPRODUCTO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tIPOPRODUCTO);
        }

        // GET: TipoProducto/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPOPRODUCTO tIPOPRODUCTO = db.TIPOPRODUCTO.Find(id);
            if (tIPOPRODUCTO == null)
            {
                return HttpNotFound();
            }
            return View(tIPOPRODUCTO);
        }

        // POST: TipoProducto/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDTIPOPRODUCTO,DESCTIPOPRODUCTO")] TIPOPRODUCTO tIPOPRODUCTO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tIPOPRODUCTO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tIPOPRODUCTO);
        }

        // GET: TipoProducto/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TIPOPRODUCTO tIPOPRODUCTO = db.TIPOPRODUCTO.Find(id);
            if (tIPOPRODUCTO == null)
            {
                return HttpNotFound();
            }
            return View(tIPOPRODUCTO);
        }

        // POST: TipoProducto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            TIPOPRODUCTO tIPOPRODUCTO = db.TIPOPRODUCTO.Find(id);
            db.TIPOPRODUCTO.Remove(tIPOPRODUCTO);
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
