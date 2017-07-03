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
    public class HorasExtrasController : Controller
    {
        private Prova2Context db = new Prova2Context();

        // GET: HorasExtras
        public ActionResult Index()
        {
            var horaExtras = db.HoraExtras.Include(h => h._Funcionario);
            return View(horaExtras.ToList());
        }

        // GET: HorasExtras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoraExtra horaExtra = db.HoraExtras.Find(id);
            if (horaExtra == null)
            {
                return HttpNotFound();
            }
            return View(horaExtra);
        }

        // GET: HorasExtras/Create
        public ActionResult Create()
        {
            ViewBag.FuncionarioID = new SelectList(db.Funcionarios, "FuncionarioID", "Nome");
            return View();
        }

        // POST: HorasExtras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HoraExtraID,FuncionarioID,Data,Horas,Inicio,Fim")] HoraExtra horaExtra)
        {
            if (ModelState.IsValid)
            {
                db.HoraExtras.Add(horaExtra);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FuncionarioID = new SelectList(db.Funcionarios, "FuncionarioID", "Nome", horaExtra.FuncionarioID);
            return View(horaExtra);
        }

        // GET: HorasExtras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoraExtra horaExtra = db.HoraExtras.Find(id);
            if (horaExtra == null)
            {
                return HttpNotFound();
            }
            ViewBag.FuncionarioID = new SelectList(db.Funcionarios, "FuncionarioID", "Nome", horaExtra.FuncionarioID);
            return View(horaExtra);
        }

        // POST: HorasExtras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HoraExtraID,FuncionarioID,Data,Horas,Inicio,Fim")] HoraExtra horaExtra)
        {
            if (ModelState.IsValid)
            {
                db.Entry(horaExtra).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FuncionarioID = new SelectList(db.Funcionarios, "FuncionarioID", "Nome", horaExtra.FuncionarioID);
            return View(horaExtra);
        }

        // GET: HorasExtras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoraExtra horaExtra = db.HoraExtras.Find(id);
            if (horaExtra == null)
            {
                return HttpNotFound();
            }
            return View(horaExtra);
        }

        // POST: HorasExtras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HoraExtra horaExtra = db.HoraExtras.Find(id);
            db.HoraExtras.Remove(horaExtra);
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
