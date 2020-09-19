using PInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PInventario.Controllers
{
    public class MovimientoController : Controller
    {
        InventContext db = new InventContext();
        // GET: Movimiento
        public ActionResult Index()
        {
            return View(db.Movimientos);
        }

        // GET: Movimiento/Details/5
        public ActionResult Details(int id)
        {
            Movimiento movimiento = db.Movimientos.Single(g => g.Id_movimiento == id);
            return View(movimiento);
        }

        // GET: Movimiento/Create
        public ActionResult Create()
        {
            Movimiento movimiento = new Movimiento
            {
                Tipo_movimimiento = ""
            };
            return View(movimiento);
        }

        // POST: Movimiento/Create
        [HttpPost]
        public ActionResult Create(Movimiento movimiento)
        {
            try
            {
                db.Movimientos.Add(movimiento);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movimiento/Edit/5
        public ActionResult Edit(int id)
        {
            Movimiento movimiento = db.Movimientos.Single(g => g.Id_movimiento == id);
            return View(movimiento);
        }

        // POST: Movimiento/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Movimiento movimiento = db.Movimientos.Single(g => g.Id_movimiento == id);
                if (TryUpdateModel<Movimiento>(movimiento))
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

        // GET: Movimiento/Delete/5
        public ActionResult Delete(int id)
        {
            Movimiento movimiento = db.Movimientos.Single(g => g.Id_movimiento == id);
            return View(movimiento);
        }

        // POST: Movimiento/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Movimiento movimiento = db.Movimientos.Single(g => g.Id_movimiento == id);
                db.Movimientos.Remove(movimiento);
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
