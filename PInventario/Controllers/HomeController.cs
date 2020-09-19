using PInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.Services.Description;

namespace PInventario.Controllers
{
   
    public class HomeController : Controller
    {
        InventContext db = new InventContext();
        public ActionResult Index(string message ="")
        {
            ViewBag.Message = message;
            return View();
        }


        [HttpPost]
        public ActionResult Login(string nombre_usuario, string password)
        {
            if (!string.IsNullOrEmpty(nombre_usuario) && !string.IsNullOrEmpty(password))
            {
                var user = db.Usuarios.FirstOrDefault(g => g.Nombre_usuario == nombre_usuario && g.Contrasena == password);
                if (user != null)
                {
                    FormsAuthentication.SetAuthCookie(user.Nombre_usuario, true);
                    return RedirectToAction("Index", "Profile");


                }
                else
                {
                    return RedirectToAction("Index", new { message = "no reconocemos tus datos" });
                }
            }
            else
            {
                return RedirectToAction("Index", new { message = "Llena los datos para iniciar sesión" });

            }



        }

        [Authorize]
        public ActionResult Logout()
        {

            FormsAuthentication.SignOut();

            return RedirectToAction("Index");
        }


        public ActionResult Ingresar()
        {

           

            return RedirectToAction("Index", "Invitado");
        }


    }
}