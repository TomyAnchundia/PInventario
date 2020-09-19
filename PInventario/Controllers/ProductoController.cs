using PInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PInventario.Controllers
{
    public class ProductoController : Controller
    {
        InventContext db = new InventContext();
        // GET: Producto
        public ActionResult Index()
        {
            return View(db.Productos);
        }



        public ActionResult IndexInvitado()
        {
            return View(db.Productos);
        }










        // GET: Producto/Details/5
        public ActionResult Details(int id)
        {
            Producto producto = db.Productos.Single(g => g.Id_producto == id);
            return View(producto);
        }

        // GET: Producto/Create
        public ActionResult Create()
        {
            ViewBag.Id_categoria = new SelectList(db.Categorias, "Id_categoria", "Nombre_categoria");
            ViewBag.Id_marca = new SelectList(db.Marcas, "Id_marca", "Nombre_marca");
           
            Producto producto = new Producto
            {
                Nombre_producto = "",
                Precio_compra = 0,
                Precio_venta = 0

            };
            return View(producto);
        }

        // POST: Producto/Create
        [HttpPost]
        public ActionResult Create(Producto producto)
        {
            try
            {
                db.Productos.Add(producto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Producto/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Id_categoria = new SelectList(db.Categorias, "Id_categoria", "Nombre_categoria");
            ViewBag.Id_marca = new SelectList(db.Marcas, "Id_marca", "Nombre_marca");
            Producto producto = db.Productos.Single(g => g.Id_producto == id);
            return View(producto);
        }

        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
               
                
                Producto producto = db.Productos.Single(g => g.Id_producto == id);
                if (TryUpdateModel<Producto>(producto))
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

        // GET: Producto/Delete/5
        public ActionResult Delete(int id)
        {
            Producto producto = db.Productos.Single(g => g.Id_producto == id);
            return View(producto);
        }

        // POST: Producto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Producto producto = db.Productos.Single(g => g.Id_producto == id);
                db.Productos.Remove(producto);
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
