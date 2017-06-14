using Aula1406.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Aula1406.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            //retornar a list de obj cad
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Categoria categoria)//, string nome, string descricao, bool ativo) , FormCollection campos) recuperar campos da pag sem ter model
        {
            if (ModelState.IsValid)
            {
                List<Categoria> categorias = new List<Categoria>();
            }
            return View(categoria);
        }

        //get
        public ActionResult Edit(int? id) //? pode ser nulo também
        {
            // verif se veio id
            if (id == null)
            {
                // faz aparecer uma página de erro
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // pesquisa no banco o obj a editar
            //Categoria categoria = null;
            Categoria categoria = new Categoria()
            {
                Nome = "Carros",
                Descricao = "Super carros",
                Ativo = true
            };

            if (categoria == null) {
                // erro 404
                return HttpNotFound();
            }
            return View(categoria);
        }

        //post
        [HttpPost]
        public ActionResult Edit (Categoria categoria)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //fazer update no banco e redirecionar
                }
                catch (Exception ex)
                {

                }

            }
            return View(categoria);
        }

        //get

        public ActionResult Delete (int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Categoria categoria = null;

            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            // pesq obj por id e altera o status do obj para deleted ativo ou falso
            TempData["Mensagem"] = "Categoria excluída com sucesso";
            return RedirectToAction("Index");
        }
    }
}