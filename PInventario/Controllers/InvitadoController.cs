using PInventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PInventario.Controllers
{
    public class InvitadoController : Controller
    {
        InventContext db = new InventContext();
        // GET: Invitado
        public ActionResult Index()
        {
            return View(db.Productos);
        }
    }
}