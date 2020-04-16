//Grupo Web Apuestas

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio_T8_2C_MVC.Controllers
{
    public class HistoricoController : Controller
    {
        
        public ActionResult Historico()
        {

            //Recojo datos y lo paso a presentacion

            List<Models.mApuestas> listaApuestas;

            using (EntidadDatos ed = new EntidadDatos())
            {


                listaApuestas = (from b in ed.EntidadDatos
                                 select new Models.mApuestas()
                                 {

                                     Id = b.Id,
                                     Usuario = b.Usuario,
                                     Fecha = b.Fecha,
                                     IdJuego = b.IdJuego,
                                     cantidad = b.cantidad
                                 }).ToList();

            }

            //Esto devolvería la lista

            return View(listaApuestas);

            return View();
        }

    


    }
}
