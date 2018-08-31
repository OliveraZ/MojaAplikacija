using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NNV.Models;

namespace NNV.Controllers
{
    public class PriloziController : Controller
    {
        private NNVContext db = new NNVContext();

        // GET: Prilozi
        public ActionResult Index()
        {
            var prilozi = db.Prilozi.Include(p => p.Sednice);
            return View(prilozi.ToList());
        }

        // GET: Prilozi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prilozi prilozi = db.Prilozi.Find(id);
            if (prilozi == null)
            {
                return HttpNotFound();
            }
            return View(prilozi);
        }

        // GET: Prilozi/Create
        public ActionResult Create()
        {
            ViewBag.ID_Sednice = new SelectList(db.Sednice, "ID_Sednice", "Vrsta_sednice");
            return View();
        }

        // POST: Prilozi/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Sednice,Rbr_Priloga,ID_Dokumenta,Putanja,Poslato,DatumSlanja")] Prilozi prilozi)
        {
            if (ModelState.IsValid)
            {
                db.Prilozi.Add(prilozi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_Sednice = new SelectList(db.Sednice, "ID_Sednice", "Vrsta_sednice", prilozi.ID_Sednice);
            return View(prilozi);
        }

        // GET: Prilozi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prilozi prilozi = db.Prilozi.Find(id);
            if (prilozi == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_Sednice = new SelectList(db.Sednice, "ID_Sednice", "Vrsta_sednice", prilozi.ID_Sednice);
            return View(prilozi);
        }

        // POST: Prilozi/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Sednice,Rbr_Priloga,ID_Dokumenta,Putanja,Poslato,DatumSlanja")] Prilozi prilozi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(prilozi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_Sednice = new SelectList(db.Sednice, "ID_Sednice", "Vrsta_sednice", prilozi.ID_Sednice);
            return View(prilozi);
        }

        // GET: Prilozi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Prilozi prilozi = db.Prilozi.Find(id);
            if (prilozi == null)
            {
                return HttpNotFound();
            }
            return View(prilozi);
        }

        // POST: Prilozi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Prilozi prilozi = db.Prilozi.Find(id);
            db.Prilozi.Remove(prilozi);
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
