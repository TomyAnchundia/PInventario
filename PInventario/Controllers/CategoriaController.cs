using PInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PInventario.Controllers
{
    public class CategoriaController : Controller
    {
        InventContext db = new InventContext();
        // GET: Categoria
        public ActionResult Index()
        {
            return View(db.Categorias);
        }

        // GET: Categoria/Details/5
        public ActionResult Details(int id)
        {
            Categoria categoria = db.Categorias.Single(g => g.Id_categoria == id);
            return View(categoria);
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            Categoria categoria = new Categoria
            {
                Nombre_categoria = ""

            };
            return View(categoria);
        }

        // POST: Categoria/Create
        [HttpPost]
        public ActionResult Create(Categoria categoria)
        {
            try
            {
                db.Categorias.Add(categoria);
                db.SaveChanges();
                return RedirectToAction("Index");

                
            }
            catch
            {
                return View();
            }
        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(int id)
        {
            Categoria categoria = db.Categorias.Single(g => g.Id_categoria == id);
            return View(categoria);
        }

        // POST: Categoria/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Categoria categoria = db.Categorias.Single(g => g.Id_categoria == id);

                if (TryUpdateModel<Categoria>(categoria))
                {
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Categoria/Delete/5
        public ActionResult Delete(int id)
        {
            Categoria categoria = db.Categorias.Single(g => g.Id_categoria == id);
            return View(categoria);
        }

        // POST: Categoria/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Categoria categoria = db.Categorias.Single(g => g.Id_categoria == id);
                db.Categorias.Remove(categoria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
