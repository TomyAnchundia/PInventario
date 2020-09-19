using PInventario.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PInventario.Controllers
{
    public class MarcaController : Controller
    {
        InventContext db = new InventContext();
        // GET: Marca
        public ActionResult Index()
        {
            return View(db.Marcas);
        }

        // GET: Marca/Details/5
        public ActionResult Details(int id)
        {
            Marca marca = db.Marcas.Single(g => g.Id_marca == id);
            return View(marca);
        }

        // GET: Marca/Create
        public ActionResult Create()
        {
            Marca marca = new Marca
            {
                Nombre_marca = "",
                
                ///Falta logica
               
            };
            return View();
        }

        // POST: Marca/Create
        [HttpPost]
        public ActionResult Create(Marca marca)
        {
            try
            {
                db.Marcas.Add(marca);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Marca/Edit/5
        public ActionResult Edit(int id)
        {
            Marca marca = db.Marcas.Single(g => g.Id_marca == id);
            return View(marca);
        }

        // POST: Marca/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Marca marca = db.Marcas.Single(g => g.Id_marca == id);

                if (TryUpdateModel<Marca>(marca))
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

        // GET: Marca/Delete/5
        public ActionResult Delete(int id)
        {
            Marca marca = db.Marcas.Single(g => g.Id_marca == id);
            return View(marca);
        }

        // POST: Marca/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Marca marca = db.Marcas.Single(g => g.Id_marca == id);
                db.Marcas.Remove(marca);
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
