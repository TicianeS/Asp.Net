using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc1206.Models;

namespace Mvc1206.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            List<Categoria> categorias = new List<Categoria>();

            categorias.Add(new Categoria() { Nome = "Carros" });
            categorias.Add(new Categoria() { Nome = "Motos" });
            categorias.Add(new Categoria() { Nome = "Aviões" });


            /* 
             List<string> categorias = new List<string>();
            categorias.Add("Carros");
             categorias.Add("Motos");
             categorias.Add("Aviões");*/

            ViewBag.ListaCategorias = categorias;

            return View(categorias);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {
            return View(categoria);
        }
    }
}