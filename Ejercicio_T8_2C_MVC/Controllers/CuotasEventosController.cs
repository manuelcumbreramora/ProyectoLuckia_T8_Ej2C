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
        //List<Models.mEventos> listaEventos;
        public ActionResult CuotaEvento()
        {


            //Recojo datos y lo paso a presentacion

            //List<Models.mEventos> listaEventos;

            //using (EntidadDatos ed = new EntidadDatos())
            //{


            //    listaEventos = (from b in ed.EntidadDatos
            //                     select new Models.mEventos()
            //                     {
                                       //Id = b.Id,
            //                         Nombre = b.Nombre,
            //                         Fecha = b.Fecha,
            //                         Cuota = b.Cuota,

            //                     }).ToList();

            //}

            //Esto devolvería la lista

            //return View(listaEventos);




            return View();
        }

       
    }
}
