using PInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PInventario.Controllers
{
    public class PapeleriaController : Controller
    {

        InventContext db = new InventContext();
        // GET: Papeleria
        public ActionResult Index()
        {
            return View(db.Papelerias);
        }

        // GET: Papeleria/Details/5
        public ActionResult Details(int id)
        {
            Papeleria papeleria = db.Papelerias.Single(g => g.Id_papeleria == id);
            return View(papeleria);
        }

        // GET: Papeleria/Create
        public ActionResult Create()
        {
            Papeleria papeleria = new Papeleria
            {
                Nombre_papeleria = "",
                Contacto_papeleria = "",
                Direccion_papeleria = ""
            };
            return View(papeleria);
        }

        // POST: Papeleria/Create
        [HttpPost]
        public ActionResult Create(Papeleria   papeleria)
        {
            try
            {
                db.Papelerias.Add(papeleria);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Papeleria/Edit/5
        public ActionResult Edit(int id)
        {
            Papeleria papeleria = db.Papelerias.Single(g => g.Id_papeleria == id);
            return View(papeleria);
        }

        // POST: Papeleria/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Papeleria papeleria = db.Papelerias.Single(g => g.Id_papeleria == id);
                if (TryUpdateModel<Papeleria>(papeleria))
                {
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Papeleria/Delete/5
        public ActionResult Delete(int id)
        {
            Papeleria papeleria = db.Papelerias.Single(g => g.Id_papeleria == id);
            return View(papeleria);
        }

        // POST: Papeleria/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Papeleria papeleria = db.Papelerias.Single(g => g.Id_papeleria == id);
                db.Papelerias.Remove(papeleria);
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
