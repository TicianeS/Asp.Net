using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Modelos;
using Prova2.Models;

namespace Prova2.Controllers
{
    public class AusenciasController : Controller
    {
        private Prova2Context db = new Prova2Context();

        // GET: Ausencias
        public ActionResult Index()
        {
            return View(db.Ausencias.ToList());
        }

        // GET: Ausencias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ausencia ausencia = db.Ausencias.Find(id);
            if (ausencia == null)
            {
                return HttpNotFound();
            }
            return View(ausencia);
        }

        // GET: Ausencias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ausencias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AusenciaID,Nome,Sigla")] Ausencia ausencia)
        {
            if (ModelState.IsValid)
            {
                db.Ausencias.Add(ausencia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ausencia);
        }

        // GET: Ausencias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ausencia ausencia = db.Ausencias.Find(id);
            if (ausencia == null)
            {
                return HttpNotFound();
            }
            return View(ausencia);
        }

        // POST: Ausencias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AusenciaID,Nome,Sigla")] Ausencia ausencia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ausencia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ausencia);
        }

        // GET: Ausencias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ausencia ausencia = db.Ausencias.Find(id);
            if (ausencia == null)
            {
                return HttpNotFound();
            }
            return View(ausencia);
        }

        // POST: Ausencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ausencia ausencia = db.Ausencias.Find(id);
            db.Ausencias.Remove(ausencia);
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
