using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio_T8_2C_MVC.Controllers
{
    public class CuotasEventosController : Controller
    {
        // GET: CuotasEventos
        List<Models.mEventos> listaEventos;
        public ActionResult CuotaEvento()
        {
            return View(listaEventos);
        }

       
    }
}
