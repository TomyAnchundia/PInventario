using PInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PInventario.Controllers
{
    public class ReporteProductoController : Controller
    {
        InventContext db = new InventContext();
        // GET: ReporteProducto
        public ActionResult Index()
        {
            return View(db.Reporte_productos);
        }

        // GET: ReporteProducto/Details/5
        public ActionResult Details(int id)
        {
            ReporteProducto reporteProducto = db.Reporte_productos.Single(g => g.Id_reporte_producto == id);
            return View(reporteProducto);
        }

        // GET: ReporteProducto/Create
        public ActionResult Create()
        {
            ViewBag.Id_papeleria = new SelectList(db.Papelerias, "Id_papeleria", "Nombre_papeleria");
            ReporteProducto reporteProducto = new ReporteProducto
            {
                Fecha_emision = DateTime.Parse(DateTime.Now.Date.ToString("dd/MM/yyyy")),
                Descripcion_reporte = "",



            };
            return View();
        }

        // POST: ReporteProducto/Create
        [HttpPost]
        public ActionResult Create(ReporteProducto reporteProducto)
        {
            try
            {
                db.Reporte_productos.Add(reporteProducto);
                db.SaveChanges();


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ReporteProducto/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Id_papeleria = new SelectList(db.Papelerias, "Id_papeleria", "Nombre_papeleria");
            ReporteProducto reporteProducto = db.Reporte_productos.Single(g => g.Id_reporte_producto == id);
            return View(reporteProducto);
        }

        // POST: ReporteProducto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                ReporteProducto reporteProducto = db.Reporte_productos.Single(g => g.Id_reporte_producto == id);
                if (TryUpdateModel<ReporteProducto>(reporteProducto))
                {
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                // TODO: Add update logic here
                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: ReporteProducto/Delete/5
        public ActionResult Delete(int id)
        {
            ReporteProducto reporteProducto = db.Reporte_productos.Single(g => g.Id_reporte_producto == id);
            return View(reporteProducto);
        }

        // POST: ReporteProducto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                ReporteProducto reporteProducto = db.Reporte_productos.Single(g => g.Id_reporte_producto == id);
                db.Reporte_productos.Remove(reporteProducto);
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
