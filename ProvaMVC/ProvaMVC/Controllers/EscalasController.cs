using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Modelos;
using ProvaMVC.Models;

namespace ProvaMVC.Controllers
{
    public class EscalasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Escalas
        public ActionResult Index()
        {
            var escalas = db.Escalas.Include(e => e._Ausencia).Include(e => e._Funcionario);
            return View(escalas.ToList());
        }

        // GET: Escalas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Escala escala = db.Escalas.Find(id);
            if (escala == null)
            {
                return HttpNotFound();
            }
            return View(escala);
        }

        // GET: Escalas/Create
        public ActionResult Create()
        {
            ViewBag.AusenciaID = new SelectList(db.Ausencias, "AusenciaID", "Nome");
            ViewBag.FuncionarioID = new SelectList(db.Funcionarios, "FuncionarioID", "Nome");
            return View();
        }

        // POST: Escalas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EscalaID,Data,FuncionarioID,AusenciaID")] Escala escala)
        {
            if (ModelState.IsValid)
            {
                db.Escalas.Add(escala);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AusenciaID = new SelectList(db.Ausencias, "AusenciaID", "Nome", escala.AusenciaID);
            ViewBag.FuncionarioID = new SelectList(db.Funcionarios, "FuncionarioID", "Nome", escala.FuncionarioID);
            return View(escala);
        }

        // GET: Escalas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Escala escala = db.Escalas.Find(id);
            if (escala == null)
            {
                return HttpNotFound();
            }
            ViewBag.AusenciaID = new SelectList(db.Ausencias, "AusenciaID", "Nome", escala.AusenciaID);
            ViewBag.FuncionarioID = new SelectList(db.Funcionarios, "FuncionarioID", "Nome", escala.FuncionarioID);
            return View(escala);
        }

        // POST: Escalas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EscalaID,Data,FuncionarioID,AusenciaID")] Escala escala)
        {
            if (ModelState.IsValid)
            {
                db.Entry(escala).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AusenciaID = new SelectList(db.Ausencias, "AusenciaID", "Nome", escala.AusenciaID);
            ViewBag.FuncionarioID = new SelectList(db.Funcionarios, "FuncionarioID", "Nome", escala.FuncionarioID);
            return View(escala);
        }

        // GET: Escalas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Escala escala = db.Escalas.Find(id);
            if (escala == null)
            {
                return HttpNotFound();
            }
            return View(escala);
        }

        // POST: Escalas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Escala escala = db.Escalas.Find(id);
            db.Escalas.Remove(escala);
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
