using PInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PInventario.Controllers
{
    public class UsuarioController : Controller
    {
        InventContext db = new InventContext();
        // GET: Usuario
        public ActionResult Index()
        {
            return View(db.Usuarios);
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            Usuario usuario = db.Usuarios.Single(g => g.Id_usuario == id);
            return View(usuario);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            ViewBag.Id_papeleria = new SelectList(db.Papelerias, "Id_papeleria", "Nombre_papeleria");
            Usuario usuario = new Usuario
            {
                Nombre = "",
                Apellido = "",
                Nombre_usuario = "",
                Contrasena = ""

            };
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        public ActionResult Create(Usuario usuario)
        {
            try
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Id_papeleria = new SelectList(db.Papelerias, "Id_papeleria", "Nombre_papeleria");
            Usuario usuario = db.Usuarios.Single(g => g.Id_usuario == id);
            return View(usuario);
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                Usuario usuario = db.Usuarios.Single(g => g.Id_usuario == id);
                if (TryUpdateModel<Usuario>(usuario))
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

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            Usuario usuario = db.Usuarios.Single(g => g.Id_usuario == id);
            return View(usuario);
        }

        // POST: Usuario/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                Usuario usuario = db.Usuarios.Single(g => g.Id_usuario == id);
                db.Usuarios.Remove(usuario);
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
