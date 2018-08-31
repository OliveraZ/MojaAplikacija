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
    public class VrstaDokumentaController : Controller
    {
        private NNVContext db = new NNVContext();

        // GET: VrstaDokumenta
        public ActionResult Index()
        {
            return View(db.VrstaDokumenta.ToList());
        }

        // GET: VrstaDokumenta/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VrstaDokumenta vrstaDokumenta = db.VrstaDokumenta.Find(id);
            if (vrstaDokumenta == null)
            {
                return HttpNotFound();
            }
            return View(vrstaDokumenta);
        }

        // GET: VrstaDokumenta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VrstaDokumenta/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Dokumenta,NazivDokumenta")] VrstaDokumenta vrstaDokumenta)
        {
            if (ModelState.IsValid)
            {
                db.VrstaDokumenta.Add(vrstaDokumenta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vrstaDokumenta);
        }

        // GET: VrstaDokumenta/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VrstaDokumenta vrstaDokumenta = db.VrstaDokumenta.Find(id);
            if (vrstaDokumenta == null)
            {
                return HttpNotFound();
            }
            return View(vrstaDokumenta);
        }

        // POST: VrstaDokumenta/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_Dokumenta,NazivDokumenta")] VrstaDokumenta vrstaDokumenta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vrstaDokumenta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vrstaDokumenta);
        }

        // GET: VrstaDokumenta/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VrstaDokumenta vrstaDokumenta = db.VrstaDokumenta.Find(id);
            if (vrstaDokumenta == null)
            {
                return HttpNotFound();
            }
            return View(vrstaDokumenta);
        }

        // POST: VrstaDokumenta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VrstaDokumenta vrstaDokumenta = db.VrstaDokumenta.Find(id);
            db.VrstaDokumenta.Remove(vrstaDokumenta);
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
