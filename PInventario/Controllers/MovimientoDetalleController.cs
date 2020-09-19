using PInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PInventario.Controllers
{
    public class MovimientoDetalleController : Controller
    {
        InventContext db = new InventContext();
        // GET: MovimientoDetalle
        public ActionResult Index()
        {
            return View(db.Movimiento_detalles);
        }

        // GET: MovimientoDetalle/Details/5
        public ActionResult Details(int id)
        {
            MovimientoDetalle movimientoDetalle = db.Movimiento_detalles.Single(g => g.Id_movimiento_detalle == id);
            return View(movimientoDetalle);
        }

        // GET: MovimientoDetalle/Create
        public ActionResult Create()
        {
            ViewBag.Id_producto = new SelectList(db.Productos, "Id_producto", "Nombre_producto");
            ViewBag.Id_movimiento = new SelectList(db.Movimientos, "Id_movimiento", "Tipo_movimimiento");
            
            MovimientoDetalle movimientoDetalle = new MovimientoDetalle
            {
                Fecha_movimiento = DateTime.Parse(DateTime.Now.Date.ToString("dd/MM/yyyy")),
                Cantidad = 0
            };
            return View(movimientoDetalle);
        }

        // POST: MovimientoDetalle/Create
        [HttpPost]
        public ActionResult Create(MovimientoDetalle movimientoDetalle)
        {
            try
            {
                db.Movimiento_detalles.Add(movimientoDetalle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: MovimientoDetalle/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Id_producto = new SelectList(db.Productos, "Id_producto", "Nombre_producto");
            ViewBag.Id_movimiento = new SelectList(db.Movimientos, "Id_movimiento", "Tipo_movimimiento");
         
            MovimientoDetalle movimientoDetalle = db.Movimiento_detalles.Single(g => g.Id_movimiento_detalle == id);
            return View(movimientoDetalle);
        }

        // POST: MovimientoDetalle/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                MovimientoDetalle movimientoDetalle = db.Movimiento_detalles.Single(g => g.Id_movimiento_detalle == id);
                if (TryUpdateModel<MovimientoDetalle>(movimientoDetalle))
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

        // GET: MovimientoDetalle/Delete/5
        public ActionResult Delete(int id)
        {
            MovimientoDetalle movimientoDetalle = db.Movimiento_detalles.Single(g => g.Id_movimiento_detalle == id);
            return View(movimientoDetalle);
        }

        // POST: MovimientoDetalle/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                MovimientoDetalle movimientoDetalle = db.Movimiento_detalles.Single(g => g.Id_movimiento_detalle == id);
                db.Movimiento_detalles.Remove(movimientoDetalle);
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
